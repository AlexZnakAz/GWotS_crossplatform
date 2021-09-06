using UnityEngine;
using System.Collections;

public class AbilitySpawnRandomBonus : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxBonusNumber;
	public int bonusNumber = 0;
	public Transform bonusPrefab;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (bonusNumber <= maxBonusNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (bonusPrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		bonusNumber = GameObject.FindGameObjectsWithTag ("Bonuses").Length;
		
		
		
	}
}
