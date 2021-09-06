using UnityEngine;
using System.Collections;

public class AbilityShield : MonoBehaviour {

	public Transform shieldPrefab;

	private float shieldDuration;
	private float shieldCooldown;

	public float duration;
	public float cooldown;

	public bool shield;

	private GameObject obj;

	public GUISkin mainGUI;

	void Start (){


		shield = false;




	}



	void Update () {

		obj = GameObject.FindGameObjectWithTag("Shield");

		if (shield == true) {
			shieldDuration = shieldDuration + 0.1f * Time.deltaTime;
		}
		if (shieldDuration > duration) {
			Destroy (obj);
			shield = false;
			shieldCooldown = 0;
			shieldDuration = 0;
		}

		shieldCooldown = shieldCooldown + 0.1f * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {

			if (shieldCooldown > cooldown) {

		
				Instantiate (shieldPrefab, transform.position, Quaternion.identity);
				shieldCooldown = 0;
				shield = true;
			}
		}

}
	void OnGUI () {

		GUI.skin = mainGUI;

		if (shieldCooldown > cooldown) {

			GUI.Box (new Rect (Screen.width / 2-100, 450, 200, 40), "", GUI.skin.GetStyle("ability"));
		}

	}
}