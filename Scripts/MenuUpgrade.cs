using UnityEngine;
using System.Collections;

public class MenuUpgrade : MonoBehaviour {

	public Texture2D armor;
	public Texture2D health;
	public Texture2D damage;
	public Texture2D speed;

	public Texture2D back;

	public Texture2D saphire;

	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 


	public static int damageU;
	public static int healthU;
	public static int speedU;
	public static int armorU;


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

		GUI.DrawTexture (new Rect (55, 15, 50, 50), saphire);
		GUI.Label (new Rect (25, 30, 30, 20), "" + GDB.blueMoney.ToString (), GUI.skin.label);

		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (115, 15, 650, 100), "Сапфиры - это валюта, за которую можно улучшать общие способности смайлов, такие как здоровье, скорость и урон. Произведенные улучшения действуют на ВСЕ персонажи. Данная валюта выдается при переходе на новый уровень. За каждый новый уровень игрока вы будете получать 10 сапфиров. Улучшение действует и на улучшенных персонажей.", GUI.skin.label);
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
				PlayerPrefs.SetInt ("damage", damageU);
				PlayerPrefs.SetInt ("health", healthU);
				PlayerPrefs.SetInt ("speed", speedU);
				PlayerPrefs.SetInt ("armor", armorU);
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
			GUI.Label (new Rect (115, 15, 650, 100), "Sapphires are the currency for which you can improve your overall emoticon abilities, such as health, speed and damage. The improvements made affect ALL characters. This currency is issued when moving to a new level. For each new player level you will receive 10 sapphires. Improvement effect on the improved characters.", GUI.skin.label);
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
				PlayerPrefs.SetInt ("damage", damageU);
				PlayerPrefs.SetInt ("health", healthU);
				PlayerPrefs.SetInt ("speed", speedU);
				PlayerPrefs.SetInt ("armor", armorU);
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
			GUI.Label (new Rect (115, 15, 650, 100), "蓝宝石是您可以提高整体表情能力的货币，例如健康，速度和伤害。所做的改进会影响所有角色。移动到新级别时会发出此货币。对于每个新玩家级别，您将获得10个蓝宝石。改善对改善人物的影响。", GUI.skin.label);
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
				PlayerPrefs.SetInt ("damage", damageU);
				PlayerPrefs.SetInt ("health", healthU);
				PlayerPrefs.SetInt ("speed", speedU);
				PlayerPrefs.SetInt ("armor", armorU);
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


		GUI.DrawTexture (new Rect (660, 120, 60, 60), damage);
		GUI.DrawTexture (new Rect (660, 190, 50, 50), health);
		GUI.DrawTexture (new Rect (662, 250, 50, 50), speed);
		GUI.DrawTexture (new Rect (661, 313, 50, 50), armor);

		/// updates

		///for damage rus

		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (550, 140, 100, 50), "СЕЙЧАС + " + damageU.ToString (), GUI.skin.label);

			if (damageU == 0) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 1/20) Увеличит урон от оружия смайла на 1. Стоимость улучшения: 3 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 3) {
						damageU += 1;
						GDB.blueMoney -= 3;
					}
				}
			}
			if (damageU == 1) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 2/20) Увеличит урон от оружия смайла еще на 1. Стоимость улучшения 7 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 7) {
						damageU += 1;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (damageU == 2) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 3/20) Увеличит урон от оружия смайла еще на 1. Стоимость улучшения 12 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 12) {
						damageU += 1;
						GDB.blueMoney -= 12;
					}
				}
			}
			if (damageU == 3) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 4/20) Увеличит урон от оружия смайла еще на 1. Стоимость улучшения 16 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 16) {
						damageU += 1;
						GDB.blueMoney -= 16;
					}
				}
			}
			if (damageU == 4) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 5/20) Увеличит урон от оружия смайла еще на 1. Стоимость улучшения 19 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 19) {
						damageU += 1;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (damageU == 5) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 6/20) Увеличит урон от оружия смайла еще на 2. Стоимость улучшения 22 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 22) {
						damageU += 2;
						GDB.blueMoney -= 22;
					}
				}
			}
			if (damageU == 7) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 7/20) Увеличит урон от оружия смайла еще на 2. Стоимость улучшения 24 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 24) {
						damageU += 2;
						GDB.blueMoney -= 24;
					}
				}
			}
			if (damageU == 9) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 8/20) Увеличит урон от оружия смайла еще на 2. Стоимость улучшения 26 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 26) {
						damageU += 2;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (damageU == 11) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 9/20) Увеличит урон от оружия смайла еще на 2. Стоимость улучшения 29 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 29) {
						damageU += 2;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (damageU == 13) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 10/20) Увеличит урон от оружия смайла еще на 2. Стоимость улучшения 33 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 33) {
						damageU += 2;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (damageU == 15) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 11/20) Увеличит урон от оружия смайла еще на 3. Стоимость улучшения 38 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 38) {
						damageU += 3;
						GDB.blueMoney -= 38;
					}
				}
			}
			if (damageU == 18) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 12/20) Увеличит урон от оружия смайла еще на 3. Стоимость улучшения 43 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 43) {
						damageU += 3;
						GDB.blueMoney -= 43;
					}
				}
			}
			if (damageU == 21) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 13/20) Увеличит урон от оружия смайла еще на 3. Стоимость улучшения 47 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 47) {
						damageU += 3;
						GDB.blueMoney -= 47;
					}
				}
			}
			if (damageU == 24) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 14/20) Увеличит урон от оружия смайла еще на 4. Стоимость улучшения 53 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 53) {
						damageU += 4;
						GDB.blueMoney -= 53;
					}
				}
			}
			if (damageU == 28) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 15/20) Увеличит урон от оружия смайла еще на 4. Стоимость улучшения 58 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 58) {
						damageU += 4;
						GDB.blueMoney -= 58;
					}
				}
			}
			if (damageU == 32) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 16/20) Увеличит урон от оружия смайла еще на 4. Стоимость улучшения 62 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 62) {
						damageU += 4;
						GDB.blueMoney -= 62;
					}
				}
			}
			if (damageU == 36) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 17/20) Увеличит урон от оружия смайла еще на 5. Стоимость улучшения 68 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 68) {
						damageU += 5;
						GDB.blueMoney -= 68;
					}
				}
			}
			if (damageU == 41) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 18/20) Увеличит урон от оружия смайла еще на 5. Стоимость улучшения 73 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 73) {
						damageU += 5;
						GDB.blueMoney -= 73;
					}
				}
			}
			if (damageU == 46) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 19/20) Увеличит урон от оружия смайла еще на 5. Стоимость улучшения 77 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 77) {
						damageU += 5;
						GDB.blueMoney -= 77;
					}
				}
			}
			if (damageU == 51) {
				GUI.Label (new Rect (180, 130, 300, 100), "(уровень 20/20) Увеличит урон от оружия смайла еще на 5. Стоимость улучшения 82 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ УРОН")) {
					if (GDB.blueMoney >= 82) {
						damageU += 5;
						GDB.blueMoney -= 82;
					}
				}
			}
			if (damageU == 56) {
				GUI.Label (new Rect (180, 130, 300, 100), "Достигнут максимально возможный уровень улучшения УРОНА", GUI.skin.label);
			}
		}

			///for damage eng

			if (MenuScript.lang == 2) {
			GUI.Label (new Rect (550, 140, 100, 50), "NOW + " + damageU.ToString (), GUI.skin.label);
				
			if (damageU == 0) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 1/20) Will increase the damage from the smiley weapon by 1. Upgrade cost: 3 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 3) {
						damageU += 1;
						GDB.blueMoney -= 3;
					}
				}
			}
			if (damageU == 1) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 2/20) Will increase the damage from the smiley weapons by another 1. Cost of upgrading 7 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 7) {
						damageU += 1;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (damageU == 2) {
				GUI.Label (new Rect (180, 130, 300, 100), "(Level 3/20) Will increase the damage from the smile weapon by another 1. Cost of upgrading 12 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 12) {
						damageU += 1;
						GDB.blueMoney -= 12;
					}
				}
			}
			if (damageU == 3) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 4/20) Will increase the damage from the smile weapons by another 1. The cost of improving 16 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 16) {
						damageU += 1;
						GDB.blueMoney -= 16;
					}
				}
			}
			if (damageU == 4) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 5/20) Will increase the damage from the smile weapon by 1. Cost to upgrade 19 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 19) {
						damageU += 1;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (damageU == 5) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 6/20) Will increase the damage from the smiley weapon by another 2. Cost of upgrading 22 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 22) {
						damageU += 2;
						GDB.blueMoney -= 22;
					}
				}
			}
			if (damageU == 7) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 7/20) Will increase the damage from the smiley weapon by another 2. Cost of upgrading 24 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 24) {
						damageU += 2;
						GDB.blueMoney -= 24;
					}
				}
			}
			if (damageU == 9) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 8/20) Will increase the damage from the smile weapons by another 2. The cost of improving sapphire 26", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 26) {
						damageU += 2;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (damageU == 11) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 9/20) Will increase the damage from the smile weapons by another 2. Cost of upgrading 29 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 29) {
						damageU += 2;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (damageU == 13) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 10/20) Will increase the damage from the smile weapons by another 2. The cost of improving the 33 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 33) {
						damageU += 2;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (damageU == 15) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 11/20) Will increase the damage from the smile weapon by 3. Improvement cost of 38 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 38) {
						damageU += 3;
						GDB.blueMoney -= 38;
					}
				}
			}
			if (damageU == 18) {
				GUI.Label (new Rect (180, 130, 300, 100), "(Level 12/20) Will increase the damage from the smile weapons by another 3. The cost of improving 43 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 43) {
						damageU += 3;
						GDB.blueMoney -= 43;
					}
				}
			}
			if (damageU == 21) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 13/20) Will increase the damage from the smile weapons by another 3. The cost of improving 47 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 47) {
						damageU += 3;
						GDB.blueMoney -= 47;
					}
				}
			}
			if (damageU == 24) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 14/20) Will increase the damage from the smile weapons by another 4. Cost of upgrading 53 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 53) {
						damageU += 4;
						GDB.blueMoney -= 53;
					}
				}
			}
			if (damageU == 28) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 15/20) Will increase the damage from the smile weapons by another 4. Cost to upgrade 58 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 58) {
						damageU += 4;
						GDB.blueMoney -= 58;
					}
				}
			}
			if (damageU == 32) {
				GUI.Label (new Rect (180, 130, 300, 100), "(16/20 Level) Will increase the damage from the smile weapons by another 4. Cost to improve 62 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 62) {
						damageU += 4;
						GDB.blueMoney -= 62;
					}
				}
			}
			if (damageU == 36) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 17/20) Will increase the damage from the smile weapons by another 5. The cost of improving 68 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 68) {
						damageU += 5;
						GDB.blueMoney -= 68;
					}
				}
			}
			if (damageU == 41) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 18/20) Will increase the damage from the smiley weapons by another 5. The cost of improving 73 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 73) {
						damageU += 5;
						GDB.blueMoney -= 73;
					}
				}
			}
			if (damageU == 46) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 19/20) Will increase the damage from the smiley weapon by another 5. Cost of improving 77 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 77) {
						damageU += 5;
						GDB.blueMoney -= 77;
					}
				}
			}
			if (damageU == 51) {
				GUI.Label (new Rect (180, 130, 300, 100), "(level 20/20) Will increase the damage from the smiley weapon by another 5. Cost of improving 82 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 130, 100, 50), "+ DAMAGE")) {
					if (GDB.blueMoney >= 82) {
						damageU += 5;
						GDB.blueMoney -= 82;
					}
				}
			}
			if (damageU == 56) {
				GUI.Label (new Rect (180, 130, 300, 100), "Reached the highest possible level of IMPROVED DAMAGE", GUI.skin.label);
			}
		}
				/// upgread damage chi

				if (MenuScript.lang == 3) {
					GUI.Label (new Rect (550, 140, 100, 50), "现在 + " + damageU.ToString (), GUI.skin.label);
					
					if (damageU == 0) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级1/20）将增加笑脸武器的伤害1.升级费用：3蓝宝石", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 3) {
								damageU += 1;
								GDB.blueMoney -= 3;
							}
						}
					}
					if (damageU == 1) {
						GUI.Label (new Rect (180, 130, 300, 100), "（2/20级）将笑脸武器的伤害提高1点。升级7蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 7) {
								damageU += 1;
								GDB.blueMoney -= 7;
							}
						}
					}
					if (damageU == 2) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级3/20）将微笑武器的伤害提高另一个1.升级12颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 12) {
								damageU += 1;
								GDB.blueMoney -= 12;
							}
						}
					}
					if (damageU == 3) {
						GUI.Label (new Rect (180, 130, 300, 100), "（4/20级）将微笑武器的伤害提高1点。改进16颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 16) {
								damageU += 1;
								GDB.blueMoney -= 16;
							}
						}
					}
					if (damageU == 4) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级5/20）将微笑武器的伤害提高1.升级19颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 19) {
								damageU += 1;
								GDB.blueMoney -= 19;
							}
						}
					}
					if (damageU == 5) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级6/20）将笑脸武器的伤害提高另外2.升级22蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 22) {
								damageU += 2;
								GDB.blueMoney -= 22;
							}
						}
					}
					if (damageU == 7) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级7/20）将笑脸武器的伤害提高另一个2.升级24蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 24) {
								damageU += 2;
								GDB.blueMoney -= 24;
							}
						}
					}
					if (damageU == 9) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级8/20）增加另外2个微笑武器造成的伤害。改善蓝宝石的成本26", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 26) {
								damageU += 2;
								GDB.blueMoney -= 26;
							}
						}
					}
					if (damageU == 11) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级9/20）将笑脸武器的伤害提高另一个2.改善蓝宝石的成本29", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 29) {
								damageU += 2;
								GDB.blueMoney -= 29;
							}
						}
					}
					if (damageU == 13) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级10/20）将增加另外2个微笑武器的伤害。改善33蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 33) {
								damageU += 2;
								GDB.blueMoney -= 33;
							}
						}
					}
					if (damageU == 15) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级11/20）将增加微笑武器造成的伤害3.增加38颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 38) {
								damageU += 3;
								GDB.blueMoney -= 38;
							}
						}
					}
					if (damageU == 18) {
						GUI.Label (new Rect (180, 130, 300, 100), "（12/20级）将笑脸武器的伤害提高3点。改善43蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 43) {
								damageU += 3;
								GDB.blueMoney -= 43;
							}
						}
					}
					if (damageU == 21) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级13/20）将增加另外3个微笑武器的伤害。改善47个蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 47) {
								damageU += 3;
								GDB.blueMoney -= 47;
							}
						}
					}
					if (damageU == 24) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级14/20）将微笑武器的伤害提高另一个4.升级53蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 53) {
								damageU += 4;
								GDB.blueMoney -= 53;
							}
						}
					}
					if (damageU == 28) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级15/20）将微笑武器的伤害提高另外4.增加58颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 58) {
								damageU += 4;
								GDB.blueMoney -= 58;
							}
						}
					}
					if (damageU == 32) {
						GUI.Label (new Rect (180, 130, 300, 100), "（16/20等级）将微笑武器的伤害提高另一个4.成本改善62蓝宝石", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 62) {
								damageU += 4;
								GDB.blueMoney -= 62;
							}
						}
					}
					if (damageU == 36) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级17/20）将增加另外5个微笑武器的伤害。改进68个蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 68) {
								damageU += 5;
								GDB.blueMoney -= 68;
							}
						}
					}
					if (damageU == 41) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级18/20）将增加另外5个笑脸武器的伤害。改善73蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 73) {
								damageU += 5;
								GDB.blueMoney -= 73;
							}
						}
					}
					if (damageU == 46) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级19/20）将笑脸武器的伤害提高5点。改善77颗蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 77) {
								damageU += 5;
								GDB.blueMoney -= 77;
							}
						}
					}
					if (damageU == 51) {
						GUI.Label (new Rect (180, 130, 300, 100), "（等级20/20）将增加另外5个微笑武器的伤害。改善82蓝宝石的成本", GUI.skin.label);
						if (GUI.Button (new Rect (50, 130, 100, 50), "+ 伤害")) {
							if (GDB.blueMoney >= 82) {
								damageU += 5;
								GDB.blueMoney -= 82;
							}
						}
					}
					if (damageU == 56) {
				GUI.Label (new Rect (180, 130, 300, 100), "达到了最高级别的改进伤害", GUI.skin.label);
					}
				}
		/// upgread health rus
	
		if (MenuScript.lang == 1) {

			GUI.Label (new Rect (550, 200, 100, 50), "СЕЙЧАС + " + healthU.ToString (), GUI.skin.label);

			if (healthU == 0) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 1/20) Увеличит здоровье смайла на 5. Стоимость улучшения 2 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 2) {
						healthU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (healthU == 5) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 2/20) Увеличит здоровье смайла еще на 5. Стоимость улучшения 5 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 5) {
						healthU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (healthU == 10) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 3/20) Увеличит здоровье смайла еще на 5. Стоимость улучшения 7 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 7) {
						healthU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (healthU == 15) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 4/20) Увеличит здоровье смайла еще на 5. Стоимость улучшения 9 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 9) {
						healthU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (healthU == 20) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 5/20) Увеличит здоровье смайла еще на 5. Стоимость улучшения 11 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 11) {
						healthU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (healthU == 25) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 6/20) Увеличит здоровье смайла еще на 10. Стоимость улучшения 13 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 13) {
						healthU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (healthU == 35) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 7/20) Увеличит здоровье смайла еще на 10. Стоимость улучшения 15 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 15) {
						healthU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (healthU == 45) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 8/20) Увеличит здоровье смайла еще на 10. Стоимость улучшения 17 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 17) {
						healthU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (healthU == 55) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 9/20) Увеличит здоровье смайла еще на 10. Стоимость улучшения 19 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 19) {
						healthU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (healthU == 65) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 10/20) Увеличит здоровье смайла еще на 15. Стоимость улучшения 21 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 21) {
						healthU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (healthU == 80) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 11/20) Увеличит здоровье смайла еще на 15. Стоимость улучшения 23 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 23) {
						healthU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (healthU == 95) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 12/20) Увеличит здоровье смайла еще на 15. Стоимость улучшения 25 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 25) {
						healthU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (healthU == 110) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 13/20) Увеличит здоровье смайла еще на 15. Стоимость улучшения 26 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 26) {
						healthU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (healthU == 125) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 14/20) Увеличит здоровье смайла еще на 15. Стоимость улучшения 27 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 27) {
						healthU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (healthU == 140) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 15/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 28 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 28) {
						healthU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (healthU == 160) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 16/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 29 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 29) {
						healthU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (healthU == 180) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 17/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 31 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 31) {
						healthU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (healthU == 200) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 18/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 32 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 32) {
						healthU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (healthU == 220) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 19/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 33 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 33) {
						healthU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (healthU == 240) {
				GUI.Label (new Rect (180, 190, 300, 100), "(уровень 20/20) Увеличит здоровье смайла еще на 20. Стоимость улучшения 34 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ ЗДОРОВЬЕ")) {
					if (GDB.blueMoney >= 34) {
						healthU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (healthU == 260) {
				GUI.Label (new Rect (180, 190, 300, 100), "Достигнут максимально возможный уровень улучшения ЗДОРОВЬЯ", GUI.skin.label);
			}
		}
			///upgrade health eng

		if (MenuScript.lang == 2) {

			GUI.Label (new Rect (550, 200, 100, 50), "NOW + " + healthU.ToString (), GUI.skin.label);

			if (healthU == 0) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 1/20) Will increase the health of a smile by 5. Cost of improving 2 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 2) {
						healthU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (healthU == 5) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 2/20) Will increase the health of the smile by another 5. Cost of improving 5 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 5) {
						healthU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (healthU == 10) {
				GUI.Label (new Rect (180, 190, 300, 100), "(Level 3/20) Will increase the health of the smile by another 5. Cost of improving 7 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 7) {
						healthU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (healthU == 15) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 4/20) Increases the health of a smile by another 5. Cost of improving 9 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 9) {
						healthU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (healthU == 20) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 5/20) Will increase the health of the smile by another 5. Cost of improving 11 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 11) {
						healthU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (healthU == 25) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 6/20) Increases the health of a smile by another 10. Cost of improving 13 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 13) {
						healthU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (healthU == 35) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 7/20) Increases the health of a smile by another 10. Cost improvement 15 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 15) {
						healthU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (healthU == 45) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 8/20) Increases the health of a smile by another 10. Cost of improving 17 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 17) {
						healthU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (healthU == 55) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 9/20) Increases the health of a smile by another 10. Cost of improving 19 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 19) {
						healthU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (healthU == 65) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 10/20) Will increase the health of the smile by another 15. Cost of improving 21 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 21) {
						healthU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (healthU == 80) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 11/20) Will increase the health of the smile by another 15. The cost of improving 23 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 23) {
						healthU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (healthU == 95) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 12/20) Will increase the health of the smile by another 15. The cost of improving 25 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 25) {
						healthU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (healthU == 110) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 13/20) Will increase the health of a smile by another 15. The cost of improving 26 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 26) {
						healthU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (healthU == 125) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 14/20) Will increase the health of the smile by another 15. Cost of improving 27 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 27) {
						healthU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (healthU == 140) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 15/20) Will increase the health of the smile by another 20. Cost improvement 28 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 28) {
						healthU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (healthU == 160) {
				GUI.Label (new Rect (180, 190, 300, 100), "(16/20 Level) Will increase the health of the smile by another 20. The cost of improving 29 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 29) {
						healthU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (healthU == 180) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 17/20) Will increase the health of a smile by another 20. Cost of improving 31 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 31) {
						healthU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (healthU == 200) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 18/20) Will increase the health of the smile by another 20. Cost of improving 32 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 32) {
						healthU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (healthU == 220) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 19/20) Will increase the health of a smile by another 20. Cost of improving 33 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 33) {
						healthU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (healthU == 240) {
				GUI.Label (new Rect (180, 190, 300, 100), "(level 20/20) Will increase the health of a smile by another 20. Cost of improving 34 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ HEALTH")) {
					if (GDB.blueMoney >= 34) {
						healthU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (healthU == 260) {
				GUI.Label (new Rect (180, 190, 300, 100), "The highest possible level of HEALTH improvement achieved", GUI.skin.label);
			}
		}
		///upgrade health chi
		 
		if (MenuScript.lang == 3) {

			GUI.Label (new Rect (550, 200, 100, 50), "现在 + " + healthU.ToString (), GUI.skin.label);

			if (healthU == 0) {
				GUI.Label (new Rect (180, 190, 300, 100), "（1/20级）将微笑的健康提高5点。改善2蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 2) {
						healthU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (healthU == 5) {
				GUI.Label (new Rect (180, 190, 300, 100), "（2/20级）将另外5个增加微笑的健康。改善5个蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 5) {
						healthU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (healthU == 10) {
				GUI.Label (new Rect (180, 190, 300, 100), "（3/20级）将增加另一个微笑的健康5.改善7蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 7) {
						healthU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (healthU == 15) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级4/20）增加另一个人的微笑健康5.提高9颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 9) {
						healthU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (healthU == 20) {
				GUI.Label (new Rect (180, 190, 300, 100), "（5/20级）将增加另一个微笑的健康状况5.提高11颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 11) {
						healthU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (healthU == 25) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级6/20）增加另一个人的微笑健康。改善13颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 13) {
						healthU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (healthU == 35) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级7/20）增加另一个人的微笑健康10.成本提高15蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 15) {
						healthU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (healthU == 45) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级8/20）增加另一个人的微笑健康。改善17颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 17) {
						healthU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (healthU == 55) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级9/20）增加另一个人的微笑健康。改善19颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 19) {
						healthU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (healthU == 65) {
				GUI.Label (new Rect (180, 190, 300, 100), "（10/20级）将另外增加15点微笑的健康。改善21蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 21) {
						healthU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (healthU == 80) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级11/20）将增加另外15个微笑的健康状况。改善23蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 23) {
						healthU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (healthU == 95) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级12/20）将另外15点增加微笑的健康。改善25颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 25) {
						healthU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (healthU == 110) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级13/20）将另外15点增加微笑的健康。改善26颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 26) {
						healthU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (healthU == 125) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级14/20）将另外的笑容增加15的健康。改善27蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 27) {
						healthU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (healthU == 140) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级15/20）将另外增加20点微笑的健康。成本提高28蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 28) {
						healthU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (healthU == 160) {
				GUI.Label (new Rect (180, 190, 300, 100), "（16/20级）将另外20个增加微笑的健康。改善29个蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 29) {
						healthU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (healthU == 180) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级17/20）将增加另一个微笑的健康。改善31蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 31) {
						healthU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (healthU == 200) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级18/20）将另外20点增加微笑的健康。改善32蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 32) {
						healthU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (healthU == 220) {
				GUI.Label (new Rect (180, 190, 300, 100), "（等级19/20）将增加另一个微笑的健康。改善33蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 33) {
						healthU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (healthU == 240) {
				GUI.Label (new Rect (180, 190, 300, 100), "（20/20级）将增加另一个微笑的健康。改善34蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 190, 100, 50), "+ 健康")) {
					if (GDB.blueMoney >= 34) {
						healthU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (healthU == 260) {
				GUI.Label (new Rect (180, 190, 300, 100), "实现了最高水平的健康改善", GUI.skin.label);
			}
		}

		/// upgrade speed rus

		if (MenuScript.lang == 1) {

			GUI.Label (new Rect (550, 260, 100, 50), "СЕЙЧАС + " + speedU.ToString (), GUI.skin.label);

			if (speedU == 0) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 1/20) Увеличит скорость смайла на 3 пункта. Стоимость улучшения 1 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 1) {
						speedU += 3;
						GDB.blueMoney -= 1;
					}
				}
			}
			if (speedU == 3) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 2/20) Увеличит скорость смайла на 3 пункта. Стоимость улучшения 2 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 2) {
						speedU += 3;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (speedU == 6) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 3/20) Увеличит скорость смайла на 3 пункта. Стоимость улучшения 3 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 3) {
						speedU += 3;
						GDB.blueMoney -= 3;
					}
				}
			}
			if (speedU == 9) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 4/20) Увеличит скорость смайла на 3 пункта. Стоимость улучшения 4 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 4) {
						speedU += 3;
						GDB.blueMoney -= 4;
					}
				}
			}
			if (speedU == 12) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 5/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 5 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 5) {
						speedU += 6;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (speedU == 18) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 6/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 6 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 6) {
						speedU += 6;
						GDB.blueMoney -= 6;
					}
				}
			}
			if (speedU == 24) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 7/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 7 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 7) {
						speedU += 6;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (speedU == 30) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 8/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 8 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 8) {
						speedU += 6;
						GDB.blueMoney -= 8;
					}
				}
			}
			if (speedU == 36) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 9/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 9 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 9) {
						speedU += 6;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (speedU == 42) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 10/20) Увеличит скорость смайла на 6 пунктов. Стоимость улучшения 10 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 10) {
						speedU += 6;
						GDB.blueMoney -= 10;
					}
				}
			}
			if (speedU == 48) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 11/20) Увеличит скорость смайла на 9 пунктов. Стоимость улучшения 11 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 11) {
						speedU += 9;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (speedU == 57) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 12/20) Увеличит скорость смайла на 9 пунктов. Стоимость улучшения 12 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 12) {
						speedU += 9;
						GDB.blueMoney -= 12;
					}
				}
			}
			if (speedU == 66) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 13/20) Увеличит скорость смайла на 9 пунктов. Стоимость улучшения 13 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 13) {
						speedU += 9;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (speedU == 75) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 14/20) Увеличит скорость смайла на 9 пунктов. Стоимость улучшения 14 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 14) {
						speedU += 9;
						GDB.blueMoney -= 14;
					}
				}
			}
			if (speedU == 84) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 15/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 16 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 16) {
						speedU += 12;
						GDB.blueMoney -= 16;
					}
				}
			}
			if (speedU == 96) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 16/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 18 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 18) {
						speedU += 12;
						GDB.blueMoney -= 18;
					}
				}
			}
			if (speedU == 108) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 17/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 19 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 19) {
						speedU += 12;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (speedU == 120) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 18/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 21 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 21) {
						speedU += 12;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (speedU == 132) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 19/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 23 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 23) {
						speedU += 12;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (speedU == 144) {
				GUI.Label (new Rect (180, 250, 300, 100), "(уровень 20/20) Увеличит скорость смайла на 12 пунктов. Стоимость улучшения 26 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ СКОРОСТЬ")) {
					if (GDB.blueMoney >= 26) {
						speedU += 12;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (speedU == 156) {
				GUI.Label (new Rect (180, 250, 300, 100), "Достигнут максимально возможный уровень улучшения СКОРОСТИ", GUI.skin.label);
			}
		}
	
		///upgrade speed eng
		if (MenuScript.lang == 2) {

			GUI.Label (new Rect (550, 260, 100, 50), "NOW + " + speedU.ToString (), GUI.skin.label);

			if (speedU == 0) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 1/20) Increases the speed of a smile by 3 points. Cost improvement 1 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 1) {
						speedU += 3;
						GDB.blueMoney -= 1;
					}
				}
			}
			if (speedU == 3) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 2/20) Increases the speed of a smile by 3 points. The cost of improving 2 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 2) {
						speedU += 3;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (speedU == 6) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 3/20) Increases the speed of a smile by 3 points. The cost of improving 3 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 3) {
						speedU += 3;
						GDB.blueMoney -= 3;
					}
				}
			}
			if (speedU == 9) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 4/20) Increases the speed of a smile by 3 points. The cost of improving 4 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 4) {
						speedU += 3;
						GDB.blueMoney -= 4;
					}
				}
			}
			if (speedU == 12) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 5/20) Increases the speed of a smile by 6 points. Cost improvement 5 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 5) {
						speedU += 6;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (speedU == 18) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 6/20) Increases the speed of a smile by 6 points. The cost of improving 6 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 6) {
						speedU += 6;
						GDB.blueMoney -= 6;
					}
				}
			}
			if (speedU == 24) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 7/20) Increases the speed of a smile by 6 points. Cost to upgrade 7 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 7) {
						speedU += 6;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (speedU == 30) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 8/20) Increases the speed of a smile by 6 points. The cost of improving 8 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 8) {
						speedU += 6;
						GDB.blueMoney -= 8;
					}
				}
			}
			if (speedU == 36) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 9/20) Increases the speed of a smile by 6 points. The cost of improving 9 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 9) {
						speedU += 6;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (speedU == 42) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 10/20) Increases the speed of a smile by 6 points. The cost of improving 10 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 10) {
						speedU += 6;
						GDB.blueMoney -= 10;
					}
				}
			}
			if (speedU == 48) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 11/20) Increases the speed of a smile by 9 points. Cost improvement 11 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 11) {
						speedU += 9;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (speedU == 57) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 12/20) Increases the speed of a smile by 9 points. The cost of improving 12 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 12) {
						speedU += 9;
						GDB.blueMoney -= 12;
					}
				}
			}
			if (speedU == 66) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 13/20) Increases the speed of a smile by 9 points. Cost improvement 13 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 13) {
						speedU += 9;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (speedU == 75) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 14/20) Increases the speed of a smile by 9 points. Cost of upgrading 14 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 14) {
						speedU += 9;
						GDB.blueMoney -= 14;
					}
				}
			}
			if (speedU == 84) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 15/20) Increases the speed of a smile by 12 points. The cost of improving 16 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 16) {
						speedU += 12;
						GDB.blueMoney -= 16;
					}
				}
			}
			if (speedU == 96) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 16/20) Increases the speed of a smile by 12 points. The cost of improving 18 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 18) {
						speedU += 12;
						GDB.blueMoney -= 18;
					}
				}
			}
			if (speedU == 108) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 17/20) Increases the speed of a smile by 12 points. The cost of improving 19 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 19) {
						speedU += 12;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (speedU == 120) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 18/20) Increases the speed of a smile by 12 points. Cost improvement 21 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 21) {
						speedU += 12;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (speedU == 132) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 19/20) Increases the speed of a smile by 12 points. The cost of improving 23 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 23) {
						speedU += 12;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (speedU == 144) {
				GUI.Label (new Rect (180, 250, 300, 100), "(level 20/20) Increases the speed of a smile by 12 points. The cost of improving 26 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ SPEED")) {
					if (GDB.blueMoney >= 26) {
						speedU += 12;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (speedU == 156) {
				GUI.Label (new Rect (180, 250, 300, 100), "The highest possible level of SPEED improvement is achieved.", GUI.skin.label);
			}
		}
		///speed upgrade chi
		if (MenuScript.lang == 3) {

			GUI.Label (new Rect (550, 260, 100, 50), "现在 + " + speedU.ToString (), GUI.skin.label);

			if (speedU == 0) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级1/20）将笑容速度提高3点。 成本改善1蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 1) {
						speedU += 3;
						GDB.blueMoney -= 1;
					}
				}
			}
			if (speedU == 3) {
				GUI.Label (new Rect (180, 250, 300, 100), "（2/20级）微笑速度提高3点。 改善2蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 2) {
						speedU += 3;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (speedU == 6) {
				GUI.Label (new Rect (180, 250, 300, 100), "（3/20级）微笑速度提高3点。 改善3蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 3) {
						speedU += 3;
						GDB.blueMoney -= 3;
					}
				}
			}
			if (speedU == 9) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级4/20）将笑容速度提高3点。 改善4蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 4) {
						speedU += 3;
						GDB.blueMoney -= 4;
					}
				}
			}
			if (speedU == 12) {
				GUI.Label (new Rect (180, 250, 300, 100), "（5/20级）微笑速度提高6点。 成本提升5蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 5) {
						speedU += 6;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (speedU == 18) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级6/20）将笑容速度提高6点。 提高6颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 6) {
						speedU += 6;
						GDB.blueMoney -= 6;
					}
				}
			}
			if (speedU == 24) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级7/20）将笑容速度提高6点。 升级7颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 7) {
						speedU += 6;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (speedU == 30) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级8/20）将笑容速度提高6点。 提高8颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 8) {
						speedU += 6;
						GDB.blueMoney -= 8;
					}
				}
			}
			if (speedU == 36) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级9/20）微笑的速度提高6点。 提高9颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 9) {
						speedU += 6;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (speedU == 42) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级10/20）将笑容速度提高6点。 提高10颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 10) {
						speedU += 6;
						GDB.blueMoney -= 10;
					}
				}
			}
			if (speedU == 48) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级11/20）微笑的速度提高9点。 成本提升11蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 11) {
						speedU += 9;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (speedU == 57) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级12/20）微笑的速度提高9点。 提高12颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 12) {
						speedU += 9;
						GDB.blueMoney -= 12;
					}
				}
			}
			if (speedU == 66) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级13/20）微笑速度提高9点。 成本提升13蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 13) {
						speedU += 9;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (speedU == 75) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级14/20）将笑容速度提高9点。 升级14颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 14) {
						speedU += 9;
						GDB.blueMoney -= 14;
					}
				}
			}
			if (speedU == 84) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级15/20）微笑的速度提高12点。 提高16颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 16) {
						speedU += 12;
						GDB.blueMoney -= 16;
					}
				}
			}
			if (speedU == 96) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级16/20）微笑的速度提高12点。 提高18颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 18) {
						speedU += 12;
						GDB.blueMoney -= 18;
					}
				}
			}
			if (speedU == 108) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级17/20）微笑的速度提高12点。 改善19颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 19) {
						speedU += 12;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (speedU == 120) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级18/20）微笑的速度提高12点。 成本提升21蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 21) {
						speedU += 12;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (speedU == 132) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级19/20）微笑的速度提高12点。 改善23蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 23) {
						speedU += 12;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (speedU == 144) {
				GUI.Label (new Rect (180, 250, 300, 100), "（等级20/20）微笑的速度提高12点。 提高26颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 250, 100, 50), "+ 速度")) {
					if (GDB.blueMoney >= 26) {
						speedU += 12;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (speedU == 156) {
				GUI.Label (new Rect (180, 250, 300, 100), "达到了最大可能的速度提升。", GUI.skin.label);
			}
		}

		/// armor upgrade rus
		if (MenuScript.lang == 1) {
			
			GUI.Label (new Rect (550, 320, 100, 50), "СЕЙЧАС + " + armorU.ToString (), GUI.skin.label);
			
			if (armorU == 0) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 1/20) Увеличит броню смайла на 5. Стоимость улучшения 2 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 2) {
						armorU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (armorU == 5) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 2/20) Увеличит броню смайла еще на 5. Стоимость улучшения 5 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 5) {
						armorU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (armorU == 10) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 3/20) Увеличит броню смайла еще на 5. Стоимость улучшения 7 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 7) {
						armorU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (armorU == 15) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 4/20) Увеличит броню смайла еще на 5. Стоимость улучшения 9 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 9) {
						armorU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (armorU == 20) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 5/20) Увеличит броню смайла еще на 5. Стоимость улучшения 11 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 11) {
						armorU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (armorU == 25) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 6/20) Увеличит броню смайла еще на 10. Стоимость улучшения 13 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 13) {
						armorU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (armorU == 35) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 7/20) Увеличит броню смайла еще на 10. Стоимость улучшения 15 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 15) {
						armorU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (armorU == 45) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 8/20) Увеличит броню смайла еще на 10. Стоимость улучшения 17 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 17) {
						armorU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (armorU == 55) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 9/20) Увеличит броню смайла еще на 10. Стоимость улучшения 19 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 19) {
						armorU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (armorU == 65) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 10/20) Увеличит броню смайла еще на 15. Стоимость улучшения 21 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 21) {
						armorU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (armorU == 80) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 11/20) Увеличит броню смайла еще на 15. Стоимость улучшения 23 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 23) {
						armorU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (armorU == 95) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 12/20) Увеличит броню смайла еще на 15. Стоимость улучшения 25 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 25) {
						armorU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (armorU == 110) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 13/20) Увеличит броню смайла еще на 15. Стоимость улучшения 26 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 26) {
						armorU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (armorU == 125) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 14/20) Увеличит броню смайла еще на 15. Стоимость улучшения 27 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 27) {
						armorU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (armorU == 140) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 15/20) Увеличит броню смайла еще на 20. Стоимость улучшения 28 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 28) {
						armorU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (armorU == 160) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 16/20) Увеличит броню смайла еще на 20. Стоимость улучшения 29 сапфиров", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 29) {
						armorU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (armorU == 180) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 17/20) Увеличит броню смайла еще на 20. Стоимость улучшения 31 сапфир", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 31) {
						armorU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (armorU == 200) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 18/20) Увеличит броню смайла еще на 20. Стоимость улучшения 32 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 32) {
						armorU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (armorU == 220) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 19/20) Увеличит броню смайла еще на 20. Стоимость улучшения 33 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 33) {
						armorU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (armorU == 240) {
				GUI.Label (new Rect (180, 310, 300, 100), "(уровень 20/20) Увеличит броню смайла еще на 20. Стоимость улучшения 34 сапфира", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ БРОНЯ")) {
					if (GDB.blueMoney >= 34) {
						armorU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (armorU == 260) {
				GUI.Label (new Rect (180, 310, 300, 100), "Достигнут максимально возможный уровень улучшения БРОНИ", GUI.skin.label);
			}
		}

		/// armor upgrade eng

		if (MenuScript.lang == 2) {
			
			GUI.Label (new Rect (550, 320, 100, 50), "NOW + " + armorU.ToString (), GUI.skin.label);
			
			if (armorU == 0) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 1/20) Increases the smile's armor by 5. Cost of upgrading 2 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 2) {
						armorU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (armorU == 5) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 2/20) Increases Smile's armor by another 5. Cost of upgrading 5 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 5) {
						armorU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (armorU == 10) {
				GUI.Label (new Rect (180, 310, 300, 100), "(Level 3/20) Increases Smile's armor by another 5. Cost of upgrading 7 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 7) {
						armorU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (armorU == 15) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 4/20) Increases Smile's armor by another 5. Cost to upgrade 9 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 9) {
						armorU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (armorU == 20) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 5/20) Increases Smile's armor by another 5. Cost of upgrading 11 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 11) {
						armorU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (armorU == 25) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 6/20) Increases Smile's armor by another 10. Cost to upgrade 13 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 13) {
						armorU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (armorU == 35) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 7/20) Increases Smile's armor by another 10. Cost to upgrade 15 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 15) {
						armorU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (armorU == 45) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 8/20) Increases Smile's armor by another 10. Cost to upgrade 17 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 17) {
						armorU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (armorU == 55) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 9/20) Increases Smile's armor by another 10. Cost to upgrade 19 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 19) {
						armorU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (armorU == 65) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 10/20) Increases Smiley's armor by another 15. Improvement Cost 21 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 21) {
						armorU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (armorU == 80) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 11/20) Increases Smiley's armor by another 15. Cost of upgrading 23 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 23) {
						armorU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (armorU == 95) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 12/20) Increases the smiley's armor by another 15. The cost of improving 25 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 25) {
						armorU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (armorU == 110) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 13/20) Increases the smiley's armor by another 15. The cost of upgrading 26 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 26) {
						armorU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (armorU == 125) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 14/20) Increases Smile's armor by another 15. Cost to upgrade 27 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 27) {
						armorU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (armorU == 140) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 15/20) Increases Smile's armor by another 20. Cost to upgrade 28 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 28) {
						armorU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (armorU == 160) {
				GUI.Label (new Rect (180, 310, 300, 100), "(16/20 Level) Increases Smile's armor by another 20. Cost to upgrade 29 sapphires", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 29) {
						armorU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (armorU == 180) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 17/20) Increases Smile's armor by another 20. Cost to upgrade 31 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 31) {
						armorU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (armorU == 200) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 18/20) Increases Smile's armor by another 20. Cost to upgrade 32 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 32) {
						armorU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (armorU == 220) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 19/20) Increases the smiley's armor by another 20. Cost to upgrade 33 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 33) {
						armorU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (armorU == 240) {
				GUI.Label (new Rect (180, 310, 300, 100), "(level 20/20) Increases Smile's armor by another 20. Cost to upgrade 34 sapphire", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ ARMOR")) {
					if (GDB.blueMoney >= 34) {
						armorU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (armorU == 260) {
				GUI.Label (new Rect (180, 310, 300, 100), "Reached the highest possible level of improvement ARMOR.", GUI.skin.label);
			}
		}

		///upgrade armor chi
		if (MenuScript.lang == 3) {
			
			GUI.Label (new Rect (550, 320, 100, 50), "现在 + " + armorU.ToString (), GUI.skin.label);
			
			if (armorU == 0) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级1/20）使笑容的护甲值提高5点。升级2颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 2) {
						armorU += 5;
						GDB.blueMoney -= 2;
					}
				}
			}
			if (armorU == 5) {
				GUI.Label (new Rect (180, 310, 300, 100), "（2/20级）微笑的护甲增加5点。升级5颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 5) {
						armorU += 5;
						GDB.blueMoney -= 5;
					}
				}
			}
			if (armorU == 10) {
				GUI.Label (new Rect (180, 310, 300, 100), "（3/20级）使笑的护甲增加5点。升级7颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 7) {
						armorU += 5;
						GDB.blueMoney -= 7;
					}
				}
			}
			if (armorU == 15) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级4/20）微笑的护甲增加5点。升级9颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 9) {
						armorU += 5;
						GDB.blueMoney -= 9;
					}
				}
			}
			if (armorU == 20) {
				GUI.Label (new Rect (180, 310, 300, 100), "（5/20级）微笑的护甲增加5点。升级11颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 11) {
						armorU += 5;
						GDB.blueMoney -= 11;
					}
				}
			}
			if (armorU == 25) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级6/20）微笑的护甲增加10点。升级13颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 13) {
						armorU += 10;
						GDB.blueMoney -= 13;
					}
				}
			}
			if (armorU == 35) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级7/20）微笑的护甲增加10点。升级15颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 15) {
						armorU += 10;
						GDB.blueMoney -= 15;
					}
				}
			}
			if (armorU == 45) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级8/20）微笑的护甲增加10点。升级17颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 17) {
						armorU += 10;
						GDB.blueMoney -= 17;
					}
				}
			}
			if (armorU == 55) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级9/20）微笑的护甲增加10点。升级19颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 19) {
						armorU += 10;
						GDB.blueMoney -= 19;
					}
				}
			}
			if (armorU == 65) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级10/20）笑脸的护甲增加另外15点。改善成本21蓝宝石", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 21) {
						armorU += 15;
						GDB.blueMoney -= 21;
					}
				}
			}
			if (armorU == 80) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级11/20）将笑脸的护甲提高15点。升级23蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 23) {
						armorU += 15;
						GDB.blueMoney -= 23;
					}
				}
			}
			if (armorU == 95) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级12/20）将笑脸的护甲提高15点。提高25颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 25) {
						armorU += 15;
						GDB.blueMoney -= 25;
					}
				}
			}
			if (armorU == 110) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级13/20）将笑脸的护甲提高15点。升级26颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 26) {
						armorU += 15;
						GDB.blueMoney -= 26;
					}
				}
			}
			if (armorU == 125) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级14/20）微笑护甲增加15点。升级27颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 27) {
						armorU += 15;
						GDB.blueMoney -= 27;
					}
				}
			}
			if (armorU == 140) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级15/20）微笑护甲再增加20点。升级28颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 28) {
						armorU += 20;
						GDB.blueMoney -= 28;
					}
				}
			}
			if (armorU == 160) {
				GUI.Label (new Rect (180, 310, 300, 100), "（16/20等级）微笑护甲再增加20点。升级29颗蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 29) {
						armorU += 20;
						GDB.blueMoney -= 29;
					}
				}
			}
			if (armorU == 180) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级17/20）微笑的护甲增加20点。升级31蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 31) {
						armorU += 20;
						GDB.blueMoney -= 31;
					}
				}
			}
			if (armorU == 200) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级18/20）微笑的护甲增加20点。升级32蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 32) {
						armorU += 20;
						GDB.blueMoney -= 32;
					}
				}
			}
			if (armorU == 220) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级19/20）将笑脸的护甲提高20点。升级33蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 33) {
						armorU += 20;
						GDB.blueMoney -= 33;
					}
				}
			}
			if (armorU == 240) {
				GUI.Label (new Rect (180, 310, 300, 100), "（等级20/20）微笑的护甲增加另外20点。升级34蓝宝石的成本", GUI.skin.label);
				if (GUI.Button (new Rect (50, 310, 100, 50), "+ 抵达")) {
					if (GDB.blueMoney >= 34) {
						armorU += 20;
						GDB.blueMoney -= 34;
					}
				}
			}
			if (armorU == 260) {
				GUI.Label (new Rect (180, 310, 300, 100), "达到了最高水平的改善。", GUI.skin.label);
			}
		}




	}
	}
