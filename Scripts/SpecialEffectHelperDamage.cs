using UnityEngine;
using System.Collections;

public class SpecialEffectHelperDamage : MonoBehaviour {

	public static SpecialEffectHelperDamage Instance;

	public ParticleSystem events;


	void Awake()
	{


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
