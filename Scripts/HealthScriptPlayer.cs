using UnityEngine;
using System.Collections;

public class HealthScriptPlayer : MonoBehaviour {

	public GUISkin mainGUI;
	public int hp = 1;
	public int hp2;
	public bool isEnemy = true;

	public bool vampire;

	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 

	public void Damage(int damageCount)
	{
		if (hp2 >= 1) {

			hp2 -= damageCount;
		}

		if (hp2 <= 0) {

		hp -= damageCount;
		if (hp <= 0) {
			Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D otherCollider){
		ShotScriptEnemy shot = otherCollider.gameObject.GetComponent<ShotScriptEnemy> ();
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				Damage (shot.damage);
				Destroy (shot.gameObject);

				SpecialEffectHelperP_Damage.Instance.Event (transform.position);
			}
		}
	}
	// Use this for initialization
	void Start () {

		hp = hp + MenuUpgrade.healthU;
		hp2 = hp2 + MenuUpgrade.armorU;

		scale.x = Screen.width/originalWidth; 
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
		
		GUI.skin = mainGUI;

		GUI.Label (new Rect (120, 3, 100, 20), "HP " + hp.ToString(), GUI.skin.label);
		
		if (hp >0) if (hp <=5)
		{GUI.Box(new Rect(10, 3, 10, 20), "", GUI.skin.GetStyle("hp2"));}
		
		if (hp >5) if (hp <=10)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));}
		
		if (hp >10) if (hp <=15)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 10, 20), "", GUI.skin.GetStyle("hp2"));}
		
		if (hp >15) if (hp <=20)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));}
		
		if (hp >20) if (hp <=25)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box (new Rect(60, 3, 10, 20), "", GUI.skin.GetStyle("hp2"));}
		
		if (hp >25) if (hp <=30)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box (new Rect(60, 3, 20, 20), "", GUI.skin.GetStyle("hp"));}
		
		if (hp >30) if (hp <=35)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(60, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(85, 3, 10, 20), "", GUI.skin.GetStyle("hp2"));}
		
		if (hp >35) if (hp <=40)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(60, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(85, 3, 20, 20), "", GUI.skin.GetStyle("hp"));}
		
		if (hp >40) if (hp <=45)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(60, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(85, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(110, 3, 10, 20), "", GUI.skin.GetStyle("hp2"));}
		
		if (hp >45)
		{GUI.Box(new Rect(10, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(35, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(60, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(85, 3, 20, 20), "", GUI.skin.GetStyle("hp"));
			GUI.Box(new Rect(110, 3, 20, 20), "", GUI.skin.GetStyle("hp"));}
		
		
		GUI.Label (new Rect (120, 26, 100, 20), "AR " + hp2.ToString(), GUI.skin.label);
		
		if (hp2 >0) if (hp2 <=5)
		{GUI.Box(new Rect(10, 26, 10, 20), "", GUI.skin.GetStyle("ar2"));}
		
		if (hp2 >5) if (hp2 <=10)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));}
		
		if (hp2 >10) if (hp2 <=15)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 10, 20), "", GUI.skin.GetStyle("ar2"));}
		
		if (hp2 >15) if (hp2 <=20)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));}
		
		if (hp2 >20) if (hp2 <=25)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box (new Rect(60, 26, 10, 20), "", GUI.skin.GetStyle("ar2"));}
		
		if (hp2 >25) if (hp2 <=30)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box (new Rect(60, 26, 20, 20), "", GUI.skin.GetStyle("ar"));}
		
		if (hp2 >30) if (hp2 <=35)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(60, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(85, 26, 10, 20), "", GUI.skin.GetStyle("ar2"));}
		
		if (hp2 >35) if (hp2 <=40)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(60, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(85, 26, 20, 20), "", GUI.skin.GetStyle("ar"));}
		
		if (hp2 >40) if (hp2 <=45)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(60, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(85, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(110, 26, 10, 20), "", GUI.skin.GetStyle("ar2"));}
		
		if (hp2 >45)
		{GUI.Box(new Rect(10, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(35, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(60, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(85, 26, 20, 20), "", GUI.skin.GetStyle("ar"));
			GUI.Box(new Rect(110, 26, 20, 20), "", GUI.skin.GetStyle("ar"));}

		
	}
}


