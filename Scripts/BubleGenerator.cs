using UnityEngine;
using System.Collections;

public class BubleGenerator : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxBubleNumber;
	public int bubleNumber = 0;
	public Transform bublePrefabSmall;
	public Transform bublePrefabMedium;
	public Transform bublePrefabBig;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (bubleNumber <= maxBubleNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (bublePrefabSmall, pos, Quaternion.identity);

			Vector2 pos1 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (bublePrefabMedium, pos1, Quaternion.identity);

			Vector2 pos2 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (bublePrefabBig, pos2, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		bubleNumber = GameObject.FindGameObjectsWithTag ("Buble").Length;
		
		
		
	}

}
