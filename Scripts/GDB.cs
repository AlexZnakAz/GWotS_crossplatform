using UnityEngine;
using System.Collections;

public class GDB : MonoBehaviour {



	public GUISkin mainGUI;

	public int enemyScore;
	public static int globalScore;
	public static int redMoney;
	public static int coins;
	public int winScore;
	public static int unlockLeavel;
	public int unlock;
	public static int greenMoney;
	public static int blueMoney;

	public static int activity;

	public static float xp;
	public static int levXp;
	public float persentXp;


	
	public float originalWidth = 800.0f; // Оригинальный размер игрового экрана по ширине
	public float originalHeight = 480.0f; // Оригинальный размер игрового экрана по высоте
	Vector3 scale; 

	// Use this for initialization
	void Start () {

		scale.x = Screen.width/originalWidth; // Получаем фактор соотношения по ширине 
		scale.y = Screen.height/originalHeight; // Получаем фактор соотношения по высоте
		scale.z = 1; // Неиспользуется, но указать стоит

	
	}
	
	// Update is called once per frame
	void Update () {


		persentXp = xp / 5000 *100;

		if (xp >= 5000) {
			levXp += 1;
			blueMoney += 10;
			xp = 0;
		}
	

	}




	void OnGUI () {

		GUI.skin = mainGUI;

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);

		if (winScore <= enemyScore) {

			unlockLeavel = unlock;

			if (MenuScript.lang == 1) {
				GUI.Box (new Rect (300, 150, 200, 30), "Победа!");
				if (GUI.Button (new Rect (300, 260, 200, 50), "Продолжить")) {

					globalScore = globalScore + enemyScore;

					PlayerPrefs.SetInt ("activity", activity);
					PlayerPrefs.SetFloat ("xp", xp);
					PlayerPrefs.SetInt ("lev", levXp);
					PlayerPrefs.SetInt ("score", globalScore);
					PlayerPrefs.SetInt ("ruby", redMoney);
					PlayerPrefs.SetInt ("coin", coins);
					PlayerPrefs.SetInt ("level", unlockLeavel);
					PlayerPrefs.SetInt ("saphire", blueMoney);
					PlayerPrefs.SetInt ("emerald", greenMoney);
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

					Application.LoadLevel ("LevelMenu");

				}
			}

			if (MenuScript.lang == 2) {
				GUI.Box (new Rect (300, 150, 200, 30), "Victory!");
				if (GUI.Button (new Rect (300, 260, 200, 50), "Continue")) {
					
					globalScore = globalScore + enemyScore;

					PlayerPrefs.SetInt ("activity", activity);
					PlayerPrefs.SetFloat ("xp", xp);
					PlayerPrefs.SetInt ("lev", levXp);
					PlayerPrefs.SetInt ("score", globalScore);
					PlayerPrefs.SetInt ("ruby", redMoney);
					PlayerPrefs.SetInt ("coin", coins);
					PlayerPrefs.SetInt ("saphire", blueMoney);
					PlayerPrefs.SetInt ("emerald", greenMoney);
					PlayerPrefs.SetInt ("level", unlockLeavel);
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
					
					Application.LoadLevel ("LevelMenu");
					
				}
			}

			if (MenuScript.lang == 3) {
				GUI.Box (new Rect (300, 150, 200, 30), "胜利!");
				if (GUI.Button (new Rect (300, 260, 200, 50), "继续")) {
					
					globalScore = globalScore + enemyScore;

					PlayerPrefs.SetInt ("activity", activity);
					PlayerPrefs.SetFloat ("xp", xp);
					PlayerPrefs.SetInt ("lev", levXp);
					PlayerPrefs.SetInt ("score", globalScore);
					PlayerPrefs.SetInt ("ruby", redMoney);
					PlayerPrefs.SetInt ("coin", coins);
					PlayerPrefs.SetInt ("level", unlockLeavel);
					PlayerPrefs.SetInt ("saphire", blueMoney);
					PlayerPrefs.SetInt ("emerald", greenMoney);
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
					
					Application.LoadLevel ("LevelMenu");
					
				}
			}
		}
	


		if (MenuScript.lang == 1) {

			MenuScript.weapon = GUI.Toggle (new Rect (700, 35, 80, 30), MenuScript.weapon, " ЗВУК");
			MenuScript.speach = GUI.Toggle (new Rect (700, 65, 80, 30), MenuScript.speach, " РЕЧЬ");
		}


		if (MenuScript.lang == 2) {

			MenuScript.weapon = GUI.Toggle (new Rect (700, 35, 80, 30), MenuScript.weapon, " SOUND");
			MenuScript.speach = GUI.Toggle (new Rect (700, 65, 80, 30), MenuScript.speach, " SPEACH");
		}
			
		if (MenuScript.lang == 3) {
		
			MenuScript.weapon = GUI.Toggle (new Rect (700, 35, 80, 30), MenuScript.weapon, " 声音");
			MenuScript.speach = GUI.Toggle (new Rect (700, 65, 80, 30), MenuScript.speach, " 演讲");
		}

		
			

		GUI.Box (new Rect (560, 5, 30, 20), "", GUI.skin.GetStyle ("green"));
		GUI.Label (new Rect (590, 5, 50, 20), "" + greenMoney.ToString (), GUI.skin.label);
		GUI.Box (new Rect (470, 5, 30, 20), "", GUI.skin.GetStyle ("blue"));
		GUI.Label (new Rect (500, 5, 50, 20), "" + blueMoney.ToString (), GUI.skin.label);
		GUI.Box (new Rect (380, 5, 30, 20), "", GUI.skin.GetStyle ("red"));
		GUI.Label (new Rect (410, 5, 50, 20), "" + redMoney.ToString (), GUI.skin.label);

		GUI.Box(new Rect(10, 80, 50, 30), "", GUI.skin.GetStyle("score"));
		GUI.Box (new Rect (250, 5, 30, 30), "", GUI.skin.GetStyle ("coins"));

		GUI.Label (new Rect (280, 5, 100, 20), "" + coins.ToString (), GUI.skin.label);
		GUI.Label(new Rect(65, 75, 60, 40), "" + enemyScore.ToString(), GUI.skin.label);
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (670, 100, 120, 20), "активность " + activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 120, 140, 40), "ВСЕГО: " + globalScore.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 160, 140, 40), "НУЖНО:" + winScore.ToString (), GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (670, 100, 120, 20), "activity " + activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 120, 140, 40), "TOTAL: " + globalScore.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 160, 140, 40), "NEED:" + winScore.ToString (), GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (670, 100, 120, 20), "活动 " + activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 120, 140, 40), "只是: " + globalScore.ToString (), GUI.skin.label);
			GUI.Label (new Rect (5, 160, 140, 40), "需要:" + winScore.ToString (), GUI.skin.label);
		}

		GUI.Label (new Rect (10, 200, 100, 20), "LV.  " + levXp.ToString (), GUI.skin.label);
		GUI.Label (new Rect (100, 200, 100, 20), "%" + persentXp.ToString (), GUI.skin.label);
	}
}
