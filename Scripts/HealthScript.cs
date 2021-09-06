using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public GameObject gdb;
	public GameObject plr;

	
	public int hp = 1;
	public bool isEnemy = true;

	public float maxHp;
	public float persentCurHp;

	public void Damage(int damageCount)

	{


		hp -= damageCount;



		if (hp <= 0) 


		{

			gdb.GetComponent<GDB>().enemyScore +=1;
			GDB.xp += 3;

			Destroy (gameObject); 

			if (plr.GetComponent<HealthScriptPlayer>().vampire == true) {
				plr.GetComponent<HealthScriptPlayer>().hp += 10;}




			SpecialEffectHelperDeath.Instance.Event (transform.position);



		}
	}

	void OnTriggerEnter2D (Collider2D otherCollider){
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				Damage (shot.damage);
				Destroy (shot.gameObject);



				SpecialEffectHelperDamage.Instance.Event (transform.position);


			}
		}
	}
	// Use this for initialization
	void Start () {
	
		gdb = GameObject.Find("GlobalDataBase");
		plr = GameObject.FindGameObjectWithTag ("Player");

		maxHp = hp;


	}

	// Update is called once per frame
	void Update () {
	

		persentCurHp = hp / maxHp *100;
	}

	void OnGUI()
	{

		Vector3 screenPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		Vector3 cameraRelative = Camera.main.transform.InverseTransformPoint(transform.position);
		if (cameraRelative.z > 0)
		{
			Rect position = new Rect(screenPosition.x-30, Screen.height - screenPosition.y-50, 40f, 20f);
			GUI.Label(position, "%" + persentCurHp.ToString());

		



		}
		
		





	}





}
