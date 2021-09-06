using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {



	public int maxX;
	public int minX;
	public int maxY;
	public int minY;

	public float minSpawnTime;
	public float maxSpawnTime;

	public int maxEnemyNumber;
	public int enemyNumber = 0;
	public Transform enemyPrefab;
	public Transform enemyPrefab2;
	public Transform enemyPrefab3;
	public Transform enemyPrefab4;
	public Transform enemyPrefab5;
	

	void Start()
	{
	
		InvokeRepeating ("Timer", minSpawnTime, maxSpawnTime);



	}


	private void Timer ()
	
	{
		if (enemyNumber <= maxEnemyNumber) {


			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (enemyPrefab, pos, Quaternion.identity);

			Vector2 pos2 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (enemyPrefab2, pos2, Quaternion.identity);

			Vector2 pos3 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (enemyPrefab3, pos3, Quaternion.identity);

			Vector2 pos4 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (enemyPrefab4, pos4, Quaternion.identity);

			Vector2 pos5 = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (enemyPrefab5, pos5, Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {

		enemyNumber = GameObject.FindGameObjectsWithTag ("Enemy").Length;



	}

}