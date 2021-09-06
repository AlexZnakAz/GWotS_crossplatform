using UnityEngine;
using System.Collections;

public class StructureSpawn : MonoBehaviour {


	public int maxX;
	public int minX;
	public int maxY;
	public int minY;
	
	public int maxStructureNumber;
	public int structureNumber = 0;
	public Transform structurePrefab;
	
	
	void Start()
	{
		
		InvokeRepeating ("Timer", 0f, 0.1f);
		
		
		
	}
	
	
	private void Timer ()
		
	{
		if (structureNumber <= maxStructureNumber) {
			
			
			Vector2 pos = new Vector2 (Random.Range (maxX, minX), Random.Range (maxY, minY));
			Instantiate (structurePrefab, pos, Quaternion.identity);
			
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		structureNumber = GameObject.FindGameObjectsWithTag ("Structure").Length;
		
	}

}
