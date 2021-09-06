using UnityEngine;
using System.Collections;

public class ShieldUPG : MonoBehaviour {





	public GameObject player;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.FindGameObjectWithTag ("Player");
	
	
	}


	void OnTriggerEnter2D (Collider2D otherCollider){

		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}

		if (otherCollider.tag == "Player") {

			GDB.activity += 1;
			player.GetComponent <HealthScriptPlayer> ().hp2 += 4;
			Destroy (gameObject);
		}




	}
}
