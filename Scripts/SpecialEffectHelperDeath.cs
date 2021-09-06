using UnityEngine;
using System.Collections;

public class SpecialEffectHelperDeath : MonoBehaviour {

	public static SpecialEffectHelperDeath Instance;

	public ParticleSystem events;


	void Awake()
	{
		if (Instance != null) {
			Debug.LogError ("Несколько экземпляров SpecialEffectHelper");
		}

		Instance = this;
	}

	public void Event(Vector3 position)

	{
		instantiate (events, position);
	

	}

	private ParticleSystem instantiate (ParticleSystem prefab, Vector3 position)

	{
		ParticleSystem newParticleSystem = Instantiate 
			(prefab, position, Quaternion.identity) as ParticleSystem;

		Destroy
			(newParticleSystem.gameObject, newParticleSystem.startLifetime);

		return newParticleSystem;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
