using UnityEngine;
using System.Collections;

public class AbilityBuble : MonoBehaviour {

	public Transform bPrefab;
	public Transform bPrefab1;
	public Transform bPrefab2;
	public Transform bPrefab3;
	public Transform bPrefab4;
	public Transform bPrefab5;
	public Transform bPrefab6;
	public Transform bPrefab7;
	
	
	private float buildCooldown;
	public float cooldown;
	
	
	public GUISkin mainGUI;
	
	
	void Start (){
		
		
		
		
		
		
		
	}
	
	
	
	void Update () {
		
		
		
		
		
		
		buildCooldown = buildCooldown + 0.1f * Time.deltaTime;
		
		if (Input.GetButtonDown ("Fire1")) {
			
			if (buildCooldown > cooldown) {
				
				
				Instantiate (bPrefab, transform.position, Quaternion.identity);
				Instantiate (bPrefab1, transform.position, Quaternion.identity);
				Instantiate (bPrefab2, transform.position, Quaternion.identity);
				Instantiate (bPrefab3, transform.position, Quaternion.identity);
				Instantiate (bPrefab4, transform.position, Quaternion.identity);
				Instantiate (bPrefab5, transform.position, Quaternion.identity);
				Instantiate (bPrefab6, transform.position, Quaternion.identity);
				Instantiate (bPrefab7, transform.position, Quaternion.identity);
				buildCooldown = 0;
				
			}
		}
		
	}
	void OnGUI ()
	
	{

		GUI.skin = mainGUI;
		
		if (buildCooldown > cooldown) {
			
			GUI.Box (new Rect (Screen.width / 2-100, 450, 200, 40), "", GUI.skin.GetStyle("ability"));
		}
		
	}
}
