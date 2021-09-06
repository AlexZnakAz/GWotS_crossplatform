using UnityEngine;
using System.Collections;

public class UpgradeSpeedSpawner : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxSpeedNumber;
	public int speedNumber = 0;
	public Transform speedPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (speedNumber <= maxSpeedNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (speedPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		speedNumber = GameObject.FindGameObjectsWithTag ("Speed").Length;
		
		
		
	}
}
