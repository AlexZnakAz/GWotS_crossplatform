using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI () {



		if (GUI.Button (new Rect (Screen.width /2-75 , 30, 150, 30), "Главное меню")) {
			Application.LoadLevel ("Menu");
		}



	}
}
