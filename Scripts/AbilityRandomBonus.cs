using UnityEngine;
using System.Collections;

public class AbilityRandomBonus : MonoBehaviour {

	private int bonus;

	// Use this for initialization
	void Start () {

		bonus = Random.Range (1, 4);
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {

			if (bonus == 1) {
			
			GDB.coins += 10;
			Destroy (gameObject);
		}
			if (bonus == 2) {

			GDB.globalScore += 20;
			Destroy (gameObject);
		}
			if (bonus == 3) {

			GDB.redMoney += 1;
			Destroy (gameObject);

		}
		
	}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
}
}