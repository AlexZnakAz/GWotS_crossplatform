using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {

	public GameObject gdb;
	public int winScore;
	public int needScore;

	public int rewardScore;
	public int rewardCoins;
	public int rewardRuby;

	public Texture2D score;
	public Texture2D coin;
	public Texture2D ruby;

	public int s;
	public int c;
	public int r;

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
		s = GDB.globalScore;
		c = GDB.coins;
		r = GDB.redMoney;



	}
	
	// Update is called once per frame
	void Update () {

		winScore = gdb.GetComponent<GDB> ().enemyScore;
	}

	void OnGUI () {


		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);


		if (needScore == winScore) {

			GDB.globalScore = s + rewardScore;
			GDB.coins = c + rewardCoins;
			GDB.redMoney = r + rewardRuby;



			GUI.DrawTexture (new Rect (700, 180, 50, 50), coin);
			GUI.Label (new Rect (760, 190, 100, 50), "" + rewardCoins.ToString (), GUI.skin.label);

			GUI.DrawTexture (new Rect (700, 260, 50, 50), ruby);
			GUI.Label (new Rect (760, 270, 100, 50), "" + rewardRuby.ToString (), GUI.skin.label);

		}
	}

}
