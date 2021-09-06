using UnityEngine;
using System.Collections;

public class AbilityBuild : MonoBehaviour {

	public Transform buildPrefab;
	

	private float buildCooldown;
	public float cooldown;


	
	public GUISkin mainGUI;
	
	void Start (){
		
		

		
		
		
		
	}
	
	
	
	void Update () {
		

		

			
		
		buildCooldown = buildCooldown + 0.1f * Time.deltaTime;
		
		if (Input.GetButtonDown ("Fire1")) {
			
			if (buildCooldown > cooldown) {
				
				
				Instantiate (buildPrefab, transform.position, Quaternion.identity);
				buildCooldown = 0;

			}
		}
		
	}
	void OnGUI () {

		GUI.skin = mainGUI;
		
		if (buildCooldown > cooldown) {
			
			GUI.Box (new Rect (Screen.width / 2-100, 450, 200, 40), "", GUI.skin.GetStyle("ability"));
		}
		
	}
}
