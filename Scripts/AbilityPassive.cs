using UnityEngine;
using System.Collections;

public class AbilityPassive : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxBullNumber;
	public int bullNumber = 0;
	public Transform bullPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (bullNumber <= maxBullNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (bullPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		bullNumber = GameObject.FindGameObjectsWithTag ("Passive").Length;
		
		
		
	}
}
