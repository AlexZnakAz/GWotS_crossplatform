using UnityEngine;
using System.Collections;

public class InsOnDes : MonoBehaviour {


	public Transform prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy () {

		Instantiate (prefab, transform.position, Quaternion.identity);
}
}