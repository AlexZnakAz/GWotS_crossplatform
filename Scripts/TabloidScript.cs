using UnityEngine;
using System.Collections;

public class TabloidScript : MonoBehaviour {



	public Texture2D inf1;
	public Texture2D inf2;
	public Texture2D inf3;
	public Texture2D inf4;
	public Texture2D inf5;
	public Texture2D inf6;
	public Texture2D inf7;
	public Texture2D inf8;

	public Texture2D tab;
	public Texture2D vers;
	public Texture2D uni;
	public Texture2D chr;


	private int tablo;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("Timer", 2f, 2f);


	}
	
	// Update is called once per frame
	void Update () {


	
	}


	private void Timer () {

		tablo = Random.Range (1, 9);


	}


	void OnGUI () {


		GUI.DrawTexture (new Rect (Screen.width / 2-160, 5, 320, 60), tab);
		GUI.DrawTexture (new Rect (5, 5 , 100, 100), vers);
		GUI.DrawTexture (new Rect (5, 100, 100, 50), uni);
		GUI.DrawTexture (new Rect (5, 160, 100, 100), chr);


		if (tablo == 1) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf1);
		}
		if (tablo == 2) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf2);
		}
		if (tablo == 3) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf3);
		}
		if (tablo == 4) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf4);
		}
		if (tablo == 5) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf5);
		}
		if (tablo == 6) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf6);
		}
		if (tablo == 7) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf7);
		}
		if (tablo == 8) {
			GUI.DrawTexture (new Rect (Screen.width / 2-150, 15, 300, 50), inf8);
		}


	}
}
