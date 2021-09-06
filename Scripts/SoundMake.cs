using UnityEngine;
using System.Collections;

public class SoundMake : MonoBehaviour {


	public Transform prefabMusic1;
	public Transform prefabMusic2;
	public Transform prefabMusic3;
	public Transform prefabMusic4;
	public Transform prefabMusic5;
	public Transform prefabMusic6;
	public Transform prefabMusic7;
	public Transform prefabMusic8;
	public Transform prefabMusic9;

	public int music;

	// Use this for initialization
	void Start () {



		music = Random.Range (1, 10);

		if (MenuScript.music == true) {

		
			if (music == 1) {
				Instantiate (prefabMusic1);
			}
			if (music == 2) {
				Instantiate (prefabMusic2);
			}
			if (music == 3) {
				Instantiate (prefabMusic3);
			}
			if (music == 4) {
				Instantiate (prefabMusic4);
			}
			if (music == 5) {
				Instantiate (prefabMusic5);
			}
			if (music == 6) {
				Instantiate (prefabMusic6);
			}
			if (music == 7) {
				Instantiate (prefabMusic7);
			}
			if (music == 8) {
				Instantiate (prefabMusic8);
			}
			if (music == 9) {
				Instantiate (prefabMusic9);
			}



		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
}
