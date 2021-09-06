using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxRocketNumber;
	public int rocketNumber = 0;
	public Transform rocketPrefabSmall;
	public Transform rocketPrefabBig;
	public Transform rocketPrefabMedium;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (rocketNumber <= maxRocketNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (rocketPrefabSmall, pos, Quaternion.identity);
			
			Vector2 pos2 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (rocketPrefabBig, pos2, Quaternion.identity);
			
			Vector2 pos3 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (rocketPrefabMedium, pos3, Quaternion.identity);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		rocketNumber = GameObject.FindGameObjectsWithTag ("Rocket").Length;
		
		
		
	}
}
