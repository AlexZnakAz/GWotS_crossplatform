using UnityEngine;
using System.Collections;

public class AbilityMoney : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {
			
			
			GDB.coins += 5;
			Destroy (gameObject);
		}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
	}
}
