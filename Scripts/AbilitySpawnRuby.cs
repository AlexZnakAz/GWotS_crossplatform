using UnityEngine;
using System.Collections;

public class AbilitySpawnRuby : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxRuby1Number;
	public int ruby1Number = 0;
	public Transform ruby1Prefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (ruby1Number <= maxRuby1Number) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (ruby1Prefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		ruby1Number = GameObject.FindGameObjectsWithTag ("Ruby1").Length;
		
		
		
	}
}
