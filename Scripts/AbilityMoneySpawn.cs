using UnityEngine;
using System.Collections;

public class AbilityMoneySpawn : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxCoins1Number;
	public int coins1Number = 0;
	public Transform coins1Prefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (coins1Number <= maxCoins1Number) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (coins1Prefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		coins1Number = GameObject.FindGameObjectsWithTag ("Coin1").Length;
		
		
		
	}
}
