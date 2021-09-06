using UnityEngine;
using System.Collections;

public class UpgradeHealth : MonoBehaviour {


	public GameObject hp;

	
	// Use this for initialization
	void Start () {
		
		
		

		hp = GameObject.FindGameObjectWithTag("Player");
		


		
	}
	
	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {

		
		hp.GetComponent<HealthScriptPlayer> ().hp += 4;
			GDB.activity +=1;
			GDB.xp +=5;
		
			Destroy (gameObject);
		
	}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
}
}
