using UnityEngine;
using System.Collections;

public class MenuDungeon : MonoBehaviour {

	public Vector2 scrollPosition = Vector2.zero;
	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 

	public Texture2D back;
	public Texture2D boss;



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

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);

		GUI.DrawTexture (new Rect (10, 140, 80, 80), boss);
		GUI.DrawTexture (new Rect (10, 230, 80, 80), boss);
		GUI.DrawTexture (new Rect (10, 320, 80, 80), boss);

		if (MenuScript.lang == 1) {
			GUI.Label (new Rect (10, 10, 780, 130), "В Режиме ПОДЗЕМЕЛЬЯ существует 20 уровней сложностей, попадать на которые можно после достижения определенного уровня персонажем. Особенность режима ПОДЗЕМЕЛЬЯ в том, что побеждая врагов в нем вы получете в качестве награды ИЗУМРУДЫ!!! Прохождение подземелья так же может продвинуть вас по уровням, или же наоборот вернуть к более ранним уровням в зависимости от сложности подземелья. УДАЧИ =)", GUI.skin.label);
		}
		if (MenuScript.lang == 2) {
			GUI.Label (new Rect (10, 10, 780, 130), "In the Underground mode there are 20 levels of difficulty, which can be reached after the character reaches a certain level. The peculiarity of the underworld mode is that by defeating the enemies in it, you will receive as a reward EMERALD !!! Passing the dungeon can also advance you through the levels, or vice versa return you to earlier levels, depending on the difficulty of the dungeon. GOOD LUCK =)", GUI.skin.label);
		}
		if (MenuScript.lang == 3) {
			GUI.Label (new Rect (10, 10, 780, 130), "在地下模式中，有20个难度级别，可以在角色达到一定水平后达到。 黑社会模式的特点是，通过击败其中的敌人，你将获得EMERALD奖励！ 通过地牢也可以提升你通过关卡，反之亦然让你回到更早的关卡，这取决于地牢的难度。 好运=）", GUI.skin.label);
		}


		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "Назад")) {
				Application.LoadLevel ("LevelMenu");
			}
		}
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "Back")) {
				Application.LoadLevel ("LevelMenu");
			}
		}
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (300, 400, 200, 50), "前")) {
				Application.LoadLevel ("LevelMenu");
			}
		}

		///buttons

		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (100, 140, 160, 40), "уровень игрока выше 0")) {
				if (GDB.levXp >= 1) {
					Application.LoadLevel ("LLevelD1");
					}
				}
			if (GUI.Button (new Rect (270, 140, 160, 40), "Уровень игрока выше 5")) {
				if (GDB.levXp >= 6) {
					Application.LoadLevel ("LLevelD2");
					}
				}
			if (GUI.Button (new Rect (440, 140, 160, 40), "Уровень игрока выше 10")) {
				if (GDB.levXp >= 11) {
					Application.LoadLevel ("LLevelD3");
					}
				}
			if (GUI.Button (new Rect (610, 140, 160, 40), "Уровень игрока выше 15")) {
				if (GDB.levXp >= 16) {
					Application.LoadLevel ("LLevelD4");
					}
				}
			if (GUI.Button (new Rect (100, 190, 160, 40), "Уровень игрока выше 20")) {
				if (GDB.levXp >= 21) {
					Application.LoadLevel ("LLevelD5");
				}
			}
			if (GUI.Button (new Rect (270, 190, 160, 40), "Уровень игрока выше 25")) {
				if (GDB.levXp >= 26) {
					Application.LoadLevel ("LLevelD6");
				}
			}
			if (GUI.Button (new Rect (440, 190, 160, 40), "Уровень игрока выше 30")) {
				if (GDB.levXp >= 31) {
					Application.LoadLevel ("LLevelD7");
				}
			}
			if (GUI.Button (new Rect (610, 190, 160, 40), "Уровень игрока выше 35")) {
				if (GDB.levXp >= 36) {
					Application.LoadLevel ("LLevelD8");
				}
			}
			if (GUI.Button (new Rect (100, 240, 160, 40), "Уровень игрока выше 40")) {
				if (GDB.levXp >= 41) {
					Application.LoadLevel ("LLevelD9");
				}
			}
			if (GUI.Button (new Rect (270, 240, 160, 40), "Уровень игрока выше 45")) {
				if (GDB.levXp >= 46) {
					Application.LoadLevel ("LLevelD10");
				}
			}
			if (GUI.Button (new Rect (440, 240, 160, 40), "Уровень игрока выше 50")) {
				if (GDB.levXp >= 51) {
					Application.LoadLevel ("LLevelD11");
				}
			}
			if (GUI.Button (new Rect (610, 240, 160, 40), "Уровень игрока выше 55")) {
				if (GDB.levXp >= 56) {
					Application.LoadLevel ("LLevelD12");
				}
			}
			if (GUI.Button (new Rect (100, 290, 160, 40), "Уровень игрока выше 60")) {
				if (GDB.levXp >= 61) {
					Application.LoadLevel ("LLevelD13");
				}
			}
			if (GUI.Button (new Rect (270, 290, 160, 40), "Уровень игрока выше 65")) {
				if (GDB.levXp >= 66) {
					Application.LoadLevel ("LLevelD14");
				}
			}
			if (GUI.Button (new Rect (440, 290, 160, 40), "Уровень игрока выше 70")) {
				if (GDB.levXp >= 71) {
					Application.LoadLevel ("LLevelD15");
				}
			}
			if (GUI.Button (new Rect (610, 290, 160, 40), "Уровень игрока выше 75")) {
				if (GDB.levXp >= 76) {
					Application.LoadLevel ("LLevelD16");
				}
			}
			if (GUI.Button (new Rect (100, 340, 160, 40), "Уровень игрока выше 80")) {
				if (GDB.levXp >= 81) {
					Application.LoadLevel ("LLevelD17");
				}
			}
			if (GUI.Button (new Rect (270, 340, 160, 40), "Уровень игрока выше 85")) {
				if (GDB.levXp >= 86) {
					Application.LoadLevel ("LLevelD18");
				}
			}
			if (GUI.Button (new Rect (440, 340, 160, 40), "Уровень игрока выше 90")) {
				if (GDB.levXp >= 91) {
					Application.LoadLevel ("LLevelD19");
				}
			}
			if (GUI.Button (new Rect (610, 340, 160, 40), "Уровень игрока выше 95")) {
				if (GDB.levXp >= 96) {
					Application.LoadLevel ("LLevelD20");
				}
			}
		}

		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (100, 140, 160, 40), "player level above 0")) {
				if (GDB.levXp >= 1) {
					Application.LoadLevel ("LLevelD1");
				}
			}
			if (GUI.Button (new Rect (270, 140, 160, 40), "player level above 5")) {
				if (GDB.levXp >= 6) {
					Application.LoadLevel ("LLevelD2");
				}
			}
			if (GUI.Button (new Rect (440, 140, 160, 40), "player level above 10")) {
				if (GDB.levXp >= 11) {
					Application.LoadLevel ("LLevelD3");
				}
			}
			if (GUI.Button (new Rect (610, 140, 160, 40), "player level above 15")) {
				if (GDB.levXp >= 16) {
					Application.LoadLevel ("LLevelD4");
				}
			}
			if (GUI.Button (new Rect (100, 190, 160, 40), "player level above 20")) {
				if (GDB.levXp >= 21) {
					Application.LoadLevel ("LLevelD5");
				}
			}
			if (GUI.Button (new Rect (270, 190, 160, 40), "player level above 25")) {
				if (GDB.levXp >= 26) {
					Application.LoadLevel ("LLevelD6");
				}
			}
			if (GUI.Button (new Rect (440, 190, 160, 40), "player level above 30")) {
				if (GDB.levXp >= 31) {
					Application.LoadLevel ("LLevelD7");
				}
			}
			if (GUI.Button (new Rect (610, 190, 160, 40), "player level above 35")) {
				if (GDB.levXp >= 36) {
					Application.LoadLevel ("LLevelD8");
				}
			}
			if (GUI.Button (new Rect (100, 240, 160, 40), "player level above 40")) {
				if (GDB.levXp >= 41) {
					Application.LoadLevel ("LLevelD9");
				}
			}
			if (GUI.Button (new Rect (270, 240, 160, 40), "player level above 45")) {
				if (GDB.levXp >= 46) {
					Application.LoadLevel ("LLevelD10");
				}
			}
			if (GUI.Button (new Rect (440, 240, 160, 40), "player level above 50")) {
				if (GDB.levXp >= 51) {
					Application.LoadLevel ("LLevelD11");
				}
			}
			if (GUI.Button (new Rect (610, 240, 160, 40), "player level above 55")) {
				if (GDB.levXp >= 56) {
					Application.LoadLevel ("LLevelD12");
				}
			}
			if (GUI.Button (new Rect (100, 290, 160, 40), "player level above 60")) {
				if (GDB.levXp >= 61) {
					Application.LoadLevel ("LLevelD13");
				}
			}
			if (GUI.Button (new Rect (270, 290, 160, 40), "player level above 65")) {
				if (GDB.levXp >= 66) {
					Application.LoadLevel ("LLevelD14");
				}
			}
			if (GUI.Button (new Rect (440, 290, 160, 40), "player level above 70")) {
				if (GDB.levXp >= 71) {
					Application.LoadLevel ("LLevelD15");
				}
			}
			if (GUI.Button (new Rect (610, 290, 160, 40), "player level above 75")) {
				if (GDB.levXp >= 76) {
					Application.LoadLevel ("LLevelD16");
				}
			}
			if (GUI.Button (new Rect (100, 340, 160, 40), "player level above 80")) {
				if (GDB.levXp >= 81) {
					Application.LoadLevel ("LLevelD17");
				}
			}
			if (GUI.Button (new Rect (270, 340, 160, 40), "player level above 85")) {
				if (GDB.levXp >= 86) {
					Application.LoadLevel ("LLevelD18");
				}
			}
			if (GUI.Button (new Rect (440, 340, 160, 40), "player level above 90")) {
				if (GDB.levXp >= 91) {
					Application.LoadLevel ("LLevelD19");
				}
			}
			if (GUI.Button (new Rect (610, 340, 160, 40), "player level above 95")) {
				if (GDB.levXp >= 96) {
					Application.LoadLevel ("LLevelD20");
				}
			}
		}


		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (100, 140, 160, 40), "玩家等级高于0")) {
				if (GDB.levXp >= 1) {
					Application.LoadLevel ("LLevelD1");
				}
			}
			if (GUI.Button (new Rect (270, 140, 160, 40), "玩家等级高于5")) {
				if (GDB.levXp >= 6) {
					Application.LoadLevel ("LLevelD2");
				}
			}
			if (GUI.Button (new Rect (440, 140, 160, 40), "玩家等级高于10")) {
				if (GDB.levXp >= 11) {
					Application.LoadLevel ("LLevelD3");
				}
			}
			if (GUI.Button (new Rect (610, 140, 160, 40), "玩家等级高于15")) {
				if (GDB.levXp >= 16) {
					Application.LoadLevel ("LLevelD4");
				}
			}
			if (GUI.Button (new Rect (100, 190, 160, 40), "玩家等级高于20")) {
				if (GDB.levXp >= 21) {
					Application.LoadLevel ("LLevelD5");
				}
			}
			if (GUI.Button (new Rect (270, 190, 160, 40), "玩家等级高于25")) {
				if (GDB.levXp >= 26) {
					Application.LoadLevel ("LLevelD6");
				}
			}
			if (GUI.Button (new Rect (440, 190, 160, 40), "玩家等级高于30")) {
				if (GDB.levXp >= 31) {
					Application.LoadLevel ("LLevelD7");
				}
			}
			if (GUI.Button (new Rect (610, 190, 160, 40), "玩家等级高于35")) {
				if (GDB.levXp >= 36) {
					Application.LoadLevel ("LLevelD8");
				}
			}
			if (GUI.Button (new Rect (100, 240, 160, 40), "玩家等级高于40")) {
				if (GDB.levXp >= 41) {
					Application.LoadLevel ("LLevelD9");
				}
			}
			if (GUI.Button (new Rect (270, 240, 160, 40), "玩家等级高于45")) {
				if (GDB.levXp >= 46) {
					Application.LoadLevel ("LLevelD10");
				}
			}
			if (GUI.Button (new Rect (440, 240, 160, 40), "玩家等级高于50")) {
				if (GDB.levXp >= 51) {
					Application.LoadLevel ("LLevelD11");
				}
			}
			if (GUI.Button (new Rect (610, 240, 160, 40), "玩家等级高于55")) {
				if (GDB.levXp >= 56) {
					Application.LoadLevel ("LLevelD12");
				}
			}
			if (GUI.Button (new Rect (100, 290, 160, 40), "玩家等级高于60")) {
				if (GDB.levXp >= 61) {
					Application.LoadLevel ("LLevelD13");
				}
			}
			if (GUI.Button (new Rect (270, 290, 160, 40), "玩家等级高于65")) {
				if (GDB.levXp >= 66) {
					Application.LoadLevel ("LLevelD14");
				}
			}
			if (GUI.Button (new Rect (440, 290, 160, 40), "玩家等级高于70")) {
				if (GDB.levXp >= 71) {
					Application.LoadLevel ("LLevelD15");
				}
			}
			if (GUI.Button (new Rect (610, 290, 160, 40), "玩家等级高于75")) {
				if (GDB.levXp >= 76) {
					Application.LoadLevel ("LLevelD16");
				}
			}
			if (GUI.Button (new Rect (100, 340, 160, 40), "玩家等级高于80")) {
				if (GDB.levXp >= 81) {
					Application.LoadLevel ("LLevelD17");
				}
			}
			if (GUI.Button (new Rect (270, 340, 160, 40), "玩家等级高于85")) {
				if (GDB.levXp >= 86) {
					Application.LoadLevel ("LLevelD18");
				}
			}
			if (GUI.Button (new Rect (440, 340, 160, 40), "玩家等级高于90")) {
				if (GDB.levXp >= 91) {
					Application.LoadLevel ("LLevelD19");
				}
			}
			if (GUI.Button (new Rect (610, 340, 160, 40), "玩家等级高于95")) {
				if (GDB.levXp >= 96) {
					Application.LoadLevel ("LLevelD20");
				}
			}
		}












		}



			



			









	}



