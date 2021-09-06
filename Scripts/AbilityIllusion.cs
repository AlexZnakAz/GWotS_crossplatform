using UnityEngine;
using System.Collections;

public class AbilityIllusion : MonoBehaviour {

	public Transform friendPrefab;
	
	
	private float friendCooldown;
	public float cooldown;
	
	
	public GUISkin mainGUI;
	
	
	void Start (){
		
		
		
		
		
		
		
	}
	
	
	
	void Update () {
		
		
		
		
		
		
		friendCooldown = friendCooldown + 0.1f * Time.deltaTime;
		
		if (Input.GetButtonDown ("Fire1")) {
			
			if (friendCooldown > cooldown) {
				
				
				Instantiate (friendPrefab, transform.position, Quaternion.identity);
				friendCooldown = 0;
				
			}
		}
		
	}
	void OnGUI () {

		GUI.skin = mainGUI;
		
		if (friendCooldown > cooldown) {
			
			GUI.Box (new Rect (Screen.width / 2-100, 450, 200, 40), "", GUI.skin.GetStyle("ability"));
		}
		
	}
}
