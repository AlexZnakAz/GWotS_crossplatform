using UnityEngine;
using System.Collections;

public class UpgradeHealthSpawner : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxMedikitNumber;
	public int medikitNumber = 0;
	public Transform medikitPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (medikitNumber <= maxMedikitNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (medikitPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		medikitNumber = GameObject.FindGameObjectsWithTag ("Medikit").Length;
		
		
		
	}
}
