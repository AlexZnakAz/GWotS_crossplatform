using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 

	public static int diff;
	public static int lang;

	public static bool weapon = true;
	public static bool music = true;
	public static bool speach = true;

	public Texture2D tog;

	private int show;

	void Start()
	{
		scale.x = Screen.width/originalWidth;  
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 

		show = 1;
	} 
	
	

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {

		

		GUI.Label(new Rect(400, 500, 500, 40), "", GUI.skin.label);

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);

		if (lang == 1) {
			music = GUI.Toggle (new Rect (600, 20, 200, 40), music, " МУЗЫКА В ИГРЕ");
		}
		if (lang == 2) {
			music = GUI.Toggle (new Rect (600, 20, 200, 40), music, " MUSIC IN GAME");
		}
		if (lang == 3) {
			music = GUI.Toggle (new Rect (600, 20, 200, 40), music, " 游戏中的音乐");
		}

		if (show == 1) {
			if (GUI.Button (new Rect (300, 100, 200, 50), "R U S")) {
				lang = 1;
				show = 2;
			}

			if (GUI.Button (new Rect (300, 160, 200, 50), "E N G")) {
				lang = 2;
				show = 2;
			}

			if (GUI.Button (new Rect (300, 220, 200, 50), "C H I")) {
				lang = 3;
				show = 2;
			}
		}
		



		///rus

			if (lang == 1) {
			if (show == 3) {
				if (GUI.Button (new Rect (300, 100, 200, 50), "Новая игра")) {
					GDB.activity = 0;
					GDB.xp = 0;
					GDB.levXp = 0;
					GDB.globalScore = 0;
					GDB.redMoney = 0;
					GDB.coins = 0;
					GDB.unlockLeavel = 0;
					GDB.greenMoney = 0;
					GDB.blueMoney = 0;
					MenuUpgrade.armorU = 0;
					MenuUpgrade.damageU = 0;
					MenuUpgrade.healthU = 0;
					MenuUpgrade.speedU = 0;
					PlayerMenu.unlock_id_2 = 0;
					PlayerMenu.unlock_id_3 = 0;
					PlayerMenu.unlock_id_4 = 0;
					PlayerMenu.unlock_id_5 = 0;
					PlayerMenu.unlock_id_6 = 0;
					PlayerMenu.unlock_id_7 = 0;
					PlayerMenu.unlock_id_8 = 0;
					PlayerMenu.unlock_id_9 = 0;
					PlayerMenu.unlock_id_10 = 0;
					PlayerMenu.unlock_id_11 = 0;
					PlayerMenu.unlock_id_12 = 0;
					PlayerMenu.unlock_id_13 = 0;
					PlayerMenu.unlock_id_14 = 0;
					PlayerMenu.unlock_id_15 = 0;
					PlayerMenu.unlock_id_16 = 0;
					PlayerMenu.unlock_id_17 = 0;
					PlayerMenu.unlock_id_18 = 0;
					PlayerMenu.unlock_id_19 = 0;
					PlayerMenu.unlock_id_20 = 0;
					PlayerMenu.unlock_id_21 = 0;
					PlayerMenu.unlock_id_22 = 0;
					PlayerMenu.unlock_id_23 = 0;
					PlayerMenu.unlock_id_24 = 0;
					PlayerMenu.unlock_id_25 = 0;
					PlayerMenu.unlock_id_26 = 0;
					PlayerMenu.unlock_id_27 = 0;
					PlayerMenu.unlock_id_28 = 0;
					PlayerMenu.unlock_id_29 = 0;
					PlayerMenu.unlock_id_30 = 0;
					PlayerMenu.unlock_id_31 = 0;
					PlayerMenu.unlock_id_32 = 0;
					PlayerMenu.unlock_id_33 = 0;
					PlayerMenu.unlock_id_34 = 0;
					PlayerMenu.unlock_id_35 = 0;
					PlayerMenu.unlock_id_36 = 0;
					PlayerMenu.unlock_id_37 = 0;
					PlayerMenu.unlock_id_38 = 0;
					PlayerMenu.unlock_id_39 = 0;
					PlayerMenu.unlock_id_40 = 0;
					PlayerMenu.unlock_id_41 = 0;
					PlayerMenu.unlock_id_42 = 0;
					PlayerMenu.unlock_id_43 = 0;
					PlayerMenu.unlock_id_44 = 0;
					PlayerMenu.unlock_id_45 = 0;
					PlayerMenu.unlock_id_46 = 0;
					PlayerMenu.unlock_id_47 = 0;
					PlayerMenu.unlock_id_48 = 0;
					PlayerMenu.unlock_id_49 = 0;
					PlayerMenu.unlock_id_50 = 0;
					PlayerMenu.unlock_id_51 = 0;
					PlayerMenu.unlock_id_52 = 0;
					PlayerMenu.unlock_id_53 = 0;
					PlayerMenu.unlock_id_54 = 0;
					PlayerMenu.unlock_id_55 = 0;
					PlayerMenu.unlock_id_56 = 0;
					PlayerMenu.unlock_id_57 = 0;
					PlayerMenu.unlock_id_58 = 0;
					PlayerMenu.unlock_id_59 = 0;
					PlayerMenu.unlock_id_60 = 0;
					PlayerMenu.unlock_id_61 = 0;
					PlayerMenu.unlock_id_62 = 0;
					PlayerMenu.unlock_id_63 = 0;
					Application.LoadLevel ("PlayerMenu");

				}

				if (GUI.Button (new Rect (300, 160, 200, 50), "Продолжить")) {

					GDB.activity = PlayerPrefs.GetInt ("activity");
					GDB.xp = PlayerPrefs.GetFloat ("xp");
					GDB.levXp = PlayerPrefs.GetInt ("lev");
					GDB.globalScore = PlayerPrefs.GetInt ("score");
					GDB.redMoney = PlayerPrefs.GetInt ("ruby");
					GDB.coins = PlayerPrefs.GetInt ("coin");
					GDB.unlockLeavel = PlayerPrefs.GetInt ("level");
					GDB.blueMoney = PlayerPrefs.GetInt ("saphire");
					GDB.greenMoney = PlayerPrefs.GetInt ("emerald");
					MenuUpgrade.armorU = PlayerPrefs.GetInt ("armor");
					MenuUpgrade.damageU = PlayerPrefs.GetInt ("damage");
					MenuUpgrade.speedU = PlayerPrefs.GetInt ("speed");
					MenuUpgrade.healthU = PlayerPrefs.GetInt ("health");
					PlayerMenu.unlock_id_2 = PlayerPrefs.GetInt ("char2");
					PlayerMenu.unlock_id_3 = PlayerPrefs.GetInt ("char3");
					PlayerMenu.unlock_id_4 = PlayerPrefs.GetInt ("char4");
					PlayerMenu.unlock_id_5 = PlayerPrefs.GetInt ("char5");
					PlayerMenu.unlock_id_6 = PlayerPrefs.GetInt ("char6");
					PlayerMenu.unlock_id_7 = PlayerPrefs.GetInt ("char7");
					PlayerMenu.unlock_id_8 = PlayerPrefs.GetInt ("char8");
					PlayerMenu.unlock_id_9 = PlayerPrefs.GetInt ("char9");
					PlayerMenu.unlock_id_10 = PlayerPrefs.GetInt ("char10");
					PlayerMenu.unlock_id_11 = PlayerPrefs.GetInt ("char11");
					PlayerMenu.unlock_id_12 = PlayerPrefs.GetInt ("char12");
					PlayerMenu.unlock_id_13 = PlayerPrefs.GetInt ("char13");
					PlayerMenu.unlock_id_14 = PlayerPrefs.GetInt ("char14");
					PlayerMenu.unlock_id_15 = PlayerPrefs.GetInt ("char15");
					PlayerMenu.unlock_id_16 = PlayerPrefs.GetInt ("char16");
					PlayerMenu.unlock_id_17 = PlayerPrefs.GetInt ("char17");
					PlayerMenu.unlock_id_18 = PlayerPrefs.GetInt ("char18");
					PlayerMenu.unlock_id_19 = PlayerPrefs.GetInt ("char19");
					PlayerMenu.unlock_id_20 = PlayerPrefs.GetInt ("char20");
					PlayerMenu.unlock_id_21 = PlayerPrefs.GetInt ("char21");
					PlayerMenu.unlock_id_22 = PlayerPrefs.GetInt ("char22");
					PlayerMenu.unlock_id_23 = PlayerPrefs.GetInt ("char23");
					PlayerMenu.unlock_id_24 = PlayerPrefs.GetInt ("char24");
					PlayerMenu.unlock_id_25 = PlayerPrefs.GetInt ("char25");
					PlayerMenu.unlock_id_26 = PlayerPrefs.GetInt ("char26");
					PlayerMenu.unlock_id_27 = PlayerPrefs.GetInt ("char27");
					PlayerMenu.unlock_id_28 = PlayerPrefs.GetInt ("char28");
					PlayerMenu.unlock_id_29 = PlayerPrefs.GetInt ("char29");
					PlayerMenu.unlock_id_30 = PlayerPrefs.GetInt ("char30");
					PlayerMenu.unlock_id_31 = PlayerPrefs.GetInt ("char31");
					PlayerMenu.unlock_id_32 = PlayerPrefs.GetInt ("char32");
					PlayerMenu.unlock_id_33 = PlayerPrefs.GetInt ("char33");
					PlayerMenu.unlock_id_34 = PlayerPrefs.GetInt ("char34");
					PlayerMenu.unlock_id_35 = PlayerPrefs.GetInt ("char35");
					PlayerMenu.unlock_id_36 = PlayerPrefs.GetInt ("char36");
					PlayerMenu.unlock_id_37 = PlayerPrefs.GetInt ("char37");
					PlayerMenu.unlock_id_38 = PlayerPrefs.GetInt ("char38");
					PlayerMenu.unlock_id_39 = PlayerPrefs.GetInt ("char39");
					PlayerMenu.unlock_id_40 = PlayerPrefs.GetInt ("char40");
					PlayerMenu.unlock_id_41 = PlayerPrefs.GetInt ("char41");
					PlayerMenu.unlock_id_42 = PlayerPrefs.GetInt ("char42");
					PlayerMenu.unlock_id_43 = PlayerPrefs.GetInt ("char43");
					PlayerMenu.unlock_id_44 = PlayerPrefs.GetInt ("char44");
					PlayerMenu.unlock_id_45 = PlayerPrefs.GetInt ("char45");
					PlayerMenu.unlock_id_46 = PlayerPrefs.GetInt ("char46");
					PlayerMenu.unlock_id_47 = PlayerPrefs.GetInt ("char47");
					PlayerMenu.unlock_id_48 = PlayerPrefs.GetInt ("char48");
					PlayerMenu.unlock_id_49 = PlayerPrefs.GetInt ("char49");
					PlayerMenu.unlock_id_50 = PlayerPrefs.GetInt ("char50");
					PlayerMenu.unlock_id_51 = PlayerPrefs.GetInt ("char51");
					PlayerMenu.unlock_id_52 = PlayerPrefs.GetInt ("char52");
					PlayerMenu.unlock_id_53 = PlayerPrefs.GetInt ("char53");
					PlayerMenu.unlock_id_54 = PlayerPrefs.GetInt ("char54");
					PlayerMenu.unlock_id_55 = PlayerPrefs.GetInt ("char55");
					PlayerMenu.unlock_id_56 = PlayerPrefs.GetInt ("char56");
					PlayerMenu.unlock_id_57 = PlayerPrefs.GetInt ("char57");
					PlayerMenu.unlock_id_58 = PlayerPrefs.GetInt ("char58");
					PlayerMenu.unlock_id_59 = PlayerPrefs.GetInt ("char59");
					PlayerMenu.unlock_id_60 = PlayerPrefs.GetInt ("char60");
					PlayerMenu.unlock_id_61 = PlayerPrefs.GetInt ("char61");
					PlayerMenu.unlock_id_62 = PlayerPrefs.GetInt ("char62");
					PlayerMenu.unlock_id_63 = PlayerPrefs.GetInt ("char63");
					Application.LoadLevel ("PlayerMenu");
				}

	
				if (GUI.Button (new Rect (300, 220, 200, 50), "Правила")) {
					Application.LoadLevel ("Staff");
				}


				if (GUI.Button (new Rect (300, 280, 200, 50), "Выход")) {
					Application.Quit ();
				}
			}
			if (show == 2) {

				if (GUI.Button (new Rect (300, 100, 200, 50), "Нормально")) {
					diff = 1;
					show = 3;
				}

				if (GUI.Button (new Rect (300, 160, 200, 50), "Хардкор")) {
					diff = 2;
					show = 3;
				}

				if (GUI.Button (new Rect (300, 220, 200, 50), "Нереально")) {
					diff = 3;
					show = 3;
				}
			}
			}


		///eng

			if (lang == 2) {
			if (show == 3) {
				if (GUI.Button (new Rect (300, 100, 200, 50), "New Game")) {
					GDB.activity = 0;
					GDB.xp = 0;
					GDB.levXp = 0;
					GDB.globalScore = 0;
					GDB.redMoney = 0;
					GDB.coins = 0;
					GDB.unlockLeavel = 0;
					GDB.blueMoney = 0;
					GDB.greenMoney = 0;
					MenuUpgrade.armorU = 0;
					MenuUpgrade.damageU = 0;
					MenuUpgrade.healthU = 0;
					MenuUpgrade.speedU = 0;
					PlayerMenu.unlock_id_2 = 0;
					PlayerMenu.unlock_id_3 = 0;
					PlayerMenu.unlock_id_4 = 0;
					PlayerMenu.unlock_id_5 = 0;
					PlayerMenu.unlock_id_6 = 0;
					PlayerMenu.unlock_id_7 = 0;
					PlayerMenu.unlock_id_8 = 0;
					PlayerMenu.unlock_id_9 = 0;
					PlayerMenu.unlock_id_10 = 0;
					PlayerMenu.unlock_id_11 = 0;
					PlayerMenu.unlock_id_12 = 0;
					PlayerMenu.unlock_id_13 = 0;
					PlayerMenu.unlock_id_14 = 0;
					PlayerMenu.unlock_id_15 = 0;
					PlayerMenu.unlock_id_16 = 0;
					PlayerMenu.unlock_id_17 = 0;
					PlayerMenu.unlock_id_18 = 0;
					PlayerMenu.unlock_id_19 = 0;
					PlayerMenu.unlock_id_20 = 0;
					PlayerMenu.unlock_id_21 = 0;
					PlayerMenu.unlock_id_22 = 0;
					PlayerMenu.unlock_id_23 = 0;
					PlayerMenu.unlock_id_24 = 0;
					PlayerMenu.unlock_id_25 = 0;
					PlayerMenu.unlock_id_26 = 0;
					PlayerMenu.unlock_id_27 = 0;
					PlayerMenu.unlock_id_28 = 0;
					PlayerMenu.unlock_id_29 = 0;
					PlayerMenu.unlock_id_30 = 0;
					PlayerMenu.unlock_id_31 = 0;
					PlayerMenu.unlock_id_32 = 0;
					PlayerMenu.unlock_id_33 = 0;
					PlayerMenu.unlock_id_34 = 0;
					PlayerMenu.unlock_id_35 = 0;
					PlayerMenu.unlock_id_36 = 0;
					PlayerMenu.unlock_id_37 = 0;
					PlayerMenu.unlock_id_38 = 0;
					PlayerMenu.unlock_id_39 = 0;
					PlayerMenu.unlock_id_40 = 0;
					PlayerMenu.unlock_id_41 = 0;
					PlayerMenu.unlock_id_42 = 0;
					PlayerMenu.unlock_id_43 = 0;
					PlayerMenu.unlock_id_44 = 0;
					PlayerMenu.unlock_id_45 = 0;
					PlayerMenu.unlock_id_46 = 0;
					PlayerMenu.unlock_id_47 = 0;
					PlayerMenu.unlock_id_48 = 0;
					PlayerMenu.unlock_id_49 = 0;
					PlayerMenu.unlock_id_50 = 0;
					PlayerMenu.unlock_id_51 = 0;
					PlayerMenu.unlock_id_52 = 0;
					PlayerMenu.unlock_id_53 = 0;
					PlayerMenu.unlock_id_54 = 0;
					PlayerMenu.unlock_id_55 = 0;
					PlayerMenu.unlock_id_56 = 0;
					PlayerMenu.unlock_id_57 = 0;
					PlayerMenu.unlock_id_58 = 0;
					PlayerMenu.unlock_id_59 = 0;
					PlayerMenu.unlock_id_60 = 0;
					PlayerMenu.unlock_id_61 = 0;
					PlayerMenu.unlock_id_62 = 0;
					PlayerMenu.unlock_id_63 = 0;
					Application.LoadLevel ("PlayerMenu");
				
				}
			
				if (GUI.Button (new Rect (300, 160, 200, 50), "Load Game")) {
				
					GDB.activity = PlayerPrefs.GetInt ("activity");
					GDB.xp = PlayerPrefs.GetFloat ("xp");
					GDB.levXp = PlayerPrefs.GetInt ("lev");
					GDB.globalScore = PlayerPrefs.GetInt ("score");
					GDB.redMoney = PlayerPrefs.GetInt ("ruby");
					GDB.coins = PlayerPrefs.GetInt ("coin");
					GDB.unlockLeavel = PlayerPrefs.GetInt ("level");
					GDB.blueMoney = PlayerPrefs.GetInt ("saphire");
					GDB.greenMoney = PlayerPrefs.GetInt ("emerald");
					MenuUpgrade.armorU = PlayerPrefs.GetInt ("armor");
					MenuUpgrade.damageU = PlayerPrefs.GetInt ("damage");
					MenuUpgrade.speedU = PlayerPrefs.GetInt ("speed");
					MenuUpgrade.healthU = PlayerPrefs.GetInt ("health");
					PlayerMenu.unlock_id_2 = PlayerPrefs.GetInt ("char2");
					PlayerMenu.unlock_id_3 = PlayerPrefs.GetInt ("char3");
					PlayerMenu.unlock_id_4 = PlayerPrefs.GetInt ("char4");
					PlayerMenu.unlock_id_5 = PlayerPrefs.GetInt ("char5");
					PlayerMenu.unlock_id_6 = PlayerPrefs.GetInt ("char6");
					PlayerMenu.unlock_id_7 = PlayerPrefs.GetInt ("char7");
					PlayerMenu.unlock_id_8 = PlayerPrefs.GetInt ("char8");
					PlayerMenu.unlock_id_9 = PlayerPrefs.GetInt ("char9");
					PlayerMenu.unlock_id_10 = PlayerPrefs.GetInt ("char10");
					PlayerMenu.unlock_id_11 = PlayerPrefs.GetInt ("char11");
					PlayerMenu.unlock_id_12 = PlayerPrefs.GetInt ("char12");
					PlayerMenu.unlock_id_13 = PlayerPrefs.GetInt ("char13");
					PlayerMenu.unlock_id_14 = PlayerPrefs.GetInt ("char14");
					PlayerMenu.unlock_id_15 = PlayerPrefs.GetInt ("char15");
					PlayerMenu.unlock_id_16 = PlayerPrefs.GetInt ("char16");
					PlayerMenu.unlock_id_17 = PlayerPrefs.GetInt ("char17");
					PlayerMenu.unlock_id_18 = PlayerPrefs.GetInt ("char18");
					PlayerMenu.unlock_id_19 = PlayerPrefs.GetInt ("char19");
					PlayerMenu.unlock_id_20 = PlayerPrefs.GetInt ("char20");
					PlayerMenu.unlock_id_21 = PlayerPrefs.GetInt ("char21");
					PlayerMenu.unlock_id_22 = PlayerPrefs.GetInt ("char22");
					PlayerMenu.unlock_id_23 = PlayerPrefs.GetInt ("char23");
					PlayerMenu.unlock_id_24 = PlayerPrefs.GetInt ("char24");
					PlayerMenu.unlock_id_25 = PlayerPrefs.GetInt ("char25");
					PlayerMenu.unlock_id_26 = PlayerPrefs.GetInt ("char26");
					PlayerMenu.unlock_id_27 = PlayerPrefs.GetInt ("char27");
					PlayerMenu.unlock_id_28 = PlayerPrefs.GetInt ("char28");
					PlayerMenu.unlock_id_29 = PlayerPrefs.GetInt ("char29");
					PlayerMenu.unlock_id_30 = PlayerPrefs.GetInt ("char30");
					PlayerMenu.unlock_id_31 = PlayerPrefs.GetInt ("char31");
					PlayerMenu.unlock_id_32 = PlayerPrefs.GetInt ("char32");
					PlayerMenu.unlock_id_33 = PlayerPrefs.GetInt ("char33");
					PlayerMenu.unlock_id_34 = PlayerPrefs.GetInt ("char34");
					PlayerMenu.unlock_id_35 = PlayerPrefs.GetInt ("char35");
					PlayerMenu.unlock_id_36 = PlayerPrefs.GetInt ("char36");
					PlayerMenu.unlock_id_37 = PlayerPrefs.GetInt ("char37");
					PlayerMenu.unlock_id_38 = PlayerPrefs.GetInt ("char38");
					PlayerMenu.unlock_id_39 = PlayerPrefs.GetInt ("char39");
					PlayerMenu.unlock_id_40 = PlayerPrefs.GetInt ("char40");
					PlayerMenu.unlock_id_41 = PlayerPrefs.GetInt ("char41");
					PlayerMenu.unlock_id_42 = PlayerPrefs.GetInt ("char42");
					PlayerMenu.unlock_id_43 = PlayerPrefs.GetInt ("char43");
					PlayerMenu.unlock_id_44 = PlayerPrefs.GetInt ("char44");
					PlayerMenu.unlock_id_45 = PlayerPrefs.GetInt ("char45");
					PlayerMenu.unlock_id_46 = PlayerPrefs.GetInt ("char46");
					PlayerMenu.unlock_id_47 = PlayerPrefs.GetInt ("char47");
					PlayerMenu.unlock_id_48 = PlayerPrefs.GetInt ("char48");
					PlayerMenu.unlock_id_49 = PlayerPrefs.GetInt ("char49");
					PlayerMenu.unlock_id_50 = PlayerPrefs.GetInt ("char50");
					PlayerMenu.unlock_id_51 = PlayerPrefs.GetInt ("char51");
					PlayerMenu.unlock_id_52 = PlayerPrefs.GetInt ("char52");
					PlayerMenu.unlock_id_53 = PlayerPrefs.GetInt ("char53");
					PlayerMenu.unlock_id_54 = PlayerPrefs.GetInt ("char54");
					PlayerMenu.unlock_id_55 = PlayerPrefs.GetInt ("char55");
					PlayerMenu.unlock_id_56 = PlayerPrefs.GetInt ("char56");
					PlayerMenu.unlock_id_57 = PlayerPrefs.GetInt ("char57");
					PlayerMenu.unlock_id_58 = PlayerPrefs.GetInt ("char58");
					PlayerMenu.unlock_id_59 = PlayerPrefs.GetInt ("char59");
					PlayerMenu.unlock_id_60 = PlayerPrefs.GetInt ("char60");
					PlayerMenu.unlock_id_61 = PlayerPrefs.GetInt ("char61");
					PlayerMenu.unlock_id_62 = PlayerPrefs.GetInt ("char62");
					PlayerMenu.unlock_id_63 = PlayerPrefs.GetInt ("char63");
					Application.LoadLevel ("PlayerMenu");
				}
			
			
				if (GUI.Button (new Rect (300, 220, 200, 50), "Rules")) {
					Application.LoadLevel ("Staff");
				}
			
			
				if (GUI.Button (new Rect (300, 280, 200, 50), "Quit")) {
					Application.Quit ();
				}

			}

			if (show == 2) {
				if (GUI.Button (new Rect (300, 100, 200, 50), "Normal")) {
					diff = 1;
					show = 3;
				}
			
				if (GUI.Button (new Rect (300, 160, 200, 50), "Hardcore")) {
					diff = 2;
					show = 3;
				}
			
				if (GUI.Button (new Rect (300, 220, 200, 50), "Unreal")) {
					diff = 3;
					show = 3;
				}
			}
			}


		///CHI
	
			if (lang == 3) {
			if (show == 3) {
				if (GUI.Button (new Rect (300, 100, 200, 50), "新的游戏")) {

					GDB.activity = 0;
					GDB.xp = 0;
					GDB.levXp = 0;
					GDB.globalScore = 0;
					GDB.redMoney = 0;
					GDB.coins = 0;
					GDB.unlockLeavel = 0;
					GDB.blueMoney = 0;
					GDB.greenMoney = 0;
					MenuUpgrade.armorU = 0;
					MenuUpgrade.damageU = 0;
					MenuUpgrade.healthU = 0;
					MenuUpgrade.speedU = 0;
					PlayerMenu.unlock_id_2 = 0;
					PlayerMenu.unlock_id_3 = 0;
					PlayerMenu.unlock_id_4 = 0;
					PlayerMenu.unlock_id_5 = 0;
					PlayerMenu.unlock_id_6 = 0;
					PlayerMenu.unlock_id_7 = 0;
					PlayerMenu.unlock_id_8 = 0;
					PlayerMenu.unlock_id_9 = 0;
					PlayerMenu.unlock_id_10 = 0;
					PlayerMenu.unlock_id_11 = 0;
					PlayerMenu.unlock_id_12 = 0;
					PlayerMenu.unlock_id_13 = 0;
					PlayerMenu.unlock_id_14 = 0;
					PlayerMenu.unlock_id_15 = 0;
					PlayerMenu.unlock_id_16 = 0;
					PlayerMenu.unlock_id_17 = 0;
					PlayerMenu.unlock_id_18 = 0;
					PlayerMenu.unlock_id_19 = 0;
					PlayerMenu.unlock_id_20 = 0;
					PlayerMenu.unlock_id_21 = 0;
					PlayerMenu.unlock_id_22 = 0;
					PlayerMenu.unlock_id_23 = 0;
					PlayerMenu.unlock_id_24 = 0;
					PlayerMenu.unlock_id_25 = 0;
					PlayerMenu.unlock_id_26 = 0;
					PlayerMenu.unlock_id_27 = 0;
					PlayerMenu.unlock_id_28 = 0;
					PlayerMenu.unlock_id_29 = 0;
					PlayerMenu.unlock_id_30 = 0;
					PlayerMenu.unlock_id_31 = 0;
					PlayerMenu.unlock_id_32 = 0;
					PlayerMenu.unlock_id_33 = 0;
					PlayerMenu.unlock_id_34 = 0;
					PlayerMenu.unlock_id_35 = 0;
					PlayerMenu.unlock_id_36 = 0;
					PlayerMenu.unlock_id_37 = 0;
					PlayerMenu.unlock_id_38 = 0;
					PlayerMenu.unlock_id_39 = 0;
					PlayerMenu.unlock_id_40 = 0;
					PlayerMenu.unlock_id_41 = 0;
					PlayerMenu.unlock_id_42 = 0;
					PlayerMenu.unlock_id_43 = 0;
					PlayerMenu.unlock_id_44 = 0;
					PlayerMenu.unlock_id_45 = 0;
					PlayerMenu.unlock_id_46 = 0;
					PlayerMenu.unlock_id_47 = 0;
					PlayerMenu.unlock_id_48 = 0;
					PlayerMenu.unlock_id_49 = 0;
					PlayerMenu.unlock_id_50 = 0;
					PlayerMenu.unlock_id_51 = 0;
					PlayerMenu.unlock_id_52 = 0;
					PlayerMenu.unlock_id_53 = 0;
					PlayerMenu.unlock_id_54 = 0;
					PlayerMenu.unlock_id_55 = 0;
					PlayerMenu.unlock_id_56 = 0;
					PlayerMenu.unlock_id_57 = 0;
					PlayerMenu.unlock_id_58 = 0;
					PlayerMenu.unlock_id_59 = 0;
					PlayerMenu.unlock_id_60 = 0;
					PlayerMenu.unlock_id_61 = 0;
					PlayerMenu.unlock_id_62 = 0;
					PlayerMenu.unlock_id_63 = 0;
					Application.LoadLevel ("PlayerMenu");
				
				}
			
				if (GUI.Button (new Rect (300, 160, 200, 50), "继续游戏")) {
				
					GDB.activity = PlayerPrefs.GetInt ("activity");
					GDB.xp = PlayerPrefs.GetFloat ("xp");
					GDB.levXp = PlayerPrefs.GetInt ("lev");
					GDB.globalScore = PlayerPrefs.GetInt ("score");
					GDB.redMoney = PlayerPrefs.GetInt ("ruby");
					GDB.coins = PlayerPrefs.GetInt ("coin");
					GDB.unlockLeavel = PlayerPrefs.GetInt ("level");
					GDB.blueMoney = PlayerPrefs.GetInt ("saphire");
					GDB.greenMoney = PlayerPrefs.GetInt ("emerald");
					MenuUpgrade.armorU = PlayerPrefs.GetInt ("armor");
					MenuUpgrade.damageU = PlayerPrefs.GetInt ("damage");
					MenuUpgrade.speedU = PlayerPrefs.GetInt ("speed");
					MenuUpgrade.healthU = PlayerPrefs.GetInt ("health");
					PlayerMenu.unlock_id_2 = PlayerPrefs.GetInt ("char2");
					PlayerMenu.unlock_id_3 = PlayerPrefs.GetInt ("char3");
					PlayerMenu.unlock_id_4 = PlayerPrefs.GetInt ("char4");
					PlayerMenu.unlock_id_5 = PlayerPrefs.GetInt ("char5");
					PlayerMenu.unlock_id_6 = PlayerPrefs.GetInt ("char6");
					PlayerMenu.unlock_id_7 = PlayerPrefs.GetInt ("char7");
					PlayerMenu.unlock_id_8 = PlayerPrefs.GetInt ("char8");
					PlayerMenu.unlock_id_9 = PlayerPrefs.GetInt ("char9");
					PlayerMenu.unlock_id_10 = PlayerPrefs.GetInt ("char10");
					PlayerMenu.unlock_id_11 = PlayerPrefs.GetInt ("char11");
					PlayerMenu.unlock_id_12 = PlayerPrefs.GetInt ("char12");
					PlayerMenu.unlock_id_13 = PlayerPrefs.GetInt ("char13");
					PlayerMenu.unlock_id_14 = PlayerPrefs.GetInt ("char14");
					PlayerMenu.unlock_id_15 = PlayerPrefs.GetInt ("char15");
					PlayerMenu.unlock_id_16 = PlayerPrefs.GetInt ("char16");
					PlayerMenu.unlock_id_17 = PlayerPrefs.GetInt ("char17");
					PlayerMenu.unlock_id_18 = PlayerPrefs.GetInt ("char18");
					PlayerMenu.unlock_id_19 = PlayerPrefs.GetInt ("char19");
					PlayerMenu.unlock_id_20 = PlayerPrefs.GetInt ("char20");
					PlayerMenu.unlock_id_21 = PlayerPrefs.GetInt ("char21");
					PlayerMenu.unlock_id_22 = PlayerPrefs.GetInt ("char22");
					PlayerMenu.unlock_id_23 = PlayerPrefs.GetInt ("char23");
					PlayerMenu.unlock_id_24 = PlayerPrefs.GetInt ("char24");
					PlayerMenu.unlock_id_25 = PlayerPrefs.GetInt ("char25");
					PlayerMenu.unlock_id_26 = PlayerPrefs.GetInt ("char26");
					PlayerMenu.unlock_id_27 = PlayerPrefs.GetInt ("char27");
					PlayerMenu.unlock_id_28 = PlayerPrefs.GetInt ("char28");
					PlayerMenu.unlock_id_29 = PlayerPrefs.GetInt ("char29");
					PlayerMenu.unlock_id_30 = PlayerPrefs.GetInt ("char30");
					PlayerMenu.unlock_id_31 = PlayerPrefs.GetInt ("char31");
					PlayerMenu.unlock_id_32 = PlayerPrefs.GetInt ("char32");
					PlayerMenu.unlock_id_33 = PlayerPrefs.GetInt ("char33");
					PlayerMenu.unlock_id_34 = PlayerPrefs.GetInt ("char34");
					PlayerMenu.unlock_id_35 = PlayerPrefs.GetInt ("char35");
					PlayerMenu.unlock_id_36 = PlayerPrefs.GetInt ("char36");
					PlayerMenu.unlock_id_37 = PlayerPrefs.GetInt ("char37");
					PlayerMenu.unlock_id_38 = PlayerPrefs.GetInt ("char38");
					PlayerMenu.unlock_id_39 = PlayerPrefs.GetInt ("char39");
					PlayerMenu.unlock_id_40 = PlayerPrefs.GetInt ("char40");
					PlayerMenu.unlock_id_41 = PlayerPrefs.GetInt ("char41");
					PlayerMenu.unlock_id_42 = PlayerPrefs.GetInt ("char42");
					PlayerMenu.unlock_id_43 = PlayerPrefs.GetInt ("char43");
					PlayerMenu.unlock_id_44 = PlayerPrefs.GetInt ("char44");
					PlayerMenu.unlock_id_45 = PlayerPrefs.GetInt ("char45");
					PlayerMenu.unlock_id_46 = PlayerPrefs.GetInt ("char46");
					PlayerMenu.unlock_id_47 = PlayerPrefs.GetInt ("char47");
					PlayerMenu.unlock_id_48 = PlayerPrefs.GetInt ("char48");
					PlayerMenu.unlock_id_49 = PlayerPrefs.GetInt ("char49");
					PlayerMenu.unlock_id_50 = PlayerPrefs.GetInt ("char50");
					PlayerMenu.unlock_id_51 = PlayerPrefs.GetInt ("char51");
					PlayerMenu.unlock_id_52 = PlayerPrefs.GetInt ("char52");
					PlayerMenu.unlock_id_53 = PlayerPrefs.GetInt ("char53");
					PlayerMenu.unlock_id_54 = PlayerPrefs.GetInt ("char54");
					PlayerMenu.unlock_id_55 = PlayerPrefs.GetInt ("char55");
					PlayerMenu.unlock_id_56 = PlayerPrefs.GetInt ("char56");
					PlayerMenu.unlock_id_57 = PlayerPrefs.GetInt ("char57");
					PlayerMenu.unlock_id_58 = PlayerPrefs.GetInt ("char58");
					PlayerMenu.unlock_id_59 = PlayerPrefs.GetInt ("char59");
					PlayerMenu.unlock_id_60 = PlayerPrefs.GetInt ("char60");
					PlayerMenu.unlock_id_61 = PlayerPrefs.GetInt ("char61");
					PlayerMenu.unlock_id_62 = PlayerPrefs.GetInt ("char62");
					PlayerMenu.unlock_id_63 = PlayerPrefs.GetInt ("char63");
					Application.LoadLevel ("PlayerMenu");
				}
			
			
				if (GUI.Button (new Rect (300, 220, 200, 50), "游戏规则")) {
					Application.LoadLevel ("Staff");
				}
			
			
				if (GUI.Button (new Rect (300, 280, 200, 50), "输出")) {
					Application.Quit ();
				}
			}
			if (show == 2) {
				if (GUI.Button (new Rect (300, 100, 200, 50), "通常")) {
					diff = 1;
					show = 3;
				}
			
				if (GUI.Button (new Rect (300, 160, 200, 50), "困难")) {
					diff = 2;
					show = 3;
				}
			
				if (GUI.Button (new Rect (300, 220, 200, 50), "虚幻的")) {
					diff = 3;
					show = 3;
				}
			}

		}
}
}
