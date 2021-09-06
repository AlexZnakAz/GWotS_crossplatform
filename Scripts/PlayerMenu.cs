using UnityEngine;
using System.Collections;
public class PlayerMenu : MonoBehaviour {

	public Vector2 scrollPosition = Vector2.zero;

	public static int unlock_id_2 = 0;
	public static int unlock_id_3 = 0;
	public static int unlock_id_4 = 0;
	public static int unlock_id_5 = 0;
	public static int unlock_id_6 = 0;
	public static int unlock_id_7 = 0;
	public static int unlock_id_8 = 0;
	public static int unlock_id_9 = 0;
	public static int unlock_id_10 = 0;
	public static int unlock_id_11 = 0;
	public static int unlock_id_12 = 0;
	public static int unlock_id_13 = 0;
	public static int unlock_id_14 = 0;
	public static int unlock_id_15 = 0;
	public static int unlock_id_16 = 0;
	public static int unlock_id_17 = 0;
	public static int unlock_id_18 = 0;
	public static int unlock_id_19 = 0;
	public static int unlock_id_20 = 0;
	public static int unlock_id_21 = 0;
	public static int unlock_id_22 = 0;
	public static int unlock_id_23 = 0;
	public static int unlock_id_24 = 0;
	public static int unlock_id_25 = 0;
	public static int unlock_id_26 = 0;
	public static int unlock_id_27 = 0;
	public static int unlock_id_28 = 0;
	public static int unlock_id_29 = 0;
	public static int unlock_id_30 = 0;
	public static int unlock_id_31 = 0;
	public static int unlock_id_32 = 0;
	public static int unlock_id_33 = 0;
	public static int unlock_id_34 = 0;
	public static int unlock_id_35 = 0;
	public static int unlock_id_36 = 0;
	public static int unlock_id_37 = 0;
	public static int unlock_id_38 = 0;
	public static int unlock_id_39 = 0;
	public static int unlock_id_40 = 0;
	public static int unlock_id_41 = 0;
	public static int unlock_id_42 = 0;
	public static int unlock_id_43 = 0;
	public static int unlock_id_44 = 0;
	public static int unlock_id_45 = 0;
	public static int unlock_id_46 = 0;
	public static int unlock_id_47 = 0;
	public static int unlock_id_48 = 0;
	public static int unlock_id_49 = 0;
	public static int unlock_id_50 = 0;
	public static int unlock_id_51 = 0;
	public static int unlock_id_52 = 0;
	public static int unlock_id_53 = 0;
	public static int unlock_id_54 = 0;
	public static int unlock_id_55 = 0;
	public static int unlock_id_56 = 0;
	public static int unlock_id_57 = 0;
	public static int unlock_id_58 = 0;
	public static int unlock_id_59 = 0;
	public static int unlock_id_60 = 0;
	public static int unlock_id_61 = 0;
	public static int unlock_id_62 = 0;
	public static int unlock_id_63 = 0;

	public Texture2D est;
	public Texture2D score;
	public Texture2D coins;
	public Texture2D ruby;

	public Texture2D emerald;
	public Texture2D saphire;

	public static int id;

	public Texture2D back;

	public Texture2D id1;
	public Texture2D idw1;
	public Texture2D idw1_2;
	public Texture2D id2;
	public Texture2D idw2;
	public Texture2D idw2_1;
	public Texture2D id3;
	public Texture2D idw3;
	public Texture2D idw3_1;
	public Texture2D id4;
	public Texture2D idw4;
	public Texture2D idw4_1;
	public Texture2D id5;
	public Texture2D idw5;
	public Texture2D idw5_1;
	public Texture2D id6;
	public Texture2D idw6;
	public Texture2D idw6_1;
	public Texture2D id7;
	public Texture2D idw7;
	public Texture2D idw7_1;
	public Texture2D id8;
	public Texture2D idw8;
	public Texture2D idw8_1;
	public Texture2D id9;
	public Texture2D idw9;
	public Texture2D idw9_1;
	public Texture2D id10;
	public Texture2D id11;
	public Texture2D idw11;
	public Texture2D idw11_1;
	public Texture2D id12;
	public Texture2D idw12;
	public Texture2D idw12_1;
	public Texture2D id13;
	public Texture2D id14;
	public Texture2D idw14;
	public Texture2D idw14_1;
	public Texture2D id15;
	public Texture2D idw15;
	public Texture2D id16;
	public Texture2D idw16;
	public Texture2D idw16_1;
	public Texture2D id17;
	public Texture2D idw17;
	public Texture2D idw17_1;
	public Texture2D id18;
	public Texture2D idw18;
	public Texture2D idw18_1;
	public Texture2D id19;
	public Texture2D idw19;
	public Texture2D idw19_1;
	public Texture2D id20;
	public Texture2D idw20;
	public Texture2D idw20_1;
	public Texture2D id21;
	public Texture2D idw21;
	public Texture2D idw21_1;
	public Texture2D id22;
	public Texture2D idw22;
	public Texture2D idw22_1;
	public Texture2D id23;
	public Texture2D id24;
	public Texture2D idw24;
	public Texture2D id25;
	public Texture2D idw25;
	public Texture2D idw25_5;
	public Texture2D id26;
	public Texture2D id27;
	public Texture2D id28;
	public Texture2D id29;
	public Texture2D id30;
	public Texture2D idw30;
	public Texture2D id31;
	public Texture2D idw31;
	public Texture2D id32;
	public Texture2D idw32;
	public Texture2D id33;
	public Texture2D idw33;
	public Texture2D id34;
	public Texture2D idw34;
	public Texture2D id35;
	public Texture2D idw35;
	public Texture2D id36;
	public Texture2D idw36;
	public Texture2D id37;
	public Texture2D idw37;
	public Texture2D id38;
	public Texture2D idw38;

	public GUISkin otherGUI;

	public string pass = "*********";



	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 




	void Start()
	{
		scale.x = Screen.width/originalWidth;  
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 
	} 
	

		




	
	// Update is called once per frame
	void Update () {

		if (pass == "v0iceless") {
			GDB.globalScore += 110;
			GDB.coins += 80;
			GDB.redMoney += 3;
			GDB.greenMoney +=3;
			GDB.blueMoney +=3;
		}
		if (pass == "darkss0ul") {
			GDB.levXp += 1;
			GDB.activity += 50;
		}
		if (pass == "perfect0s") {
			GDB.unlockLeavel = 100;
		}
	
	}

