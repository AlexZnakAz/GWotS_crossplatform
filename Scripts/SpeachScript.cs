using UnityEngine;
using System.Collections;

public class SpeachScript : MonoBehaviour {




	public GameObject gdb;
	public int enemy;
	private int lateEnemy;
	public bool isPlaying;
	private bool playOnce1;
	private bool playOnce2;
	private bool playOnce3;
	private bool playOnce4;
	private bool playOnce5;
	private bool playOnce6;
	private bool playOnce7;

	public int change;

	public AudioClip firstBlood;
	public AudioClip doubleKill;
	public AudioClip tripleKill;
	public AudioClip megaKill;
	public AudioClip ultraKill;
	public AudioClip monsterKill;
	public AudioClip killingSpree;
	public AudioClip rampagE;
	public AudioClip dominatinG;
	public AudioClip unstoppeblE;
	public AudioClip godlikE;
	public AudioClip ornagE;

	public Texture2D firstblood;
	public Texture2D doublekill;
	public Texture2D triplekill;
	public Texture2D megakill;
	public Texture2D ultrakill;
	public Texture2D monsterkill;
	public Texture2D killingspree;
	public Texture2D rampage;
	public Texture2D dominating;
	public Texture2D unstoppeble;
	public Texture2D godlike;
	public Texture2D ornage;


	// Use this for initialization
	void Start () {



		InvokeRepeating ("Timer", 2f, 2f);
		gdb = GameObject.Find ("GlobalDataBase");

		playOnce1 = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		enemy = gdb.GetComponent<GDB> ().enemyScore;



		if (MenuScript.speach == true) {

			if (change == -2) { 
				if (isPlaying == false) {
					AudioSource.PlayClipAtPoint (doubleKill, transform.position);
					isPlaying = true;
				}
			}

			if (change == -3) {
				if (isPlaying == false) {
					AudioSource.PlayClipAtPoint (tripleKill, transform.position);
					isPlaying = true;
				}
			}

			if (change == -4) {
				if (isPlaying == false) {
					AudioSource.PlayClipAtPoint (megaKill, transform.position);
					isPlaying = true;
				}
			}

			if (change == -5) {
				if (isPlaying == false) {
					AudioSource.PlayClipAtPoint (ultraKill, transform.position);
					isPlaying = true;
				}
			}

			if (change == -6) {
				if (isPlaying == false) {
					AudioSource.PlayClipAtPoint (monsterKill, transform.position);
					isPlaying = true;
				}
			}
		}
	}

	void LateUpdate () {

		if (MenuScript.speach == true) {

			if (enemy == 1) {
				if (isPlaying == false) {
					if (playOnce1 == false) {
						AudioSource.PlayClipAtPoint (firstBlood, transform.position);
						isPlaying = true;
						playOnce1 = true;
					}
				}
			}
			if (enemy == 10) {
				if (isPlaying == false) {
					if (playOnce2 == false) {
						AudioSource.PlayClipAtPoint (killingSpree, transform.position);
						isPlaying = true;
						playOnce2 = true;
					}
				}
			}
			if (enemy == 20) {
				if (isPlaying == false) {
					if (playOnce3 == false) {
						AudioSource.PlayClipAtPoint (rampagE, transform.position);
						isPlaying = true;
						playOnce3 = true;
					}
				}
			}
			if (enemy == 40) {
				if (isPlaying == false) {
					if (playOnce4 == false) {
						AudioSource.PlayClipAtPoint (dominatinG, transform.position);
						isPlaying = true;
						playOnce4 = true;
					}
				}
			}
			if (enemy == 60) {
				if (isPlaying == false) {
					if (playOnce5 == false) {
						AudioSource.PlayClipAtPoint (unstoppeblE, transform.position);
						isPlaying = true;
						playOnce5 = true;
					}
				}
			}
			if (enemy == 80) {
				if (isPlaying == false) {
					if (playOnce6 == false) {
						AudioSource.PlayClipAtPoint (godlikE, transform.position);
						isPlaying = true;
						playOnce6 = true;
					}
				}
			}
			if (enemy == 100) {
				if (isPlaying == false) {
					if (playOnce7 == false) {
						AudioSource.PlayClipAtPoint (ornagE, transform.position);
						isPlaying = true;
						playOnce7 = true;
					}
				}
			}
		}

	}





	private void Timer () {

		change = lateEnemy - enemy;
		isPlaying = false;
		lateEnemy = enemy;


	}
	void OnGUI () {

		if (enemy == 1) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), firstblood);
		}
		if (enemy == 10) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), killingspree);
		}
		if (enemy == 20) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), rampage);
		}
		if (enemy == 40) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), dominating);
		}
		if (enemy == 60) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), unstoppeble);
		}
		if (enemy == 80) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), godlike);
		}
		if (enemy == 100) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 550, 200, 40), ornage);
		}



		if (change == -2) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 500, 200, 40), doublekill);
		}
		if (change == -3) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 500, 200, 40), triplekill);
		}
		if (change == -4) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 500, 200, 40), megakill);
		}
		if (change == -5) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 500, 200, 40), ultrakill);
		}
		if (change == -6) {
			GUI.DrawTexture (new Rect (Screen.width / 2-100, 500, 200, 40), monsterkill);
		}
	}
}
