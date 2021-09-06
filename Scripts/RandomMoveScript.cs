using UnityEngine;
using System.Collections;

public class RandomMoveScript : MonoBehaviour {

	public int speed = 2;
	public float minGoTime;
	public float maxGoTime;
	public float timeToChangeMove;



	private Vector2 movement;

	// Use this for initialization
	void Start () {


		InvokeRepeating ("Timer", minGoTime, maxGoTime);
	
	}

	void Timer () {

	

		movement = new Vector2 (Random.Range (2f, -2f) * speed, Random.Range (2f, -2f) * speed);


	}

	void Update () {

		if (maxGoTime >= timeToChangeMove) {

			movement = Vector2.zero;
		}
	
	}
	// Update is called once per frame
	void FixedUpdate () {

		GetComponent<Rigidbody2D>().velocity = movement;
	
	}
}
