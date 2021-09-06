using UnityEngine;
using System.Collections;

public class ShotScriptEnemy : MonoBehaviour {

	public int damage = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 5);

		if (MenuScript.diff == 2) {
			damage = damage + 2;
		}
		if (MenuScript.diff == 3) {
			damage = damage + 4;
		}


	
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnTriggerEnter2D (Collider2D otherCollider)
	{
		
		if (otherCollider.tag == "Buble") {
			Destroy (gameObject);
		}
		if (otherCollider.tag == "Shield") {
			Destroy (gameObject);
		}
}
}
