using UnityEngine;
using System.Collections;

public class AbilityRuby : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {
			
			
			GDB.redMoney += 2;
			Destroy (gameObject);
		}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
	}


}



