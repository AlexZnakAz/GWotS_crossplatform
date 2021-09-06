using UnityEngine;
using System.Collections;

public class FriendScript : MonoBehaviour {

	public Transform shotPrefab;
	
	
	private float shotCooldown;
	public float cooldown;
	
	public int destroy;
	
	
	
	void Start (){
		
		
		
		Destroy (gameObject, destroy);
		
		
		
	}
	
	
	
	void Update () {
		
		
		
		
		
		
		shotCooldown = shotCooldown + 0.1f * Time.deltaTime;
		

			
			if (shotCooldown > cooldown) {
				
				
				Instantiate (shotPrefab, transform.position, Quaternion.identity);
				shotCooldown = 0;
				
			}
		}
		
	}


