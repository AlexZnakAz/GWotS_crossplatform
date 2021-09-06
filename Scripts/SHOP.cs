using UnityEngine;
using System.Collections;

public class SHOP : MonoBehaviour {

	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 

	public Texture2D back;

	public Texture2D emerald;
	public Texture2D ruby;
	public Texture2D coins;
	public Texture2D saphire;
	public Texture2D score;

	// Use this for initialization
	void Start () {

		scale.x = Screen.width/originalWidth;  
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI () {

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), back);
		
		GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, scale);

		GUI.DrawTexture (new Rect (310, 4, 40, 40), saphire);
		GUI.Label (new Rect (360, 10, 50, 20), "" + GDB.blueMoney.ToString (), GUI.skin.label);
		GUI.DrawTexture (new Rect (390, 4, 40, 40), emerald);
		GUI.Label (new Rect (440, 10, 50, 20), "" + GDB.greenMoney.ToString (), GUI.skin.label);
		
		GUI.DrawTexture (new Rect (230, 5, 40, 40), ruby);
		GUI.Label (new Rect (280, 10, 50, 20), "" + GDB.redMoney.ToString (), GUI.skin.label);
		GUI.DrawTexture (new Rect (20, 5, 70, 50), score);
		GUI.Label (new Rect (90, 10, 50, 20), "" + GDB.globalScore.ToString (), GUI.skin.label);
		GUI.DrawTexture (new Rect (130, 5, 40, 40), coins);
		GUI.Label (new Rect (180, 10, 50, 20), "" + GDB.coins.ToString (), GUI.skin.label);


		///coins
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (280, 100, 200, 50), "обменять 1 изумруд на 100 монет", GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (280, 110, 200, 50), "exchange 1 emerald for 100 coins", GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (280, 110, 200, 50), "交换1颗祖母绿100枚硬币", GUI.skin.label);
		}
		GUI.Label (new Rect (120, 110, 300, 20), "1            = 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (135, 110, 30, 30), emerald);
		GUI.DrawTexture (new Rect (220, 110, 30, 30), coins);
		if (GUI.Button (new Rect (50, 100, 50, 50), " + ")) {
			if (GDB.greenMoney >= 1) {
				GDB.greenMoney -= 1;
				GDB.coins += 100;
			}
		}
		///ruby
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (280, 160, 200, 50), "обменять 1 изумруд на 5 рубинов", GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (280, 170, 200, 50), "exchange 1 emerald for 5 rubies", GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (280, 170, 200, 50), "交换1颗祖母绿为5颗红宝石", GUI.skin.label);
		}
		GUI.Label (new Rect (120, 170, 300, 20), "1              = 5", GUI.skin.label);
		GUI.DrawTexture (new Rect (135, 170, 30, 30), emerald);
		GUI.DrawTexture (new Rect (220, 170, 30, 30), ruby);
		if (GUI.Button (new Rect (50, 160, 50, 50), " + ")) {
			if (GDB.greenMoney >= 1) {
				GDB.greenMoney -= 1;
				GDB.redMoney += 5;
			}
		}
		/// saphire
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (280, 220, 200, 50), "обменять 1 изумруд на 5 сапфира", GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (280, 220, 200, 50), "exchange 1 emerald for 5 sapphires", GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (280, 230, 200, 50), "交换1颗祖母绿，用于5颗蓝宝石", GUI.skin.label);
		}
		GUI.Label (new Rect (120, 230, 300, 20), "1              = 5", GUI.skin.label);
		GUI.DrawTexture (new Rect (135, 230, 30, 30), emerald);
		GUI.DrawTexture (new Rect (220, 230, 30, 30), saphire);
		if (GUI.Button (new Rect (50, 220, 50, 50), " + ")) {
			if (GDB.greenMoney >= 1) {
				GDB.greenMoney -= 1;
				GDB.blueMoney += 5;
			}
		}
		///enemies
		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (280, 280, 200, 50), "обменять 1 изумруд на 100 врагов", GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (280, 290, 200, 50), "exchange 1 emerald for 100 enemies", GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (280, 290, 200, 50), "为100个敌人交换1颗祖母绿", GUI.skin.label);
		}
		GUI.Label (new Rect (120, 290, 300, 20), "1            = 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (135, 290, 30, 30), emerald);
		GUI.DrawTexture (new Rect (220, 290, 40, 30), score);
		if (GUI.Button (new Rect (50, 280, 50, 50), " + ")) {
			if (GDB.greenMoney >= 1) {
				GDB.greenMoney -= 1;
				GDB.globalScore += 100;
			}
		}


		/// emerald

		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (600, 20, 120, 20), "активность " + GDB.activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (540, 40, 150, 400), "Изумруды даются за активность в игре. Очки активности вы можете пополнять только за активность в игре, а именно подбирая на поле боя аптечки, броню, бонусы скорости и бонусы опыта", GUI.skin.label);
			if (GUI.Button (new Rect (520, 200, 260, 40), "+ 1 изумруд за 100 активности")) {
				if (GDB.activity >= 100){
					GDB.activity -= 100;
					GDB.greenMoney += 1;
				}
			}
			if (GUI.Button (new Rect (520, 250, 260, 40), "+ 5 изумрудов за 400 активности")) {
				if (GDB.activity >= 400){
					GDB.activity -= 400;
					GDB.greenMoney += 5;
				}
			}
			if (GUI.Button (new Rect (520, 300, 260, 40), "+ 10 изумрудов за 800 активности")) {
				if (GDB.activity >= 800){
					GDB.activity -= 800;
					GDB.greenMoney += 10;
				}
			}
		}

		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (600, 20, 120, 20), "activity " + GDB.activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (540, 40, 150, 400), "Emeralds are given for activity in the game. You can replenish activity points only for activity in the game, namely by picking up first-aid kits, armor, speed bonuses and experience bonuses on the battlefield.", GUI.skin.label);
			if (GUI.Button (new Rect (520, 200, 260, 40), "+ 1 emerald per 100 activities")) {
				if (GDB.activity >= 100){
					GDB.activity -= 100;
					GDB.greenMoney += 1;
				}
			}
			if (GUI.Button (new Rect (520, 250, 260, 40), "+ 5 emeralds for 400 activity")) {
				if (GDB.activity >= 400){
					GDB.activity -= 400;
					GDB.greenMoney += 5;
				}
			}
			if (GUI.Button (new Rect (520, 300, 260, 40), "+ 10 emeralds for 800 activity")) {
				if (GDB.activity >= 800){
					GDB.activity -= 800;
					GDB.greenMoney += 10;
				}
			}
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (600, 20, 120, 20), "活动 " + GDB.activity.ToString (), GUI.skin.label);
			GUI.Label (new Rect (540, 40, 150, 400), "祖母绿是在游戏中进行活动的。 您可以仅为游戏中的活动补充活动积分，即在战场上获取急救包，护甲，速度奖励和经验奖励。", GUI.skin.label);
			if (GUI.Button (new Rect (520, 200, 260, 40), "+ 每100个活动1颗祖母绿")) {
				if (GDB.activity >= 100){
					GDB.activity -= 100;
					GDB.greenMoney += 1;
				}
			}
			if (GUI.Button (new Rect (520, 250, 260, 40), "+ 5颗祖母绿可进行400次活动")) {
				if (GDB.activity >= 400){
					GDB.activity -= 400;
					GDB.greenMoney += 5;
				}
			}
			if (GUI.Button (new Rect (520, 300, 260, 40), "+ 10颗祖母绿可以进行800次活动")) {
				if (GDB.activity >= 800){
					GDB.activity -= 800;
					GDB.greenMoney += 10;
				}
			}
		}







		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "Назад")) {
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
				Application.LoadLevel ("PlayerMenu");
			}
		}
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "Back")) {
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
				Application.LoadLevel ("PlayerMenu");
			}
		}
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "前")) {
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
				Application.LoadLevel ("PlayerMenu");
			}
		}

	}
}

