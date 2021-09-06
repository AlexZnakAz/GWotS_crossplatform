using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerControl : MonoBehaviour {

	private WeaponScript[] weapons;
	public bool pause;

	public Joystick joystick;
	public GameObject joy;

	public Joystick2 joystick2;
	public GameObject joy2;


	
	public enum ProjectAxis {onlyX = 0, xAndY = 1};
	public ProjectAxis projectAxis = ProjectAxis.onlyX;
	public float speed = 150;
	public float addForce = 7;
	public static bool lookAtCursor;
	public static bool lookAtJoy;
	public KeyCode leftButton = KeyCode.A;
	public KeyCode rightButton = KeyCode.D;
	public KeyCode upButton = KeyCode.W;
	public KeyCode downButton = KeyCode.S;
	public KeyCode addForceButton = KeyCode.Space;
	public bool isFacingRight = true;
	private Vector3 direction;
	private float vertical;
	private float horizontal;
	private Rigidbody2D body;
	private float rotationY;
	private bool jump;

	public bool speeded;
	public float duration = 1f;
	public float speedDuration = 1f;
	public float defSpeed;

	public Texture2D upB;

	public GameObject gdb;
	private int totalScore;


	public Vector3 MoveVector2 { set; get;}
	public Vector3 MoveVector { set; get;}
	public float drag = 0.5f;
	public float terminalRotationSpeed = 25.0f;

	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 

	private Rigidbody2D thisRigitBody2D;



	void Awake () {

		weapons = GetComponentsInChildren<WeaponScript> ();


	}
	
	void Start () 


	{
		speed = speed + MenuUpgrade.speedU;


		scale.x = Screen.width/originalWidth;  
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 

		thisRigitBody2D = gameObject.GetComponent<Rigidbody2D>();

		thisRigitBody2D.drag = drag;



		duration = 1f;
		speedDuration = 1f;
		defSpeed = speed;

		body = GetComponent<Rigidbody2D>();
		body.freezeRotation = true;
		
		if(projectAxis == ProjectAxis.xAndY) 
		{
			body.gravityScale = 0;
			body.drag = 10;
		}

		gdb = GameObject.Find ("GlobalDataBase");

		joy = GameObject.FindGameObjectWithTag("joystick");
		joystick = joy.GetComponent<Joystick> ();

		joy2 = GameObject.FindGameObjectWithTag ("joystick2");
		joystick2 = joy2.GetComponent<Joystick2> ();
	}



	
	void OnCollisionStay2D(Collision2D coll) 
	{
		if(coll.transform.tag == "Ground")
		{
			body.drag = 10;
			jump = true;
		}
	}
	
	void OnCollisionExit2D(Collision2D coll) 
	{
		if(coll.transform.tag == "Ground")
		{
			body.drag = 0;
			jump = false;
		}
	}
	
	void FixedUpdate()
	{
		body.AddForce(direction * body.mass * speed);
		
		if(Mathf.Abs(body.velocity.x) > speed/100f)
		{
			body.velocity = new Vector2(Mathf.Sign(body.velocity.x) * speed/100f, body.velocity.y);
		}
		
		if(projectAxis == ProjectAxis.xAndY)
		{
			if(Mathf.Abs(body.velocity.y) > speed/100f)
			{
				body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y) * speed/100f);
			}
		}
		else
		{
			if(Input.GetKey(addForceButton) && jump)
			{
				body.velocity = new Vector2(0, addForce);
			}
		}
	}
	
	void Flip()
	{
		if(projectAxis == ProjectAxis.onlyX)
		{
			isFacingRight = !isFacingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}


	private Vector3 PoolInput2 ()

	{
		Vector3 dir2 = Vector3.zero;
		dir2.x = joystick2.Horizontal ();
		dir2.y = joystick2.Vertical ();

		float angle = Mathf.Atan2 (dir2.y, dir2.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);


		if (dir2.magnitude > 1)
			dir2.Normalize ();
		return dir2;
	}


	private Vector3 PoolInput ()
	{
		Vector3 dir = Vector3.zero;
		dir.x = joystick.Horizontal ();
		dir.y = joystick.Vertical ();

	
			


		if (dir.magnitude > 1)
			dir.Normalize ();
		return dir;
	}

	private void Move ()
	{

		thisRigitBody2D.AddForce ((MoveVector * speed));





	    ///transform.rotation = Quaternion.Euler ((MoveVector)*sens);
	}




	void Update () 
	{




		///androidFor

		MoveVector2 = PoolInput2 ();
		MoveVector = PoolInput ();
		Move ();

	








		if (speeded == true) {

			speedDuration = speedDuration +0.1f * Time.deltaTime;


		}
		if (speedDuration > duration) {
			speed =+ 200;

		}
		if (speedDuration > 2.5f) {
			speeded = false;
			speedDuration = 1f;
			duration = 1f;
			speed = defSpeed;
		}


		if (Input.GetKey (KeyCode.Escape)) {
			pause = true;
		}

		if (pause == false) {
			Time.timeScale = 1f;
		}





			///USE FOR PC 
			///if (lookAtCursor) {
			///Vector3 lookPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
			///lookPos = lookPos - transform.position;
			///float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;
			///transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			///}




		
		if(Input.GetKey(upButton)) vertical = 1;
		else if(Input.GetKey(downButton)) vertical = -1; else vertical = 0;
		
		if(Input.GetKey(leftButton)) horizontal = -1;
		else if(Input.GetKey(rightButton)) horizontal = 1; else horizontal = 0;
		
		if(projectAxis == ProjectAxis.onlyX) 
		{
			direction = new Vector2(horizontal, 0); 
		}
		else 
		{
			if(Input.GetKeyDown(addForceButton)) speed += addForce; else if(Input.GetKeyUp(addForceButton)) speed -= addForce;
			direction = new Vector2(horizontal, vertical);
		}
		
		if(horizontal > 0 && !isFacingRight) Flip(); else if(horizontal < 0 && isFacingRight) Flip();


			bool shoot = Input.GetButton ("Fire1");


	
		
		
		
		{
			foreach (WeaponScript weapon in weapons) {

				if (shoot) {


					if (weapon != null) {
						weapon.Attack (false);
					}
				
				}
			}
		}

		totalScore = gdb.GetComponent<GDB> ().enemyScore;
}
	void OnDestroy ()
	{

	}

	void OnGUI ()
	{
		


		GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, scale);
		
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (670, 130, 100, 30), "СКОРОСТЬ " + speed.ToString (), GUI.skin.label);}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (670, 130, 100, 30), "SPEED " + speed.ToString (), GUI.skin.label);}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (670, 130, 100, 30), "速度 " + speed.ToString (), GUI.skin.label);}



		if (pause) {

			Time.timeScale = 0.0001f;






			///rus
			if (MenuScript.lang == 1) {
				if (GUI.Button (new Rect (300, 190, 200, 50), "Меню уровней")) {
					Application.LoadLevel ("LevelMenu");
				}
		
				if (GUI.Button (new Rect (300, 310, 200, 50), "Главное меню")) {
					Application.LoadLevel ("Menu");
				}

				if (GUI.Button (new Rect (300, 70, 200, 50), "Продолжить")) {
					pause = false;
				}

				if (GUI.Button (new Rect (300, 250, 200, 50), "Меню смайлов")) {
					Application.LoadLevel ("PlayerMenu");
				}

				if (GUI.Button (new Rect (300, 370, 200, 50), "Выйти из игры")) {
					Application.Quit ();
				}

				if (GUI.Button (new Rect (300, 130, 200, 50), "Сохранить")) {
					GDB.globalScore = GDB.globalScore + totalScore;
					PlayerPrefs.SetInt ("activity", GDB.activity);
					PlayerPrefs.SetFloat ("xp", GDB.xp);
					PlayerPrefs.SetInt ("lev", GDB.levXp);
					PlayerPrefs.SetInt ("score", GDB.globalScore);
					PlayerPrefs.SetInt ("ruby", GDB.redMoney);
					PlayerPrefs.SetInt ("coin", GDB.coins);
					PlayerPrefs.SetInt ("level", GDB.unlockLeavel);
					PlayerPrefs.SetInt ("saphire", GDB.blueMoney);
					PlayerPrefs.SetInt ("emerald", GDB.greenMoney);
					PlayerPrefs.SetInt ("damage", MenuUpgrade.damageU);
					PlayerPrefs.SetInt ("health", MenuUpgrade.healthU);
					PlayerPrefs.SetInt ("speed", MenuUpgrade.speedU);
					PlayerPrefs.SetInt ("armor", MenuUpgrade.armorU);
					PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
					PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
					PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
					PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
					PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
					PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
					PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
					PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
					PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
					PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
					PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
					PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
					PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
					PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
					PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
					PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
					PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
					PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
					PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
					PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
					PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
					PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
					PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
					PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_25);
					PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
					PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
					PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
					PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
					PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
					PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
					PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
					PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
					PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
					PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
					PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
					PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
					PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
					PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
					PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
					PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
					PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
					PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
					PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
					PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
					PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
					PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
					PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
					PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
					PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
					PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
					PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
					PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
					PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
					PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
					PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
					PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
					PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
					PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
					PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
					PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
					PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
					PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
				}
			}
			///eng
			if (MenuScript.lang == 2) {
				if (GUI.Button (new Rect (300, 190, 200, 50), "Level Menu")) {
					Application.LoadLevel ("LevelMenu");
				}
				
				if (GUI.Button (new Rect (300, 310, 200, 50), "Main Menu")) {
					Application.LoadLevel ("Menu");
				}
				
				if (GUI.Button (new Rect (300, 70, 200, 50), "Continue")) {
					pause = false;
				}
				
				if (GUI.Button (new Rect (300, 250, 200, 50), "Characters")) {
					Application.LoadLevel ("PlayerMenu");
				}
				
				if (GUI.Button (new Rect (300, 370, 200, 50), "Quit Game")) {
					Application.Quit ();
				}
				
				if (GUI.Button (new Rect (300, 130, 200, 50), "Save Game")) {
					GDB.globalScore = GDB.globalScore + totalScore;
					PlayerPrefs.SetInt ("activity", GDB.activity);
					PlayerPrefs.SetFloat ("xp", GDB.xp);
					PlayerPrefs.SetInt ("lev", GDB.levXp);
					PlayerPrefs.SetInt ("score", GDB.globalScore);
					PlayerPrefs.SetInt ("ruby", GDB.redMoney);
					PlayerPrefs.SetInt ("coin", GDB.coins);
					PlayerPrefs.SetInt ("level", GDB.unlockLeavel);
					PlayerPrefs.SetInt ("saphire", GDB.blueMoney);
					PlayerPrefs.SetInt ("emerald", GDB.greenMoney);
					PlayerPrefs.SetInt ("damage", MenuUpgrade.damageU);
					PlayerPrefs.SetInt ("health", MenuUpgrade.healthU);
					PlayerPrefs.SetInt ("speed", MenuUpgrade.speedU);
					PlayerPrefs.SetInt ("armor", MenuUpgrade.armorU);
					PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
					PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
					PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
					PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
					PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
					PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
					PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
					PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
					PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
					PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
					PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
					PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
					PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
					PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
					PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
					PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
					PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
					PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
					PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
					PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
					PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
					PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
					PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
					PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_25);
					PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
					PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
					PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
					PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
					PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
					PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
					PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
					PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
					PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
					PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
					PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
					PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
					PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
					PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
					PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
					PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
					PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
					PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
					PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
					PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
					PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
					PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
					PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
					PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
					PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
					PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
					PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
					PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
					PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
					PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
					PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
					PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
					PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
					PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
					PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
					PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
					PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
					PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
				}
			}
			///chi
			if (MenuScript.lang == 3) {
				if (GUI.Button (new Rect (300, 190, 200, 50), "该级别的菜单")) {
					Application.LoadLevel ("LevelMenu");
				}
				
				if (GUI.Button (new Rect (300, 310, 200, 50), "主菜单")) {
					Application.LoadLevel ("Menu");
				}
				
				if (GUI.Button (new Rect (300, 70, 200, 50), "继续")) {
					pause = false;
				}
				
				if (GUI.Button (new Rect (300, 250, 200, 50), "菜单字")) {
					Application.LoadLevel ("PlayerMenu");
				}
				
				if (GUI.Button (new Rect (300, 370, 200, 50), "得出的游戏")) {
					Application.Quit ();
				}
				
				if (GUI.Button (new Rect (300, 130, 200, 50), "保存游戏")) {
					PlayerPrefs.SetInt ("activity", GDB.activity);
					GDB.globalScore = GDB.globalScore + totalScore;
					PlayerPrefs.SetFloat ("xp", GDB.xp);
					PlayerPrefs.SetInt ("lev", GDB.levXp);
					PlayerPrefs.SetInt ("score", GDB.globalScore);
					PlayerPrefs.SetInt ("ruby", GDB.redMoney);
					PlayerPrefs.SetInt ("coin", GDB.coins);
					PlayerPrefs.SetInt ("level", GDB.unlockLeavel);
					PlayerPrefs.SetInt ("saphire", GDB.blueMoney);
					PlayerPrefs.SetInt ("emerald", GDB.greenMoney);
					PlayerPrefs.SetInt ("damage", MenuUpgrade.damageU);
					PlayerPrefs.SetInt ("health", MenuUpgrade.healthU);
					PlayerPrefs.SetInt ("speed", MenuUpgrade.speedU);
					PlayerPrefs.SetInt ("armor", MenuUpgrade.armorU);
					PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
					PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
					PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
					PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
					PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
					PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
					PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
					PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
					PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
					PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
					PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
					PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
					PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
					PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
					PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
					PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
					PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
					PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
					PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
					PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
					PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
					PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
					PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
					PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_25);
					PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
					PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
					PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
					PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
					PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
					PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
					PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
					PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
					PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
					PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
					PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
					PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
					PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
					PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
					PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
					PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
					PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
					PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
					PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
					PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
					PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
					PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
					PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
					PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
					PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
					PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
					PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
					PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
					PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
					PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
					PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
					PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
					PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
					PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
					PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
					PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
					PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
					PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
				}
			}
		}
	}
}