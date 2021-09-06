using UnityEngine;
using System.Collections;

public class UpgradeSpeed : MonoBehaviour {



	public GameObject speed;




	// Use this for initialization
	void Start () {


		speed = GameObject.FindGameObjectWithTag("Player");




	}
	
	// Update is called once per frame
	void Update () {


	}




	
	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {


			

			GDB.activity +=1;

				speed.GetComponent<PlayerControl> ().speeded = true;

			
				Destroy (gameObject);
			

		}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
	}
}
