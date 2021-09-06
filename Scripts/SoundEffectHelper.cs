using UnityEngine;
using System.Collections;

public class SoundEffectHelper : MonoBehaviour {


	public static SoundEffectHelper Instance;

	public AudioClip playerShotSound;


	void Awake () {

		if (Instance != null) {
			Debug.LogError ("двоиться");
		}
		Instance = this;
	}

	public void MakePlayerShotSound () {
		if (MenuScript.weapon == true) {
			MakeSound (playerShotSound);
		}
	}

	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
