using UnityEngine;
using System.Collections;

public class XpUpgrade : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D (Collider2D otherCollider){
		
		
		if (otherCollider.tag == "Player") {
			
			
			GDB.activity +=1;
			GDB.xp +=175;
			
			Destroy (gameObject);
			
		}
		if (otherCollider.tag == "Structure") {
			Destroy (gameObject);
		}
	}

}
