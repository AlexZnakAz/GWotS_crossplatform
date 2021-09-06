using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxCoinsNumber;
	public int coinsNumber = 0;
	public Transform coinsPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (coinsNumber <= maxCoinsNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (coinsPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		coinsNumber = GameObject.FindGameObjectsWithTag ("Coin").Length;
		
		
		
	}
}
