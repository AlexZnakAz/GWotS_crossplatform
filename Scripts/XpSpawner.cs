using UnityEngine;
using System.Collections;

public class XpSpawner : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxXpNumber;
	public int xpNumber = 0;
	public Transform xpPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (xpNumber <= maxXpNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (xpPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		xpNumber = GameObject.FindGameObjectsWithTag ("Xpp").Length;
		
		
		
	}
}