	void OnGUI () {

		GUI.skin = otherGUI;



		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), back);

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);


	


		///CODES =)

		pass = GUI.PasswordField (new Rect (570, 10, 55, 20), pass, "*" [0], 10);

		///shop

		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (650, 5, 100, 40), "МАГАЗИН")) {
				Application.LoadLevel ("Shop");
			}
		}
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (650, 5, 100, 40), "SHOP")) {
				Application.LoadLevel ("Shop");
			}
		}
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (650, 5, 100, 40), "这家商店")) {
				Application.LoadLevel ("Shop");
			}
		}

		///codes

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
		if (MenuScript.lang == 1)
		{GUI.Label (new Rect (470, 10, 100, 20), "УРОВЕНЬ " + GDB.levXp.ToString (), GUI.skin.label);}
		if (MenuScript.lang == 2)
		{GUI.Label (new Rect (470, 10, 100, 20), "LEVEL " + GDB.levXp.ToString (), GUI.skin.label);}
		if (MenuScript.lang == 3)
		{GUI.Label (new Rect (470, 10, 100, 20), "水平 " + GDB.levXp.ToString (), GUI.skin.label);}


	
		scrollPosition = GUI.BeginScrollView(new Rect(5, 60, 780, Screen.height - 60), scrollPosition, new Rect(0, 0, 500, 15000));

		/// Лошарик
		GUI.DrawTexture (new Rect (450, 80, 100, 100), id1);
		GUI.DrawTexture (new Rect (560, 100, 70, 70), idw1);
		if (MenuScript.lang == 1)
		{GUI.Label (new Rect (140, 80, 300, 100), "Обычный смайлик, необладающий никакими способностями. Медленный и неуклюжий. Данная модификация бесплатна. Вооружен одним пистолетом (низкая скорость стрельбы, наносит 1 единицу урона за выстрел). Имеет 20 жизней. Cтартовый персонаж.", GUI.skin.label);
		if (GUI.Button (new Rect (30, 80, 100, 100), "ЛОШАРИК")) {
			id = 1;
				Application.LoadLevel ("LevelMenu");}}
		if (MenuScript.lang == 2)
		{GUI.Label (new Rect (140, 80, 300, 100), "Normal smiley, palladiumii any abilities. Slow and clumsy. This modification is free. Armed with one gun (low rate of fire, and inflicts 1 unit of damage per shot). Has 20 lives. Starting character.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 80, 100, 100), "STUPID")) {
				id = 1;
				Application.LoadLevel ("LevelMenu");}}
		if (MenuScript.lang == 3)
		{GUI.Label (new Rect (140, 80, 300, 100), "一个正常的笑脸，不具有任何权力。 缓慢而笨拙。 这种修改是免费的。 武装的一个枪(低利率的火灾，并造成1单元的损坏每一枪). 有20人的生命。 起始字符。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 80, 100, 100), "傻瓜")) {
				id = 1;
				Application.LoadLevel ("LevelMenu");}}
		GUI.DrawTexture (new Rect (140, 190, 100, 20), est);

		///RUS
		if (MenuScript.lang == 1) {

			/// Лошарик 2
			if (unlock_id_2 == 0) {
				if (GUI.Button (new Rect (30, 330, 100, 20), "купить")) {
					if (GDB.coins >= 30) {
						if (GDB.globalScore >= 20) { 
			
							GDB.coins -= 30;
							GDB.globalScore -= 20;
							unlock_id_2 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
						}
					}
				}
			}
			GUI.DrawTexture (new Rect (450, 220, 70, 70), idw1_2);
			GUI.DrawTexture (new Rect (535, 210, 100, 100), id1);
			GUI.DrawTexture (new Rect (640, 220, 70, 70), idw1);
			GUI.Label (new Rect (140, 220, 300, 100), "Тот же лошарик, однако вооружен уже двумя пистолетами, которые стреляют в разных направлениях. Характеристика оружия идентична обычному лошарику. Этот персонаж можно приобрести за 20 убитых врагов в общем счете и дополнительно за 30 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 220, 100, 100), "ЛОШАРИК(2)")) {
				if (unlock_id_2 == 1) {
					id = 2;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_2 == 1) {
				GUI.DrawTexture (new Rect (140, 330, 100, 20), est);
			}

			/// Волшебка

			if (unlock_id_3 == 0) {
				if (GUI.Button (new Rect (30, 470, 100, 20), "купить")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {

									GDB.coins -= 70;
									GDB.globalScore -= 60;
									GDB.redMoney -= 2;
									unlock_id_3 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (450, 360, 100, 100), id2);
			GUI.DrawTexture (new Rect (560, 360, 30, 100), idw2);
			GUI.Label (new Rect (140, 360, 300, 100), "Смайл-Волшебница (40 жизней). Огромные выстрелы наносят 6 единицы урона и распадаются при первом касании. Скорострельность средняя. Скорость ниже среднего. Стоимость: 60 врагов, 70 монет и 2 рубинов и 1 уровень. Для открытых уровней.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 360, 100, 100), "ВОЛШЕБКА")) {
				if (unlock_id_3 == 1) {
					id = 3;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_3 == 1) {
				GUI.DrawTexture (new Rect (140, 470, 100, 20), est);
			}

			/// Волшебка 2

			if (unlock_id_4 == 0) {
				if (GUI.Button (new Rect (30, 610, 100, 20), "купить")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_3 == 1) {
									if (GDB.levXp >= 1) {

										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_4 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (640, 500, 30, 100), idw2);
			GUI.DrawTexture (new Rect (525, 500, 100, 100), id2);
			GUI.DrawTexture (new Rect (450, 520, 60, 60), idw2_1);
			GUI.Label (new Rect (140, 500, 300, 100), "Нужен уровень 1. В дополнение ко всем характеристикам, обладает щитом из кольца. Щит на протяжении незначительного времени предотвращает любые повреждения. Также требуется время на перезарядку. Стоимость: 40 врагов, 70 монет и 2 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 500, 100, 100), "ВОЛШЕБКА(2)")) {
				if (unlock_id_4 == 1) {
					id = 4;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_4 == 1) {
				GUI.DrawTexture (new Rect (140, 610, 100, 20), est);
			}

			/// Вампиряк

			if (unlock_id_5 == 0) {
				if (GUI.Button (new Rect (30, 750, 100, 20), "купить")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {

									GDB.coins -= 70;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_5 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 640, 30, 100), idw3);
			GUI.DrawTexture (new Rect (450, 640, 100, 100), id3);
			GUI.Label (new Rect (140, 640, 300, 100), "Смайл-вампир (20 жизней). Нужен уровень 0. Вооружен тяжелым мечом. При близком контакте с врагом наносит 3 единицы урона. Скорость атаки не высокая. Достаточно быстрый персонаж. Стоимость: 50 врагов, 70 монет и 2 рубинов. Только для ближнего боя.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 640, 100, 100), "ВАМПИРЯК")) {
				if (unlock_id_5 == 1) {
					id = 5;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_5 == 1) {
				GUI.DrawTexture (new Rect (140, 750, 100, 20), est);
			}

			/// Вампиряк 2

			if (unlock_id_6 == 0) {
				if (GUI.Button (new Rect (30, 890, 100, 20), "купить")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_5 == 1) {
									if (GDB.levXp >= 2) {

										GDB.coins -= 100;
										GDB.globalScore -= 60;
										GDB.redMoney -= 3;
										unlock_id_6 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (610, 780, 30, 100), idw3);
			GUI.DrawTexture (new Rect (500, 780, 100, 100), id3);
			GUI.DrawTexture (new Rect (450, 795, 50, 80), idw3_1);
			GUI.Label (new Rect (140, 780, 300, 100), "Нужен уровень 2. В дополнение ко всем характеристикам обладает очень сильной и чрезвычайно полезной способностью высасывать жизни. За каждого убитого врага персонаж получает дополнительно 10 жизней. Стоимость: 60 врагов, 100 монет и 3 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 780, 100, 100), "ВАМПИРЯК(2)")) {
				if (unlock_id_6 == 1) {
					id = 6;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_6 == 1) {
				GUI.DrawTexture (new Rect (140, 890, 100, 20), est);
			}

			/// Святоша

			if (unlock_id_7 == 0) {
				if (GUI.Button (new Rect (30, 1030, 100, 20), "купить")) {
					if (GDB.coins >= 60) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {

									GDB.coins -= 60;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_7 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 920, 35, 100), idw4);
			GUI.DrawTexture (new Rect (450, 920, 100, 100), id4);
			GUI.Label (new Rect (140, 920, 300, 100), "Самый добрый смайл (30 жизней). Нужен уровень 0. Не быстрый персонаж. Не часто параллельно выпускает 2 быстрые стрелы (по 2 единицы урона). Персонаж освещает местность вокруг на темных уровнях. Стоимость: 50 врагов, 60 монет и 2 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 920, 100, 100), "СВЯТОША")) {
				if (unlock_id_7 == 1) {
					id = 7;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_7 == 1) {
				GUI.DrawTexture (new Rect (140, 1030, 100, 20), est);
			}

			/// Святоша(2)
			if (unlock_id_8 == 0) {
				if (GUI.Button (new Rect (30, 1170, 100, 20), "купить")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_7 == 1) {
									if (GDB.levXp >= 3) {

										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_8 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (625, 1060, 35, 100), idw4);
			GUI.DrawTexture (new Rect (515, 1060, 100, 100), id4);
			GUI.DrawTexture (new Rect (450, 1070, 50, 80), idw4_1);
			GUI.Label (new Rect (140, 1060, 300, 100), "Нужен уровень 3. В дополнение к функциям стандартного персанажа выпускает сразу 4 параллельные стрелы. Освещает гораздо более обширную площадь. Стоимость: 40 врагов, 70 монет и 2 рубинов. Чрезвычайно полезный персонаж на уровнях со слабым освещением.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1060, 100, 100), "СВЯТОША(2)")) {
				if (unlock_id_8 == 1) {
					id = 8;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_8 == 1) {
				GUI.DrawTexture (new Rect (140, 1170, 100, 20), est);
			}

			/// Панкрат

			if (unlock_id_9 == 0) {
				if (GUI.Button (new Rect (30, 1310, 100, 20), "купить")) {
					if (GDB.coins >= 90) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 1) {

									GDB.coins -= 90;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_9 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 1230, 100, 30), idw5);
			GUI.DrawTexture (new Rect (450, 1200, 100, 100), id5);
			GUI.Label (new Rect (140, 1200, 300, 100), "Смайлик-панк (30 жизней). Нужен уровень 1. Не быстрый. Стреляет россыпью мелкой дроби (3 единица урона от каждой). Всего за выстрел выпускает 5 снарядов. Требуется достаточно длительное время на перезарядку. Стоимость: 80 врагов, 90 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1200, 100, 100), "ПАНКРАТ")) {
				if (unlock_id_9 == 1) {
					id = 9;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_9 == 1) {
				GUI.DrawTexture (new Rect (140, 1310, 100, 20), est);
			}

			/// Панкрат(2)

			if (unlock_id_10 == 0) {
				if (GUI.Button (new Rect (30, 1450, 100, 20), "купить")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_9 == 1) {
									if (GDB.levXp >= 4) {

										GDB.coins -= 120;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_10 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (610, 1370, 100, 30), idw5);
			GUI.DrawTexture (new Rect (500, 1340, 100, 100), id5);
			GUI.DrawTexture (new Rect (450, 1350, 40, 70), idw5_1);
			GUI.Label (new Rect (140, 1340, 300, 100), "Нужен уровень 4. В отличии от стандартного персонажа имеет 60 жизней. Вооружен более мощным дробовиком (выпускает 11 снарядов за выстрел). Этот персонаж относиться к категории сильных персонажей. Стоимость: 80 врагов, 120 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1340, 100, 100), "ПАНКРАТ(2)")) {
				if (unlock_id_10 == 1) {
					id = 10;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_10 == 1) {
				GUI.DrawTexture (new Rect (140, 1450, 100, 20), est);
			}

			/// Инжик

			if (unlock_id_11 == 0) {
				if (GUI.Button (new Rect (30, 1590, 100, 20), "купить")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 90) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 3) {

									GDB.coins -= 140;
									GDB.globalScore -= 90;
									GDB.redMoney -= 8;
									unlock_id_11 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 1490, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 1480, 100, 100), id6);
			GUI.Label (new Rect (140, 1480, 300, 100), "Смайл-инженер (40 жизней). Нужен уровень 3. Быстрый персонаж. Вооружен очень скорострельным узи, каждый снаряд которого наносит 1 единицу урона. Это сильный персонаж даже в стартовой комплектации. Стоимость: 90 врагов, 140 монет и 8 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1480, 100, 100), "ИНЖИК")) {
				if (unlock_id_11 == 1) {
					id = 11;
					Application.LoadLevel ("Levelmenu");
				}
			}
			if (unlock_id_11 == 1) {
				GUI.DrawTexture (new Rect (140, 1590, 100, 20), est);
			}

			/// Инжик (2)

			if (unlock_id_12 == 0) {
				if (GUI.Button (new Rect (30, 1730, 100, 20), "купить")) {
					if (GDB.coins >= 50) {
						if (GDB.globalScore >= 30) {
							if (GDB.redMoney >= 1) {
								if (unlock_id_11 == 1) {
									if (GDB.levXp >= 4) {

										GDB.coins -= 50;
										GDB.globalScore -= 30;
										GDB.redMoney -= 1;
										unlock_id_12 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (640, 1630, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 1620, 100, 100), id6);
			GUI.DrawTexture (new Rect (450, 1620, 80, 100), idw6_1);
			GUI.Label (new Rect (140, 1620, 300, 100), "Нужен уровень 4. В дополнение ко всем характеристикам стандартного персонажа имеет способность возводить твердые стены. Незаменим, когда толстого врага нужно забрикадировать, чтобы он не убежал. Стоимость: 30 врагов, 50 монет и 1 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1620, 100, 100), "ИНЖИК(2)")) {
				if (unlock_id_12 == 1) {
					id = 12;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_12 == 1) {
				GUI.DrawTexture (new Rect (140, 1730, 100, 20), est);
			}

			/// Пикряк

			if (unlock_id_13 == 0) {
				if (GUI.Button (new Rect (30, 1870, 100, 20), "купить")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (GDB.levXp >= 5) {

									GDB.coins -= 160;
									GDB.globalScore -= 100;
									GDB.redMoney -= 6;
									unlock_id_13 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (545, 1780, 85, 55), idw7);
			GUI.DrawTexture (new Rect (450, 1760, 100, 100), id7);
			GUI.Label (new Rect (140, 1760, 300, 100), "Смайлик-пират (30 жизней). Нужен уровень 5. Достаточно шустрый персонаж. Вооружен мощным кольтом, который наносит по 12 единиц урона за выстрел. Скорострельность не высокая. Стоимость: 100 врагов, 160 монет и 6 рубинов. Полезен в бою с толстокожими.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1760, 100, 100), "ПИКРЯК")) {
				if (unlock_id_13 == 1) {
					id = 13;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_13 == 1) {
				GUI.DrawTexture (new Rect (140, 1870, 100, 20), est);
			}

			/// Пикряк (2)

			if (unlock_id_14 == 0) {
				if (GUI.Button (new Rect (30, 2010, 100, 20), "купить")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_13 == 1) {
									if (GDB.levXp >= 6) {

										GDB.coins -= 100;
										GDB.globalScore -= 50;
										GDB.redMoney -= 3;
										unlock_id_14 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (625, 1920, 85, 55), idw7);
			GUI.DrawTexture (new Rect (530, 1900, 100, 100), id7);
			GUI.DrawTexture (new Rect (450, 1920, 85, 55), idw7_1);
			GUI.Label (new Rect (140, 1900, 300, 100), "Нужен уровень 6. В отличии от стандартного персонажа вооружен двумя кольтами, которые стреляют в разных направлениях (также наносят 12 единиц урона). Дополнительно имеет 60 жизней. Стоимость: 50 врагов, 100 монет и 3 рубинов. Вдвойне эффективен.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1900, 100, 100), "ПИКРЯК(2)")) {
				if (unlock_id_14 == 1) {
					id = 14;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_14 == 1) {
				GUI.DrawTexture (new Rect (140, 2010, 100, 20), est);
			}

			/// Книжлок

			if (unlock_id_15 == 0) {
				if (GUI.Button (new Rect (30, 2150, 100, 20), "купить")) {
					if (GDB.coins >= 80) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 7) {

									GDB.coins -= 80;
									GDB.globalScore -= 100;
									GDB.redMoney -= 7;
									unlock_id_15 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (540, 2040, 30, 100), idw8);
			GUI.DrawTexture (new Rect (450, 2040, 100, 100), id8);
			GUI.Label (new Rect (140, 2040, 300, 100), "Смайлик-варлок (40 жизней). Нужен уровень 7. Быстрый. Часто выпускает два больших заряда магии в противоположных направлениях, наносящих 7 единиц урона (разрушаются при касании). Стоимость: 80 врагов, 100 монет и 7 рубинов. Для открытых зон.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2040, 100, 100), "КНИЖЛОК")) {
				if (unlock_id_15 == 1) {
					id = 15;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_15 == 1) {
				GUI.DrawTexture (new Rect (140, 2150, 100, 20), est);
			}

			/// Книжлок (2)

			if (unlock_id_16 == 0) {
				if (GUI.Button (new Rect (30, 2290, 100, 20), "купить")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_15 == 1) {
									if (GDB.levXp >= 8) {

										GDB.coins -= 140;
										GDB.globalScore -= 80;
										GDB.redMoney -= 3;
										unlock_id_16 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (620, 2180, 30, 100), idw8);
			GUI.DrawTexture (new Rect (510, 2180, 100, 100), id8);
			GUI.DrawTexture (new Rect (450, 2190, 60, 80), idw8_1);
			GUI.Label (new Rect (140, 2180, 300, 100), "Нужен уровень 8. Дополнительно ко всем характеристикам имеет способность активировать щит, который предотвращает любые повреждения в течении среднего времени. Довольно быстро заряжается. Стоимость: 80 врагов, 140 монет и 3 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2180, 100, 100), "КНИЖЛОК(2)")) {
				if (unlock_id_16 == 1) {
					id = 16;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_16 == 1) {
				GUI.DrawTexture (new Rect (140, 2290, 100, 20), est);
			}

			/// Мазюк

			if (unlock_id_17 == 0) {
				if (GUI.Button (new Rect (30, 2430, 100, 20), "купить")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 5) {

									GDB.coins -= 160;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_17 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (550, 2340, 70, 70), idw9);
			GUI.DrawTexture (new Rect (450, 2320, 100, 100), id9);
			GUI.Label (new Rect (140, 2320, 300, 100), "Смайлик-художник (40 жизней). Нужен уровень 5. Со средней скоростью разливает кляксы. Если на кляксу попадает враг, то получает 20 единиц урона. Быстрый персонаж. Стоимость: 80 врагов, 160 монет и 4 рубинов. Полезен на уровнях с множеством строений.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2320, 100, 100), "МАЗЮК")) {
				if (unlock_id_17 == 1) {
					id = 17;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_17 == 1) {
				GUI.DrawTexture (new Rect (140, 2430, 100, 20), est);
			}

			/// Мазюк (2)

			if (unlock_id_18 == 0) {
				if (GUI.Button (new Rect (30, 2570, 100, 20), "купить")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_17 == 1) {
									if (GDB.levXp >= 7) {

										GDB.coins -= 120;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_18 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 2480, 70, 70), idw9);
			GUI.DrawTexture (new Rect (525, 2460, 100, 100), id9);
			GUI.DrawTexture (new Rect (450, 2470, 80, 80), idw9_1);
			GUI.Label (new Rect (140, 2460, 300, 100), "Нужен уровень 7. Имеет существенные улучшения в сравнении со стандартным персонажем. Обладает очень высокой скоростью. Имеет 80 жизней. Чаще разливает кляксы. Стоимость: 60 врагов, 120 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2460, 100, 100), "МАЗЮК(2)")) {
				if (unlock_id_18 == 1) {
					id = 18;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_18 == 1) {
				GUI.DrawTexture (new Rect (140, 2570, 100, 20), est);
			}

			/// Тамада

			if (unlock_id_19 == 0) {
				if (GUI.Button (new Rect (30, 2710, 100, 20), "купить")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 70) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 4) {

									GDB.coins -= 140;
									GDB.globalScore -= 70;
									GDB.redMoney -= 4;
									unlock_id_19 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 2620, 70, 70), idw1);
			GUI.DrawTexture (new Rect (450, 2600, 100, 100), id10);
			GUI.Label (new Rect (140, 2600, 300, 100), "Праздничный смайлик (40 жизней). Нужен уровень 4. Вооружен обычным пистолетом. Не быстрый. Имеет способность периодически создавать Лошариков, периодически бросающих камни (наносят 8 единиц урона врагам). Стоимость: 70 врагов, 140 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2600, 100, 100), "ТАМАДА")) {
				if (unlock_id_19 == 1) {
					id = 19;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_19 == 1) {
				GUI.DrawTexture (new Rect (140, 2710, 100, 20), est);
			}

			/// Тамада (2)

			if (unlock_id_20 == 0) {
				if (GUI.Button (new Rect (30, 2850, 100, 20), "купить")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_19 == 1) {
									if (GDB.levXp >= 6) {
						
										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_20 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 2760, 90, 70), idw7);
			GUI.DrawTexture (new Rect (450, 2740, 100, 100), id10);
			GUI.Label (new Rect (140, 2740, 300, 100), "Нужен уровень 6. В отличии от стандартного персонажа имеет 80 жизней. Обладает высокой скоростью. Вооружен кольтом. Чаще создает Лошариков (одновременно большее количество), которые наносят по 16 единыц урона. Стоимость: 80 врагов, 160 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2740, 100, 100), "ТАМАДА(2)")) {
				if (unlock_id_20 == 1) {
					id = 20;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_20 == 1) {
				GUI.DrawTexture (new Rect (140, 2850, 100, 20), est);
			}

			/// Зомбик

			if (unlock_id_21 == 0) {
				if (GUI.Button (new Rect (30, 2990, 100, 20), "купить")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 6) {

									GDB.coins -= 200;
									GDB.globalScore -= 140;
									GDB.redMoney -= 8;
									unlock_id_21 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 2880, 30, 100), idw11);
			GUI.DrawTexture (new Rect (450, 2880, 100, 100), id11);
			GUI.Label (new Rect (140, 2880, 300, 100), "Смайл-зомби (120 жизней). Нужен уровень 6. Медленный. Вооружен медленным мечом (12 урона в ближнем бою). Стоимость: 140 врагов, 200 монет и 8 рубинов. Практически бессмертный за счет большого количества жизней.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2880, 100, 100), "ЗОМБИК")) {
				if (unlock_id_21 == 1) {
					id = 21;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_21 == 1) {
				GUI.DrawTexture (new Rect (140, 2990, 100, 20), est);
			}

			/// Зомбик (2)

			if (unlock_id_22 == 0) {
				if (GUI.Button (new Rect (30, 3130, 100, 20), "купить")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_21 == 1) {
									if (GDB.levXp >= 9) {

										GDB.coins -= 220;
										GDB.globalScore -= 140;
										GDB.redMoney -= 8;
										unlock_id_22 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (640, 3020, 30, 100), idw11);
			GUI.DrawTexture (new Rect (530, 3020, 100, 100), id11);
			GUI.DrawTexture (new Rect (450, 3030, 70, 70), idw11_1);
			GUI.Label (new Rect (140, 3020, 300, 100), "Нужен уровень 9. Значительно отличается от стандартного персонажа. Имеет 240 жизней. Имеет способность щита, которые периодически защищает от любого урона. Освещает темные уровни. Стоимость: 140 врагов, 220 монет и 8 рубинов. Сильный персонаж.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3020, 100, 100), "ЗОМБИК(2)")) {
				if (unlock_id_22 == 1) {
					id = 22;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_22 == 1) {
				GUI.DrawTexture (new Rect (140, 3130, 100, 20), est);
			}

			/// Футуря

			if (unlock_id_23 == 0) {
				if (GUI.Button (new Rect (30, 3270, 100, 20), "купить")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 10) {

									GDB.coins -= 220;
									GDB.globalScore -= 80;
									GDB.redMoney -= 7;
									unlock_id_23 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (550, 3170, 80, 70), idw12);
			GUI.DrawTexture (new Rect (450, 3160, 100, 100), id12);
			GUI.Label (new Rect (140, 3160, 300, 100), "Смайлик из будущего (50 жизней). Нужен уровень 10. Быстрый. Вооружен лазером (очень быстрые снаряды), который наносит по 15 единиц урона. Стоимость: 80 врагов, 220 монет и 7 рубинов. Эффективен в любой ситуации и на любом уровне.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3160, 100, 100), "ФУТУРЯ")) {
				if (unlock_id_23 == 1) {
					id = 23;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_23 == 1) {
				GUI.DrawTexture (new Rect (140, 3270, 100, 20), est);
			}

			/// Футуря (2)

			if (unlock_id_24 == 0) {
				if (GUI.Button (new Rect (30, 3410, 100, 20), "купить")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_23 == 1) {
									if (GDB.levXp >= 12) {

										GDB.coins -= 180;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_24 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (640, 3310, 80, 70), idw12);
			GUI.DrawTexture (new Rect (540, 3300, 100, 100), id12);
			GUI.DrawTexture (new Rect (450, 3310, 80, 70), idw12_1);
			GUI.Label (new Rect (140, 3300, 300, 100), "Нужен уровень 12. Вдвойне эффективнее своего стандартного аналога по причине того, что обладает еще одним лазером, который стреляет в противоположном направлении. Характеристики те же. Стоимость: 60 врагов, 180 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3300, 100, 100), "ФУТУРЯ(2)")) {
				if (unlock_id_24 == 1) {
					id = 24;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_24 == 1) {
				GUI.DrawTexture (new Rect (140, 3410, 100, 20), est);
			}

			/// Ворюга

			if (unlock_id_25 == 0) {
				if (GUI.Button (new Rect (30, 3550, 100, 20), "купить")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 7) {

									GDB.coins -= 220;
									GDB.globalScore -= 100;
									GDB.redMoney -= 9;
									unlock_id_25 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_24);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 3470, 100, 40), idw5);
			GUI.DrawTexture (new Rect (450, 3440, 100, 100), id13);
			GUI.Label (new Rect (140, 3440, 300, 100), "Смай-вор (40 жизней). Нужен уровень 7. Достаточно шустрый. Вооружен слабым дробовиком. Имеет способность находить на уровне больше монет (платиновые монеты стоят пяти золотых), чем другие персонажи. Стоимость: 100 врагов, 220 монет и 9 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3440, 100, 100), "ВОРЮГА")) {
				if (unlock_id_25 == 1) {
					id = 25;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_25 == 1) {
				GUI.DrawTexture (new Rect (140, 3550, 100, 20), est);
			}

			/// Ворюга (2)

			if (unlock_id_26 == 0) {
				if (GUI.Button (new Rect (30, 3690, 100, 20), "купить")) {
					if (GDB.coins >= 240) {
						if (GDB.globalScore >= 130) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_25 == 1) {
									if (GDB.levXp >= 8) {

										GDB.coins -= 240;
										GDB.globalScore -= 130;
										GDB.redMoney -= 7;
										unlock_id_26 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 3580, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 3580, 100, 100), id13);
			GUI.Label (new Rect (140, 3580, 300, 100), "Нужен уровень 8. Отличается от стандартного персонажа тем, что вооружен очень скорострельным узи вместо обычного дробовика. Остальные характеристики остались без изменений. Стоимость: 130 врагов, 240 монет и 7 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3580, 100, 100), "ВОРЮГА(2)")) {
				if (unlock_id_26 == 1) {
					id = 26;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_26 == 1) {
				GUI.DrawTexture (new Rect (140, 3690, 100, 20), est);
			}

			/// Няшка

			if (unlock_id_27 == 0) {
				if (GUI.Button (new Rect (30, 3830, 100, 20), "купить")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 120) {
							if (GDB.redMoney >= 10) {
								if (GDB.levXp >= 11) {

									GDB.coins -= 220;
									GDB.globalScore -= 120;
									GDB.redMoney -= 10;
									unlock_id_27 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 3720, 30, 100), idw14);
			GUI.DrawTexture (new Rect (450, 3720, 100, 100), id14);
			GUI.Label (new Rect (140, 3720, 300, 100), "Смайлик-бабочка (40 жизней). Нужен уровень 11. Очень быстрая. Со средней скоростью выпускает 4 среднескоростных огромных снаряда (под углом 90 градусов) в разные стороны (наноят 9 единиц урона). Стоимость: 120 врагов, 220 монет и 10 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3720, 100, 100), "НЯШКА")) {
				if (unlock_id_27 == 1) {
					id = 27;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_27 == 1) {
				GUI.DrawTexture (new Rect (140, 3830, 100, 20), est);
			}

			/// Няшка (2)

			if (unlock_id_28 == 0) {
				if (GUI.Button (new Rect (30, 3970, 100, 20), "купить")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_27 == 1) {
									if (GDB.levXp >= 13) {

										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 6;
										unlock_id_28 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 3860, 30, 100), idw14);
			GUI.DrawTexture (new Rect (520, 3860, 100, 100), id14);
			GUI.DrawTexture (new Rect (450, 3870, 50, 80), idw14_1);
			GUI.Label (new Rect (140, 3860, 300, 100), "Нужен уровень 13. Отличается от стандартного персонажа тем, что обладает сумасшедшей скоростью. Также имеет способность щита (предотвращает любой урон). Щит долго держиться, но и заряжается тоже долго. Стоимость: 80 врагов, 160 монет и 6 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3860, 100, 100), "НЯШКА(2)")) {
				if (unlock_id_28 == 1) {
					id = 28;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_28 == 1) {
				GUI.DrawTexture (new Rect (140, 3970, 100, 20), est);
			}

			/// Бомбер

			if (unlock_id_29 == 0) {
				if (GUI.Button (new Rect (30, 4110, 100, 20), "купить")) {
					if (GDB.coins >= 150) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 10) {

									GDB.coins -= 150;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_29 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 4010, 50, 80), idw15);
			GUI.DrawTexture (new Rect (450, 4000, 100, 100), id15);
			GUI.Label (new Rect (140, 4000, 300, 100), "Смайл-бомба (40 жизней). Нужен уровень 10. Не очень быстрый. Переодически взрывается (10 единиц урона). Способность: переодически создает динамиты, которые создают серию взрывов (по 10 единиц урона). Стоимость: 80 врагов, 150 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4000, 100, 100), "БОМБЕР")) {
				if (unlock_id_29 == 1) {
					id = 29;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_29 == 1) {
				GUI.DrawTexture (new Rect (140, 4110, 100, 20), est);
			}

			/// Бомбер (2)

			if (unlock_id_30 == 0) {
				if (GUI.Button (new Rect (30, 4250, 100, 20), "купить")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_29 == 1) {
									if (GDB.levXp >= 12) {

										GDB.coins -= 180;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_30 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (640, 4150, 50, 80), idw15);
			GUI.DrawTexture (new Rect (530, 4140, 100, 100), id15);
			GUI.DrawTexture (new Rect (450, 4150, 50, 80), idw15);
			GUI.Label (new Rect (140, 4140, 300, 100), "Нужен уровень 12. Немного быстрее своего стандартного персонажа. Более чем в два раза чаще создает динамиты. Все остальные характеристики не отличаюися от стандартного варианта. Стоимость: 80 врагов, 180 монет и 4 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4140, 100, 100), "БОМБЕР(2)")) {
				if (unlock_id_30 == 1) {
					id = 30;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_30 == 1) {
				GUI.DrawTexture (new Rect (140, 4250, 100, 20), est);
			}

			/// Терминат

			if (unlock_id_31 == 0) {
				if (GUI.Button (new Rect (30, 4390, 100, 20), "купить")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 14) {

									GDB.coins -= 400;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_31 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 4300, 100, 70), idw16);
			GUI.DrawTexture (new Rect (450, 4280, 100, 100), id16);
			GUI.Label (new Rect (140, 4280, 300, 100), "Настоящий терминатор (80 жизней). Нужен уровень 14. Не быстрый. Базука выпускает ракету, которая наносит 30 урона при столкновении и создает серию взрывов (по 10 урона каждый). Стоимость: 200 врагов, 400 монет и 15 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4280, 100, 100), "ТЕРМИНАТ")) {
				if (unlock_id_31 == 1) {
					id = 31;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_31 == 1) {
				GUI.DrawTexture (new Rect (140, 4390, 100, 20), est);
			}

			/// Терминат (2)

			if (unlock_id_32 == 0) {
				if (GUI.Button (new Rect (30, 4530, 100, 20), "купить")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_31 == 1) {
									if (GDB.levXp >= 16) {

										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 15;
										unlock_id_32 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 4420, 110, 80), idw16_1);
			GUI.DrawTexture (new Rect (450, 4420, 100, 100), id16);
			GUI.Label (new Rect (140, 4420, 300, 100), "Нужен уровень 16. В отличии от своего собрата вооружен пулеметом, который параллельно выпускает 4 пули (каждая наносит урон 1 единицу). Просто умопомрачительная скорость стрельбы оружия. Очень сильный персонаж. Стоимость: 200 врагов, 400 монет и 15 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4420, 100, 100), "ТЕРМИНАТ(2)")) {
				if (unlock_id_32 == 1) {
					id = 32;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_32 == 1) {
				GUI.DrawTexture (new Rect (140, 4530, 100, 20), est);
			}

			/// Злючка

			if (unlock_id_33 == 0) {
				if (GUI.Button (new Rect (30, 4670, 100, 20), "купить")) {
					if (GDB.coins >= 420) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 12) {
								if (GDB.levXp >= 15) {

									GDB.coins -= 420;
									GDB.globalScore -= 200;
									GDB.redMoney -= 12;
									unlock_id_33 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 4560, 30, 100), idw17);
			GUI.DrawTexture (new Rect (450, 4560, 100, 100), id17);
			GUI.Label (new Rect (140, 4560, 300, 100), "Смайл-дьяволенок (70 жизней). Нужен уровень 15. Быстрый. Выпускает файерболы размером больше среднего во все стороны под углом 45 градусов (5 единиц урона). Стоимость: 200 врагов, 420 монет и 12 рубинов. Как любой маг более полезна на открытых уровнях.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4560, 100, 100), "ЗЛЮЧКА")) {
				if (unlock_id_33 == 1) {
					id = 33;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_33 == 1) {
				GUI.DrawTexture (new Rect (140, 4670, 100, 20), est);
			}

			/// Злючка (2)

			if (unlock_id_34 == 0) {
				if (GUI.Button (new Rect (30, 4810, 100, 20), "купить")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_33 == 1) {
									if (GDB.levXp >= 17) {

										GDB.coins -= 200;
										GDB.globalScore -= 100;
										GDB.redMoney -= 6;
										unlock_id_34 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (620, 4700, 30, 100), idw17);
			GUI.DrawTexture (new Rect (510, 4700, 100, 100), id17);
			GUI.DrawTexture (new Rect (450, 4710, 50, 90), idw17_1);
			GUI.Label (new Rect (140, 4700, 300, 100), "Нужен уровень 17. Отличается тем, что имеет щит, предотвращающий все повреждения длительное время. Заряжается тоже длительное время. Остальные характеристики не отличаются от стандартного персонажа. Стоимость: 100 врагов, 200 монет и 6 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4700, 100, 100), "ЗЛЮЧКА(2)")) {
				if (unlock_id_34 == 1) {
					id = 34;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_34 == 1) {
				GUI.DrawTexture (new Rect (140, 4810, 100, 20), est);
			}

			/// Нюнзяка

			if (unlock_id_35 == 0) {
				if (GUI.Button (new Rect (30, 4950, 100, 20), "купить")) {
					if (GDB.coins >= 500) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 20) {
								if (GDB.levXp >= 17) {

									GDB.coins -= 500;
									GDB.globalScore -= 200;
									GDB.redMoney -= 20;
									unlock_id_35 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 4840, 30, 100), idw18);
			GUI.DrawTexture (new Rect (450, 4840, 100, 100), id18);
			GUI.Label (new Rect (140, 4840, 300, 100), "Смайл-нинзя (70 жизней). Нужен уровень 17. Очень быстрый. Вооружен катаной, которая наносит 20 единиц урона (достаточно быстрое оружие). Стоимость: 200 врагов, 500 монет и 20 рубинов. Эффективен в любой ситуации.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4840, 100, 100), "НЮНЗЯКА")) {
				if (unlock_id_35 == 1) {
					id = 35;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_35 == 1) {
				GUI.DrawTexture (new Rect (140, 4950, 100, 20), est);
			}

			///Нюнзяка (2)

			if (unlock_id_36 == 0) {
				if (GUI.Button (new Rect (30, 5090, 100, 20), "купить")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_35 == 1) {
									if (GDB.levXp >= 22) {

										GDB.coins -= 450;
										GDB.globalScore -= 150;
										GDB.redMoney -= 15;
										unlock_id_36 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 4980, 30, 100), idw18);
			GUI.DrawTexture (new Rect (520, 4980, 100, 100), id18);
			GUI.DrawTexture (new Rect (450, 4990, 70, 70), idw18_1);
			GUI.Label (new Rect (140, 4980, 300, 100), "Нужен уровень 22. В отличии от своего стандартного варианта дополнительно выпускает 4 сюрикена с достаточно быстрой скоростью в разных направлениях (наносят 20 единиц урона каждый). Стоимость: 150 врагов, 450 монет и 15 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4980, 100, 100), "НЮНЗЯКА(2)")) {
				if (unlock_id_36 == 1) {
					id = 36;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_36 == 1) {
				GUI.DrawTexture (new Rect (140, 5090, 100, 20), est);
			}

			/// Гламурка

			if (unlock_id_37 == 0) {
				if (GUI.Button (new Rect (30, 5230, 100, 20), "купить")) {
					if (GDB.coins >= 600) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 18) {

									GDB.coins -= 600;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_37 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 5120, 30, 100), idw19);
			GUI.DrawTexture (new Rect (450, 5120, 100, 100), id19);
			GUI.Label (new Rect (140, 5120, 300, 100), "Крутая девчонка смайлик (70 жизней). Нужен уровень 18. Быстрая. Лук выпускает параллельно быстрых 4 стрелы (15 единиц урона каждая). Имеет способность создавать пузыри (8 пузырей сразу). Стоимость: 200 врагов, 600 монет и 15 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5120, 100, 100), "ГЛАМУРКА")) {
				if (unlock_id_37 == 1) {
					id = 37;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_37 == 1) {
				GUI.DrawTexture (new Rect (140, 5230, 100, 20), est);
			}

			/// Гламурка (2)

			if (unlock_id_38 == 0) {
				if (GUI.Button (new Rect (30, 5370, 100, 20), "купить")) {
					if (GDB.coins >= 330) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_37 == 1) {
									if (GDB.levXp >= 20) {
					
										GDB.coins -= 330;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_38 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (600, 5260, 30, 100), idw19);
			GUI.DrawTexture (new Rect (490, 5260, 100, 100), id19);
			GUI.DrawTexture (new Rect (450, 5260, 30, 100), idw19_1);
			GUI.Label (new Rect (140, 5260, 300, 100), "Нужен уровень 20. Отличается от стандартной тем, что имеет второй лук идентичный оригинальному, который стреляет в противоположном направлении. Кроме того способна создавать пузыри в два раза быстрее. Стоимость: 200 врагов, 330 монет и 10 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5260, 100, 100), "ГЛАМУРКА(2)")) {
				if (unlock_id_38 == 1) {
					id = 38;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_38 == 1) {
				GUI.DrawTexture (new Rect (140, 5370, 100, 20), est);
			}

			/// Мафик

			if (unlock_id_39 == 0) {
				if (GUI.Button (new Rect (30, 5510, 100, 20), "купить")) {
					if (GDB.coins >= 350) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 13) {
								if (GDB.levXp >= 19) {

									GDB.coins -= 350;
									GDB.globalScore -= 200;
									GDB.redMoney -= 13;
									unlock_id_39 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 5430, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 5400, 100, 100), id20);
			GUI.Label (new Rect (140, 5400, 300, 100), "Смайлик-мафиози (70 жизней). Нужен уровень 19. Довольно шустрый. Вооружен скорострельной М16 (каждая пуля наносит 8 единиц урона). Других способностей не имеет. Стоимость: 200 врагов, 350 монет и 13 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5400, 100, 100), "МАФИК")) {
				if (unlock_id_39 == 1) {
					id = 39;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_39 == 1) {
				GUI.DrawTexture (new Rect (140, 5510, 100, 20), est);
			}

			/// Мафик (2)

			if (unlock_id_40 == 0) {
				if (GUI.Button (new Rect (30, 5650, 100, 20), "купить")) {
					if (GDB.coins >= 250) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_39 == 1) {
									if (GDB.levXp >= 21) {

										GDB.coins -= 250;
										GDB.globalScore -= 200;
										GDB.redMoney -= 7;
										unlock_id_40 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 5570, 100, 50), idw20);
			GUI.DrawTexture (new Rect (530, 5540, 100, 100), id20);
			GUI.DrawTexture (new Rect (450, 5550, 70, 70), idw20_1); 
			GUI.Label (new Rect (140, 5540, 300, 100), "Нужен уровень 21. Отличается тем, что имеет очень эффективную способность находить на уровнях дополнительные монеты. Очень много дополнительных монет. Остальные характеристики те же. Стоимость: 200 врагов, 250 монет и 7 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5540, 100, 100), "МАФИК(2)")) {
				if (unlock_id_40 == 1) {
					id = 40;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_40 == 1) {
				GUI.DrawTexture (new Rect (140, 5650, 100, 20), est);
			}

			/// Скайфай

			if (unlock_id_41 == 0) {
				if (GUI.Button (new Rect (30, 5790, 100, 20), "купить")) {
					if (GDB.coins >= 680) {
						if (GDB.globalScore >= 220) {
							if (GDB.redMoney >= 17) {
								if (GDB.levXp >= 24) {
						
									GDB.coins -= 680;
									GDB.globalScore -= 220;
									GDB.redMoney -= 17;
									unlock_id_41 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 5710, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 5680, 100, 100), id21);
			GUI.Label (new Rect (140, 5680, 300, 100), "Смайл из будущего (70 жизней). Нужен уровень 24. Вооружен скорострельным бластером. Очень быстрые выстрелы наносят по 11 единиц урона. Обладает не плохой скоростью. Стоимость: 220 врагов, 680 монет и 17 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5680, 100, 100), "СКАЙФАЙ")) {
				if (unlock_id_41 == 1) {
					id = 41;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_41 == 1) {
				GUI.DrawTexture (new Rect (140, 5790, 100, 20), est);
			}

			/// Скайфай (2)

			if (unlock_id_42 == 0) {
				if (GUI.Button (new Rect (30, 5930, 100, 20), "купить")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_41 == 1) {
									if (GDB.levXp >= 26) {

										GDB.coins -= 400;
										GDB.globalScore -= 150;
										GDB.redMoney -= 8;
										unlock_id_42 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (620, 5850, 100, 50), idw21);
			GUI.DrawTexture (new Rect (510, 5820, 100, 100), id21);
			GUI.DrawTexture (new Rect (450, 5820, 40, 90), idw21_1);
			GUI.Label (new Rect (140, 5820, 300, 100), "Нужен уровень 26. Отличается от стандартного персонажа тем, что имеет щит, предоствращающий весь получаемый урон. Щит держиться короткое время, зато очень быстро перезаряжается. Освещает темные уровни. Стоимость: 150 врагов, 400 монет и 8 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5820, 100, 100), "СКАЙФАЙ(2)")) {
				if (unlock_id_42 == 1) {
					id = 42;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_42 == 1) {
				GUI.DrawTexture (new Rect (140, 5930, 100, 20), est);
			}
	
			/// Марсюк

			if (unlock_id_43 == 0) {
				if (GUI.Button (new Rect (30, 6070, 100, 20), "купить")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 33) {

									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_43 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 5970, 120, 80), idw22);
			GUI.DrawTexture (new Rect (450, 5960, 100, 100), id22);
			GUI.Label (new Rect (140, 5960, 300, 100), "Смайлик-марсианин (100 жизней). Нужен уровень 33. Быстрый. Вооружен скорострельным многолучевым лазером (3 луча, каждый наносит по 10 единиц урона). Стоимость: 300 врагов, 900 монет и 40 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5960, 100, 100), "МАРСЮК")) {
				if (unlock_id_43 == 1) {
					id = 43;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_43 == 1) {
				GUI.DrawTexture (new Rect (140, 6070, 100, 20), est);
			}

			/// Марсюк (2)

			if (unlock_id_44 == 0) {
				if (GUI.Button (new Rect (30, 6210, 100, 20), "купить")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (unlock_id_43 == 1) {
									if (GDB.levXp >= 39) {

										GDB.coins -= 900;
										GDB.globalScore -= 300;
										GDB.redMoney -= 40;
										unlock_id_44 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 6120, 120, 80), idw22_1);
			GUI.DrawTexture (new Rect (450, 6100, 100, 100), id22);
			GUI.Label (new Rect (140, 6100, 300, 100), "Нужен уровень 39. Вооружен гораздо более мощным оружием - скорострельным многолучевым лазером (тоже 3 луча, зато каждый луч наносит 20 единиц урона). Остальные характеристики теже. Стоимость: 300 врагов, 900 монет и 40 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6100, 100, 100), "МАРСЮК(2)")) {
				if (unlock_id_44 == 1) {
					id = 44;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_44 == 1) {
				GUI.DrawTexture (new Rect (140, 6210, 100, 20), est);
			}

			/// Роктер

			if (unlock_id_45 == 0) {
				if (GUI.Button (new Rect (30, 6350, 100, 20), "купить")) {
					if (GDB.coins >= 300) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 22) {
						
									GDB.coins -= 300;
									GDB.globalScore -= 200;
									GDB.redMoney -= 9;
									unlock_id_45 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 6270, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 6240, 100, 100), id23);
			GUI.Label (new Rect (140, 6240, 300, 100), "Смайл-рокер (70 жизней). Нужен уровень 22. Вооружен М16 (8 урона за выстрел). Быстр. Часто при выстреле в разные стороны от направления выстрела выпускает ноты, которые мешают врагам. Стоимость: 200 врагов, 300 монет и 9 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6240, 100, 100), "РОКТЕР")) {
				if (unlock_id_45 == 1) {
					id = 45;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_45 == 1) {
				GUI.DrawTexture (new Rect (140, 6350, 100, 20), est);
			}

			/// Роктер (2)

			if (unlock_id_46 == 0) {
				if (GUI.Button (new Rect (30, 6490, 100, 20), "купить")) {
					if (GDB.coins >= 550) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_45 == 1) {
									if (GDB.levXp >= 27) {

										GDB.coins -= 550;
										GDB.globalScore -= 200;
										GDB.redMoney -= 8;
										unlock_id_46 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 6410, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 6380, 100, 100), id23);
			GUI.Label (new Rect (140, 6380, 300, 100), "Нужен уровень 27. Тот же рокер. Отличается только тем, что вооружен более мощным оружием - скорострельным бластером (наносит по 11 единиц урона за выстрел). Стоимость: 200 врагов, 550 монет и 8 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6380, 100, 100), "РОКТЕР(2)")) {
				if (unlock_id_46 == 1) {
					id = 46;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_46 == 1) {
				GUI.DrawTexture (new Rect (140, 6490, 100, 20), est);
			}

			/// Бигбосс

			if (unlock_id_47 == 0) {
				if (GUI.Button (new Rect (30, 6630, 100, 20), "купить")) {
					if (GDB.coins >= 410) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 23) {
								if (GDB.levXp >= 10) {

									GDB.coins -= 410;
									GDB.globalScore -= 190;
									GDB.redMoney -= 10;
									unlock_id_47 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 6540, 100, 60), idw24);
			GUI.DrawTexture (new Rect (450, 6520, 100, 100), id24);
			GUI.Label (new Rect (140, 6520, 300, 100), "Смайл большой босс (80 жизней). Нужен уровень 20. Не быстрый. Вооружен гранатометом (граната наносит 30 единиц урона и взрывается, серия взрывов наносит по 10 единиц урона). Стоимость: 190 врагов, 410 монет и 10 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6520, 100, 100), "БИГ-БОСС")) {
				if (unlock_id_47 == 1) {
					id = 47;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_47 == 1) {
				GUI.DrawTexture (new Rect (140, 6630, 100, 20), est);
			}

			/// Бигбосс (2)

			if (unlock_id_48 == 0) {
				if (GUI.Button (new Rect (30, 6770, 100, 20), "купить")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_47 == 1) {
									if (GDB.levXp >= 22) {

										GDB.coins -= 450;
										GDB.globalScore -= 190;
										GDB.redMoney -= 10;
										unlock_id_48 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 6660, 100, 60), idw24);
			GUI.DrawTexture (new Rect (530, 6660, 100, 100), id24);
			GUI.DrawTexture (new Rect (450, 6670, 70, 70), idw20_1);
			GUI.Label (new Rect (140, 6660, 300, 100), "Нужен уровень 22. Отличается от стандартного персонажа способностью, благодаря которой способен на уровнях находить дополнительные монеты. Других отличий от стандартного персонажа не имеет. Стоимость: 190 врагов, 450 монет и 10 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6660, 100, 100), "БИГ-БОСС(2)")) {
				if (unlock_id_48 == 1) {
					id = 48;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_48 == 1) {
				GUI.DrawTexture (new Rect (140, 6770, 100, 20), est);
			}

			/// Космос

			if (unlock_id_49 == 0) {
				if (GUI.Button (new Rect (30, 6910, 100, 20), "купить")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 38) {

									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_49 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 6820, 90, 60), idw25);
			GUI.DrawTexture (new Rect (450, 6800, 110, 100), id25);
			GUI.Label (new Rect (140, 6800, 300, 100), "Смайл-космонавт (100 жизней). Нужен уровень 38. Вооружен среднескоростным бластером (50 урона). Быстрый. Имеет способность выпускать нечто, отталкиваюшее врагов (4 сразу). Очень сильный персонаж. Стоимость: 300 врагов, 900 монет и 40 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6800, 100, 100), "КОСМОС")) {
				if (unlock_id_49 == 1) {
					id = 49;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_49 == 1) {
				GUI.DrawTexture (new Rect (140, 6910, 100, 20), est);
			}

			/// Космос (2)

			if (unlock_id_50 == 0) {
				if (GUI.Button (new Rect (30, 7050, 100, 20), "купить")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_49 == 1) {
									if (GDB.levXp >= 44) {

										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_50 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 6960, 90, 60), idw25);
			GUI.DrawTexture (new Rect (540, 6940, 110, 100), id25);
			GUI.DrawTexture (new Rect (450, 6960, 90, 60), idw25_5);
			GUI.Label (new Rect (140, 6940, 300, 100), "Нужен уровень 44. В отличии от своего стандартного варианта имеет второй бластер, стреляющий в противоположном направлении. Кроме того, имеет дополнительную способность освещать темные уровни. Стоимость: 200 врагов, 400 монет и 10 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6940, 100, 100), "КОСМОС(2)")) {
				if (unlock_id_50 == 1) {
					id = 50;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_50 == 1) {
				GUI.DrawTexture (new Rect (140, 7050, 100, 20), est);
			}

			/// Мажорик (специальный)

			if (unlock_id_51 == 0) {
				if (GUI.Button (new Rect (30, 7190, 100, 20), "купить")) {
					if (GDB.coins >= 1000) {
						if (GDB.levXp >= 25) {
		

							GDB.coins -= 1000;
							unlock_id_51 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 7090, 90, 60), idw7);
			GUI.DrawTexture (new Rect (450, 7080, 100, 100), id26);
			GUI.Label (new Rect (140, 7080, 300, 100), "Это СПЕЦИАЛЬНЫЙ смайлик. Нужен уровень 25. Со средними способностями (50 жизней, вооружен кольтом, нормальная скорость). Имеет уникальный навык находить на любых уровнях большие рубины (+2 к рубинам). Стоимость: 1000 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7080, 100, 100), "МАЖОРИК")) {
				if (unlock_id_51 == 1) {
					id = 51;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_51 == 1) {
				GUI.DrawTexture (new Rect (140, 7190, 100, 20), est);
			}

			/// Джокер (специальный)

			if (unlock_id_52 == 0) {
				if (GUI.Button (new Rect (30, 7330, 100, 20), "купить")) {
					if (GDB.coins >= 1500) {
						if (GDB.levXp >= 50) {

							GDB.coins -= 1500;
							unlock_id_52 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 7250, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 7220, 100, 100), id27);
			GUI.Label (new Rect (140, 7220, 300, 100), "Это СПЕЦИАЛЬНЫЙ смайлик. Нужен уровень 50. Сильный (вооружен М16, 50 жизней, очень быстрый). Имеет способность находить коробку, в которой случайно выпадает +20 к счету врагов, +10 монет или +1 рубин. Стоимость: 1500 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7220, 100, 100), "ДЖОКЕР")) {
				if (unlock_id_52 == 1) {
					id = 52;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_52 == 1) {
				GUI.DrawTexture (new Rect (140, 7330, 100, 20), est);
			}

			/// Тучка (специальный)

			if (unlock_id_53 == 0) {
				if (GUI.Button (new Rect (30, 7470, 100, 20), "купить")) {
					if (GDB.coins >= 250) {
						if (GDB.levXp >= 25) {

							GDB.coins -= 250;
							unlock_id_53 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (450, 7360, 100, 100), id28);
			GUI.Label (new Rect (140, 7360, 300, 100), "Это СПЕЦИАЛЬНЫЙ смайлик (50 жизней, очень медленный). Нужен уровень 25. Автоматически создает на карте блуждающие шаровые молнии, которые бьют врагов. Этот персонаж может использоваться в режиме AFK. Стоимость: 250 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7360, 100, 100), "ТУЧКА")) {
				if (unlock_id_53 == 1) {
					id = 53;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_53 == 1) {
				GUI.DrawTexture (new Rect (140, 7470, 100, 20), est);
			}

			/// Гроза (специальный)

			if (unlock_id_54 == 0) {
				if (GUI.Button (new Rect (30, 7610, 100, 20), "купить")) {
					if (GDB.coins >= 750) {
						if (GDB.levXp >= 50) {

							GDB.coins -= 750;
							unlock_id_54 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (450, 7500, 100, 100), id29);
			GUI.Label (new Rect (140, 7500, 300, 100), "Это СПЕЦИАЛЬНЫЙ смайлик (100 жизней, быстрый). Нужен уровень 50. Автоматически создаваемые заряды не только бьют врагов, но и сами собирают монеты. Этот персонаж идеально подходит для режима AFK. Стоимость: 750 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7500, 100, 100), "ГРОЗА")) {
				if (unlock_id_54 == 1) {
					id = 54;
					Application.LoadLevel ("LevelMenu");
				}
			}
		
			if (unlock_id_54 == 1) {
				GUI.DrawTexture (new Rect (140, 7610, 100, 20), est);
			}

			/// Истиричка (специальный)

			if (unlock_id_55 == 0) {
				if (GUI.Button (new Rect (30, 7750, 100, 20), "купить")) {
					if (GDB.coins >= 500) {
						if (GDB.levXp >= 99) {

							GDB.coins -= 500;
							unlock_id_55 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (630, 7650, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 7640, 100, 100), id30);
			GUI.DrawTexture (new Rect (450, 7650, 80, 80), idw30);
			GUI.Label (new Rect (140, 7640, 300, 100), "Это СПЕЦИАЛЬНЫЙ смайлик (50 жизней, быстрый). Нужен уровень 99. Вооружена двумя стандартными узи, стреляющими в противоположных направлениях. Теоретически имеет ничтожный шанс найти клад (5000 монет и 100 рубинов). Стоимость: 500 монет.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7640, 100, 100), "ИСТИРИЧКА")) {
				if (unlock_id_55 == 1) {
					id = 55;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_55 == 1) {
				GUI.DrawTexture (new Rect (140, 7750, 100, 20), est);
			}

			/// Рейдер (коллекция)

			if (unlock_id_56 == 0) {
				if (GUI.Button (new Rect (30, 7890, 100, 20), "купить")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {

							GDB.redMoney -= 30;
							unlock_id_56 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 7800, 100, 50), idw31);
			GUI.DrawTexture (new Rect (450, 7780, 100, 100), id31);
			GUI.Label (new Rect (140, 7780, 300, 100), "Это КОЛЛЕКЦИОННЫЙ смайл (50 жизней, средняя скорость). Нужен уровень 30. Вооружен автоматом калашникова (очень скорострельный, наносит по 8 единиц урона). Подходит практически к любому уровню. Нейтральный вариант для игры. Стоимость: 30 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7780, 100, 100), "РЕЙДЕР")) {
				if (unlock_id_56 == 1) {
					id = 56;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_56 == 1) {
				GUI.DrawTexture (new Rect (140, 7890, 100, 20), est);
			}

			/// Ранчо (коллекция)

			if (unlock_id_57 == 0) {
				if (GUI.Button (new Rect (30, 8030, 100, 20), "купить")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {

							GDB.redMoney -= 30;
							unlock_id_57 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 7940, 110, 50), idw32);
			GUI.DrawTexture (new Rect (450, 7920, 100, 100), id32);
			GUI.Label (new Rect (140, 7920, 300, 100), "Это КОЛЛЕКЦИОННЫЙ смайд (50 жизней, быстрый). Нужен уровень 30. Вооружен ружьем (40 единиц урона). Типичный коллекционный смайл со средними способностями. Актуален на любом уровне. Стоимость: 30 рубинов. ", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7920, 100, 100), "РАНЧО")) {
				if (unlock_id_57 == 1) {
					id = 57;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_57 == 1) {
				GUI.DrawTexture (new Rect (140, 8030, 100, 20), est);
			}

			/// Камикадзе (коллекция)

			if (unlock_id_58 == 0) {
				if (GUI.Button (new Rect (30, 8170, 100, 20), "купить")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {

							GDB.redMoney -= 30;
							unlock_id_58 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 8090, 50, 50), idw33);
			GUI.DrawTexture (new Rect (450, 8060, 100, 100), id33);
			GUI.Label (new Rect (140, 8060, 300, 100), "Это КОЛЛЕКЦИОННЫЙ смайл (быстрый, 50 жизней). Нужен уровень 30. Кидает гранаты (30 урона при попадании и по 10 урона взрывы). Очень веселый смайл для коллекции. Стоимость: 30 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8060, 100, 100), "КАМИКАДЗЕ")) {
				if (unlock_id_58 == 1) {
					id = 58;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_58 == 1) {
				GUI.DrawTexture (new Rect (140, 8170, 100, 20), est);
			}

			/// Геймер (коллекция)

			if (unlock_id_59 == 0) {
				if (GUI.Button (new Rect (30, 8310, 100, 20), "купить")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
			
							GDB.redMoney -= 300;
							unlock_id_59 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 8210, 150, 90), idw34);
			GUI.DrawTexture (new Rect (450, 8200, 100, 100), id34);
			GUI.Label (new Rect (140, 8200, 300, 100), "Это КОЛЛЕКЦИОННЫЙ смайл (быстрый, 100 жизней). Нужен уровень 80. Вооружен невероятно мощным BFG (1 большой заряд в 500 урона и 2 малых по 250 урона). На открытых уровнях эффективнее. Стоимость: 300 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8200, 100, 100), "ГЕЙМЕР")) {
				if (unlock_id_59 == 1) {
					id = 59;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_59 == 1) {
				GUI.DrawTexture (new Rect (140, 8310, 100, 20), est);
			}

			/// Псих (коллекция)

			if (unlock_id_60 == 0) {
				if (GUI.Button (new Rect (30, 8450, 100, 20), "купить")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
			
							GDB.redMoney -= 300;
							unlock_id_60 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 8350, 150, 90), idw35);
			GUI.DrawTexture (new Rect (450, 8340, 100, 100), id35);
			GUI.Label (new Rect (140, 8340, 300, 100), "Это КОЛЛЕКЦИОННЫЙ смайл (средняя скорость, 100 жизней). Нужен уровень 80. Вооружен трехствольной ракетницей (каждая ракета 30 урона при столкновении и 10 урона взрывы). Очень эффективный персонаж. Стоимость: 300 рубинов.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8340, 100, 100), "ПСИХ")) {
				if (unlock_id_60 == 1) {
					id = 60;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_60 == 1) {
				GUI.DrawTexture (new Rect (140, 8450, 100, 20), est);
			}

			/// Джэдай (Легенда)

			if (unlock_id_61 == 0) {
				if (GUI.Button (new Rect (30, 8590, 100, 20), "забрать!")) {
					if (unlock_id_3 == 1) {
						if (unlock_id_5 == 1) {
							if (unlock_id_7 == 1) {
								if (unlock_id_9 == 1) {
									if (unlock_id_11 == 1) {
										if (unlock_id_13 == 1) {
											if (unlock_id_15 == 1) {
												if (unlock_id_17 == 1) {
													if (unlock_id_19 == 1) {
														if (unlock_id_21 == 1) {
															if (unlock_id_23 == 1) {
																if (unlock_id_25 == 1) {
																	if (unlock_id_27 == 1) {
																		if (unlock_id_29 == 1) {
																			if (unlock_id_31 == 1) {
																				if (unlock_id_33 == 1) {
																					if (unlock_id_35 == 1) {
																						if (unlock_id_37 == 1) {
																							if (unlock_id_39 == 1) {
																								if (unlock_id_41 == 1) {
																									if (unlock_id_43 == 1) {
																										if (unlock_id_45 == 1) {
																											if (unlock_id_47 == 1) {
																												if (unlock_id_49 == 1) {
																								
																													unlock_id_61 = 1;
																													PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 8480, 100, 100), idw36);
			GUI.DrawTexture (new Rect (450, 8480, 100, 120), id36);
			GUI.Label (new Rect (140, 8480, 300, 100), "Это ЛЕГЕНДАРНЫЙ смайл. Имеет 999 жизней. Очень быстрый. Световой меч наносит 100 урона за взмах. Быстрое оружие. Можно забрать, если разблокированы (есть в наличии) все стандартные смайлы-персонажы. Способен пройти любой уровень.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8480, 100, 100), "ДЖЭДАЙ")) {
				if (unlock_id_61 == 1) {
					id = 61;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_61 == 1) {
				GUI.DrawTexture (new Rect (140, 8590, 100, 20), est);
			}

			/// Ситх (Легенда)

			if (unlock_id_62 == 0) {
				if (GUI.Button (new Rect (30, 8730, 100, 20), "забрать!")) {
					if (unlock_id_2 == 1) {
						if (unlock_id_4 == 1) {
							if (unlock_id_6 == 1) {
								if (unlock_id_8 == 1) {
									if (unlock_id_10 == 1) {
										if (unlock_id_12 == 1) {
											if (unlock_id_14 == 1) {
												if (unlock_id_16 == 1) {
													if (unlock_id_18 == 1) {
														if (unlock_id_20 == 1) {
															if (unlock_id_22 == 1) {
																if (unlock_id_24 == 1) {
																	if (unlock_id_26 == 1) {
																		if (unlock_id_28 == 1) {
																			if (unlock_id_30 == 1) {
																				if (unlock_id_32 == 1) {
																					if (unlock_id_34 == 1) {
																						if (unlock_id_36 == 1) {
																							if (unlock_id_38 == 1) {
																								if (unlock_id_40 == 1) {
																									if (unlock_id_42 == 1) {
																										if (unlock_id_44 == 1) {
																											if (unlock_id_46 == 1) {
																												if (unlock_id_48 == 1) {
																													if (unlock_id_50 == 1) {																				
																														unlock_id_62 = 1;
																														PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}


			GUI.DrawTexture (new Rect (560, 8620, 100, 100), idw37);
			GUI.DrawTexture (new Rect (450, 8620, 100, 100), id37);
			GUI.Label (new Rect (140, 8620, 300, 100), "Это ЛЕГЕНДАРНЫЙ смайл. Имеет 999 жизней и быстрый световой меч (100 урона). Дополнительно выпускает 3 молнии (по 50 урона). Имеет периодический щит. Можно забрать, если разблокированы все продвинутые смайлы с пометкой (2).", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8620, 100, 100), "СИТХ")) {
				if (unlock_id_62 == 1) {
					id = 62;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_62 == 1) {
				GUI.DrawTexture (new Rect (140, 8730, 100, 20), est);
			}

			/// Смерть (легенда)

			if (unlock_id_63 == 0) {
				if (GUI.Button (new Rect (30, 8870, 100, 20), "забрать!")) {
					if (unlock_id_51 == 1) {
						if (unlock_id_52 == 1) {
							if (unlock_id_53 == 1) {
								if (unlock_id_54 == 1) {
									if (unlock_id_55 == 1) {
										if (unlock_id_56 == 1) {
											if (unlock_id_57 == 1) {
												if (unlock_id_58 == 1) {
													if (unlock_id_59 == 1) {
														if (unlock_id_60 == 1) {
									
															unlock_id_63 = 1;
															PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}

			GUI.DrawTexture (new Rect (560, 8760, 100, 100), idw38);
			GUI.DrawTexture (new Rect (450, 8760, 100, 100), id38);
			GUI.Label (new Rect (140, 8760, 300, 100), "Это ЛЕГЕНДАРНЫЙ смайл. Имеет 666 жизней. Небыстрая коса наносит 66 урона за взмах. Имеет запредельную скорость. Собирает души (+ 10 хп за врага). Можно забрать, если собраны все специальные и коллекционные смайлы.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8760, 100, 100), "СМЕРТЬ")) {
				if (unlock_id_63 == 1) {
					id = 63;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_63 == 1) {
				GUI.DrawTexture (new Rect (140, 8870, 100, 20), est);
			}
		}

		///ENG
		if (MenuScript.lang == 2) {
			
			/// Лошарик 2
			if (unlock_id_2 == 0) {
				if (GUI.Button (new Rect (30, 330, 100, 20), "buy")) {
					if (GDB.coins >= 30) {
						if (GDB.globalScore >= 20) { 
							
							GDB.coins -= 30;
							GDB.globalScore -= 20;
							unlock_id_2 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
						}
					}
				}
			}
			GUI.DrawTexture (new Rect (450, 220, 70, 70), idw1_2);
			GUI.DrawTexture (new Rect (535, 210, 100, 100), id1);
			GUI.DrawTexture (new Rect (640, 220, 70, 70), idw1);
			GUI.Label (new Rect (140, 220, 300, 100), "The same losharik, however, is armed with two pistols that shoot in different directions. Characteristics of the weapons are identical to the normal losharik. This character can be purchased for 20 enemies killed in the total score and an additional 30 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 220, 100, 100), "STUPID(2)")) {
				if (unlock_id_2 == 1) {
					id = 2;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_2 == 1) {
				GUI.DrawTexture (new Rect (140, 330, 100, 20), est);
			}
			
			/// Волшебка
			
			if (unlock_id_3 == 0) {
				if (GUI.Button (new Rect (30, 470, 100, 20), "buy")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 70;
									GDB.globalScore -= 60;
									GDB.redMoney -= 2;
									unlock_id_3 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 360, 100, 100), id2);
			GUI.DrawTexture (new Rect (560, 360, 30, 100), idw2);
			GUI.Label (new Rect (140, 360, 300, 100), "Smile-the Sorceress (40 lives). Huge shots deal 6 damage and decay at the first touch. Rate of fire is average. Below average speed. Cost: 60 enemies, 70 coins and 2 rubies and 1 level. For open levels.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 360, 100, 100), "WITCH")) {
				if (unlock_id_3 == 1) {
					id = 3;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_3 == 1) {
				GUI.DrawTexture (new Rect (140, 470, 100, 20), est);
			}
			
			/// Волшебка 2
			
			if (unlock_id_4 == 0) {
				if (GUI.Button (new Rect (30, 610, 100, 20), "buy")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_3 == 1) {
									if (GDB.levXp >= 1) {
										
										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_4 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 500, 30, 100), idw2);
			GUI.DrawTexture (new Rect (525, 500, 100, 100), id2);
			GUI.DrawTexture (new Rect (450, 520, 60, 60), idw2_1);
			GUI.Label (new Rect (140, 500, 300, 100), "Need level 1. In addition to all the features, it has a ring shield. Shield for minor time prevents any damage. It also takes time to recharge. Cost: 40 enemies, 70 coins and 2 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 500, 100, 100), "WITCH(2)")) {
				if (unlock_id_4 == 1) {
					id = 4;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_4 == 1) {
				GUI.DrawTexture (new Rect (140, 610, 100, 20), est);
			}
			
			/// Вампиряк
			
			if (unlock_id_5 == 0) {
				if (GUI.Button (new Rect (30, 750, 100, 20), "buy")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 70;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_5 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 640, 30, 100), idw3);
			GUI.DrawTexture (new Rect (450, 640, 100, 100), id3);
			GUI.Label (new Rect (140, 640, 300, 100), "Smile-as a vampire (20 lives). Need level 0. Armed with a heavy sword. In close contact with the enemy deals 3 damage units. Attack speed is not high. A fairly quick character. Cost: 50 enemies, 70 coins and 2 rubies. Close combat only.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 640, 100, 100), "VAMPIRE")) {
				if (unlock_id_5 == 1) {
					id = 5;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_5 == 1) {
				GUI.DrawTexture (new Rect (140, 750, 100, 20), est);
			}
			
			/// Вампиряк 2
			
			if (unlock_id_6 == 0) {
				if (GUI.Button (new Rect (30, 890, 100, 20), "buy")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_5 == 1) {
									if (GDB.levXp >= 2) {
										
										GDB.coins -= 100;
										GDB.globalScore -= 60;
										GDB.redMoney -= 3;
										unlock_id_6 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (610, 780, 30, 100), idw3);
			GUI.DrawTexture (new Rect (500, 780, 100, 100), id3);
			GUI.DrawTexture (new Rect (450, 795, 50, 80), idw3_1);
			GUI.Label (new Rect (140, 780, 300, 100), "Need level 2. In addition to all the characteristics it has a very strong and extremely useful ability to suck life out. For each enemy killed, the character gains an extra 10 lives. Cost: 60 enemies, 100 coins and 3 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 780, 100, 100), "VAMPIRE(2)")) {
				if (unlock_id_6 == 1) {
					id = 6;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_6 == 1) {
				GUI.DrawTexture (new Rect (140, 890, 100, 20), est);
			}
			
			/// Святоша
			
			if (unlock_id_7 == 0) {
				if (GUI.Button (new Rect (30, 1030, 100, 20), "buy")) {
					if (GDB.coins >= 60) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 60;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_7 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 920, 35, 100), idw4);
			GUI.DrawTexture (new Rect (450, 920, 100, 100), id4);
			GUI.Label (new Rect (140, 920, 300, 100), "The most are a good smile (30 lives). Need level 0. Not a quick character. Not often in parallel releases 2 fast arrows (2 damage). The character illuminates the area around the dark levels. Cost: 50 enemies, 60 coins and 2 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 920, 100, 100), "PRIEST")) {
				if (unlock_id_7 == 1) {
					id = 7;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_7 == 1) {
				GUI.DrawTexture (new Rect (140, 1030, 100, 20), est);
			}
			
			/// Святоша(2)
			if (unlock_id_8 == 0) {
				if (GUI.Button (new Rect (30, 1170, 100, 20), "buy")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_7 == 1) {
									if (GDB.levXp >= 3) {
										
										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_8 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (625, 1060, 35, 100), idw4);
			GUI.DrawTexture (new Rect (515, 1060, 100, 100), id4);
			GUI.DrawTexture (new Rect (450, 1070, 50, 80), idw4_1);
			GUI.Label (new Rect (140, 1060, 300, 100), "Need level 3. In addition to the functions of the standard persanazha releases directly 4 parallel arrows. Illuminates a much larger area. Cost: 40 enemies, 70 coins and 2 rubies. Extremely useful character in the levels with poor lighting.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1060, 100, 100), "PRIEST(2)")) {
				if (unlock_id_8 == 1) {
					id = 8;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_8 == 1) {
				GUI.DrawTexture (new Rect (140, 1170, 100, 20), est);
			}
			
			/// Панкрат
			
			if (unlock_id_9 == 0) {
				if (GUI.Button (new Rect (30, 1310, 100, 20), "buy")) {
					if (GDB.coins >= 90) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 1) {
									
									GDB.coins -= 90;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_9 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 1230, 100, 30), idw5);
			GUI.DrawTexture (new Rect (450, 1200, 100, 100), id5);
			GUI.Label (new Rect (140, 1200, 300, 100), "Smiley punk (30 lives). Need level 1. Not fast. Shoots a scattering of small fraction (3 units of damage from each). Just over shot rolls 5 missile. It takes quite a long time to recharge. Cost: 80 enemies, 90 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1200, 100, 100), "PUNK")) {
				if (unlock_id_9 == 1) {
					id = 9;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_9 == 1) {
				GUI.DrawTexture (new Rect (140, 1310, 100, 20), est);
			}
			
			/// Панкрат(2)
			
			if (unlock_id_10 == 0) {
				if (GUI.Button (new Rect (30, 1450, 100, 20), "buy")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_9 == 1) {
									if (GDB.levXp >= 4) {
										
										GDB.coins -= 120;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_10 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (610, 1370, 100, 30), idw5);
			GUI.DrawTexture (new Rect (500, 1340, 100, 100), id5);
			GUI.DrawTexture (new Rect (450, 1350, 40, 70), idw5_1);
			GUI.Label (new Rect (140, 1340, 300, 100), "Need level 4. Unlike standard individual has 60 lives. Armed with a more powerful shotgun (released 11 shells per shot). This character belongs to the category of strong characters. Cost: 80 enemies, 120 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1340, 100, 100), "PUNK(2)")) {
				if (unlock_id_10 == 1) {
					id = 10;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_10 == 1) {
				GUI.DrawTexture (new Rect (140, 1450, 100, 20), est);
			}
			
			/// Инжик
			
			if (unlock_id_11 == 0) {
				if (GUI.Button (new Rect (30, 1590, 100, 20), "buy")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 90) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 3) {
									
									GDB.coins -= 140;
									GDB.globalScore -= 90;
									GDB.redMoney -= 8;
									unlock_id_11 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 1490, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 1480, 100, 100), id6);
			GUI.Label (new Rect (140, 1480, 300, 100), "Smile-engineer (40 lives). Need level 3. Quick character. Armed with a very rapid-fire ultrasound, each shell which deals 1 unit of damage. This is a strong character even in the starting configuration. Cost: 90 enemies, 140 coins and 8 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1480, 100, 100), "ENGINEER")) {
				if (unlock_id_11 == 1) {
					id = 11;
					Application.LoadLevel ("Levelmenu");
				}
			}
			if (unlock_id_11 == 1) {
				GUI.DrawTexture (new Rect (140, 1590, 100, 20), est);
			}
			
			/// Инжик (2)
			
			if (unlock_id_12 == 0) {
				if (GUI.Button (new Rect (30, 1730, 100, 20), "buy")) {
					if (GDB.coins >= 50) {
						if (GDB.globalScore >= 30) {
							if (GDB.redMoney >= 1) {
								if (unlock_id_11 == 1) {
									if (GDB.levXp >= 4) {
										
										GDB.coins -= 50;
										GDB.globalScore -= 30;
										GDB.redMoney -= 1;
										unlock_id_12 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 1630, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 1620, 100, 100), id6);
			GUI.DrawTexture (new Rect (450, 1620, 80, 100), idw6_1);
			GUI.Label (new Rect (140, 1620, 300, 100), "Need level 4. In addition to all the features of the standard character has the ability to build solid walls. Indispensable when Tolstoy enemy sobrecaliente that he didn't run away. Cost: 30 enemies, 50 coins and 1 ruby.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1620, 100, 100), "ENGINEER(2)")) {
				if (unlock_id_12 == 1) {
					id = 12;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_12 == 1) {
				GUI.DrawTexture (new Rect (140, 1730, 100, 20), est);
			}
			
			/// Пикряк
			
			if (unlock_id_13 == 0) {
				if (GUI.Button (new Rect (30, 1870, 100, 20), "buy")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (GDB.levXp >= 5) {
									
									GDB.coins -= 160;
									GDB.globalScore -= 100;
									GDB.redMoney -= 6;
									unlock_id_13 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (545, 1780, 85, 55), idw7);
			GUI.DrawTexture (new Rect (450, 1760, 100, 100), id7);
			GUI.Label (new Rect (140, 1760, 300, 100), "Smiley pirate (30 lives). Need level 5. Nimble enough character. Armed with a powerful colt that deals 12 points of damage per shot. Rate of fire is not high. Cost: 100 enemies, 160 coins and 6 rubies. Useful in a battle with the pachyderms.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1760, 100, 100), "PIRATE")) {
				if (unlock_id_13 == 1) {
					id = 13;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_13 == 1) {
				GUI.DrawTexture (new Rect (140, 1870, 100, 20), est);
			}
			
			/// Пикряк (2)
			
			if (unlock_id_14 == 0) {
				if (GUI.Button (new Rect (30, 2010, 100, 20), "buy")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_13 == 1) {
									if (GDB.levXp >= 6) {
										
										GDB.coins -= 100;
										GDB.globalScore -= 50;
										GDB.redMoney -= 3;
										unlock_id_14 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (625, 1920, 85, 55), idw7);
			GUI.DrawTexture (new Rect (530, 1900, 100, 100), id7);
			GUI.DrawTexture (new Rect (450, 1920, 85, 55), idw7_1);
			GUI.Label (new Rect (140, 1900, 300, 100), "Need level 6. Unlike the standard character is armed with two collars that shoot in different directions (also cause 12 damage). Additionally has 60 lives. Cost: 50 enemies, 100 coins and 3 rubies. Doubly effective.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1900, 100, 100), "PIRATE(2)")) {
				if (unlock_id_14 == 1) {
					id = 14;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_14 == 1) {
				GUI.DrawTexture (new Rect (140, 2010, 100, 20), est);
			}
			
			/// Книжлок
			
			if (unlock_id_15 == 0) {
				if (GUI.Button (new Rect (30, 2150, 100, 20), "buy")) {
					if (GDB.coins >= 80) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 7) {
									
									GDB.coins -= 80;
									GDB.globalScore -= 100;
									GDB.redMoney -= 7;
									unlock_id_15 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (540, 2040, 30, 100), idw8);
			GUI.DrawTexture (new Rect (450, 2040, 100, 100), id8);
			GUI.Label (new Rect (140, 2040, 300, 100), "Smiley-warlock (40 lives). Need level 7. Fast. Often produces two large charge of magic in opposite directions, causing 7 points of damage (destroyed at the touch). Cost: 80 enemies, 100 coins and 7 rubies. For open areas.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2040, 100, 100), "WARLOCK")) {
				if (unlock_id_15 == 1) {
					id = 15;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_15 == 1) {
				GUI.DrawTexture (new Rect (140, 2150, 100, 20), est);
			}
			
			/// Книжлок (2)
			
			if (unlock_id_16 == 0) {
				if (GUI.Button (new Rect (30, 2290, 100, 20), "buy")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_15 == 1) {
									if (GDB.levXp >= 8) {
										
										GDB.coins -= 140;
										GDB.globalScore -= 80;
										GDB.redMoney -= 3;
										unlock_id_16 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 2180, 30, 100), idw8);
			GUI.DrawTexture (new Rect (510, 2180, 100, 100), id8);
			GUI.DrawTexture (new Rect (450, 2190, 60, 80), idw8_1);
			GUI.Label (new Rect (140, 2180, 300, 100), "Need level 8. In addition to all the features it has the ability to activate the shield, which prevents any damage during the average time. Charges pretty fast. Cost: 80 enemies, 140 coins and 3 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2180, 100, 100), "WARLOCK(2)")) {
				if (unlock_id_16 == 1) {
					id = 16;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_16 == 1) {
				GUI.DrawTexture (new Rect (140, 2290, 100, 20), est);
			}
			
			/// Мазюк
			
			if (unlock_id_17 == 0) {
				if (GUI.Button (new Rect (30, 2430, 100, 20), "buy")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 5) {
									
									GDB.coins -= 160;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_17 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (550, 2340, 70, 70), idw9);
			GUI.DrawTexture (new Rect (450, 2320, 100, 100), id9);
			GUI.Label (new Rect (140, 2320, 300, 100), "Smiley-artist (40 lives). Need level 5. With an average speed spill blots. If the enemy hits the blot, it gets 20 units of damage. Quick character. Cost: 80 enemies, 160 coins and 4 rubies. Useful on levels with lots of buildings.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2320, 100, 100), "ARTIST")) {
				if (unlock_id_17 == 1) {
					id = 17;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_17 == 1) {
				GUI.DrawTexture (new Rect (140, 2430, 100, 20), est);
			}
			
			/// Мазюк (2)
			
			if (unlock_id_18 == 0) {
				if (GUI.Button (new Rect (30, 2570, 100, 20), "buy")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_17 == 1) {
									if (GDB.levXp >= 7) {
										
										GDB.coins -= 120;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_18 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 2480, 70, 70), idw9);
			GUI.DrawTexture (new Rect (525, 2460, 100, 100), id9);
			GUI.DrawTexture (new Rect (450, 2470, 80, 80), idw9_1);
			GUI.Label (new Rect (140, 2460, 300, 100), "Need level 7. Has substantial improvements compared with standard character. Has a very high speed. Has 80 lives. More often pours blots. Cost: 60 enemies, 120 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2460, 100, 100), "ARTIST(2)")) {
				if (unlock_id_18 == 1) {
					id = 18;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_18 == 1) {
				GUI.DrawTexture (new Rect (140, 2570, 100, 20), est);
			}
			
			/// Тамада
			
			if (unlock_id_19 == 0) {
				if (GUI.Button (new Rect (30, 2710, 100, 20), "buy")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 70) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 4) {
									
									GDB.coins -= 140;
									GDB.globalScore -= 70;
									GDB.redMoney -= 4;
									unlock_id_19 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2620, 70, 70), idw1);
			GUI.DrawTexture (new Rect (450, 2600, 100, 100), id10);
			GUI.Label (new Rect (140, 2600, 300, 100), "Festive smiley face (40 lives). Need level 4. Armed with a conventional pistol. Not fast. Has the ability to periodically create Losharikov, occasionally throwing stones (cause 8 points of damage to enemies). Cost: 70 enemies, 140 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2600, 100, 100), "HOLIDAY")) {
				if (unlock_id_19 == 1) {
					id = 19;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_19 == 1) {
				GUI.DrawTexture (new Rect (140, 2710, 100, 20), est);
			}
			
			/// Тамада (2)
			
			if (unlock_id_20 == 0) {
				if (GUI.Button (new Rect (30, 2850, 100, 20), "buy")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_19 == 1) {
									if (GDB.levXp >= 6) {
										
										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_20 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2760, 90, 70), idw7);
			GUI.DrawTexture (new Rect (450, 2740, 100, 100), id10);
			GUI.Label (new Rect (140, 2740, 300, 100), "Need level 6. Unlike standard individual has 80 lives. Has a high speed. Armed with a colt. Often creates Losharikov (the more), which is applied for 16 ediniz damage. Cost: 80 enemies, 160 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2740, 100, 100), "HOLIDAY(2)")) {
				if (unlock_id_20 == 1) {
					id = 20;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_20 == 1) {
				GUI.DrawTexture (new Rect (140, 2850, 100, 20), est);
			}
			
			/// Зомбик
			
			if (unlock_id_21 == 0) {
				if (GUI.Button (new Rect (30, 2990, 100, 20), "buy")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 6) {
									
									GDB.coins -= 200;
									GDB.globalScore -= 140;
									GDB.redMoney -= 8;
									unlock_id_21 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2880, 30, 100), idw11);
			GUI.DrawTexture (new Rect (450, 2880, 100, 100), id11);
			GUI.Label (new Rect (140, 2880, 300, 100), "Smile-zombies (120 lives). Need level 6. Slow. Armed with a slow sword (12 melee damage). Cost: 140 enemies, 200 coins and 8 rubies. Virtually immortal due to the large number of lives.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2880, 100, 100), "ZOMBIE")) {
				if (unlock_id_21 == 1) {
					id = 21;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_21 == 1) {
				GUI.DrawTexture (new Rect (140, 2990, 100, 20), est);
			}
			
			/// Зомбик (2)
			
			if (unlock_id_22 == 0) {
				if (GUI.Button (new Rect (30, 3130, 100, 20), "buy")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_21 == 1) {
									if (GDB.levXp >= 9) {
										
										GDB.coins -= 220;
										GDB.globalScore -= 140;
										GDB.redMoney -= 8;
										unlock_id_22 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 3020, 30, 100), idw11);
			GUI.DrawTexture (new Rect (530, 3020, 100, 100), id11);
			GUI.DrawTexture (new Rect (450, 3030, 70, 70), idw11_1);
			GUI.Label (new Rect (140, 3020, 300, 100), "Need level 9. Significantly different from the standard character. Has 240 lives. Has ability to shield, which periodically protects from any damage. Light up the dark levels. Cost: 140 enemies, 220 coins and 8 rubies. Strong character.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3020, 100, 100), "ZOMBIE(2)")) {
				if (unlock_id_22 == 1) {
					id = 22;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_22 == 1) {
				GUI.DrawTexture (new Rect (140, 3130, 100, 20), est);
			}
			
			/// Футуря
			
			if (unlock_id_23 == 0) {
				if (GUI.Button (new Rect (30, 3270, 100, 20), "buy")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 80;
									GDB.redMoney -= 7;
									unlock_id_23 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (550, 3170, 80, 70), idw12);
			GUI.DrawTexture (new Rect (450, 3160, 100, 100), id12);
			GUI.Label (new Rect (140, 3160, 300, 100), "Smiley face from the future (50 lives). Need level 10. Fast. Armed with a laser (very fast projectiles), which deals 15 damage. Cost: 80 enemies, 220 coins and 7 rubies. Effective in any situation and at any level.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3160, 100, 100), "FUTURE")) {
				if (unlock_id_23 == 1) {
					id = 23;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_23 == 1) {
				GUI.DrawTexture (new Rect (140, 3270, 100, 20), est);
			}
			
			/// Футуря (2)
			
			if (unlock_id_24 == 0) {
				if (GUI.Button (new Rect (30, 3410, 100, 20), "buy")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_23 == 1) {
									if (GDB.levXp >= 12) {
										
										GDB.coins -= 180;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_24 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 3310, 80, 70), idw12);
			GUI.DrawTexture (new Rect (540, 3300, 100, 100), id12);
			GUI.DrawTexture (new Rect (450, 3310, 80, 70), idw12_1);
			GUI.Label (new Rect (140, 3300, 300, 100), "Need level 12. Twice as effective as its standard counterpart due to the fact that it has another laser that shoots in the opposite direction. Characteristics are the same. Cost: 60 enemies, 180 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3300, 100, 100), "FUTURE(2)")) {
				if (unlock_id_24 == 1) {
					id = 24;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_24 == 1) {
				GUI.DrawTexture (new Rect (140, 3410, 100, 20), est);
			}
			
			/// Ворюга
			
			if (unlock_id_25 == 0) {
				if (GUI.Button (new Rect (30, 3550, 100, 20), "buy")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 7) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 100;
									GDB.redMoney -= 9;
									unlock_id_25 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_24);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3470, 100, 40), idw5);
			GUI.DrawTexture (new Rect (450, 3440, 100, 100), id13);
			GUI.Label (new Rect (140, 3440, 300, 100), "Smay-the thief (40 lives). We need level 7. Quite nimble. Armed with a weak shotgun. Has ability to find on level more coins (platinum coin are worth five gold), than other characters. Cost: 100 enemies, 220 coins and 9 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3440, 100, 100), "THIEF")) {
				if (unlock_id_25 == 1) {
					id = 25;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_25 == 1) {
				GUI.DrawTexture (new Rect (140, 3550, 100, 20), est);
			}
			
			/// Ворюга (2)
			
			if (unlock_id_26 == 0) {
				if (GUI.Button (new Rect (30, 3690, 100, 20), "buy")) {
					if (GDB.coins >= 240) {
						if (GDB.globalScore >= 130) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_25 == 1) {
									if (GDB.levXp >= 8) {
										
										GDB.coins -= 240;
										GDB.globalScore -= 130;
										GDB.redMoney -= 7;
										unlock_id_26 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3580, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 3580, 100, 100), id13);
			GUI.Label (new Rect (140, 3580, 300, 100), "Need level 8. Differs from the standard character that is armed with a very rapid-fire Uzi instead of the regular shotgun. The other characteristics remained unchanged. Cost: 130 enemies, 240 coins and 7 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3580, 100, 100), "THIEF(2)")) {
				if (unlock_id_26 == 1) {
					id = 26;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_26 == 1) {
				GUI.DrawTexture (new Rect (140, 3690, 100, 20), est);
			}
			
			/// Няшка
			
			if (unlock_id_27 == 0) {
				if (GUI.Button (new Rect (30, 3830, 100, 20), "buy")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 120) {
							if (GDB.redMoney >= 10) {
								if (GDB.levXp >= 11) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 120;
									GDB.redMoney -= 10;
									unlock_id_27 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3720, 30, 100), idw14);
			GUI.DrawTexture (new Rect (450, 3720, 100, 100), id14);
			GUI.Label (new Rect (140, 3720, 300, 100), "Smiley butterfly (40 lives). Need level 11. Very fast. With an average speed of 4 medium produces a huge projectile (angle 90 degrees) in different directions (Nanuet 9 points of damage). Cost: 120 enemies, 220 coins and 10 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3720, 100, 100), "GENTLE")) {
				if (unlock_id_27 == 1) {
					id = 27;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_27 == 1) {
				GUI.DrawTexture (new Rect (140, 3830, 100, 20), est);
			}
			
			/// Няшка (2)
			
			if (unlock_id_28 == 0) {
				if (GUI.Button (new Rect (30, 3970, 100, 20), "buy")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_27 == 1) {
									if (GDB.levXp >= 13) {
										
										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 6;
										unlock_id_28 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 3860, 30, 100), idw14);
			GUI.DrawTexture (new Rect (520, 3860, 100, 100), id14);
			GUI.DrawTexture (new Rect (450, 3870, 50, 80), idw14_1);
			GUI.Label (new Rect (140, 3860, 300, 100), "Need level 13. Differs from the standard character that has crazy speed. Also has ability to shield (prevents any damage). Shield long held, but and is charging, too, long. Cost: 80 enemies, 160 coins and 6 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3860, 100, 100), "GENTLE(2)")) {
				if (unlock_id_28 == 1) {
					id = 28;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_28 == 1) {
				GUI.DrawTexture (new Rect (140, 3970, 100, 20), est);
			}
			
			/// Бомбер
			
			if (unlock_id_29 == 0) {
				if (GUI.Button (new Rect (30, 4110, 100, 20), "buy")) {
					if (GDB.coins >= 150) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 150;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_29 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4010, 50, 80), idw15);
			GUI.DrawTexture (new Rect (450, 4000, 100, 100), id15);
			GUI.Label (new Rect (140, 4000, 300, 100), "Smile-bomb (40 lives). Need level 10. Not very fast. Intermittently explodes (10 damage). Ability: periodically creates dynamites are creating a series of explosions (10 points of damage). Cost: 80 enemies, 150 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4000, 100, 100), "BOMB")) {
				if (unlock_id_29 == 1) {
					id = 29;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_29 == 1) {
				GUI.DrawTexture (new Rect (140, 4110, 100, 20), est);
			}
			
			/// Бомбер (2)
			
			if (unlock_id_30 == 0) {
				if (GUI.Button (new Rect (30, 4250, 100, 20), "buy")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_29 == 1) {
									if (GDB.levXp >= 12) {
										
										GDB.coins -= 180;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_30 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 4150, 50, 80), idw15);
			GUI.DrawTexture (new Rect (530, 4140, 100, 100), id15);
			GUI.DrawTexture (new Rect (450, 4150, 50, 80), idw15);
			GUI.Label (new Rect (140, 4140, 300, 100), "Need level 12. A little faster than your standard character. More than twice as often creates dynamites. All other characteristics do not differ from the standard version. Cost: 80 enemies, 180 coins and 4 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4140, 100, 100), "BOMB(2)")) {
				if (unlock_id_30 == 1) {
					id = 30;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_30 == 1) {
				GUI.DrawTexture (new Rect (140, 4250, 100, 20), est);
			}
			
			/// Терминат
			
			if (unlock_id_31 == 0) {
				if (GUI.Button (new Rect (30, 4390, 100, 20), "buy")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 14) {
									
									GDB.coins -= 400;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_31 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4300, 100, 70), idw16);
			GUI.DrawTexture (new Rect (450, 4280, 100, 100), id16);
			GUI.Label (new Rect (140, 4280, 300, 100), "Real terminator (80 lives). Need level 14. Not fast. Bazooka launches a rocket that deals 30 damage in a collision and creates a series of explosions (10 damage each). Cost: 200 enemies, 400 coins and 15 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4280, 100, 100), "TERMI")) {
				if (unlock_id_31 == 1) {
					id = 31;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_31 == 1) {
				GUI.DrawTexture (new Rect (140, 4390, 100, 20), est);
			}
			
			/// Терминат (2)
			
			if (unlock_id_32 == 0) {
				if (GUI.Button (new Rect (30, 4530, 100, 20), "buy")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_31 == 1) {
									if (GDB.levXp >= 16) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 15;
										unlock_id_32 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4420, 110, 80), idw16_1);
			GUI.DrawTexture (new Rect (450, 4420, 100, 100), id16);
			GUI.Label (new Rect (140, 4420, 300, 100), "Need level 16. Unlike his colleague armed with a machine gun, which produces parallel 4 bullets (each deals damage to 1 unit). Simply mind-blowing the speed called the shots weapons. A very strong character. Cost: 200 enemies, 400 coins and 15 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4420, 100, 100), "TERMI(2)")) {
				if (unlock_id_32 == 1) {
					id = 32;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_32 == 1) {
				GUI.DrawTexture (new Rect (140, 4530, 100, 20), est);
			}
			
			/// Злючка
			
			if (unlock_id_33 == 0) {
				if (GUI.Button (new Rect (30, 4670, 100, 20), "buy")) {
					if (GDB.coins >= 420) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 12) {
								if (GDB.levXp >= 15) {
									
									GDB.coins -= 420;
									GDB.globalScore -= 200;
									GDB.redMoney -= 12;
									unlock_id_33 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4560, 30, 100), idw17);
			GUI.DrawTexture (new Rect (450, 4560, 100, 100), id17);
			GUI.Label (new Rect (140, 4560, 300, 100), "Smiley devil (70 lives). Need level 15. Fast. Releases a fireball larger than the average in all directions at an angle of 45 degrees (5 points of damage). Cost: 200 enemies, 420 coins and 12 rubies. As any mage more useful on open levels.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4560, 100, 100), "EVIL")) {
				if (unlock_id_33 == 1) {
					id = 33;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_33 == 1) {
				GUI.DrawTexture (new Rect (140, 4670, 100, 20), est);
			}
			
			/// Злючка (2)
			
			if (unlock_id_34 == 0) {
				if (GUI.Button (new Rect (30, 4810, 100, 20), "buy")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_33 == 1) {
									if (GDB.levXp >= 17) {
										
										GDB.coins -= 200;
										GDB.globalScore -= 100;
										GDB.redMoney -= 6;
										unlock_id_34 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 4700, 30, 100), idw17);
			GUI.DrawTexture (new Rect (510, 4700, 100, 100), id17);
			GUI.DrawTexture (new Rect (450, 4710, 50, 90), idw17_1);
			GUI.Label (new Rect (140, 4700, 300, 100), "Need level 17. It differs in that it has a shield that prevents all damage for a long time. Charged too for a long time. The other characteristics do not differ from the standard character. Cost: 100 enemies, 200 coins and 6 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4700, 100, 100), "EVIL(2)")) {
				if (unlock_id_34 == 1) {
					id = 34;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_34 == 1) {
				GUI.DrawTexture (new Rect (140, 4810, 100, 20), est);
			}
			
			/// Нюнзяка
			
			if (unlock_id_35 == 0) {
				if (GUI.Button (new Rect (30, 4950, 100, 20), "buy")) {
					if (GDB.coins >= 500) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 20) {
								if (GDB.levXp >= 17) {
									
									GDB.coins -= 500;
									GDB.globalScore -= 200;
									GDB.redMoney -= 20;
									unlock_id_35 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4840, 30, 100), idw18);
			GUI.DrawTexture (new Rect (450, 4840, 100, 100), id18);
			GUI.Label (new Rect (140, 4840, 300, 100), "Smile-ninja (70 lives). Need level 17. Very fast. Armed with a katana that deals 20 damage (fast enough weapon). Cost: 200 enemies, 500 coins and 20 rubies. Effective in any situation.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4840, 100, 100), "NINJA")) {
				if (unlock_id_35 == 1) {
					id = 35;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_35 == 1) {
				GUI.DrawTexture (new Rect (140, 4950, 100, 20), est);
			}
			
			///Нюнзяка (2)
			
			if (unlock_id_36 == 0) {
				if (GUI.Button (new Rect (30, 5090, 100, 20), "buy")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_35 == 1) {
									if (GDB.levXp >= 22) {
										
										GDB.coins -= 450;
										GDB.globalScore -= 150;
										GDB.redMoney -= 15;
										unlock_id_36 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 4980, 30, 100), idw18);
			GUI.DrawTexture (new Rect (520, 4980, 100, 100), id18);
			GUI.DrawTexture (new Rect (450, 4990, 70, 70), idw18_1);
			GUI.Label (new Rect (140, 4980, 300, 100), "Need level of 22. Unlike its standard version additionally produces 4 shuriken with a fairly fast speed in different directions (cause 20 damage each). Cost: 150 enemies, 450 coins and 15 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4980, 100, 100), "NINJA(2)")) {
				if (unlock_id_36 == 1) {
					id = 36;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_36 == 1) {
				GUI.DrawTexture (new Rect (140, 5090, 100, 20), est);
			}
			
			/// Гламурка
			
			if (unlock_id_37 == 0) {
				if (GUI.Button (new Rect (30, 5230, 100, 20), "buy")) {
					if (GDB.coins >= 600) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 18) {
									
									GDB.coins -= 600;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_37 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5120, 30, 100), idw19);
			GUI.DrawTexture (new Rect (450, 5120, 100, 100), id19);
			GUI.Label (new Rect (140, 5120, 300, 100), "Cool girl smiley (70 lives). We need level 18. Fast. The onion produces parallel 4-fast arrow (15 damage each). Has ability to create bubbles (8 bubbles at once). Cost: 200 enemies, 600 coins and 15 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5120, 100, 100), "GLAMOUR")) {
				if (unlock_id_37 == 1) {
					id = 37;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_37 == 1) {
				GUI.DrawTexture (new Rect (140, 5230, 100, 20), est);
			}
			
			/// Гламурка (2)
			
			if (unlock_id_38 == 0) {
				if (GUI.Button (new Rect (30, 5370, 100, 20), "buy")) {
					if (GDB.coins >= 330) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_37 == 1) {
									if (GDB.levXp >= 20) {
										
										GDB.coins -= 330;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_38 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (600, 5260, 30, 100), idw19);
			GUI.DrawTexture (new Rect (490, 5260, 100, 100), id19);
			GUI.DrawTexture (new Rect (450, 5260, 30, 100), idw19_1);
			GUI.Label (new Rect (140, 5260, 300, 100), "Need level 20. Differs from the standard in that it has a second identical bow that shoots in the opposite direction. Also able to create bubbles twice as fast. Cost: 200 enemies, 330 coins and 10 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5260, 100, 100), "GLAMOUR(2)")) {
				if (unlock_id_38 == 1) {
					id = 38;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_38 == 1) {
				GUI.DrawTexture (new Rect (140, 5370, 100, 20), est);
			}
			
			/// Мафик
			
			if (unlock_id_39 == 0) {
				if (GUI.Button (new Rect (30, 5510, 100, 20), "buy")) {
					if (GDB.coins >= 350) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 13) {
								if (GDB.levXp >= 19) {
									
									GDB.coins -= 350;
									GDB.globalScore -= 200;
									GDB.redMoney -= 13;
									unlock_id_39 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5430, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 5400, 100, 100), id20);
			GUI.Label (new Rect (140, 5400, 300, 100), "Smiley mafia (70 lives). Need level 19. Pretty nimble. Armed with a fast-firing M16 (each bullet deals 8 damage). Other abilities not has. Cost: 200 enemies, 350 coins and 13 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5400, 100, 100), "MAFIA")) {
				if (unlock_id_39 == 1) {
					id = 39;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_39 == 1) {
				GUI.DrawTexture (new Rect (140, 5510, 100, 20), est);
			}
			
			/// Мафик (2)
			
			if (unlock_id_40 == 0) {
				if (GUI.Button (new Rect (30, 5650, 100, 20), "buy")) {
					if (GDB.coins >= 250) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_39 == 1) {
									if (GDB.levXp >= 21) {
										
										GDB.coins -= 250;
										GDB.globalScore -= 200;
										GDB.redMoney -= 7;
										unlock_id_40 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 5570, 100, 50), idw20);
			GUI.DrawTexture (new Rect (530, 5540, 100, 100), id20);
			GUI.DrawTexture (new Rect (450, 5550, 70, 70), idw20_1); 
			GUI.Label (new Rect (140, 5540, 300, 100), "Need level 21. Differs in that it has a very effective ability to find the levels for more coins. A lot of extra coins. Other characteristics are the same. Cost: 200 enemies, 250 coins and 7 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5540, 100, 100), "MAFIA(2)")) {
				if (unlock_id_40 == 1) {
					id = 40;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_40 == 1) {
				GUI.DrawTexture (new Rect (140, 5650, 100, 20), est);
			}
			
			/// Скайфай
			
			if (unlock_id_41 == 0) {
				if (GUI.Button (new Rect (30, 5790, 100, 20), "buy")) {
					if (GDB.coins >= 680) {
						if (GDB.globalScore >= 220) {
							if (GDB.redMoney >= 17) {
								if (GDB.levXp >= 24) {
									
									GDB.coins -= 680;
									GDB.globalScore -= 220;
									GDB.redMoney -= 17;
									unlock_id_41 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5710, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 5680, 100, 100), id21);
			GUI.Label (new Rect (140, 5680, 300, 100), "Smile from the future (the lives of 70). Need level 24. Armed with a rapid-fire Blaster. Very quick shots inflict 11 points of damage. Has good speed. Cost: 220 enemies, 680 coins and 17 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5680, 100, 100), "SCI-FI")) {
				if (unlock_id_41 == 1) {
					id = 41;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_41 == 1) {
				GUI.DrawTexture (new Rect (140, 5790, 100, 20), est);
			}
			
			/// Скайфай (2)
			
			if (unlock_id_42 == 0) {
				if (GUI.Button (new Rect (30, 5930, 100, 20), "buy")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_41 == 1) {
									if (GDB.levXp >= 26) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 150;
										GDB.redMoney -= 8;
										unlock_id_42 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 5850, 100, 50), idw21);
			GUI.DrawTexture (new Rect (510, 5820, 100, 100), id21);
			GUI.DrawTexture (new Rect (450, 5820, 40, 90), idw21_1);
			GUI.Label (new Rect (140, 5820, 300, 100), "Need level of 26. Differs from the standard character that has a shield, predotvraschaya all damage taken. The shield rests a short time, but recharges very quickly. Light up the dark levels. Cost: 150 enemies, 400 coins and 8 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5820, 100, 100), "SCI-FI(2)")) {
				if (unlock_id_42 == 1) {
					id = 42;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_42 == 1) {
				GUI.DrawTexture (new Rect (140, 5930, 100, 20), est);
			}
			
			/// Марсюк
			
			if (unlock_id_43 == 0) {
				if (GUI.Button (new Rect (30, 6070, 100, 20), "buy")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 33) {
									
									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_43 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5970, 120, 80), idw22);
			GUI.DrawTexture (new Rect (450, 5960, 100, 100), id22);
			GUI.Label (new Rect (140, 5960, 300, 100), "Smiley face-Martian (100 lives). Need level 33. Fast. Armed with rapid-fire multi-beam laser (3 beam, each deals 10 points of damage). Cost: 300 enemies, 900 coins and 40 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5960, 100, 100), "MARTIAN")) {
				if (unlock_id_43 == 1) {
					id = 43;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_43 == 1) {
				GUI.DrawTexture (new Rect (140, 6070, 100, 20), est);
			}
			
			/// Марсюк (2)
			
			if (unlock_id_44 == 0) {
				if (GUI.Button (new Rect (30, 6210, 100, 20), "buy")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (unlock_id_43 == 1) {
									if (GDB.levXp >= 39) {
										
										GDB.coins -= 900;
										GDB.globalScore -= 300;
										GDB.redMoney -= 40;
										unlock_id_44 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6120, 120, 80), idw22_1);
			GUI.DrawTexture (new Rect (450, 6100, 100, 100), id22);
			GUI.Label (new Rect (140, 6100, 300, 100), "Need level 39. Armed with much more powerful weapons - rapid-fire multi-beam laser (also 3 beams, but each beam does 20 points of damage). Other characteristics are the same. Cost: 300 enemies, 900 coins and 40 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6100, 100, 100), "MARTIAN(2)")) {
				if (unlock_id_44 == 1) {
					id = 44;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_44 == 1) {
				GUI.DrawTexture (new Rect (140, 6210, 100, 20), est);
			}
			
			/// Роктер
			
			if (unlock_id_45 == 0) {
				if (GUI.Button (new Rect (30, 6350, 100, 20), "buy")) {
					if (GDB.coins >= 300) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 22) {
									
									GDB.coins -= 300;
									GDB.globalScore -= 200;
									GDB.redMoney -= 9;
									unlock_id_45 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6270, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 6240, 100, 100), id23);
			GUI.Label (new Rect (140, 6240, 300, 100), "Smile-rocker (70 lives). Need level 22. Armed with M16 (8 damage per shot). Fast. Often when shot in different directions from the direction of the shot produces notes that hinder the enemies. Cost: 200 enemies, 300 coins and 9 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6240, 100, 100), "ROCKER")) {
				if (unlock_id_45 == 1) {
					id = 45;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_45 == 1) {
				GUI.DrawTexture (new Rect (140, 6350, 100, 20), est);
			}
			
			/// Роктер (2)
			
			if (unlock_id_46 == 0) {
				if (GUI.Button (new Rect (30, 6490, 100, 20), "buy")) {
					if (GDB.coins >= 550) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_45 == 1) {
									if (GDB.levXp >= 27) {
										
										GDB.coins -= 550;
										GDB.globalScore -= 200;
										GDB.redMoney -= 8;
										unlock_id_46 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6410, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 6380, 100, 100), id23);
			GUI.Label (new Rect (140, 6380, 300, 100), "Need level 27. The same rocker. Only difference is that armed with more powerful weapons - quick-firing Blaster (inflicts 11 points of damage per shot). Cost: 200 enemies, 550 coins and 8 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6380, 100, 100), "ROCKER(2)")) {
				if (unlock_id_46 == 1) {
					id = 46;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_46 == 1) {
				GUI.DrawTexture (new Rect (140, 6490, 100, 20), est);
			}
			
			/// Бигбосс
			
			if (unlock_id_47 == 0) {
				if (GUI.Button (new Rect (30, 6630, 100, 20), "buy")) {
					if (GDB.coins >= 410) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 23) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 410;
									GDB.globalScore -= 190;
									GDB.redMoney -= 10;
									unlock_id_47 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6540, 100, 60), idw24);
			GUI.DrawTexture (new Rect (450, 6520, 100, 100), id24);
			GUI.Label (new Rect (140, 6520, 300, 100), "Smile big boss (80 lives). Need level 20. Not fast. Armed with the grenade launcher (grenade deals 30 points of damage and explodes, a series of explosions that deals 10 points of damage). Cost: 190 enemies, 410 coins and 10 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6520, 100, 100), "BIGBOSS")) {
				if (unlock_id_47 == 1) {
					id = 47;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_47 == 1) {
				GUI.DrawTexture (new Rect (140, 6630, 100, 20), est);
			}
			
			/// Бигбосс (2)
			
			if (unlock_id_48 == 0) {
				if (GUI.Button (new Rect (30, 6770, 100, 20), "buy")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_47 == 1) {
									if (GDB.levXp >= 22) {
										
										GDB.coins -= 450;
										GDB.globalScore -= 190;
										GDB.redMoney -= 10;
										unlock_id_48 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 6660, 100, 60), idw24);
			GUI.DrawTexture (new Rect (530, 6660, 100, 100), id24);
			GUI.DrawTexture (new Rect (450, 6670, 70, 70), idw20_1);
			GUI.Label (new Rect (140, 6660, 300, 100), "Need level 22. Differs from the standard character ability, thanks to which is capable levels to find extra coins. Other differences from the standard character does not. Cost: 190 enemies, 450 coins and 10 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6660, 100, 100), "BIGBOSS(2)")) {
				if (unlock_id_48 == 1) {
					id = 48;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_48 == 1) {
				GUI.DrawTexture (new Rect (140, 6770, 100, 20), est);
			}
			
			/// Космос
			
			if (unlock_id_49 == 0) {
				if (GUI.Button (new Rect (30, 6910, 100, 20), "buy")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 38) {
									
									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_49 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6820, 90, 60), idw25);
			GUI.DrawTexture (new Rect (450, 6800, 110, 100), id25);
			GUI.Label (new Rect (140, 6800, 300, 100), "Smile-astronaut (100 lives). Need level 38. Armed with medium-speed Blaster (50 damage). Fast. Has the ability to produce something, repelling enemies (4 at once). A very strong character. Cost: 300 enemies, 900 coins and 40 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6800, 100, 100), "SPACE")) {
				if (unlock_id_49 == 1) {
					id = 49;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_49 == 1) {
				GUI.DrawTexture (new Rect (140, 6910, 100, 20), est);
			}
			
			/// Космос (2)
			
			if (unlock_id_50 == 0) {
				if (GUI.Button (new Rect (30, 7050, 100, 20), "buy")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_49 == 1) {
									if (GDB.levXp >= 44) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_50 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 6960, 90, 60), idw25);
			GUI.DrawTexture (new Rect (540, 6940, 110, 100), id25);
			GUI.DrawTexture (new Rect (450, 6960, 90, 60), idw25_5);
			GUI.Label (new Rect (140, 6940, 300, 100), "Need level 44. Unlike its standard version has a second Blaster, firing in the opposite direction. In addition, it has the additional ability to illuminate dark levels. Cost: 200 enemies, 400 coins and 10 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6940, 100, 100), "SPACE(2)")) {
				if (unlock_id_50 == 1) {
					id = 50;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_50 == 1) {
				GUI.DrawTexture (new Rect (140, 7050, 100, 20), est);
			}
			
			/// Мажорик (специальный)
			
			if (unlock_id_51 == 0) {
				if (GUI.Button (new Rect (30, 7190, 100, 20), "buy")) {
					if (GDB.coins >= 1000) {
						if (GDB.levXp >= 25) {
							
							
							GDB.coins -= 1000;
							unlock_id_51 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7090, 90, 60), idw7);
			GUI.DrawTexture (new Rect (450, 7080, 100, 100), id26);
			GUI.Label (new Rect (140, 7080, 300, 100), "This is a SPECIAL smiley. Need level 25. With average abilities (50 lives, armed with colt, normal speed). Has unique skill find on any levels big rubies (+2 to rubies). Cost: 1000 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7080, 100, 100), "MAJOR")) {
				if (unlock_id_51 == 1) {
					id = 51;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_51 == 1) {
				GUI.DrawTexture (new Rect (140, 7190, 100, 20), est);
			}
			
			/// Джокер (специальный)
			
			if (unlock_id_52 == 0) {
				if (GUI.Button (new Rect (30, 7330, 100, 20), "buy")) {
					if (GDB.coins >= 1500) {
						if (GDB.levXp >= 50) {
							
							GDB.coins -= 1500;
							unlock_id_52 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7250, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 7220, 100, 100), id27);
			GUI.Label (new Rect (140, 7220, 300, 100), "This is a SPECIAL smiley. Need level 50. A strong (armed M16, 50 lives, very rapid). Has the ability to find the box in which accidentally drops a +20 to the score of the enemy, +10 coins or 1 ruby. Cost: 1500 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7220, 100, 100), "JOKER")) {
				if (unlock_id_52 == 1) {
					id = 52;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_52 == 1) {
				GUI.DrawTexture (new Rect (140, 7330, 100, 20), est);
			}
			
			/// Тучка (специальный)
			
			if (unlock_id_53 == 0) {
				if (GUI.Button (new Rect (30, 7470, 100, 20), "buy")) {
					if (GDB.coins >= 250) {
						if (GDB.levXp >= 25) {
							
							GDB.coins -= 250;
							unlock_id_53 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 7360, 100, 100), id28);
			GUI.Label (new Rect (140, 7360, 300, 100), "This a SPECIAL smiley face (50 lives, very slow). Need level 25. Automatically creates on the map wandering ball lightning that hit enemies. This character can be used in AFK mode. Cost: 250 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7360, 100, 100), "CLOUD")) {
				if (unlock_id_53 == 1) {
					id = 53;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_53 == 1) {
				GUI.DrawTexture (new Rect (140, 7470, 100, 20), est);
			}
			
			/// Гроза (специальный)
			
			if (unlock_id_54 == 0) {
				if (GUI.Button (new Rect (30, 7610, 100, 20), "buy")) {
					if (GDB.coins >= 750) {
						if (GDB.levXp >= 50) {
							
							GDB.coins -= 750;
							unlock_id_54 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 7500, 100, 100), id29);
			GUI.Label (new Rect (140, 7500, 300, 100), "This is a SPECIAL smiley (100, fast). Need level 50. Automatically created charges not only beat enemies, but also collect coins. This character is perfect for AFK mode. Cost: 750 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7500, 100, 100), "STORM")) {
				if (unlock_id_54 == 1) {
					id = 54;
					Application.LoadLevel ("LevelMenu");
				}
			}
			
			if (unlock_id_54 == 1) {
				GUI.DrawTexture (new Rect (140, 7610, 100, 20), est);
			}
			
			/// Истиричка (специальный)
			
			if (unlock_id_55 == 0) {
				if (GUI.Button (new Rect (30, 7750, 100, 20), "buy")) {
					if (GDB.coins >= 500) {
						if (GDB.levXp >= 99) {
							
							GDB.coins -= 500;
							unlock_id_55 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 7650, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 7640, 100, 100), id30);
			GUI.DrawTexture (new Rect (450, 7650, 80, 80), idw30);
			GUI.Label (new Rect (140, 7640, 300, 100), "This a SPECIAL smiley face (50 lives, rapid). Need level 99. Armed with two standard ultrasound, shooting in opposite directions. Theoretically has a negligible chance find treasure (5,000 coins and 100 rubies). Cost: 500 coins.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7640, 100, 100), "HYSTERICAL")) {
				if (unlock_id_55 == 1) {
					id = 55;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_55 == 1) {
				GUI.DrawTexture (new Rect (140, 7750, 100, 20), est);
			}
			
			/// Рейдер (коллекция)
			
			if (unlock_id_56 == 0) {
				if (GUI.Button (new Rect (30, 7890, 100, 20), "buy")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_56 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7800, 100, 50), idw31);
			GUI.DrawTexture (new Rect (450, 7780, 100, 100), id31);
			GUI.Label (new Rect (140, 7780, 300, 100), "This is a COLLECTIBLE smiley face (50 lives, average speed). Need level 30. Armed with a Kalashnikov assault rifle (very quick-fire, deals 8 damage). Suitable for almost any level. Neutral option for the game. Price: 30 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7780, 100, 100), "RAIDER")) {
				if (unlock_id_56 == 1) {
					id = 56;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_56 == 1) {
				GUI.DrawTexture (new Rect (140, 7890, 100, 20), est);
			}
			
			/// Ранчо (коллекция)
			
			if (unlock_id_57 == 0) {
				if (GUI.Button (new Rect (30, 8030, 100, 20), "buy")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_57 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7940, 110, 50), idw32);
			GUI.DrawTexture (new Rect (450, 7920, 100, 100), id32);
			GUI.Label (new Rect (140, 7920, 300, 100), "This is a COLLECTIBLE smiley face (50 lives, fast). Need level 30. Armed with a gun (40 damage). A typical collection smiley with average abilities. Relevant at any level. Price: 30 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7920, 100, 100), "RANCH")) {
				if (unlock_id_57 == 1) {
					id = 57;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_57 == 1) {
				GUI.DrawTexture (new Rect (140, 8030, 100, 20), est);
			}
			
			/// Камикадзе (коллекция)
			
			if (unlock_id_58 == 0) {
				if (GUI.Button (new Rect (30, 8170, 100, 20), "buy")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_58 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8090, 50, 50), idw33);
			GUI.DrawTexture (new Rect (450, 8060, 100, 100), id33);
			GUI.Label (new Rect (140, 8060, 300, 100), "This is a COLLECTIBLE smiley face (fast, 50 lives). Need level 30. Throws grenades (30 damage on hit and 10 damage explosions). Very cheerful smile for the collection. Price: 30 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8060, 100, 100), "KAMIKAZE")) {
				if (unlock_id_58 == 1) {
					id = 58;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_58 == 1) {
				GUI.DrawTexture (new Rect (140, 8170, 100, 20), est);
			}
			
			/// Геймер (коллекция)
			
			if (unlock_id_59 == 0) {
				if (GUI.Button (new Rect (30, 8310, 100, 20), "buy")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
							
							GDB.redMoney -= 300;
							unlock_id_59 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8210, 150, 90), idw34);
			GUI.DrawTexture (new Rect (450, 8200, 100, 100), id34);
			GUI.Label (new Rect (140, 8200, 300, 100), "This is a COLLECTOR's smile (quick, 100 lives).Need level 80. Armed with an incredibly powerful BFG (1 large charge of 500 damage and 2 small 250 damage). On open levels more effectively. Price: 300 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8200, 100, 100), "GAMER")) {
				if (unlock_id_59 == 1) {
					id = 59;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_59 == 1) {
				GUI.DrawTexture (new Rect (140, 8310, 100, 20), est);
			}
			
			/// Псих (коллекция)
			
			if (unlock_id_60 == 0) {
				if (GUI.Button (new Rect (30, 8450, 100, 20), "buy")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
							
							GDB.redMoney -= 300;
							unlock_id_60 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8350, 150, 90), idw35);
			GUI.DrawTexture (new Rect (450, 8340, 100, 100), id35);
			GUI.Label (new Rect (140, 8340, 300, 100), "This is a COLLECTIBLE smiley (average speed, 100 lives). The desired level 80. Armed with a three-barrel rocket launcher (each rocket 30 collision damage and 10 explosions damage). A very effective character. Price: 300 rubies.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8340, 100, 100), "CRAZY")) {
				if (unlock_id_60 == 1) {
					id = 60;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_60 == 1) {
				GUI.DrawTexture (new Rect (140, 8450, 100, 20), est);
			}
			
			/// Джэдай (Легенда)
			
			if (unlock_id_61 == 0) {
				if (GUI.Button (new Rect (30, 8590, 100, 20), "got it!")) {
					if (unlock_id_3 == 1) {
						if (unlock_id_5 == 1) {
							if (unlock_id_7 == 1) {
								if (unlock_id_9 == 1) {
									if (unlock_id_11 == 1) {
										if (unlock_id_13 == 1) {
											if (unlock_id_15 == 1) {
												if (unlock_id_17 == 1) {
													if (unlock_id_19 == 1) {
														if (unlock_id_21 == 1) {
															if (unlock_id_23 == 1) {
																if (unlock_id_25 == 1) {
																	if (unlock_id_27 == 1) {
																		if (unlock_id_29 == 1) {
																			if (unlock_id_31 == 1) {
																				if (unlock_id_33 == 1) {
																					if (unlock_id_35 == 1) {
																						if (unlock_id_37 == 1) {
																							if (unlock_id_39 == 1) {
																								if (unlock_id_41 == 1) {
																									if (unlock_id_43 == 1) {
																										if (unlock_id_45 == 1) {
																											if (unlock_id_47 == 1) {
																												if (unlock_id_49 == 1) {
																													
																													unlock_id_61 = 1;
																													PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8480, 100, 100), idw36);
			GUI.DrawTexture (new Rect (450, 8480, 100, 120), id36);
			GUI.Label (new Rect (140, 8480, 300, 100), "This is the LEGENDARY smiley. Has 999 lives. Very fast. Light sword deals 100 damage per swing. Quick weapon. You can pick up, if unlocked (available) all the standard emoticons-characters. Able to pass any level.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8480, 100, 100), "JEDI")) {
				if (unlock_id_61 == 1) {
					id = 61;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_61 == 1) {
				GUI.DrawTexture (new Rect (140, 8590, 100, 20), est);
			}
			
			/// Ситх (Легенда)
			
			if (unlock_id_62 == 0) {
				if (GUI.Button (new Rect (30, 8730, 100, 20), "got it!")) {
					if (unlock_id_2 == 1) {
						if (unlock_id_4 == 1) {
							if (unlock_id_6 == 1) {
								if (unlock_id_8 == 1) {
									if (unlock_id_10 == 1) {
										if (unlock_id_12 == 1) {
											if (unlock_id_14 == 1) {
												if (unlock_id_16 == 1) {
													if (unlock_id_18 == 1) {
														if (unlock_id_20 == 1) {
															if (unlock_id_22 == 1) {
																if (unlock_id_24 == 1) {
																	if (unlock_id_26 == 1) {
																		if (unlock_id_28 == 1) {
																			if (unlock_id_30 == 1) {
																				if (unlock_id_32 == 1) {
																					if (unlock_id_34 == 1) {
																						if (unlock_id_36 == 1) {
																							if (unlock_id_38 == 1) {
																								if (unlock_id_40 == 1) {
																									if (unlock_id_42 == 1) {
																										if (unlock_id_44 == 1) {
																											if (unlock_id_46 == 1) {
																												if (unlock_id_48 == 1) {
																													if (unlock_id_50 == 1) {																				
																														unlock_id_62 = 1;
																														PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			
			GUI.DrawTexture (new Rect (560, 8620, 100, 100), idw37);
			GUI.DrawTexture (new Rect (450, 8620, 100, 100), id37);
			GUI.Label (new Rect (140, 8620, 300, 100), "This is the LEGENDARY smiley. Has 999 lives and a lightning fast sword (100 damage). Additionally, fires 3 lightning (50 damage). Has a periodic shield. Can be take from, if unlocked all advanced emoticons with your (2).", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8620, 100, 100), "SITH")) {
				if (unlock_id_62 == 1) {
					id = 62;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_62 == 1) {
				GUI.DrawTexture (new Rect (140, 8730, 100, 20), est);
			}
			
			/// Смерть (легенда)
			
			if (unlock_id_63 == 0) {
				if (GUI.Button (new Rect (30, 8870, 100, 20), "got it!")) {
					if (unlock_id_51 == 1) {
						if (unlock_id_52 == 1) {
							if (unlock_id_53 == 1) {
								if (unlock_id_54 == 1) {
									if (unlock_id_55 == 1) {
										if (unlock_id_56 == 1) {
											if (unlock_id_57 == 1) {
												if (unlock_id_58 == 1) {
													if (unlock_id_59 == 1) {
														if (unlock_id_60 == 1) {
															
															unlock_id_63 = 1;
															PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8760, 100, 100), idw38);
			GUI.DrawTexture (new Rect (450, 8760, 100, 100), id38);
			GUI.Label (new Rect (140, 8760, 300, 100), "This is the LEGENDARY smiley. Has 666 lives. A quick braid deals 66 damage per swing. It has an exorbitant speed. Collecting the souls (+ 10 HP per enemy). You can collect, if you collected all the special and collector's smiles.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8760, 100, 100), "DEATH")) {
				if (unlock_id_63 == 1) {
					id = 63;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_63 == 1) {
				GUI.DrawTexture (new Rect (140, 8870, 100, 20), est);
			}
		}

		///CHI
		if (MenuScript.lang == 3) {
			
			/// Лошарик 2
			if (unlock_id_2 == 0) {
				if (GUI.Button (new Rect (30, 330, 100, 20), "买")) {
					if (GDB.coins >= 30) {
						if (GDB.globalScore >= 20) { 
							
							GDB.coins -= 30;
							GDB.globalScore -= 20;
							unlock_id_2 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char2", PlayerMenu.unlock_id_2);
						}
					}
				}
			}
			GUI.DrawTexture (new Rect (450, 220, 70, 70), idw1_2);
			GUI.DrawTexture (new Rect (535, 210, 100, 100), id1);
			GUI.DrawTexture (new Rect (640, 220, 70, 70), idw1);
			GUI.Label (new Rect (140, 220, 300, 100), "同样愚蠢的，但是，已经装备有两把手枪，射击方向不同。 功能的武器是完全相同的一个经常愚蠢的。 这个角色就可以买到20敌人杀害，另外30个金币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 220, 100, 100), "愚蠢的(2)")) {
				if (unlock_id_2 == 1) {
					id = 2;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_2 == 1) {
				GUI.DrawTexture (new Rect (140, 330, 100, 20), est);
			}
			
			/// Волшебка
			
			if (unlock_id_3 == 0) {
				if (GUI.Button (new Rect (30, 470, 100, 20), "买")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 70;
									GDB.globalScore -= 60;
									GDB.redMoney -= 2;
									unlock_id_3 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char3", PlayerMenu.unlock_id_3);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 360, 100, 100), id2);
			GUI.DrawTexture (new Rect (560, 360, 30, 100), idw2);
			GUI.Label (new Rect (140, 360, 300, 100), "微笑的女巫(40人丧生的)。 巨大的射击造成的6点的损坏和瓦解在第一次接触。 火率是平均水平。 速度低于平均水平。 费用：60的敌人，70币和2红宝石和1水平。 为开放的水平。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 360, 100, 100), "女巫")) {
				if (unlock_id_3 == 1) {
					id = 3;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_3 == 1) {
				GUI.DrawTexture (new Rect (140, 470, 100, 20), est);
			}
			
			/// Волшебка 2
			
			if (unlock_id_4 == 0) {
				if (GUI.Button (new Rect (30, 610, 100, 20), "买")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_3 == 1) {
									if (GDB.levXp >= 1) {
										
										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_4 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char4", PlayerMenu.unlock_id_4);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 500, 30, 100), idw2);
			GUI.DrawTexture (new Rect (525, 500, 100, 100), id2);
			GUI.DrawTexture (new Rect (450, 520, 60, 60), idw2_1);
			GUI.Label (new Rect (140, 500, 300, 100), "需要1级。 除了所有的功能，具有一个屏蔽了环。 屏蔽小时防止任何损害。 它还需要时间来充电。 费用：40的敌人，70币和2红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 500, 100, 100), "女巫(2)")) {
				if (unlock_id_4 == 1) {
					id = 4;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_4 == 1) {
				GUI.DrawTexture (new Rect (140, 610, 100, 20), est);
			}
			
			/// Вампиряк
			
			if (unlock_id_5 == 0) {
				if (GUI.Button (new Rect (30, 750, 100, 20), "买")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 70;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_5 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char5", PlayerMenu.unlock_id_5);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 640, 30, 100), idw3);
			GUI.DrawTexture (new Rect (450, 640, 100, 100), id3);
			GUI.Label (new Rect (140, 640, 300, 100), "笑脸吸血鬼(20人的生命的)。 需要水平为0。 武装与重剑。 在密切的联系与敌人交易，3损害。 攻击速度不高。 一个相当快的角色。 费用：50的敌人70币和2红宝石。 仅于近战。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 640, 100, 100), "吸血鬼")) {
				if (unlock_id_5 == 1) {
					id = 5;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_5 == 1) {
				GUI.DrawTexture (new Rect (140, 750, 100, 20), est);
			}
			
			/// Вампиряк 2
			
			if (unlock_id_6 == 0) {
				if (GUI.Button (new Rect (30, 890, 100, 20), "买")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_5 == 1) {
									if (GDB.levXp >= 2) {
										
										GDB.coins -= 100;
										GDB.globalScore -= 60;
										GDB.redMoney -= 3;
										unlock_id_6 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char6", PlayerMenu.unlock_id_6);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (610, 780, 30, 100), idw3);
			GUI.DrawTexture (new Rect (500, 780, 100, 100), id3);
			GUI.DrawTexture (new Rect (450, 795, 50, 80), idw3_1);
			GUI.Label (new Rect (140, 780, 300, 100), "所需2级。 此外，所有特性的一个非常强和非常有用的能力，以吸生活。 对于每一个敌人被杀，的角色获得一个额外的10人的生命。 费用：60的敌人，100币和3红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 780, 100, 100), "吸血鬼(2)")) {
				if (unlock_id_6 == 1) {
					id = 6;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_6 == 1) {
				GUI.DrawTexture (new Rect (140, 890, 100, 20), est);
			}
			
			/// Святоша
			
			if (unlock_id_7 == 0) {
				if (GUI.Button (new Rect (30, 1030, 100, 20), "买")) {
					if (GDB.coins >= 60) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 2) {
								if (GDB.levXp >= 0) {
									
									GDB.coins -= 60;
									GDB.globalScore -= 50;
									GDB.redMoney -= 2;
									unlock_id_7 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char7", PlayerMenu.unlock_id_7);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 920, 35, 100), idw4);
			GUI.DrawTexture (new Rect (450, 920, 100, 100), id4);
			GUI.Label (new Rect (140, 920, 300, 100), "有一个良好的微笑(30生命的)。 需要水平为0。 不是一个快速性。 不是经常在平行会产生2快速箭(2破坏的)。 字符亮了该地区周围的黑暗的水平。 费用：50的敌人，60币和2红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 920, 100, 100), "神圣的")) {
				if (unlock_id_7 == 1) {
					id = 7;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_7 == 1) {
				GUI.DrawTexture (new Rect (140, 1030, 100, 20), est);
			}
			
			/// Святоша(2)
			if (unlock_id_8 == 0) {
				if (GUI.Button (new Rect (30, 1170, 100, 20), "买")) {
					if (GDB.coins >= 70) {
						if (GDB.globalScore >= 40) {
							if (GDB.redMoney >= 2) {
								if (unlock_id_7 == 1) {
									if (GDB.levXp >= 3) {
										
										GDB.coins -= 70;
										GDB.globalScore -= 40;
										GDB.redMoney -= 2;
										unlock_id_8 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char8", PlayerMenu.unlock_id_8);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (625, 1060, 35, 100), idw4);
			GUI.DrawTexture (new Rect (515, 1060, 100, 100), id4);
			GUI.DrawTexture (new Rect (450, 1070, 50, 80), idw4_1);
			GUI.Label (new Rect (140, 1060, 300, 100), "需要3级。 此外，标准字符产生4平行箭。 灯一个更广泛的区域。 费用：40的敌人，70币和2红宝石。 非常有角色在各级与贫穷的照明。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1060, 100, 100), "神圣的(2)")) {
				if (unlock_id_8 == 1) {
					id = 8;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_8 == 1) {
				GUI.DrawTexture (new Rect (140, 1170, 100, 20), est);
			}
			
			/// Панкрат
			
			if (unlock_id_9 == 0) {
				if (GUI.Button (new Rect (30, 1310, 100, 20), "买")) {
					if (GDB.coins >= 90) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 1) {
									
									GDB.coins -= 90;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_9 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char9", PlayerMenu.unlock_id_9);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 1230, 100, 30), idw5);
			GUI.DrawTexture (new Rect (450, 1200, 100, 100), id5);
			GUI.Label (new Rect (140, 1200, 300, 100), "笑脸庞克(30生命的)。 需要1级。 不快。 火灾散的小分(3单元损坏，从每个)。 只拍释放5炮弹。 它需要相当长的时间来充电。 费用：80敌人，90币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1200, 100, 100), "朋克")) {
				if (unlock_id_9 == 1) {
					id = 9;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_9 == 1) {
				GUI.DrawTexture (new Rect (140, 1310, 100, 20), est);
			}
			
			/// Панкрат(2)
			
			if (unlock_id_10 == 0) {
				if (GUI.Button (new Rect (30, 1450, 100, 20), "买")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_9 == 1) {
									if (GDB.levXp >= 4) {
										
										GDB.coins -= 120;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_10 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char10", PlayerMenu.unlock_id_10);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (610, 1370, 100, 30), idw5);
			GUI.DrawTexture (new Rect (500, 1340, 100, 100), id5);
			GUI.DrawTexture (new Rect (450, 1350, 40, 70), idw5_1);
			GUI.Label (new Rect (140, 1340, 300, 100), "所需级别4。 不同标准的性格有60人的生命。 武装与一个更强大的猎枪(发布了11炮弹每一枪). 这个角色所属的类别的强烈的字符。 费用：80敌人，120币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1340, 100, 100), "朋克(2)")) {
				if (unlock_id_10 == 1) {
					id = 10;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_10 == 1) {
				GUI.DrawTexture (new Rect (140, 1450, 100, 20), est);
			}
			
			/// Инжик
			
			if (unlock_id_11 == 0) {
				if (GUI.Button (new Rect (30, 1590, 100, 20), "买")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 90) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 3) {
									
									GDB.coins -= 140;
									GDB.globalScore -= 90;
									GDB.redMoney -= 8;
									unlock_id_11 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char11", PlayerMenu.unlock_id_11);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 1490, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 1480, 100, 100), id6);
			GUI.Label (new Rect (140, 1480, 300, 100), "微笑工程处(40人丧生的)。 需要3级。 快速性。 武装的非常迅速的发声，每个弹丸导致1单元的损坏。 这是一个坚强的性格甚至在开始的配置。 费用：90敌人，140币和8红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1480, 100, 100), "工程师")) {
				if (unlock_id_11 == 1) {
					id = 11;
					Application.LoadLevel ("Levelmenu");
				}
			}
			if (unlock_id_11 == 1) {
				GUI.DrawTexture (new Rect (140, 1590, 100, 20), est);
			}
			
			/// Инжик (2)
			
			if (unlock_id_12 == 0) {
				if (GUI.Button (new Rect (30, 1730, 100, 20), "买")) {
					if (GDB.coins >= 50) {
						if (GDB.globalScore >= 30) {
							if (GDB.redMoney >= 1) {
								if (unlock_id_11 == 1) {
									if (GDB.levXp >= 4) {
										
										GDB.coins -= 50;
										GDB.globalScore -= 30;
										GDB.redMoney -= 1;
										unlock_id_12 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char12", PlayerMenu.unlock_id_12);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 1630, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 1620, 100, 100), id6);
			GUI.DrawTexture (new Rect (450, 1620, 80, 100), idw6_1);
			GUI.Label (new Rect (140, 1620, 300, 100), "所需级别4。 此外，所有特征的标准的角色有能力建立牢固的墙壁。 不可或缺的当厚的敌人你想锁，所以他不会逃跑。 费用：30的敌人，50个硬币和1红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1620, 100, 100), "工程师(2)")) {
				if (unlock_id_12 == 1) {
					id = 12;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_12 == 1) {
				GUI.DrawTexture (new Rect (140, 1730, 100, 20), est);
			}
			
			/// Пикряк
			
			if (unlock_id_13 == 0) {
				if (GUI.Button (new Rect (30, 1870, 100, 20), "买")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (GDB.levXp >= 5) {
									
									GDB.coins -= 160;
									GDB.globalScore -= 100;
									GDB.redMoney -= 6;
									unlock_id_13 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char13", PlayerMenu.unlock_id_13);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (545, 1780, 85, 55), idw7);
			GUI.DrawTexture (new Rect (450, 1760, 100, 100), id7);
			GUI.Label (new Rect (140, 1760, 300, 100), "С笑脸-海盗(30生命的)。 所需要的水平5. 足够灵活性。 有了强大的柯尔特那交易12点的损害的每一枪。 率不高。 费用：100敌人，160币和6红宝石。 用于战斗的厚皮动物.", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1760, 100, 100), "海盗")) {
				if (unlock_id_13 == 1) {
					id = 13;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_13 == 1) {
				GUI.DrawTexture (new Rect (140, 1870, 100, 20), est);
			}
			
			/// Пикряк (2)
			
			if (unlock_id_14 == 0) {
				if (GUI.Button (new Rect (30, 2010, 100, 20), "买")) {
					if (GDB.coins >= 100) {
						if (GDB.globalScore >= 50) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_13 == 1) {
									if (GDB.levXp >= 6) {
										
										GDB.coins -= 100;
										GDB.globalScore -= 50;
										GDB.redMoney -= 3;
										unlock_id_14 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char14", PlayerMenu.unlock_id_14);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (625, 1920, 85, 55), idw7);
			GUI.DrawTexture (new Rect (530, 1900, 100, 100), id7);
			GUI.DrawTexture (new Rect (450, 1920, 85, 55), idw7_1);
			GUI.Label (new Rect (140, 1900, 300, 100), "所需要的水平6. 不同的标准字符武装的两支手枪射在不同的方向(也因为12点的损坏的)。 另外有60人的生命。 费用：50的敌人，100币和3红宝石。 双倍的效益。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 1900, 100, 100), "海盗(2)")) {
				if (unlock_id_14 == 1) {
					id = 14;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_14 == 1) {
				GUI.DrawTexture (new Rect (140, 2010, 100, 20), est);
			}
			
			/// Книжлок
			
			if (unlock_id_15 == 0) {
				if (GUI.Button (new Rect (30, 2150, 100, 20), "买")) {
					if (GDB.coins >= 80) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 7) {
									
									GDB.coins -= 80;
									GDB.globalScore -= 100;
									GDB.redMoney -= 7;
									unlock_id_15 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char15", PlayerMenu.unlock_id_15);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (540, 2040, 30, 100), idw8);
			GUI.DrawTexture (new Rect (450, 2040, 100, 100), id8);
			GUI.Label (new Rect (140, 2040, 300, 100), "笑脸-术士(40人丧生的)。 需要水平7. 快。 通常会产生两大电荷的魔法在相反的方向，造成7点的损坏(销毁在触摸)。 费用：80敌人，100币和7红宝石。 开放的区域。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2040, 100, 100), "术士")) {
				if (unlock_id_15 == 1) {
					id = 15;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_15 == 1) {
				GUI.DrawTexture (new Rect (140, 2150, 100, 20), est);
			}
			
			/// Книжлок (2)
			
			if (unlock_id_16 == 0) {
				if (GUI.Button (new Rect (30, 2290, 100, 20), "买")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 3) {
								if (unlock_id_15 == 1) {
									if (GDB.levXp >= 8) {
										
										GDB.coins -= 140;
										GDB.globalScore -= 80;
										GDB.redMoney -= 3;
										unlock_id_16 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char16", PlayerMenu.unlock_id_16);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 2180, 30, 100), idw8);
			GUI.DrawTexture (new Rect (510, 2180, 100, 100), id8);
			GUI.DrawTexture (new Rect (450, 2190, 60, 80), idw8_1);
			GUI.Label (new Rect (140, 2180, 300, 100), "需要的水平8. 此外，所有特征有能力激活一个屏蔽，以防止任何损害期间的平均时间。 漂亮的快速充电。 费用：80敌人，140币和3红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2180, 100, 100), "术士(2)")) {
				if (unlock_id_16 == 1) {
					id = 16;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_16 == 1) {
				GUI.DrawTexture (new Rect (140, 2290, 100, 20), est);
			}
			
			/// Мазюк
			
			if (unlock_id_17 == 0) {
				if (GUI.Button (new Rect (30, 2430, 100, 20), "买")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 5) {
									
									GDB.coins -= 160;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_17 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char17", PlayerMenu.unlock_id_17);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (550, 2340, 70, 70), idw9);
			GUI.DrawTexture (new Rect (450, 2320, 100, 100), id9);
			GUI.Label (new Rect (140, 2320, 300, 100), "笑艺术家(40人丧生的)。 所需要的水平5. 平均速度的漏水坑。 如果池命一个敌人，它接收到20点的损害。 快速性。 费用：80敌人，160币和4红宝石。 有用的水平上有很多的建筑物。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2320, 100, 100), "艺术家")) {
				if (unlock_id_17 == 1) {
					id = 17;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_17 == 1) {
				GUI.DrawTexture (new Rect (140, 2430, 100, 20), est);
			}
			
			/// Мазюк (2)
			
			if (unlock_id_18 == 0) {
				if (GUI.Button (new Rect (30, 2570, 100, 20), "买")) {
					if (GDB.coins >= 120) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_17 == 1) {
									if (GDB.levXp >= 7) {
										
										GDB.coins -= 120;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_18 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char18", PlayerMenu.unlock_id_18);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 2480, 70, 70), idw9);
			GUI.DrawTexture (new Rect (525, 2460, 100, 100), id9);
			GUI.DrawTexture (new Rect (450, 2470, 80, 80), idw9_1);
			GUI.Label (new Rect (140, 2460, 300, 100), "需要水平7. 具有显着的改善，比一个标准字符。 有一个非常高的速度。 有80人的生命。 经常泄漏的污点。 费用：60的敌人，120币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2460, 100, 100), "艺术家(2)")) {
				if (unlock_id_18 == 1) {
					id = 18;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_18 == 1) {
				GUI.DrawTexture (new Rect (140, 2570, 100, 20), est);
			}
			
			/// Тамада
			
			if (unlock_id_19 == 0) {
				if (GUI.Button (new Rect (30, 2710, 100, 20), "买")) {
					if (GDB.coins >= 140) {
						if (GDB.globalScore >= 70) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 4) {
									
									GDB.coins -= 140;
									GDB.globalScore -= 70;
									GDB.redMoney -= 4;
									unlock_id_19 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char19", PlayerMenu.unlock_id_19);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2620, 70, 70), idw1);
			GUI.DrawTexture (new Rect (450, 2600, 100, 100), id10);
			GUI.Label (new Rect (140, 2600, 300, 100), "假笑(40人丧生的)。 所需级别4。 武装与传统的枪。 不快。 有能力定期创建傻了，偶尔投掷石块(造成8点的损坏的敌人). 费用：70敌人，140币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2600, 100, 100), "假日")) {
				if (unlock_id_19 == 1) {
					id = 19;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_19 == 1) {
				GUI.DrawTexture (new Rect (140, 2710, 100, 20), est);
			}
			
			/// Тамада (2)
			
			if (unlock_id_20 == 0) {
				if (GUI.Button (new Rect (30, 2850, 100, 20), "买")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_19 == 1) {
									if (GDB.levXp >= 6) {
										
										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_20 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char20", PlayerMenu.unlock_id_20);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2760, 90, 70), idw7);
			GUI.DrawTexture (new Rect (450, 2740, 100, 100), id10);
			GUI.Label (new Rect (140, 2740, 300, 100), "所需要的水平6. 不同标准的性格有80人的生命。 有一高速度。 武装柯尔特。 往往造成愚蠢的(多个)，这是适用于16点的损害。 费用：80敌人，160币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2740, 100, 100), "假日(2)")) {
				if (unlock_id_20 == 1) {
					id = 20;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_20 == 1) {
				GUI.DrawTexture (new Rect (140, 2850, 100, 20), est);
			}
			
			/// Зомбик
			
			if (unlock_id_21 == 0) {
				if (GUI.Button (new Rect (30, 2990, 100, 20), "买")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (GDB.levXp >= 6) {
									
									GDB.coins -= 200;
									GDB.globalScore -= 140;
									GDB.redMoney -= 8;
									unlock_id_21 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char21", PlayerMenu.unlock_id_21);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 2880, 30, 100), idw11);
			GUI.DrawTexture (new Rect (450, 2880, 100, 100), id11);
			GUI.Label (new Rect (140, 2880, 300, 100), "微笑-僵尸(120生活中)。 所需要的水平6. 慢。 武装与一个缓慢的剑(12损害在近战中)。 费用：140敌人，200币和8红宝石。 几乎不朽由于大量的生命。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 2880, 100, 100), "僵尸")) {
				if (unlock_id_21 == 1) {
					id = 21;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_21 == 1) {
				GUI.DrawTexture (new Rect (140, 2990, 100, 20), est);
			}
			
			/// Зомбик (2)
			
			if (unlock_id_22 == 0) {
				if (GUI.Button (new Rect (30, 3130, 100, 20), "买")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 140) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_21 == 1) {
									if (GDB.levXp >= 9) {
										
										GDB.coins -= 220;
										GDB.globalScore -= 140;
										GDB.redMoney -= 8;
										unlock_id_22 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char22", PlayerMenu.unlock_id_22);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 3020, 30, 100), idw11);
			GUI.DrawTexture (new Rect (530, 3020, 100, 100), id11);
			GUI.DrawTexture (new Rect (450, 3030, 70, 70), idw11_1);
			GUI.Label (new Rect (140, 3020, 300, 100), "需要水平9. 明显不同的标准字符。 有240人的生命。 有能力的盾牌，定期保护你免受任何损害。 照亮黑暗的水平。 费用：140敌人，220币和8红宝石。 坚强的性格。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3020, 100, 100), "僵尸(2)")) {
				if (unlock_id_22 == 1) {
					id = 22;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_22 == 1) {
				GUI.DrawTexture (new Rect (140, 3130, 100, 20), est);
			}
			
			/// Футуря
			
			if (unlock_id_23 == 0) {
				if (GUI.Button (new Rect (30, 3270, 100, 20), "买")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 7) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 80;
									GDB.redMoney -= 7;
									unlock_id_23 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char23", PlayerMenu.unlock_id_23);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (550, 3170, 80, 70), idw12);
			GUI.DrawTexture (new Rect (450, 3160, 100, 100), id12);
			GUI.Label (new Rect (140, 3160, 300, 100), "笑脸从未来(50人死亡). 需要10级。 快。 武装有激光器(很快射弹)，涉及15个单位的损害。 费用：80敌人，220币和7红宝石。 有效的，在任何情况下和在任何级别。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3160, 100, 100), "未来")) {
				if (unlock_id_23 == 1) {
					id = 23;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_23 == 1) {
				GUI.DrawTexture (new Rect (140, 3270, 100, 20), est);
			}
			
			/// Футуря (2)
			
			if (unlock_id_24 == 0) {
				if (GUI.Button (new Rect (30, 3410, 100, 20), "买")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 60) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_23 == 1) {
									if (GDB.levXp >= 12) {
										
										GDB.coins -= 180;
										GDB.globalScore -= 60;
										GDB.redMoney -= 4;
										unlock_id_24 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char24", PlayerMenu.unlock_id_24);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 3310, 80, 70), idw12);
			GUI.DrawTexture (new Rect (540, 3300, 100, 100), id12);
			GUI.DrawTexture (new Rect (450, 3310, 80, 70), idw12_1);
			GUI.Label (new Rect (140, 3300, 300, 100), "所需要的水平12. 双重的更有效的标准对口由于这一事实，即它具有另一种激光射击的方向相反。 特性是相同的。 费用：60的敌人，180币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3300, 100, 100), "未来(2)")) {
				if (unlock_id_24 == 1) {
					id = 24;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_24 == 1) {
				GUI.DrawTexture (new Rect (140, 3410, 100, 20), est);
			}
			
			/// Ворюга
			
			if (unlock_id_25 == 0) {
				if (GUI.Button (new Rect (30, 3550, 100, 20), "买")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 7) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 100;
									GDB.redMoney -= 9;
									unlock_id_25 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char25", PlayerMenu.unlock_id_24);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3470, 100, 40), idw5);
			GUI.DrawTexture (new Rect (450, 3440, 100, 100), id13);
			GUI.Label (new Rect (140, 3440, 300, 100), "微笑贼(40人丧生的)。 需要水平7. 足够灵活的。 武装弱的猎枪。 有能力找到更多的硬币(铂硬币价值的五金)比其他人物。 费用：100敌人，220币和9红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3440, 100, 100), "小偷")) {
				if (unlock_id_25 == 1) {
					id = 25;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_25 == 1) {
				GUI.DrawTexture (new Rect (140, 3550, 100, 20), est);
			}
			
			/// Ворюга (2)
			
			if (unlock_id_26 == 0) {
				if (GUI.Button (new Rect (30, 3690, 100, 20), "买")) {
					if (GDB.coins >= 240) {
						if (GDB.globalScore >= 130) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_25 == 1) {
									if (GDB.levXp >= 8) {
										
										GDB.coins -= 240;
										GDB.globalScore -= 130;
										GDB.redMoney -= 7;
										unlock_id_26 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char26", PlayerMenu.unlock_id_26);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3580, 80, 80), idw6);
			GUI.DrawTexture (new Rect (450, 3580, 100, 100), id13);
			GUI.Label (new Rect (140, 3580, 300, 100), "需要的水平8. 不同于标准的角色，装有一个非常迅速的火乌兹，而不是常规的猎枪。 其它特性保持不变。 费用：130的敌人，240币和7红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3580, 100, 100), "小偷(2)")) {
				if (unlock_id_26 == 1) {
					id = 26;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_26 == 1) {
				GUI.DrawTexture (new Rect (140, 3690, 100, 20), est);
			}
			
			/// Няшка
			
			if (unlock_id_27 == 0) {
				if (GUI.Button (new Rect (30, 3830, 100, 20), "买")) {
					if (GDB.coins >= 220) {
						if (GDB.globalScore >= 120) {
							if (GDB.redMoney >= 10) {
								if (GDB.levXp >= 11) {
									
									GDB.coins -= 220;
									GDB.globalScore -= 120;
									GDB.redMoney -= 10;
									unlock_id_27 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char27", PlayerMenu.unlock_id_27);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 3720, 30, 100), idw14);
			GUI.DrawTexture (new Rect (450, 3720, 100, 100), id14);
			GUI.Label (new Rect (140, 3720, 300, 100), "笑脸-蝴蝶(40人丧生的)。 所需要的水平11. 速度非常快。 平均速度为4中产生的一个巨大的炮弹(角90度)，在不同的方向(南乌特9点的损坏的)。 费用：120敌人，220币和10红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3720, 100, 100), "温柔")) {
				if (unlock_id_27 == 1) {
					id = 27;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_27 == 1) {
				GUI.DrawTexture (new Rect (140, 3830, 100, 20), est);
			}
			
			/// Няшка (2)
			
			if (unlock_id_28 == 0) {
				if (GUI.Button (new Rect (30, 3970, 100, 20), "买")) {
					if (GDB.coins >= 160) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_27 == 1) {
									if (GDB.levXp >= 13) {
										
										GDB.coins -= 160;
										GDB.globalScore -= 80;
										GDB.redMoney -= 6;
										unlock_id_28 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char28", PlayerMenu.unlock_id_28);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 3860, 30, 100), idw14);
			GUI.DrawTexture (new Rect (520, 3860, 100, 100), id14);
			GUI.DrawTexture (new Rect (450, 3870, 50, 80), idw14_1);
			GUI.Label (new Rect (140, 3860, 300, 100), "需要级别的13人。 不同于标准的角色，都有疯狂的速度。 还有能力屏蔽(防止任何破坏的)。 屏蔽的长期住宿，但是充太长。 费用：80敌人，160币和6红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 3860, 100, 100), "温柔(2)")) {
				if (unlock_id_28 == 1) {
					id = 28;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_28 == 1) {
				GUI.DrawTexture (new Rect (140, 3970, 100, 20), est);
			}
			
			/// Бомбер
			
			if (unlock_id_29 == 0) {
				if (GUI.Button (new Rect (30, 4110, 100, 20), "买")) {
					if (GDB.coins >= 150) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 150;
									GDB.globalScore -= 80;
									GDB.redMoney -= 4;
									unlock_id_29 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char29", PlayerMenu.unlock_id_29);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4010, 50, 80), idw15);
			GUI.DrawTexture (new Rect (450, 4000, 100, 100), id15);
			GUI.Label (new Rect (140, 4000, 300, 100), "微笑炸弹(40人丧生的)。 需要10级。 不是很快。 周期性爆炸(10损坏的)。 能力：周期性地创建了炸药是创建一系列的爆炸(10点的损坏的)。 费用：80敌人，150币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4000, 100, 100), "炸弹")) {
				if (unlock_id_29 == 1) {
					id = 29;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_29 == 1) {
				GUI.DrawTexture (new Rect (140, 4110, 100, 20), est);
			}
			
			/// Бомбер (2)
			
			if (unlock_id_30 == 0) {
				if (GUI.Button (new Rect (30, 4250, 100, 20), "买")) {
					if (GDB.coins >= 180) {
						if (GDB.globalScore >= 80) {
							if (GDB.redMoney >= 4) {
								if (unlock_id_29 == 1) {
									if (GDB.levXp >= 12) {
										
										GDB.coins -= 180;
										GDB.globalScore -= 80;
										GDB.redMoney -= 4;
										unlock_id_30 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char30", PlayerMenu.unlock_id_30);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (640, 4150, 50, 80), idw15);
			GUI.DrawTexture (new Rect (530, 4140, 100, 100), id15);
			GUI.DrawTexture (new Rect (450, 4150, 50, 80), idw15);
			GUI.Label (new Rect (140, 4140, 300, 100), "所需要的水平12. 快一点比他的标准字符。 超过两次作为经常创造的炸药的。 所有其他特性不同的标准版本。 费用：80敌人，180币和4红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4140, 100, 100), "炸弹(2)")) {
				if (unlock_id_30 == 1) {
					id = 30;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_30 == 1) {
				GUI.DrawTexture (new Rect (140, 4250, 100, 20), est);
			}
			
			/// Терминат
			
			if (unlock_id_31 == 0) {
				if (GUI.Button (new Rect (30, 4390, 100, 20), "买")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 14) {
									
									GDB.coins -= 400;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_31 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char31", PlayerMenu.unlock_id_31);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4300, 100, 70), idw16);
			GUI.DrawTexture (new Rect (450, 4280, 100, 100), id16);
			GUI.Label (new Rect (140, 4280, 300, 100), "这个终结者(80生活中)。 需要水平14. 不快。 火箭炮发射一枚导弹，涉及30损害的碰撞，并创建一系列的爆炸(10损害每个)。 费用：200敌人，400币和15红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4280, 100, 100), "终结者")) {
				if (unlock_id_31 == 1) {
					id = 31;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_31 == 1) {
				GUI.DrawTexture (new Rect (140, 4390, 100, 20), est);
			}
			
			/// Терминат (2)
			
			if (unlock_id_32 == 0) {
				if (GUI.Button (new Rect (30, 4530, 100, 20), "买")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_31 == 1) {
									if (GDB.levXp >= 16) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 15;
										unlock_id_32 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char32", PlayerMenu.unlock_id_32);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4420, 110, 80), idw16_1);
			GUI.DrawTexture (new Rect (450, 4420, 100, 100), id16);
			GUI.Label (new Rect (140, 4420, 300, 100), "所需要的水平16. 不像他的同胞装有一挺机关枪，谁也产生了4颗子弹(每个交易损坏的1个单元)。 只要可笑的快速射击武器。 一个非常坚强的性格。 费用：200敌人，400币和15红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4420, 100, 100), "终结者(2)")) {
				if (unlock_id_32 == 1) {
					id = 32;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_32 == 1) {
				GUI.DrawTexture (new Rect (140, 4530, 100, 20), est);
			}
			
			/// Злючка
			
			if (unlock_id_33 == 0) {
				if (GUI.Button (new Rect (30, 4670, 100, 20), "买")) {
					if (GDB.coins >= 420) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 12) {
								if (GDB.levXp >= 15) {
									
									GDB.coins -= 420;
									GDB.globalScore -= 200;
									GDB.redMoney -= 12;
									unlock_id_33 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char33", PlayerMenu.unlock_id_33);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4560, 30, 100), idw17);
			GUI.DrawTexture (new Rect (450, 4560, 100, 100), id17);
			GUI.Label (new Rect (140, 4560, 300, 100), "笑魔鬼(70的生活条)。 所需的水平15. 快。 发布了一个火球大于平均在所有方向的角度45度(5点的损坏的)。 费用：200敌人，420币和12红宝石。 作为任何魔术师更有用在开放的水平。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4560, 100, 100), "邪恶的")) {
				if (unlock_id_33 == 1) {
					id = 33;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_33 == 1) {
				GUI.DrawTexture (new Rect (140, 4670, 100, 20), est);
			}
			
			/// Злючка (2)
			
			if (unlock_id_34 == 0) {
				if (GUI.Button (new Rect (30, 4810, 100, 20), "买")) {
					if (GDB.coins >= 200) {
						if (GDB.globalScore >= 100) {
							if (GDB.redMoney >= 6) {
								if (unlock_id_33 == 1) {
									if (GDB.levXp >= 17) {
										
										GDB.coins -= 200;
										GDB.globalScore -= 100;
										GDB.redMoney -= 6;
										unlock_id_34 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char34", PlayerMenu.unlock_id_34);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 4700, 30, 100), idw17);
			GUI.DrawTexture (new Rect (510, 4700, 100, 100), id17);
			GUI.DrawTexture (new Rect (450, 4710, 50, 90), idw17_1);
			GUI.Label (new Rect (140, 4700, 300, 100), "需要水平的17. 不同之处在于它具有一种屏蔽可防止所有损害很长一段时间。 费太长时间。 其他特性不同的标准字符。 费用：100敌人，200币和6红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4700, 100, 100), "邪恶的(2)")) {
				if (unlock_id_34 == 1) {
					id = 34;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_34 == 1) {
				GUI.DrawTexture (new Rect (140, 4810, 100, 20), est);
			}
			
			/// Нюнзяка
			
			if (unlock_id_35 == 0) {
				if (GUI.Button (new Rect (30, 4950, 100, 20), "买")) {
					if (GDB.coins >= 500) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 20) {
								if (GDB.levXp >= 17) {
									
									GDB.coins -= 500;
									GDB.globalScore -= 200;
									GDB.redMoney -= 20;
									unlock_id_35 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char35", PlayerMenu.unlock_id_35);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 4840, 30, 100), idw18);
			GUI.DrawTexture (new Rect (450, 4840, 100, 100), id18);
			GUI.Label (new Rect (140, 4840, 300, 100), "笑脸-忍者(70的生活条)。 需要水平的17. 速度非常快。 武装与武士刀，涉及20点的损坏(足够迅速的武器). 费用：200敌人,500币和20红宝石。 有效的，在任何情况。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4840, 100, 100), "忍者")) {
				if (unlock_id_35 == 1) {
					id = 35;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_35 == 1) {
				GUI.DrawTexture (new Rect (140, 4950, 100, 20), est);
			}
			
			///Нюнзяка (2)
			
			if (unlock_id_36 == 0) {
				if (GUI.Button (new Rect (30, 5090, 100, 20), "买")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 15) {
								if (unlock_id_35 == 1) {
									if (GDB.levXp >= 22) {
										
										GDB.coins -= 450;
										GDB.globalScore -= 150;
										GDB.redMoney -= 15;
										unlock_id_36 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char36", PlayerMenu.unlock_id_36);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 4980, 30, 100), idw18);
			GUI.DrawTexture (new Rect (520, 4980, 100, 100), id18);
			GUI.DrawTexture (new Rect (450, 4990, 70, 70), idw18_1);
			GUI.Label (new Rect (140, 4980, 300, 100), "所需要的水平22. 不同于其的标准的变另外产生4飞镖一个相当快的速度在不同的方向(导致20点的损害每个)。 费用：150敌人，450币和15红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 4980, 100, 100), "忍者(2)")) {
				if (unlock_id_36 == 1) {
					id = 36;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_36 == 1) {
				GUI.DrawTexture (new Rect (140, 5090, 100, 20), est);
			}
			
			/// Гламурка
			
			if (unlock_id_37 == 0) {
				if (GUI.Button (new Rect (30, 5230, 100, 20), "买")) {
					if (GDB.coins >= 600) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 15) {
								if (GDB.levXp >= 18) {
									
									GDB.coins -= 600;
									GDB.globalScore -= 200;
									GDB.redMoney -= 15;
									unlock_id_37 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char37", PlayerMenu.unlock_id_37);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5120, 30, 100), idw19);
			GUI.DrawTexture (new Rect (450, 5120, 100, 100), id19);
			GUI.Label (new Rect (140, 5120, 300, 100), "强悍的笑(70的生活条)。 所需要的水平18. 快。 洋葱生产的并行4-快箭(15损害每个)。 有能力创造泡沫(8泡立即). 费用：200敌人，600币和15红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5120, 100, 100), "魅力")) {
				if (unlock_id_37 == 1) {
					id = 37;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_37 == 1) {
				GUI.DrawTexture (new Rect (140, 5230, 100, 20), est);
			}
			
			/// Гламурка (2)
			
			if (unlock_id_38 == 0) {
				if (GUI.Button (new Rect (30, 5370, 100, 20), "买")) {
					if (GDB.coins >= 330) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_37 == 1) {
									if (GDB.levXp >= 20) {
										
										GDB.coins -= 330;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_38 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char38", PlayerMenu.unlock_id_38);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (600, 5260, 30, 100), idw19);
			GUI.DrawTexture (new Rect (490, 5260, 100, 100), id19);
			GUI.DrawTexture (new Rect (450, 5260, 30, 100), idw19_1);
			GUI.Label (new Rect (140, 5260, 300, 100), "所需要的水平20. 不同于标准在于，它有一个第二相同的弓射击的方向相反。 还能够创造泡沫的快两倍。 费用：200敌人，330币和10红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5260, 100, 100), "魅力(2)")) {
				if (unlock_id_38 == 1) {
					id = 38;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_38 == 1) {
				GUI.DrawTexture (new Rect (140, 5370, 100, 20), est);
			}
			
			/// Мафик
			
			if (unlock_id_39 == 0) {
				if (GUI.Button (new Rect (30, 5510, 100, 20), "买")) {
					if (GDB.coins >= 350) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 13) {
								if (GDB.levXp >= 19) {
									
									GDB.coins -= 350;
									GDB.globalScore -= 200;
									GDB.redMoney -= 13;
									unlock_id_39 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char39", PlayerMenu.unlock_id_39);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5430, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 5400, 100, 100), id20);
			GUI.Label (new Rect (140, 5400, 300, 100), "笑脸-黑手党(70的生活条)。 所需要的水平19. 相当灵活。 武装快速火M16(每个子弹的交易8点的损坏的)。 其他的能力是没有的。 费用：200敌人，350币和13红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5400, 100, 100), "黑手党")) {
				if (unlock_id_39 == 1) {
					id = 39;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_39 == 1) {
				GUI.DrawTexture (new Rect (140, 5510, 100, 20), est);
			}
			
			/// Мафик (2)
			
			if (unlock_id_40 == 0) {
				if (GUI.Button (new Rect (30, 5650, 100, 20), "买")) {
					if (GDB.coins >= 250) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 7) {
								if (unlock_id_39 == 1) {
									if (GDB.levXp >= 21) {
										
										GDB.coins -= 250;
										GDB.globalScore -= 200;
										GDB.redMoney -= 7;
										unlock_id_40 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char40", PlayerMenu.unlock_id_40);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 5570, 100, 50), idw20);
			GUI.DrawTexture (new Rect (530, 5540, 100, 100), id20);
			GUI.DrawTexture (new Rect (450, 5550, 70, 70), idw20_1); 
			GUI.Label (new Rect (140, 5540, 300, 100), "需要水平21. 不同之处在于，它有一个非常有效的能力，以找到级别更多的硬币。 更多的硬币。 其他特点都是相同的。 费用：200敌人，250币和7红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5540, 100, 100), "黑手党(2)")) {
				if (unlock_id_40 == 1) {
					id = 40;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_40 == 1) {
				GUI.DrawTexture (new Rect (140, 5650, 100, 20), est);
			}
			
			/// Скайфай
			
			if (unlock_id_41 == 0) {
				if (GUI.Button (new Rect (30, 5790, 100, 20), "买")) {
					if (GDB.coins >= 680) {
						if (GDB.globalScore >= 220) {
							if (GDB.redMoney >= 17) {
								if (GDB.levXp >= 24) {
									
									GDB.coins -= 680;
									GDB.globalScore -= 220;
									GDB.redMoney -= 17;
									unlock_id_41 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char41", PlayerMenu.unlock_id_41);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5710, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 5680, 100, 100), id21);
			GUI.Label (new Rect (140, 5680, 300, 100), "微笑来自未来(生活的70). 需要水平24. 武装快速冲击波。 非常快速射击造成11点的损害。 具有良好的速度。 费用：220敌人,680币和17红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5680, 100, 100), "科幻")) {
				if (unlock_id_41 == 1) {
					id = 41;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_41 == 1) {
				GUI.DrawTexture (new Rect (140, 5790, 100, 20), est);
			}
			
			/// Скайфай (2)
			
			if (unlock_id_42 == 0) {
				if (GUI.Button (new Rect (30, 5930, 100, 20), "买")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 150) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_41 == 1) {
									if (GDB.levXp >= 26) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 150;
										GDB.redMoney -= 8;
										unlock_id_42 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char42", PlayerMenu.unlock_id_42);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (620, 5850, 100, 50), idw21);
			GUI.DrawTexture (new Rect (510, 5820, 100, 100), id21);
			GUI.DrawTexture (new Rect (450, 5820, 40, 90), idw21_1);
			GUI.Label (new Rect (140, 5820, 300, 100), "需要水平26. 不同于标准字符，有一个屏蔽，以防止一切损失。 屏蔽休息时间很短，但再充电的速度非常快。 照亮黑暗的水平。 费用：150敌人，400币和8红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5820, 100, 100), "科幻(2)")) {
				if (unlock_id_42 == 1) {
					id = 42;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_42 == 1) {
				GUI.DrawTexture (new Rect (140, 5930, 100, 20), est);
			}
			
			/// Марсюк
			
			if (unlock_id_43 == 0) {
				if (GUI.Button (new Rect (30, 6070, 100, 20), "买")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 33) {
									
									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_43 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char43", PlayerMenu.unlock_id_43);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 5970, 120, 80), idw22);
			GUI.DrawTexture (new Rect (450, 5960, 100, 100), id22);
			GUI.Label (new Rect (140, 5960, 300, 100), "笑脸-火星(100生命的)。 所需要的水平33. 快。 武装快速的多波束激光(3束，每个涉及的10点的损坏的)。 费用：300敌人，900币和40红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 5960, 100, 100), "火星")) {
				if (unlock_id_43 == 1) {
					id = 43;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_43 == 1) {
				GUI.DrawTexture (new Rect (140, 6070, 100, 20), est);
			}
			
			/// Марсюк (2)
			
			if (unlock_id_44 == 0) {
				if (GUI.Button (new Rect (30, 6210, 100, 20), "买")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (unlock_id_43 == 1) {
									if (GDB.levXp >= 39) {
										
										GDB.coins -= 900;
										GDB.globalScore -= 300;
										GDB.redMoney -= 40;
										unlock_id_44 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char44", PlayerMenu.unlock_id_44);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6120, 120, 80), idw22_1);
			GUI.DrawTexture (new Rect (450, 6100, 100, 100), id22);
			GUI.Label (new Rect (140, 6100, 300, 100), "需要水平39. 武装与更强大武器的迅速火的多波束激光(也3束，但各束会的20点的损坏的)。 其他特点都是相同的。 费用：300敌人，900币和40红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6100, 100, 100), "火星(2)")) {
				if (unlock_id_44 == 1) {
					id = 44;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_44 == 1) {
				GUI.DrawTexture (new Rect (140, 6210, 100, 20), est);
			}
			
			/// Роктер
			
			if (unlock_id_45 == 0) {
				if (GUI.Button (new Rect (30, 6350, 100, 20), "买")) {
					if (GDB.coins >= 300) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 9) {
								if (GDB.levXp >= 22) {
									
									GDB.coins -= 300;
									GDB.globalScore -= 200;
									GDB.redMoney -= 9;
									unlock_id_45 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char45", PlayerMenu.unlock_id_45);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6270, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 6240, 100, 100), id23);
			GUI.Label (new Rect (140, 6240, 300, 100), "微笑-摇(70的生活条)。 所需要的水平22. 武装带M16(8损害每一枪). 快。 经常拍摄时在不同的方向来自的方向射击产生注意到，阻碍敌人。 费用：200敌人，300币和9红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6240, 100, 100), "摇")) {
				if (unlock_id_45 == 1) {
					id = 45;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_45 == 1) {
				GUI.DrawTexture (new Rect (140, 6350, 100, 20), est);
			}
			
			/// Роктер (2)
			
			if (unlock_id_46 == 0) {
				if (GUI.Button (new Rect (30, 6490, 100, 20), "买")) {
					if (GDB.coins >= 550) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 8) {
								if (unlock_id_45 == 1) {
									if (GDB.levXp >= 27) {
										
										GDB.coins -= 550;
										GDB.globalScore -= 200;
										GDB.redMoney -= 8;
										unlock_id_46 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char46", PlayerMenu.unlock_id_46);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6410, 100, 50), idw21);
			GUI.DrawTexture (new Rect (450, 6380, 100, 100), id23);
			GUI.Label (new Rect (140, 6380, 300, 100), "需要水平27. 同样摇的。 唯一的区别是，武装与更强大的武器-快-发射冲击波(造成11点的损害的每一枪). 费用：200敌人，550币和8红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6380, 100, 100), "摇(2)")) {
				if (unlock_id_46 == 1) {
					id = 46;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_46 == 1) {
				GUI.DrawTexture (new Rect (140, 6490, 100, 20), est);
			}
			
			/// Бигбосс
			
			if (unlock_id_47 == 0) {
				if (GUI.Button (new Rect (30, 6630, 100, 20), "买")) {
					if (GDB.coins >= 410) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 23) {
								if (GDB.levXp >= 10) {
									
									GDB.coins -= 410;
									GDB.globalScore -= 190;
									GDB.redMoney -= 10;
									unlock_id_47 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char47", PlayerMenu.unlock_id_47);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6540, 100, 60), idw24);
			GUI.DrawTexture (new Rect (450, 6520, 100, 100), id24);
			GUI.Label (new Rect (140, 6520, 300, 100), "微笑老大(80生活中)。 所需要的水平20. 不快。 武装带榴弹发射器(手榴弹交易30点的损害和爆炸的一系列爆炸，涉及10点的损坏的)。 费用：190敌人，410币和10红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6520, 100, 100), "大老板")) {
				if (unlock_id_47 == 1) {
					id = 47;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_47 == 1) {
				GUI.DrawTexture (new Rect (140, 6630, 100, 20), est);
			}
			
			/// Бигбосс (2)
			
			if (unlock_id_48 == 0) {
				if (GUI.Button (new Rect (30, 6770, 100, 20), "买")) {
					if (GDB.coins >= 450) {
						if (GDB.globalScore >= 190) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_47 == 1) {
									if (GDB.levXp >= 22) {
										
										GDB.coins -= 450;
										GDB.globalScore -= 190;
										GDB.redMoney -= 10;
										unlock_id_48 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char48", PlayerMenu.unlock_id_48);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 6660, 100, 60), idw24);
			GUI.DrawTexture (new Rect (530, 6660, 100, 100), id24);
			GUI.DrawTexture (new Rect (450, 6670, 70, 70), idw20_1);
			GUI.Label (new Rect (140, 6660, 300, 100), "所需要的水平22. 不同于标准字符的能力，感谢它能够水平，以寻找额外的硬币。 其他的差异，从标准的角色没有。 费用：190敌人，450币和10红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6660, 100, 100), "大老板(2)")) {
				if (unlock_id_48 == 1) {
					id = 48;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_48 == 1) {
				GUI.DrawTexture (new Rect (140, 6770, 100, 20), est);
			}
			
			/// Космос
			
			if (unlock_id_49 == 0) {
				if (GUI.Button (new Rect (30, 6910, 100, 20), "买")) {
					if (GDB.coins >= 900) {
						if (GDB.globalScore >= 300) {
							if (GDB.redMoney >= 40) {
								if (GDB.levXp >= 38) {
									
									GDB.coins -= 900;
									GDB.globalScore -= 300;
									GDB.redMoney -= 40;
									unlock_id_49 = 1;
									PlayerPrefs.SetInt ("score", GDB.globalScore);
									PlayerPrefs.SetInt ("ruby", GDB.redMoney);
									PlayerPrefs.SetInt ("coin", GDB.coins);
									PlayerPrefs.SetInt ("char49", PlayerMenu.unlock_id_49);
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 6820, 90, 60), idw25);
			GUI.DrawTexture (new Rect (450, 6800, 110, 100), id25);
			GUI.Label (new Rect (140, 6800, 300, 100), "微笑的宇航员(100生命的)。 需要水平38. 武装与培冲击波(50损坏的)。 快。 有能力生产的东西，击退敌人(4次). 一个非常坚强的性格。 费用：300敌人，900币和40红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6800, 100, 100), "空间")) {
				if (unlock_id_49 == 1) {
					id = 49;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_49 == 1) {
				GUI.DrawTexture (new Rect (140, 6910, 100, 20), est);
			}
			
			/// Космос (2)
			
			if (unlock_id_50 == 0) {
				if (GUI.Button (new Rect (30, 7050, 100, 20), "买")) {
					if (GDB.coins >= 400) {
						if (GDB.globalScore >= 200) {
							if (GDB.redMoney >= 10) {
								if (unlock_id_49 == 1) {
									if (GDB.levXp >= 44) {
										
										GDB.coins -= 400;
										GDB.globalScore -= 200;
										GDB.redMoney -= 10;
										unlock_id_50 = 1;
										PlayerPrefs.SetInt ("score", GDB.globalScore);
										PlayerPrefs.SetInt ("ruby", GDB.redMoney);
										PlayerPrefs.SetInt ("coin", GDB.coins);
										PlayerPrefs.SetInt ("char50", PlayerMenu.unlock_id_50);
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 6960, 90, 60), idw25);
			GUI.DrawTexture (new Rect (540, 6940, 110, 100), id25);
			GUI.DrawTexture (new Rect (450, 6960, 90, 60), idw25_5);
			GUI.Label (new Rect (140, 6940, 300, 100), "所需要的水平44. 不同于其的标准的变具有第二线发射，发射了相反的方向。 此外，它具有附加的能力照亮黑暗的水平。 费用：200敌人，400币和10红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 6940, 100, 100), "空间(2)")) {
				if (unlock_id_50 == 1) {
					id = 50;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_50 == 1) {
				GUI.DrawTexture (new Rect (140, 7050, 100, 20), est);
			}
			
			/// Мажорик (специальный)
			
			if (unlock_id_51 == 0) {
				if (GUI.Button (new Rect (30, 7190, 100, 20), "买")) {
					if (GDB.coins >= 1000) {
						if (GDB.levXp >= 25) {
							
							
							GDB.coins -= 1000;
							unlock_id_51 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char51", PlayerMenu.unlock_id_51);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7090, 90, 60), idw7);
			GUI.DrawTexture (new Rect (450, 7080, 100, 100), id26);
			GUI.Label (new Rect (140, 7080, 300, 100), "这是一个特殊的笑脸。 所需要的水平25. 平均能力(50人死亡，武装一个驴驹，正常的速度)。 有一个独特的技能，寻找在所有级别大的红宝石(+2到红宝石的)。 费用：1000币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7080, 100, 100), "主要的")) {
				if (unlock_id_51 == 1) {
					id = 51;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_51 == 1) {
				GUI.DrawTexture (new Rect (140, 7190, 100, 20), est);
			}
			
			/// Джокер (специальный)
			
			if (unlock_id_52 == 0) {
				if (GUI.Button (new Rect (30, 7330, 100, 20), "买")) {
					if (GDB.coins >= 1500) {
						if (GDB.levXp >= 50) {
							
							GDB.coins -= 1500;
							unlock_id_52 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char52", PlayerMenu.unlock_id_52);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7250, 100, 50), idw20);
			GUI.DrawTexture (new Rect (450, 7220, 100, 100), id27);
			GUI.Label (new Rect (140, 7220, 300, 100), "这是一个特殊的笑脸。 需要50级。 强(与武装M16、50生活，非常快速)。 有能力找到的盒子中，意外下降+20到，这是你的敌人，+10个硬币或者1的红宝石。 费用：1500币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7220, 100, 100), "小丑")) {
				if (unlock_id_52 == 1) {
					id = 52;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_52 == 1) {
				GUI.DrawTexture (new Rect (140, 7330, 100, 20), est);
			}
			
			/// Тучка (специальный)
			
			if (unlock_id_53 == 0) {
				if (GUI.Button (new Rect (30, 7470, 100, 20), "买")) {
					if (GDB.coins >= 250) {
						if (GDB.levXp >= 25) {
							
							GDB.coins -= 250;
							unlock_id_53 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char53", PlayerMenu.unlock_id_53);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 7360, 100, 100), id28);
			GUI.Label (new Rect (140, 7360, 300, 100), "这是一个特殊的笑(50人死亡，非常慢)。 所需要的水平25. 自动造成的地图徘徊球状闪电，从而击败敌人。 这个角色可以用在AFK模式。 费用：250币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7360, 100, 100), "云")) {
				if (unlock_id_53 == 1) {
					id = 53;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_53 == 1) {
				GUI.DrawTexture (new Rect (140, 7470, 100, 20), est);
			}
			
			/// Гроза (специальный)
			
			if (unlock_id_54 == 0) {
				if (GUI.Button (new Rect (30, 7610, 100, 20), "买")) {
					if (GDB.coins >= 750) {
						if (GDB.levXp >= 50) {
							
							GDB.coins -= 750;
							unlock_id_54 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char54", PlayerMenu.unlock_id_54);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (450, 7500, 100, 100), id29);
			GUI.Label (new Rect (140, 7500, 300, 100), "这是一个特殊的笑(100,快速)。 需要50级。 所产生的费用不仅打击敌人和收集硬币。 这个角色是完美的AFK模式。 费用：750币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7500, 100, 100), "暴风雨")) {
				if (unlock_id_54 == 1) {
					id = 54;
					Application.LoadLevel ("LevelMenu");
				}
			}
			
			if (unlock_id_54 == 1) {
				GUI.DrawTexture (new Rect (140, 7610, 100, 20), est);
			}
			
			/// Истиричка (специальный)
			
			if (unlock_id_55 == 0) {
				if (GUI.Button (new Rect (30, 7750, 100, 20), "买")) {
					if (GDB.coins >= 500) {
						if (GDB.levXp >= 99) {
							
							GDB.coins -= 500;
							unlock_id_55 = 1;
							PlayerPrefs.SetInt ("score", GDB.globalScore);
							PlayerPrefs.SetInt ("coin", GDB.coins);
							PlayerPrefs.SetInt ("char55", PlayerMenu.unlock_id_55);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (630, 7650, 80, 80), idw6);
			GUI.DrawTexture (new Rect (530, 7640, 100, 100), id30);
			GUI.DrawTexture (new Rect (450, 7650, 80, 80), idw30);
			GUI.Label (new Rect (140, 7640, 300, 100), "这是一个特殊的笑(50生活、快速)。 需要99级。 武装与两个标准的乌兹冲锋枪，发射着相反的方向。 理论上可以忽略不计的机会找到宝藏(5,000币和100红宝石的)。 费用：500币。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7640, 100, 100), "恐慌")) {
				if (unlock_id_55 == 1) {
					id = 55;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_55 == 1) {
				GUI.DrawTexture (new Rect (140, 7750, 100, 20), est);
			}
			
			/// Рейдер (коллекция)
			
			if (unlock_id_56 == 0) {
				if (GUI.Button (new Rect (30, 7890, 100, 20), "买")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_56 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char56", PlayerMenu.unlock_id_56);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7800, 100, 50), idw31);
			GUI.DrawTexture (new Rect (450, 7780, 100, 100), id31);
			GUI.Label (new Rect (140, 7780, 300, 100), "这是一个收藏家的微笑(50人死亡，平均速度)。 需要30级。 装备有卡拉什尼科夫(非常迅速的火，造成8点的损坏的)。 几乎适用于任何级别。 中性选择的游戏。 价格:30红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7780, 100, 100), "入侵者")) {
				if (unlock_id_56 == 1) {
					id = 56;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_56 == 1) {
				GUI.DrawTexture (new Rect (140, 7890, 100, 20), est);
			}
			
			/// Ранчо (коллекция)
			
			if (unlock_id_57 == 0) {
				if (GUI.Button (new Rect (30, 8030, 100, 20), "买")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_57 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char57", PlayerMenu.unlock_id_57);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 7940, 110, 50), idw32);
			GUI.DrawTexture (new Rect (450, 7920, 100, 100), id32);
			GUI.Label (new Rect (140, 7920, 300, 100), "这是一个收藏家的微笑(50生活、快速)。 需要30级。 用猎枪武装(40损坏的)。 典型的收藏笑的平均能力。 重要的各个层面。 价格:30红宝石。 ", GUI.skin.label);
			if (GUI.Button (new Rect (30, 7920, 100, 100), "牧场")) {
				if (unlock_id_57 == 1) {
					id = 57;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_57 == 1) {
				GUI.DrawTexture (new Rect (140, 8030, 100, 20), est);
			}
			
			/// Камикадзе (коллекция)
			
			if (unlock_id_58 == 0) {
				if (GUI.Button (new Rect (30, 8170, 100, 20), "买")) {
					if (GDB.redMoney >= 30) {
						if (GDB.levXp >= 30) {
							
							GDB.redMoney -= 30;
							unlock_id_58 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char58", PlayerMenu.unlock_id_58);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8090, 50, 50), idw33);
			GUI.DrawTexture (new Rect (450, 8060, 100, 100), id33);
			GUI.Label (new Rect (140, 8060, 300, 100), "这是一个收藏家的微笑(快速，50人死亡). 需要30级。 投掷手榴弹(30损害打击和10损害的爆炸). 非常可笑的表情符号集的。 价格:30红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8060, 100, 100), "神风敢死队")) {
				if (unlock_id_58 == 1) {
					id = 58;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_58 == 1) {
				GUI.DrawTexture (new Rect (140, 8170, 100, 20), est);
			}
			
			/// Геймер (коллекция)
			
			if (unlock_id_59 == 0) {
				if (GUI.Button (new Rect (30, 8310, 100, 20), "买")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
							
							GDB.redMoney -= 300;
							unlock_id_59 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char59", PlayerMenu.unlock_id_59);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8210, 150, 90), idw34);
			GUI.DrawTexture (new Rect (450, 8200, 100, 100), id34);
			GUI.Label (new Rect (140, 8200, 300, 100), "这是一个收藏家的微笑(快速、100生命的)。 所需要的水平80. 武装的令人难以置信的强大的BFG(1大费500损害和2小250损坏的)。 在开放水平更加有效。 费用：300红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8200, 100, 100), "播放器")) {
				if (unlock_id_59 == 1) {
					id = 59;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_59 == 1) {
				GUI.DrawTexture (new Rect (140, 8310, 100, 20), est);
			}
			
			/// Псих (коллекция)
			
			if (unlock_id_60 == 0) {
				if (GUI.Button (new Rect (30, 8450, 100, 20), "买")) {
					if (GDB.redMoney >= 300) {
						if (GDB.levXp >= 80) {
							
							GDB.redMoney -= 300;
							unlock_id_60 = 1;
							PlayerPrefs.SetInt ("ruby", GDB.redMoney);
							PlayerPrefs.SetInt ("char60", PlayerMenu.unlock_id_60);
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8350, 150, 90), idw35);
			GUI.DrawTexture (new Rect (450, 8340, 100, 100), id35);
			GUI.Label (new Rect (140, 8340, 300, 100), "一个经典笑容(中等速度的100生活中)。 所需要的水平80. 装备有一个三管火箭发射器(每个导弹30损害的碰撞和10损害的爆炸). 一个非常有效的角色。 费用：300红宝石。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8340, 100, 100), "疯狂的")) {
				if (unlock_id_60 == 1) {
					id = 60;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_60 == 1) {
				GUI.DrawTexture (new Rect (140, 8450, 100, 20), est);
			}
			
			/// Джэдай (Легенда)
			
			if (unlock_id_61 == 0) {
				if (GUI.Button (new Rect (30, 8590, 100, 20), "拿!")) {
					if (unlock_id_3 == 1) {
						if (unlock_id_5 == 1) {
							if (unlock_id_7 == 1) {
								if (unlock_id_9 == 1) {
									if (unlock_id_11 == 1) {
										if (unlock_id_13 == 1) {
											if (unlock_id_15 == 1) {
												if (unlock_id_17 == 1) {
													if (unlock_id_19 == 1) {
														if (unlock_id_21 == 1) {
															if (unlock_id_23 == 1) {
																if (unlock_id_25 == 1) {
																	if (unlock_id_27 == 1) {
																		if (unlock_id_29 == 1) {
																			if (unlock_id_31 == 1) {
																				if (unlock_id_33 == 1) {
																					if (unlock_id_35 == 1) {
																						if (unlock_id_37 == 1) {
																							if (unlock_id_39 == 1) {
																								if (unlock_id_41 == 1) {
																									if (unlock_id_43 == 1) {
																										if (unlock_id_45 == 1) {
																											if (unlock_id_47 == 1) {
																												if (unlock_id_49 == 1) {
																													
																													unlock_id_61 = 1;
																													PlayerPrefs.SetInt ("char61", PlayerMenu.unlock_id_61);
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8480, 100, 100), idw36);
			GUI.DrawTexture (new Rect (450, 8480, 100, 120), id36);
			GUI.Label (new Rect (140, 8480, 300, 100), "这就是传说中的笑脸。 有999人的生命。 速度非常快。 光剑交易100损害每摇摆。 快速的武器。 你可以拿起，如果锁定(提供)的所有标准的表情-符。 能够通过任何水平。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8480, 100, 100), "骑士")) {
				if (unlock_id_61 == 1) {
					id = 61;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_61 == 1) {
				GUI.DrawTexture (new Rect (140, 8590, 100, 20), est);
			}
			
			/// Ситх (Легенда)
			
			if (unlock_id_62 == 0) {
				if (GUI.Button (new Rect (30, 8730, 100, 20), "拿!")) {
					if (unlock_id_2 == 1) {
						if (unlock_id_4 == 1) {
							if (unlock_id_6 == 1) {
								if (unlock_id_8 == 1) {
									if (unlock_id_10 == 1) {
										if (unlock_id_12 == 1) {
											if (unlock_id_14 == 1) {
												if (unlock_id_16 == 1) {
													if (unlock_id_18 == 1) {
														if (unlock_id_20 == 1) {
															if (unlock_id_22 == 1) {
																if (unlock_id_24 == 1) {
																	if (unlock_id_26 == 1) {
																		if (unlock_id_28 == 1) {
																			if (unlock_id_30 == 1) {
																				if (unlock_id_32 == 1) {
																					if (unlock_id_34 == 1) {
																						if (unlock_id_36 == 1) {
																							if (unlock_id_38 == 1) {
																								if (unlock_id_40 == 1) {
																									if (unlock_id_42 == 1) {
																										if (unlock_id_44 == 1) {
																											if (unlock_id_46 == 1) {
																												if (unlock_id_48 == 1) {
																													if (unlock_id_50 == 1) {																				
																														unlock_id_62 = 1;
																														PlayerPrefs.SetInt ("char62", PlayerMenu.unlock_id_62);
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			
			GUI.DrawTexture (new Rect (560, 8620, 100, 100), idw37);
			GUI.DrawTexture (new Rect (450, 8620, 100, 100), id37);
			GUI.Label (new Rect (140, 8620, 300, 100), "这就是传说中的笑脸。 有999生活和一个闪电般快速的剑(100损坏的)。 此外，火灾3闪电(50损坏的)。 具有周期性的屏蔽。 你可以选择如果你锁的所有先进的表情符号标记(2)条。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8620, 100, 100), "西斯")) {
				if (unlock_id_62 == 1) {
					id = 62;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_62 == 1) {
				GUI.DrawTexture (new Rect (140, 8730, 100, 20), est);
			}
			
			/// Смерть (легенда)
			
			if (unlock_id_63 == 0) {
				if (GUI.Button (new Rect (30, 8870, 100, 20), "拿!")) {
					if (unlock_id_51 == 1) {
						if (unlock_id_52 == 1) {
							if (unlock_id_53 == 1) {
								if (unlock_id_54 == 1) {
									if (unlock_id_55 == 1) {
										if (unlock_id_56 == 1) {
											if (unlock_id_57 == 1) {
												if (unlock_id_58 == 1) {
													if (unlock_id_59 == 1) {
														if (unlock_id_60 == 1) {
															
															unlock_id_63 = 1;
															PlayerPrefs.SetInt ("char63", PlayerMenu.unlock_id_63);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			
			GUI.DrawTexture (new Rect (560, 8760, 100, 100), idw38);
			GUI.DrawTexture (new Rect (450, 8760, 100, 100), id38);
			GUI.Label (new Rect (140, 8760, 300, 100), "这就是传说中的笑脸。 有666人的生命。 慢镰刀交易66损害每摇摆。 有无耻的速度。 收集的灵魂(+10马力每敌人的人)。 你可以收集，如果你收集了所有特别和集热器的微笑。", GUI.skin.label);
			if (GUI.Button (new Rect (30, 8760, 100, 100), "死")) {
				if (unlock_id_63 == 1) {
					id = 63;
					Application.LoadLevel ("LevelMenu");
				}
			}
			if (unlock_id_63 == 1) {
				GUI.DrawTexture (new Rect (140, 8870, 100, 20), est);
			}
		}


		GUI.EndScrollView();
	}
}
