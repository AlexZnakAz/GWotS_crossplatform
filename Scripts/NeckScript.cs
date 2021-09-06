using UnityEngine;
using System.Collections;

public class NeckScript : MonoBehaviour {

	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public float minSpawnTime;
	public float maxSpawnTime;
	
	public int maxNeckNumber;
	public int neckNumber = 0;
	public Transform neckPrefabSmall;
	public Transform neckPrefabBig;
	public Transform neckPrefabMedium;
	
	void Start()
	{
		
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (neckNumber <= maxNeckNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (neckPrefabSmall, pos, Quaternion.identity);
			
			Vector2 pos2 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (neckPrefabBig, pos2, Quaternion.identity);

			Vector2 pos3 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (neckPrefabMedium, pos3, Quaternion.identity);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		neckNumber = GameObject.FindGameObjectsWithTag ("Neck").Length;
		
		
		
	}
}
