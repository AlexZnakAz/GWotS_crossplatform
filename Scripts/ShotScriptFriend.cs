using UnityEngine;
using System.Collections;

public class ShotScriptFriend : MonoBehaviour {

	public int damage = 1;
	public bool isEnemyShot = false;
	public int destroy;
	// Use this for initialization
	
	
	
	
	void Start () {
		

		
		Destroy (gameObject, destroy);
		
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
		lookPos = lookPos - transform.position;
		float angle  = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	
	
	
	
	
	
	void OnTriggerEnter2D (Collider2D otherCollider)
	{
		
		if (otherCollider.tag == "Structure") {
			

			
			Destroy (gameObject);
		}
		
		
		
	}

}
