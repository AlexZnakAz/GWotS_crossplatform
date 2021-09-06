using UnityEngine;
using System.Collections;

public class DungeonBoss : MonoBehaviour {
	
	public GameObject gdb;
	public int winScore;
	public int needScore;
	

	public int rewardEmerald;

	

	public Texture2D Emerald;

	

	public int e;

	
	public float originalWidth = 800.0f;
	public float originalHeight = 480.0f;
	Vector3 scale; 
	
	// Use this for initialization
	void Start () {
		
		
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z = 1; // Неиспользуется, но указать стоит
		
		gdb = GameObject.Find ("GlobalDataBase");
		
		
		winScore = gdb.GetComponent<GDB> ().enemyScore;

		e = GDB.greenMoney;

		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		winScore = gdb.GetComponent<GDB> ().enemyScore;
	}
	
	void OnGUI () {
		
		
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
		
		
		if (needScore == winScore) {
			

			GDB.greenMoney = e + rewardEmerald;

			
			

			
			GUI.DrawTexture (new Rect (600, 180, 50, 50), Emerald);
			GUI.Label (new Rect (660, 190, 100, 50), "" + rewardEmerald.ToString (), GUI.skin.label);
			

			
		}
	}
	
}
