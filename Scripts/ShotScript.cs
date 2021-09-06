using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int damage;
	public bool isEnemyShot = false;
	public int destroy;

	public Vector3 MoveVector { set; get;}
	public Joystick2 joystick2;
	public GameObject joy2;



	void Start () {

		damage = damage + MenuUpgrade.damageU;

		joy2 = GameObject.FindGameObjectWithTag("joystick2");
		joystick2 = joy2.GetComponent<Joystick2> ();


		SpecialEffectHelperShoot.Instance.Event (transform.position);
		SoundEffectHelper.Instance.MakePlayerShotSound ();

		Destroy (gameObject, destroy);

		///USE FOR PC
		///Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
		///lookPos = lookPos - transform.position;
		///float angle  = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		///transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		Vector3 dir2 = Vector3.zero;
		dir2.x = joystick2.Horizontal ();
		dir2.y = joystick2.Vertical ();

		float angle2 = Mathf.Atan2 (dir2.y, dir2.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle2, Vector3.forward);

	
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnGUI () {
	
		GUI.Label (new Rect (Screen.width/2 - 40, Screen.height - 35, 80, 30), "attack " + damage.ToString (), GUI.skin.label);

	}


		
	



	void OnTriggerEnter2D (Collider2D otherCollider)
	{

		if (otherCollider.tag == "Structure") {

			SpecialEffectHelperShotDestr.Instance.Event (transform.position);

			Destroy (gameObject);
		}


	
	}



}
