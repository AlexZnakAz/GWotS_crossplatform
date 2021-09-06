using UnityEngine;
using System.Collections;

public class CoinBonusScript : MonoBehaviour {



	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnTriggerEnter2D (Collider2D otherCollider){


		if (otherCollider.tag == "Player") {


			GDB.coins += 1;
			GDB.xp += 4;
			Destroy (gameObject);
		}
		if (otherCollider.tag == "PassiveBonus") {
			
			
			GDB.coins += 1;
			Destroy (gameObject);
		}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
	}
}
