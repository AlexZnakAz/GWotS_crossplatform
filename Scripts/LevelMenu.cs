using UnityEngine;
using System.Collections;

public class LevelMenu : MonoBehaviour {

	public Vector2 scrollPosition = Vector2.zero;

	public GUISkin otherGUI;

	public Texture2D closed;
	public Texture2D open;
	public Texture2D mob;
	public Texture2D boss;

	public Texture2D back;

	public float originalWidth = 800.0f; 
	public float originalHeight = 480.0f; 
	Vector3 scale; 
	
	void Start()
	{
		scale.x = Screen.width/originalWidth;  
		scale.y = Screen.height/originalHeight; 
		scale.z = 1; 
	} 
	


	void OnGUI () {


		GUI.skin = otherGUI;


		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), back);

		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);


		///Dungeon button

		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (610, 430, 150, 30), "!! ПОДЗЕМЕЛЬЕ !!")){
				Application.LoadLevel ("DungeonMenu");
			}
		}
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (610, 430, 150, 30), "!! DUNGEON !!")){
				Application.LoadLevel ("DungeonMenu");
			}
		}
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (610, 430, 150, 30), "!! 地下 !!")){
				Application.LoadLevel ("DungeonMenu");
			}
		}


		///Upgrades button

		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (610, 10, 150, 30), "УЛУЧШЕНИЯ")) {
				Application.LoadLevel ("Upgrade");
			}
		}
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (610, 10, 150, 30), "UPGRADE")){
				Application.LoadLevel ("Upgrade");
			}
		}
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (610, 10, 150, 30), "起色")) {
				Application.LoadLevel ("Upgrade");
			}
		}




		///rus
		if (MenuScript.lang == 1) {
			if (GUI.Button (new Rect (610, 50, 150, 30), "Выбор персонажа")) {
				Application.LoadLevel ("PlayerMenu");
			}
		
			if (GUI.Button (new Rect (610, 90, 150, 30), "Главное меню")) {
				Application.LoadLevel ("Menu");
			}

			if (GUI.Button (new Rect (640, 130, 100, 20), "(10)БОСС-1")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel92");
				}
			}
			if (GUI.Button (new Rect (640, 160, 100, 20), "(20)БОСС-2")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel93");
				}
			}
			if (GUI.Button (new Rect (640, 190, 100, 20), "(30)БОСС-3")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel94");
				}
			}
			if (GUI.Button (new Rect (640, 220, 100, 20), "(40)БОСС-4")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel95");
				}
			}
			if (GUI.Button (new Rect (640, 250, 100, 20), "(50)БОСС-5")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel96");
				}
			}
			if (GUI.Button (new Rect (640, 280, 100, 20), "(60)БОСС-6")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel97");
				}
			}
			if (GUI.Button (new Rect (640, 310, 100, 20), "(70)БОСС-7")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel98");
				}
			}
			if (GUI.Button (new Rect (640, 340, 100, 20), "(80)БОСС-8")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel99");
				}
			}
			if (GUI.Button (new Rect (640, 370, 100, 20), "(90)БОСС-9")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel100");
				}
			}
			if (GUI.Button (new Rect (640, 400, 100, 20), "Главное Зло")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel101");
				}
			}


			if (GDB.unlockLeavel < 11) {
				GUI.DrawTexture (new Rect (610, 130, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 21) {
				GUI.DrawTexture (new Rect (610, 160, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 31) {
				GUI.DrawTexture (new Rect (610, 190, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 41) {
				GUI.DrawTexture (new Rect (610, 220, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 51) {
				GUI.DrawTexture (new Rect (610, 250, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 61) {
				GUI.DrawTexture (new Rect (610, 280, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 71) {
				GUI.DrawTexture (new Rect (610, 310, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 81) {
				GUI.DrawTexture (new Rect (610, 340, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 370, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 400, 20, 20), closed);
			}




	


			scrollPosition = GUI.BeginScrollView (new Rect (1, 1, 570, Screen.height), scrollPosition, new Rect (0, 0, 500, 4000));

			if (MenuScript.diff <=1) {
			GUI.Label (new Rect (160, 15, 300, 20), "враги 005 | сила 001 | строения 040 | пузыри 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
			GUI.Label (new Rect (160, 45, 300, 20), "враги 015 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
			GUI.Label (new Rect (160, 75, 300, 20), "враги 005 | сила 001 | строения 250 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
			GUI.Label (new Rect (160, 105, 300, 20), "враги 005 | сила 001 | строения 000 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
			GUI.Label (new Rect (160, 135, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
			GUI.Label (new Rect (160, 165, 300, 20), "враги 025 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
			GUI.Label (new Rect (160, 195, 300, 20), "враги 010 | сила 001 | строения 040 | пузыри 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
			GUI.Label (new Rect (160, 225, 300, 20), "враги 010 | сила 001 | строения 030 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
			GUI.Label (new Rect (160, 255, 300, 20), "враги 010 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
			GUI.Label (new Rect (160, 285, 300, 20), "враги 010 | сила 001 | строения 060 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
			GUI.Label (new Rect (160, 315, 300, 20), "враги 005 | сила 001 | строения 010 | пузыри 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
			GUI.Label (new Rect (160, 345, 300, 20), "враги 015 | сила 001 | строения 015 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
			GUI.Label (new Rect (160, 375, 300, 20), "враги 005 | сила 001 | строения 250 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
			GUI.Label (new Rect (160, 405, 300, 20), "враги 005 | сила 001 | строения 000 | пузыри 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
			GUI.Label (new Rect (160, 435, 300, 20), "враги 020 | сила 001 | строения 000 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
			GUI.Label (new Rect (160, 465, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
			GUI.Label (new Rect (160, 495, 300, 20), "враги 010 | сила 001 | строения 110 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
			GUI.Label (new Rect (160, 525, 300, 20), "враги 005 | сила 001 | строения 010 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
			GUI.Label (new Rect (160, 555, 300, 20), "враги 010 | сила 001 | строения 300 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
			GUI.Label (new Rect (160, 585, 300, 20), "враги 030 | сила 001 | строения 200 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
			GUI.Label (new Rect (160, 615, 300, 20), "враги 005 | сила 001 | строения 055 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
			GUI.Label (new Rect (160, 645, 300, 20), "враги 005 | сила 001 | строения 005 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
			GUI.Label (new Rect (160, 675, 300, 20), "враги 005 | сила 001 | строения 005 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
			GUI.Label (new Rect (160, 705, 300, 20), "враги 010 | сила 001 | строения 005 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
			GUI.Label (new Rect (160, 735, 300, 20), "враги 015 | сила 001 | строения 010 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
			GUI.Label (new Rect (160, 765, 300, 20), "враги 015 | сила 001 | строения 050 | пузыри 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
			GUI.Label (new Rect (160, 795, 300, 20), "враги 010 | сила 001 | строения 000 | пузыри 240", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
			GUI.Label (new Rect (160, 825, 300, 20), "враги 015 | сила 001 | строения 305 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
			GUI.Label (new Rect (160, 855, 300, 20), "враги 005 | сила 001 | строения 040 | пузыри 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
			GUI.Label (new Rect (160, 885, 300, 20), "враги 020 | сила 001 | строения 200 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
			GUI.Label (new Rect (160, 915, 300, 20), "враги 005 | сила 001 | строения 035 | пузыри 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
			GUI.Label (new Rect (160, 945, 300, 20), "враги 005 | сила 001 | строения 045 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
			GUI.Label (new Rect (160, 975, 300, 20), "враги 015 | сила 001 | строения 005 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
			GUI.Label (new Rect (160, 1005, 300, 20), "враги 010 | сила 001 | строения 000 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
			GUI.Label (new Rect (160, 1035, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
			GUI.Label (new Rect (160, 1065, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
			GUI.Label (new Rect (160, 1095, 300, 20), "враги 005 | сила 001 | строения 100 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
			GUI.Label (new Rect (160, 1125, 300, 20), "враги 005 | сила 001 | строения 100 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
			GUI.Label (new Rect (160, 1155, 300, 20), "враги 010 | сила 001 | строения 000 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
			GUI.Label (new Rect (160, 1185, 300, 20), "враги 010 | сила 001 | строения 050 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
			GUI.Label (new Rect (160, 1215, 300, 20), "враги 015 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
			GUI.Label (new Rect (160, 1245, 300, 20), "враги 015 | сила 001 | строения 100 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
			GUI.Label (new Rect (160, 1275, 300, 20), "враги 010 | сила 001 | строения 050 | пузыри 025", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
			GUI.Label (new Rect (160, 1305, 300, 20), "враги 005 | сила 001 | строения 000 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
			GUI.Label (new Rect (160, 1335, 300, 20), "враги 010 | сила 001 | строения 300 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
			GUI.Label (new Rect (160, 1365, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
			GUI.Label (new Rect (160, 1395, 300, 20), "враги 015 | сила 001 | строения 205 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
			GUI.Label (new Rect (160, 1425, 300, 20), "враги 015 | сила 001 | строения 006 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
			GUI.Label (new Rect (160, 1455, 300, 20), "враги 010 | сила 001 | строения 011 | пузыри 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
			GUI.Label (new Rect (160, 1485, 300, 20), "враги 020 | сила 001 | строения 410 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
			GUI.Label (new Rect (160, 1515, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
			GUI.Label (new Rect (160, 1545, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
			GUI.Label (new Rect (160, 1575, 300, 20), "враги 005 | сила 001 | строения 100 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
			GUI.Label (new Rect (160, 1605, 300, 20), "враги 020 | сила 001 | строения 100 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
			GUI.Label (new Rect (160, 1635, 300, 20), "враги 010 | сила 001 | строения 200 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
			GUI.Label (new Rect (160, 1665, 300, 20), "враги 010 | сила 001 | строения 000 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
			GUI.Label (new Rect (160, 1695, 300, 20), "враги 010 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
			GUI.Label (new Rect (160, 1725, 300, 20), "враги 010 | сила 001 | строения 205 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
			GUI.Label (new Rect (160, 1755, 300, 20), "враги 015 | сила 001 | строения 055 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
			GUI.Label (new Rect (160, 1785, 300, 20), "враги 015 | сила 001 | строения 205 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
			GUI.Label (new Rect (160, 1815, 300, 20), "враги 005 | сила 001 | строения 005 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
			GUI.Label (new Rect (160, 1845, 300, 20), "враги 005 | сила 001 | строения 050 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
			GUI.Label (new Rect (160, 1875, 300, 20), "враги 015 | сила 001 | строения 005 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
			GUI.Label (new Rect (160, 1905, 300, 20), "враги 005 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
			GUI.Label (new Rect (160, 1935, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
			GUI.Label (new Rect (160, 1965, 300, 20), "враги 010 | сила 001 | строения 050 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
			GUI.Label (new Rect (160, 1995, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
			GUI.Label (new Rect (160, 2025, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
			GUI.Label (new Rect (160, 2055, 300, 20), "враги 010 | сила 001 | строения 300 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
			GUI.Label (new Rect (160, 2085, 300, 20), "враги 010 | сила 001 | строения 010 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
			GUI.Label (new Rect (160, 2115, 300, 20), "враги 010 | сила 001 | строения 300 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
			GUI.Label (new Rect (160, 2145, 300, 20), "враги 010 | сила 001 | строения 000 | пузыри 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
			GUI.Label (new Rect (160, 2175, 300, 20), "враги 010 | сила 001 | строения 300 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
			GUI.Label (new Rect (160, 2205, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
			GUI.Label (new Rect (160, 2235, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
			GUI.Label (new Rect (160, 2265, 300, 20), "враги 010 | сила 001 | строения 200 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
			GUI.Label (new Rect (160, 2295, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
			GUI.Label (new Rect (160, 2325, 300, 20), "враги 010 | сила 001 | строения 310 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
			GUI.Label (new Rect (160, 2355, 300, 20), "враги 010 | сила 001 | строения 210 | пузыри 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
			GUI.Label (new Rect (160, 2385, 300, 20), "враги 010 | сила 001 | строения 310 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
			GUI.Label (new Rect (160, 2415, 300, 20), "враги 010 | сила 001 | строения 210 | пузыри 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
			GUI.Label (new Rect (160, 2445, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
			GUI.Label (new Rect (160, 2475, 300, 20), "враги 010 | сила 001 | строения 205 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
			GUI.Label (new Rect (160, 2505, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
			GUI.Label (new Rect (160, 2535, 300, 20), "враги 010 | сила 001 | строения 205 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
			GUI.Label (new Rect (160, 2565, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
			GUI.Label (new Rect (160, 2595, 300, 20), "враги 010 | сила 001 | строения 105 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
			GUI.Label (new Rect (160, 2625, 300, 20), "враги 010 | сила 001 | строения 205 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
			GUI.Label (new Rect (160, 2655, 300, 20), "враги 025 | сила 001 | строения 005 | пузыри 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
			GUI.Label (new Rect (160, 2685, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
			GUI.Label (new Rect (160, 2715, 300, 20), "враги 010 | сила 001 | строения 100 | пузыри 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}

			if (MenuScript.diff ==2) {
				GUI.Label (new Rect (160, 15, 300, 20), "враги 005 | сила 002 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
				GUI.Label (new Rect (160, 45, 300, 20), "враги 015 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
				GUI.Label (new Rect (160, 75, 300, 20), "враги 005 | сила 002 | строения 250 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
				GUI.Label (new Rect (160, 105, 300, 20), "враги 005 | сила 002 | строения 000 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
				GUI.Label (new Rect (160, 135, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
				GUI.Label (new Rect (160, 165, 300, 20), "враги 025 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
				GUI.Label (new Rect (160, 195, 300, 20), "враги 010 | сила 002 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
				GUI.Label (new Rect (160, 225, 300, 20), "враги 010 | сила 002 | строения 030 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
				GUI.Label (new Rect (160, 255, 300, 20), "враги 010 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
				GUI.Label (new Rect (160, 285, 300, 20), "враги 010 | сила 002 | строения 060 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
				GUI.Label (new Rect (160, 315, 300, 20), "враги 005 | сила 002 | строения 010 | пузыри 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
				GUI.Label (new Rect (160, 345, 300, 20), "враги 015 | сила 002 | строения 015 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
				GUI.Label (new Rect (160, 375, 300, 20), "враги 005 | сила 002 | строения 250 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
				GUI.Label (new Rect (160, 405, 300, 20), "враги 005 | сила 002 | строения 000 | пузыри 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
				GUI.Label (new Rect (160, 435, 300, 20), "враги 020 | сила 002 | строения 000 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
				GUI.Label (new Rect (160, 465, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
				GUI.Label (new Rect (160, 495, 300, 20), "враги 010 | сила 002 | строения 110 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
				GUI.Label (new Rect (160, 525, 300, 20), "враги 005 | сила 002 | строения 010 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
				GUI.Label (new Rect (160, 555, 300, 20), "враги 010 | сила 002 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
				GUI.Label (new Rect (160, 585, 300, 20), "враги 030 | сила 002 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
				GUI.Label (new Rect (160, 615, 300, 20), "враги 005 | сила 002 | строения 055 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
				GUI.Label (new Rect (160, 645, 300, 20), "враги 005 | сила 002 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
				GUI.Label (new Rect (160, 675, 300, 20), "враги 005 | сила 002 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
				GUI.Label (new Rect (160, 705, 300, 20), "враги 010 | сила 002 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
				GUI.Label (new Rect (160, 735, 300, 20), "враги 015 | сила 002 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
				GUI.Label (new Rect (160, 765, 300, 20), "враги 015 | сила 002 | строения 050 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
				GUI.Label (new Rect (160, 795, 300, 20), "враги 010 | сила 002 | строения 000 | пузыри 240", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
				GUI.Label (new Rect (160, 825, 300, 20), "враги 015 | сила 002 | строения 305 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
				GUI.Label (new Rect (160, 855, 300, 20), "враги 005 | сила 002 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
				GUI.Label (new Rect (160, 885, 300, 20), "враги 020 | сила 002 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
				GUI.Label (new Rect (160, 915, 300, 20), "враги 005 | сила 002 | строения 035 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
				GUI.Label (new Rect (160, 945, 300, 20), "враги 005 | сила 002 | строения 045 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
				GUI.Label (new Rect (160, 975, 300, 20), "враги 015 | сила 002 | строения 005 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
				GUI.Label (new Rect (160, 1005, 300, 20), "враги 010 | сила 002 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
				GUI.Label (new Rect (160, 1035, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
				GUI.Label (new Rect (160, 1065, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
				GUI.Label (new Rect (160, 1095, 300, 20), "враги 005 | сила 002 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
				GUI.Label (new Rect (160, 1125, 300, 20), "враги 005 | сила 002 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
				GUI.Label (new Rect (160, 1155, 300, 20), "враги 010 | сила 002 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
				GUI.Label (new Rect (160, 1185, 300, 20), "враги 010 | сила 002 | строения 050 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
				GUI.Label (new Rect (160, 1215, 300, 20), "враги 015 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
				GUI.Label (new Rect (160, 1245, 300, 20), "враги 015 | сила 002 | строения 100 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
				GUI.Label (new Rect (160, 1275, 300, 20), "враги 010 | сила 002 | строения 050 | пузыри 025", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
				GUI.Label (new Rect (160, 1305, 300, 20), "враги 005 | сила 002 | строения 000 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
				GUI.Label (new Rect (160, 1335, 300, 20), "враги 010 | сила 002 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
				GUI.Label (new Rect (160, 1365, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
				GUI.Label (new Rect (160, 1395, 300, 20), "враги 015 | сила 002 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
				GUI.Label (new Rect (160, 1425, 300, 20), "враги 015 | сила 002 | строения 006 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
				GUI.Label (new Rect (160, 1455, 300, 20), "враги 010 | сила 002 | строения 011 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
				GUI.Label (new Rect (160, 1485, 300, 20), "враги 020 | сила 002 | строения 410 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
				GUI.Label (new Rect (160, 1515, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
				GUI.Label (new Rect (160, 1545, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
				GUI.Label (new Rect (160, 1575, 300, 20), "враги 005 | сила 002 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
				GUI.Label (new Rect (160, 1605, 300, 20), "враги 020 | сила 002 | строения 100 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
				GUI.Label (new Rect (160, 1635, 300, 20), "враги 010 | сила 002 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
				GUI.Label (new Rect (160, 1665, 300, 20), "враги 010 | сила 002 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
				GUI.Label (new Rect (160, 1695, 300, 20), "враги 010 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
				GUI.Label (new Rect (160, 1725, 300, 20), "враги 010 | сила 002 | строения 205 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
				GUI.Label (new Rect (160, 1755, 300, 20), "враги 015 | сила 002 | строения 055 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
				GUI.Label (new Rect (160, 1785, 300, 20), "враги 015 | сила 002 | строения 205 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
				GUI.Label (new Rect (160, 1815, 300, 20), "враги 005 | сила 002 | строения 005 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
				GUI.Label (new Rect (160, 1845, 300, 20), "враги 005 | сила 002 | строения 050 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
				GUI.Label (new Rect (160, 1875, 300, 20), "враги 015 | сила 002 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
				GUI.Label (new Rect (160, 1905, 300, 20), "враги 005 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
				GUI.Label (new Rect (160, 1935, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
				GUI.Label (new Rect (160, 1965, 300, 20), "враги 010 | сила 002 | строения 050 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
				GUI.Label (new Rect (160, 1995, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
				GUI.Label (new Rect (160, 2025, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
				GUI.Label (new Rect (160, 2055, 300, 20), "враги 010 | сила 002 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
				GUI.Label (new Rect (160, 2085, 300, 20), "враги 010 | сила 002 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
				GUI.Label (new Rect (160, 2115, 300, 20), "враги 010 | сила 002 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
				GUI.Label (new Rect (160, 2145, 300, 20), "враги 010 | сила 002 | строения 000 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
				GUI.Label (new Rect (160, 2175, 300, 20), "враги 010 | сила 002 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
				GUI.Label (new Rect (160, 2205, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
				GUI.Label (new Rect (160, 2235, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
				GUI.Label (new Rect (160, 2265, 300, 20), "враги 010 | сила 002 | строения 200 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
				GUI.Label (new Rect (160, 2295, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
				GUI.Label (new Rect (160, 2325, 300, 20), "враги 010 | сила 002 | строения 310 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
				GUI.Label (new Rect (160, 2355, 300, 20), "враги 010 | сила 002 | строения 210 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
				GUI.Label (new Rect (160, 2385, 300, 20), "враги 010 | сила 002 | строения 310 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
				GUI.Label (new Rect (160, 2415, 300, 20), "враги 010 | сила 002 | строения 210 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
				GUI.Label (new Rect (160, 2445, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
				GUI.Label (new Rect (160, 2475, 300, 20), "враги 010 | сила 002 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
				GUI.Label (new Rect (160, 2505, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
				GUI.Label (new Rect (160, 2535, 300, 20), "враги 010 | сила 002 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
				GUI.Label (new Rect (160, 2565, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
				GUI.Label (new Rect (160, 2595, 300, 20), "враги 010 | сила 002 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
				GUI.Label (new Rect (160, 2625, 300, 20), "враги 010 | сила 002 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
				GUI.Label (new Rect (160, 2655, 300, 20), "враги 025 | сила 002 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
				GUI.Label (new Rect (160, 2685, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
				GUI.Label (new Rect (160, 2715, 300, 20), "враги 010 | сила 002 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}

			if (MenuScript.diff ==3) {
				GUI.Label (new Rect (160, 15, 300, 20), "враги 005 | сила 003 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
				GUI.Label (new Rect (160, 45, 300, 20), "враги 015 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
				GUI.Label (new Rect (160, 75, 300, 20), "враги 005 | сила 003 | строения 250 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
				GUI.Label (new Rect (160, 105, 300, 20), "враги 005 | сила 003 | строения 000 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
				GUI.Label (new Rect (160, 135, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
				GUI.Label (new Rect (160, 165, 300, 20), "враги 025 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
				GUI.Label (new Rect (160, 195, 300, 20), "враги 010 | сила 003 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
				GUI.Label (new Rect (160, 225, 300, 20), "враги 010 | сила 003 | строения 030 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
				GUI.Label (new Rect (160, 255, 300, 20), "враги 010 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
				GUI.Label (new Rect (160, 285, 300, 20), "враги 010 | сила 003 | строения 060 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
				GUI.Label (new Rect (160, 315, 300, 20), "враги 005 | сила 003 | строения 010 | пузыри 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
				GUI.Label (new Rect (160, 345, 300, 20), "враги 015 | сила 003 | строения 015 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
				GUI.Label (new Rect (160, 375, 300, 20), "враги 005 | сила 003 | строения 250 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
				GUI.Label (new Rect (160, 405, 300, 20), "враги 005 | сила 003 | строения 000 | пузыри 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
				GUI.Label (new Rect (160, 435, 300, 20), "враги 020 | сила 003 | строения 000 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
				GUI.Label (new Rect (160, 465, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
				GUI.Label (new Rect (160, 495, 300, 20), "враги 010 | сила 003 | строения 110 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
				GUI.Label (new Rect (160, 525, 300, 20), "враги 005 | сила 003 | строения 010 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
				GUI.Label (new Rect (160, 555, 300, 20), "враги 010 | сила 003 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
				GUI.Label (new Rect (160, 585, 300, 20), "враги 030 | сила 003 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
				GUI.Label (new Rect (160, 615, 300, 20), "враги 005 | сила 003 | строения 055 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
				GUI.Label (new Rect (160, 645, 300, 20), "враги 005 | сила 003 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
				GUI.Label (new Rect (160, 675, 300, 20), "враги 005 | сила 003 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
				GUI.Label (new Rect (160, 705, 300, 20), "враги 010 | сила 003 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
				GUI.Label (new Rect (160, 735, 300, 20), "враги 015 | сила 003 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
				GUI.Label (new Rect (160, 765, 300, 20), "враги 015 | сила 003 | строения 050 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
				GUI.Label (new Rect (160, 795, 300, 20), "враги 010 | сила 003 | строения 000 | пузыри 240", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
				GUI.Label (new Rect (160, 825, 300, 20), "враги 015 | сила 003 | строения 305 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
				GUI.Label (new Rect (160, 855, 300, 20), "враги 005 | сила 003 | строения 040 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
				GUI.Label (new Rect (160, 885, 300, 20), "враги 020 | сила 003 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
				GUI.Label (new Rect (160, 915, 300, 20), "враги 005 | сила 003 | строения 035 | пузыри 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
				GUI.Label (new Rect (160, 945, 300, 20), "враги 005 | сила 003 | строения 045 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
				GUI.Label (new Rect (160, 975, 300, 20), "враги 015 | сила 003 | строения 005 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
				GUI.Label (new Rect (160, 1005, 300, 20), "враги 010 | сила 003 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
				GUI.Label (new Rect (160, 1035, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
				GUI.Label (new Rect (160, 1065, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
				GUI.Label (new Rect (160, 1095, 300, 20), "враги 005 | сила 003 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
				GUI.Label (new Rect (160, 1125, 300, 20), "враги 005 | сила 003 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
				GUI.Label (new Rect (160, 1155, 300, 20), "враги 010 | сила 003 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
				GUI.Label (new Rect (160, 1185, 300, 20), "враги 010 | сила 003 | строения 050 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
				GUI.Label (new Rect (160, 1215, 300, 20), "враги 015 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
				GUI.Label (new Rect (160, 1245, 300, 20), "враги 015 | сила 003 | строения 100 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
				GUI.Label (new Rect (160, 1275, 300, 20), "враги 010 | сила 003 | строения 050 | пузыри 025", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
				GUI.Label (new Rect (160, 1305, 300, 20), "враги 005 | сила 003 | строения 000 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
				GUI.Label (new Rect (160, 1335, 300, 20), "враги 010 | сила 003 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
				GUI.Label (new Rect (160, 1365, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
				GUI.Label (new Rect (160, 1395, 300, 20), "враги 015 | сила 003 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
				GUI.Label (new Rect (160, 1425, 300, 20), "враги 015 | сила 003 | строения 006 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
				GUI.Label (new Rect (160, 1455, 300, 20), "враги 010 | сила 003 | строения 011 | пузыри 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
				GUI.Label (new Rect (160, 1485, 300, 20), "враги 020 | сила 003 | строения 410 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
				GUI.Label (new Rect (160, 1515, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
				GUI.Label (new Rect (160, 1545, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
				GUI.Label (new Rect (160, 1575, 300, 20), "враги 005 | сила 003 | строения 100 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
				GUI.Label (new Rect (160, 1605, 300, 20), "враги 020 | сила 003 | строения 100 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
				GUI.Label (new Rect (160, 1635, 300, 20), "враги 010 | сила 003 | строения 200 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
				GUI.Label (new Rect (160, 1665, 300, 20), "враги 010 | сила 003 | строения 000 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
				GUI.Label (new Rect (160, 1695, 300, 20), "враги 010 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
				GUI.Label (new Rect (160, 1725, 300, 20), "враги 010 | сила 003 | строения 205 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
				GUI.Label (new Rect (160, 1755, 300, 20), "враги 015 | сила 003 | строения 055 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
				GUI.Label (new Rect (160, 1785, 300, 20), "враги 015 | сила 003 | строения 205 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
				GUI.Label (new Rect (160, 1815, 300, 20), "враги 005 | сила 003 | строения 005 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
				GUI.Label (new Rect (160, 1845, 300, 20), "враги 005 | сила 003 | строения 050 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
				GUI.Label (new Rect (160, 1875, 300, 20), "враги 015 | сила 003 | строения 005 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
				GUI.Label (new Rect (160, 1905, 300, 20), "враги 005 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
				GUI.Label (new Rect (160, 1935, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
				GUI.Label (new Rect (160, 1965, 300, 20), "враги 010 | сила 003 | строения 050 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
				GUI.Label (new Rect (160, 1995, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
				GUI.Label (new Rect (160, 2025, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
				GUI.Label (new Rect (160, 2055, 300, 20), "враги 010 | сила 003 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
				GUI.Label (new Rect (160, 2085, 300, 20), "враги 010 | сила 003 | строения 010 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
				GUI.Label (new Rect (160, 2115, 300, 20), "враги 010 | сила 003 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
				GUI.Label (new Rect (160, 2145, 300, 20), "враги 010 | сила 003 | строения 000 | пузыри 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
				GUI.Label (new Rect (160, 2175, 300, 20), "враги 010 | сила 003 | строения 300 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
				GUI.Label (new Rect (160, 2205, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
				GUI.Label (new Rect (160, 2235, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
				GUI.Label (new Rect (160, 2265, 300, 20), "враги 010 | сила 003 | строения 200 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
				GUI.Label (new Rect (160, 2295, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
				GUI.Label (new Rect (160, 2325, 300, 20), "враги 010 | сила 003 | строения 310 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
				GUI.Label (new Rect (160, 2355, 300, 20), "враги 010 | сила 003 | строения 210 | пузыри 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
				GUI.Label (new Rect (160, 2385, 300, 20), "враги 010 | сила 003 | строения 310 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
				GUI.Label (new Rect (160, 2415, 300, 20), "враги 010 | сила 003 | строения 210 | пузыри 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
				GUI.Label (new Rect (160, 2445, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
				GUI.Label (new Rect (160, 2475, 300, 20), "враги 010 | сила 003 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
				GUI.Label (new Rect (160, 2505, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
				GUI.Label (new Rect (160, 2535, 300, 20), "враги 010 | сила 003 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
				GUI.Label (new Rect (160, 2565, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
				GUI.Label (new Rect (160, 2595, 300, 20), "враги 010 | сила 003 | строения 105 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
				GUI.Label (new Rect (160, 2625, 300, 20), "враги 010 | сила 003 | строения 205 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
				GUI.Label (new Rect (160, 2655, 300, 20), "враги 025 | сила 003 | строения 005 | пузыри 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
				GUI.Label (new Rect (160, 2685, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
				GUI.Label (new Rect (160, 2715, 300, 20), "враги 010 | сила 003 | строения 100 | пузыри 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}





			if (GUI.Button (new Rect (15, 15, 100, 20), "Уровень01(S)")) {
				Application.LoadLevel ("LLevel1");
			}
			if (GUI.Button (new Rect (15, 45, 100, 20), "Уровень02(S)")) {
				if (GDB.unlockLeavel >= 2) {
					Application.LoadLevel ("LLevel2");
				}
			}
			if (GUI.Button (new Rect (15, 75, 100, 20), "Уровень03(S)")) {
				if (GDB.unlockLeavel >= 3) {
					Application.LoadLevel ("LLevel3");
				}
			}
			if (GUI.Button (new Rect (15, 105, 100, 20), "Уровень04(S)")) {
				if (GDB.unlockLeavel >= 4) {
					Application.LoadLevel ("LLevel4");
				}
			}
			if (GUI.Button (new Rect (15, 135, 100, 20), "Уровень05(M)")) {
				if (GDB.unlockLeavel >= 5) {
					Application.LoadLevel ("LLevel5");
				}
			}
			if (GUI.Button (new Rect (15, 165, 100, 20), "Уровень06(M)")) {
				if (GDB.unlockLeavel >= 6) {
					Application.LoadLevel ("LLevel6");
				}
			}
			if (GUI.Button (new Rect (15, 195, 100, 20), "Уровень07(S)")) {
				if (GDB.unlockLeavel >= 7) {
					Application.LoadLevel ("LLevel7");
				}
			}
			if (GUI.Button (new Rect (15, 225, 100, 20), "Уровень08(S)")) {
				if (GDB.unlockLeavel >= 8) {
					Application.LoadLevel ("LLevel8");
				}
			}
			if (GUI.Button (new Rect (15, 255, 100, 20), "Уровень09(S)")) {
				if (GDB.unlockLeavel >= 9) {
					Application.LoadLevel ("LLevel9");
				}
			}
			if (GUI.Button (new Rect (15, 285, 100, 20), "Уровень10(M)")) {
				if (GDB.unlockLeavel >= 10) {
					Application.LoadLevel ("LLevel10");
				}
			}
			if (GUI.Button (new Rect (15, 315, 100, 20), "Уровень11(M)")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel11");
				}
			}
			if (GUI.Button (new Rect (15, 345, 100, 20), "Уровень12(M)")) {
				if (GDB.unlockLeavel >= 12) {
					Application.LoadLevel ("LLevel12");
				}
			}
			if (GUI.Button (new Rect (15, 375, 100, 20), "Уровень13(S)")) {
				if (GDB.unlockLeavel >= 13) {
					Application.LoadLevel ("LLevel13");
				}
			}
			if (GUI.Button (new Rect (15, 405, 100, 20), "Уровень14(S)")) {
				if (GDB.unlockLeavel >= 14) {
					Application.LoadLevel ("LLevel14");
				}
			}
			if (GUI.Button (new Rect (15, 435, 100, 20), "Уровень15(S)")) {
				if (GDB.unlockLeavel >= 15) {
					Application.LoadLevel ("LLevel15");
				}
			}
			if (GUI.Button (new Rect (15, 465, 100, 20), "Уровень16(S)")) {
				if (GDB.unlockLeavel >= 16) {
					Application.LoadLevel ("LLevel16");
				}
			}
			if (GUI.Button (new Rect (15, 495, 100, 20), "Уровень17(M)")) {
				if (GDB.unlockLeavel >= 17) {
					Application.LoadLevel ("LLevel17");
				}
			}
			if (GUI.Button (new Rect (15, 525, 100, 20), "Уровень18(S)")) {
				if (GDB.unlockLeavel >= 18) {
					Application.LoadLevel ("LLevel18");
				}
			}
			if (GUI.Button (new Rect (15, 555, 100, 20), "Уровень19(M)")) {
				if (GDB.unlockLeavel >= 19) {
					Application.LoadLevel ("LLevel19");
				}
			}
			if (GUI.Button (new Rect (15, 585, 100, 20), "Уровень20(M)")) {
				if (GDB.unlockLeavel >= 20) {
					Application.LoadLevel ("LLevel20");
				}
			}
			if (GUI.Button (new Rect (15, 615, 100, 20), "Уровень21(S)")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel21");
				}
			}
			if (GUI.Button (new Rect (15, 645, 100, 20), "Уровень22(S)")) {
				if (GDB.unlockLeavel >= 22) {
					Application.LoadLevel ("LLevel22");
				}
			}
			if (GUI.Button (new Rect (15, 675, 100, 20), "Уровень23(S)")) {
				if (GDB.unlockLeavel >= 23) {
					Application.LoadLevel ("LLevel23");
				}
			}
			if (GUI.Button (new Rect (15, 705, 100, 20), "Уровень24(S)")) {
				if (GDB.unlockLeavel >= 24) {
					Application.LoadLevel ("LLevel24");
				}
			}
			if (GUI.Button (new Rect (15, 735, 100, 20), "Уровень25(M)")) {
				if (GDB.unlockLeavel >= 25) {
					Application.LoadLevel ("LLevel25");
				}
			}
			if (GUI.Button (new Rect (15, 765, 100, 20), "Уровень26(S)")) {
				if (GDB.unlockLeavel >= 26) {
					Application.LoadLevel ("LLevel26");
				}
			}
			if (GUI.Button (new Rect (15, 795, 100, 20), "Уровень27(M)")) {
				if (GDB.unlockLeavel >= 27) {
					Application.LoadLevel ("LLevel27");
				}
			}
			if (GUI.Button (new Rect (15, 825, 100, 20), "Уровень28(M)")) {
				if (GDB.unlockLeavel >= 28) {
					Application.LoadLevel ("LLevel28");
				}
			}
			if (GUI.Button (new Rect (15, 855, 100, 20), "Уровень29(S)")) {
				if (GDB.unlockLeavel >= 29) {
					Application.LoadLevel ("LLevel29");
				}
			}
			if (GUI.Button (new Rect (15, 885, 100, 20), "Уровень30(M)")) {
				if (GDB.unlockLeavel >= 30) {
					Application.LoadLevel ("LLevel30");
				}
			}
			if (GUI.Button (new Rect (15, 915, 100, 20), "Уровень31(S)")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel31");
				}
			}
			if (GUI.Button (new Rect (15, 945, 100, 20), "Уровень32(S)")) {
				if (GDB.unlockLeavel >= 32) {
					Application.LoadLevel ("LLevel32");
				}
			}
			if (GUI.Button (new Rect (15, 975, 100, 20), "Уровень33(M)")) {
				if (GDB.unlockLeavel >= 33) {
					Application.LoadLevel ("LLevel33");
				}
			}
			if (GUI.Button (new Rect (15, 1005, 100, 20), "Уровень34(M)")) {
				if (GDB.unlockLeavel >= 34) {
					Application.LoadLevel ("LLevel34");
				}
			}
			if (GUI.Button (new Rect (15, 1035, 100, 20), "Уровень35(M)")) {
				if (GDB.unlockLeavel >= 35) {
					Application.LoadLevel ("LLevel35");
				}
			}
			if (GUI.Button (new Rect (15, 1065, 100, 20), "Уровень36(M)")) {
				if (GDB.unlockLeavel >= 36) {
					Application.LoadLevel ("LLevel36");
				}
			}
			if (GUI.Button (new Rect (15, 1095, 100, 20), "Уровень37(S)")) {
				if (GDB.unlockLeavel >= 37) {
					Application.LoadLevel ("LLevel37");
				}
			}
			if (GUI.Button (new Rect (15, 1125, 100, 20), "Уровень38(S)")) {
				if (GDB.unlockLeavel >= 38) {
					Application.LoadLevel ("LLevel38");
				}
			}
			if (GUI.Button (new Rect (15, 1155, 100, 20), "Уровень39(M)")) {
				if (GDB.unlockLeavel >= 39) {
					Application.LoadLevel ("LLevel39");
				}
			}
			if (GUI.Button (new Rect (15, 1185, 100, 20), "Уровень40(M)")) {
				if (GDB.unlockLeavel >= 40) {
					Application.LoadLevel ("LLevel40");
				}
			}
			if (GUI.Button (new Rect (15, 1215, 100, 20), "Уровень41(S)")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel41");
				}
			}
			if (GUI.Button (new Rect (15, 1245, 100, 20), "Уровень42(S)")) {
				if (GDB.unlockLeavel >= 42) {
					Application.LoadLevel ("LLevel42");
				}
			}
			if (GUI.Button (new Rect (15, 1275, 100, 20), "Уровень43(S)")) {
				if (GDB.unlockLeavel >= 43) {
					Application.LoadLevel ("LLevel43");
				}
			}
			if (GUI.Button (new Rect (15, 1305, 100, 20), "Уровень44(S)")) {
				if (GDB.unlockLeavel >= 44) {
					Application.LoadLevel ("LLevel44");
				}
			}
			if (GUI.Button (new Rect (15, 1335, 100, 20), "Уровень45(M)")) {
				if (GDB.unlockLeavel >= 45) {
					Application.LoadLevel ("LLevel45");
				}
			}
			if (GUI.Button (new Rect (15, 1365, 100, 20), "Уровень46(M)")) {
				if (GDB.unlockLeavel >= 46) {
					Application.LoadLevel ("LLevel46");
				}
			}
			if (GUI.Button (new Rect (15, 1395, 100, 20), "Уровень47(M)")) {
				if (GDB.unlockLeavel >= 47) {
					Application.LoadLevel ("LLevel47");
				}
			}
			if (GUI.Button (new Rect (15, 1425, 100, 20), "Уровень48(M)")) {
				if (GDB.unlockLeavel >= 48) {
					Application.LoadLevel ("LLevel48");
				}
			}
			if (GUI.Button (new Rect (15, 1455, 100, 20), "Уровень49(M)")) {
				if (GDB.unlockLeavel >= 49) {
					Application.LoadLevel ("LLevel49");
				}
			}
			if (GUI.Button (new Rect (15, 1485, 100, 20), "Уровень50(L)")) {
				if (GDB.unlockLeavel >= 50) {
					Application.LoadLevel ("LLevel50");
				}
			}
			if (GUI.Button (new Rect (15, 1515, 100, 20), "Уровень51(M)")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel51");
				}
			}
			if (GUI.Button (new Rect (15, 1545, 100, 20), "Уровень52(M)")) {
				if (GDB.unlockLeavel >= 52) {
					Application.LoadLevel ("LLevel52");
				}
			}
			if (GUI.Button (new Rect (15, 1575, 100, 20), "Уровень53(S)")) {
				if (GDB.unlockLeavel >= 53) {
					Application.LoadLevel ("LLevel53");
				}
			}
			if (GUI.Button (new Rect (15, 1605, 100, 20), "Уровень54(L)")) {
				if (GDB.unlockLeavel >= 54) {
					Application.LoadLevel ("LLevel54");
				}
			}
			if (GUI.Button (new Rect (15, 1635, 100, 20), "Уровень55(M)")) {
				if (GDB.unlockLeavel >= 55) {
					Application.LoadLevel ("LLevel55");
				}
			}
			if (GUI.Button (new Rect (15, 1665, 100, 20), "Уровень56(M)")) {
				if (GDB.unlockLeavel >= 56) {
					Application.LoadLevel ("LLevel56");
				}
			}
			if (GUI.Button (new Rect (15, 1695, 100, 20), "Уровень57(M)")) {
				if (GDB.unlockLeavel >= 57) {
					Application.LoadLevel ("LLevel57");
				}
			}
			if (GUI.Button (new Rect (15, 1725, 100, 20), "Уровень58(M)")) {
				if (GDB.unlockLeavel >= 58) {
					Application.LoadLevel ("LLevel58");
				}
			}
			if (GUI.Button (new Rect (15, 1755, 100, 20), "Уровень59(L)")) {
				if (GDB.unlockLeavel >= 59) {
					Application.LoadLevel ("LLevel59");
				}
			}
			if (GUI.Button (new Rect (15, 1785, 100, 20), "Уровень60(L)")) {
				if (GDB.unlockLeavel >= 60) {
					Application.LoadLevel ("LLevel60");
				}
			}
			if (GUI.Button (new Rect (15, 1815, 100, 20), "Уровень61(M)")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel61");
				}
			}
			if (GUI.Button (new Rect (15, 1845, 100, 20), "Уровень62(S)")) {
				if (GDB.unlockLeavel >= 62) {
					Application.LoadLevel ("LLevel62");
				}
			}
			if (GUI.Button (new Rect (15, 1875, 100, 20), "Уровень63(S)")) {
				if (GDB.unlockLeavel >= 63) {
					Application.LoadLevel ("LLevel63");
				}
			}
			if (GUI.Button (new Rect (15, 1905, 100, 20), "Уровень64(M)")) {
				if (GDB.unlockLeavel >= 64) {
					Application.LoadLevel ("LLevel64");
				}
			}
			if (GUI.Button (new Rect (15, 1935, 100, 20), "Уровень65(L)")) {
				if (GDB.unlockLeavel >= 65) {
					Application.LoadLevel ("LLevel65");
				}
			}
			if (GUI.Button (new Rect (15, 1965, 100, 20), "Уровень66(M)")) {
				if (GDB.unlockLeavel >= 66) {
					Application.LoadLevel ("LLevel66");
				}
			}
			if (GUI.Button (new Rect (15, 1995, 100, 20), "Уровень67(L)")) {
				if (GDB.unlockLeavel >= 67) {
					Application.LoadLevel ("LLevel67");
				}
			}
			if (GUI.Button (new Rect (15, 2025, 100, 20), "Уровень68(M)")) {
				if (GDB.unlockLeavel >= 68) {
					Application.LoadLevel ("LLevel68");
				}
			}
			if (GUI.Button (new Rect (15, 2055, 100, 20), "Уровень69(L)")) {
				if (GDB.unlockLeavel >= 69) {
					Application.LoadLevel ("LLevel69");
				}
			}
			if (GUI.Button (new Rect (15, 2085, 100, 20), "Уровень70(M)")) {
				if (GDB.unlockLeavel >= 70) {
					Application.LoadLevel ("LLevel70");
				}
			}
			if (GUI.Button (new Rect (15, 2115, 100, 20), "Уровень71(M)")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel71");
				}
			}
			if (GUI.Button (new Rect (15, 2145, 100, 20), "Уровень72(L)")) {
				if (GDB.unlockLeavel >= 72) {
					Application.LoadLevel ("LLevel72");
				}
			}
			if (GUI.Button (new Rect (15, 2175, 100, 20), "Уровень73(M)")) {
				if (GDB.unlockLeavel >= 73) {
					Application.LoadLevel ("LLevel73");
				}
			}
			if (GUI.Button (new Rect (15, 2205, 100, 20), "Уровень74(L)")) {
				if (GDB.unlockLeavel >= 74) {
					Application.LoadLevel ("LLevel74");
				}
			}
			if (GUI.Button (new Rect (15, 2235, 100, 20), "Уровень75(M)")) {
				if (GDB.unlockLeavel >= 75) {
					Application.LoadLevel ("LLevel75");
				}
			}
			if (GUI.Button (new Rect (15, 2265, 100, 20), "Уровень76(L)")) {
				if (GDB.unlockLeavel >= 76) {
					Application.LoadLevel ("LLevel76");
				}
			}
			if (GUI.Button (new Rect (15, 2295, 100, 20), "Уровень77(L)")) {
				if (GDB.unlockLeavel >= 77) {
					Application.LoadLevel ("LLevel77");
				}
			}
			if (GUI.Button (new Rect (15, 2325, 100, 20), "Уровень78(M)")) {
				if (GDB.unlockLeavel >= 78) {
					Application.LoadLevel ("LLevel78");
				}
			}
			if (GUI.Button (new Rect (15, 2355, 100, 20), "Уровень79(L)")) {
				if (GDB.unlockLeavel >= 79) {
					Application.LoadLevel ("LLevel79");
				}
			}
			if (GUI.Button (new Rect (15, 2385, 100, 20), "Уровень80(L)")) {
				if (GDB.unlockLeavel >= 80) {
					Application.LoadLevel ("LLevel80");
				}
			}
			if (GUI.Button (new Rect (15, 2415, 100, 20), "Уровень81(M)")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel81");
				}
			}
			if (GUI.Button (new Rect (15, 2445, 100, 20), "Уровень82(M)")) {
				if (GDB.unlockLeavel >= 82) {
					Application.LoadLevel ("LLevel82");
				}
			}
			if (GUI.Button (new Rect (15, 2475, 100, 20), "Уровень83(L)")) {
				if (GDB.unlockLeavel >= 83) {
					Application.LoadLevel ("LLevel83");
				}
			}
			if (GUI.Button (new Rect (15, 2505, 100, 20), "Уровень84(M)")) {
				if (GDB.unlockLeavel >= 84) {
					Application.LoadLevel ("LLevel84");
				}
			}
			if (GUI.Button (new Rect (15, 2535, 100, 20), "Уровень85(L)")) {
				if (GDB.unlockLeavel >= 85) {
					Application.LoadLevel ("LLevel85");
				}
			}
			if (GUI.Button (new Rect (15, 2565, 100, 20), "Уровень86(M)")) {
				if (GDB.unlockLeavel >= 86) {
					Application.LoadLevel ("LLevel86");
				}
			}
			if (GUI.Button (new Rect (15, 2595, 100, 20), "Уровень87(M)")) {
				if (GDB.unlockLeavel >= 87) {
					Application.LoadLevel ("LLevel87");
				}
			}
			if (GUI.Button (new Rect (15, 2625, 100, 20), "Уровень88(L)")) {
				if (GDB.unlockLeavel >= 88) {
					Application.LoadLevel ("LLevel88");
				}
			}
			if (GUI.Button (new Rect (15, 2655, 100, 20), "Уровень89(M)")) {
				if (GDB.unlockLeavel >= 89) {
					Application.LoadLevel ("LLevel89");
				}
			}
			if (GUI.Button (new Rect (15, 2685, 100, 20), "Уровень90(M)")) {
				if (GDB.unlockLeavel >= 90) {
					Application.LoadLevel ("LLevel90");
				}
			}
			if (GUI.Button (new Rect (15, 2715, 100, 20), "Уровень91(M)")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel91");
				}
			}
		}

		///eng
		if (MenuScript.lang == 2) {
			if (GUI.Button (new Rect (610, 50, 150, 30), "Character")) {
				Application.LoadLevel ("PlayerMenu");
			}
			
			if (GUI.Button (new Rect (610, 90, 150, 30), "Main Menu")) {
				Application.LoadLevel ("Menu");
			}
			
			if (GUI.Button (new Rect (640, 130, 100, 20), "(10)BOSS-1")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel92");
				}
			}
			if (GUI.Button (new Rect (640, 160, 100, 20), "(20)BOSS-2")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel93");
				}
			}
			if (GUI.Button (new Rect (640, 190, 100, 20), "(30)BOSS-3")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel94");
				}
			}
			if (GUI.Button (new Rect (640, 220, 100, 20), "(40)BOSS-4")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel95");
				}
			}
			if (GUI.Button (new Rect (640, 250, 100, 20), "(50)BOSS-5")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel96");
				}
			}
			if (GUI.Button (new Rect (640, 280, 100, 20), "(60)BOSS-6")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel97");
				}
			}
			if (GUI.Button (new Rect (640, 310, 100, 20), "(70)BOSS-7")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel98");
				}
			}
			if (GUI.Button (new Rect (640, 340, 100, 20), "(80)BOSS-8")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel99");
				}
			}
			if (GUI.Button (new Rect (640, 370, 100, 20), "(90)BOSS-9")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel100");
				}
			}
			if (GUI.Button (new Rect (640, 400, 100, 20), "Main Evil")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel101");
				}
			}
			
			
			if (GDB.unlockLeavel < 11) {
				GUI.DrawTexture (new Rect (610, 130, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 21) {
				GUI.DrawTexture (new Rect (610, 160, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 31) {
				GUI.DrawTexture (new Rect (610, 190, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 41) {
				GUI.DrawTexture (new Rect (610, 220, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 51) {
				GUI.DrawTexture (new Rect (610, 250, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 61) {
				GUI.DrawTexture (new Rect (610, 280, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 71) {
				GUI.DrawTexture (new Rect (610, 310, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 81) {
				GUI.DrawTexture (new Rect (610, 340, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 370, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 400, 20, 20), closed);
			}
			
			
			
			
			
			
			
			scrollPosition = GUI.BeginScrollView (new Rect (1, 1, 570, Screen.height), scrollPosition, new Rect (0, 0, 500, 4000));
			
			if (MenuScript.diff <= 1){
			GUI.Label (new Rect (160, 15, 300, 20), "enemy 005 | diff 001 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
			GUI.Label (new Rect (160, 45, 300, 20), "enemy 015 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
			GUI.Label (new Rect (160, 75, 300, 20), "enemy 005 | diff 001 | structur 250 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
			GUI.Label (new Rect (160, 105, 300, 20), "enemy 005 | diff 001 | structur 000 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
			GUI.Label (new Rect (160, 135, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
			GUI.Label (new Rect (160, 165, 300, 20), "enemy 025 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
			GUI.Label (new Rect (160, 195, 300, 20), "enemy 010 | diff 001 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
			GUI.Label (new Rect (160, 225, 300, 20), "enemy 010 | diff 001 | structur 030 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
			GUI.Label (new Rect (160, 255, 300, 20), "enemy 010 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
			GUI.Label (new Rect (160, 285, 300, 20), "enemy 010 | diff 001 | structur 060 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
			GUI.Label (new Rect (160, 315, 300, 20), "enemy 005 | diff 001 | structur 010 | bubble 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
			GUI.Label (new Rect (160, 345, 300, 20), "enemy 015 | diff 001 | structur 015 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
			GUI.Label (new Rect (160, 375, 300, 20), "enemy 005 | diff 001 | structur 250 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
			GUI.Label (new Rect (160, 405, 300, 20), "enemy 005 | diff 001 | structur 000 | bubble 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
			GUI.Label (new Rect (160, 435, 300, 20), "enemy 020 | diff 001 | structur 000 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
			GUI.Label (new Rect (160, 465, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
			GUI.Label (new Rect (160, 495, 300, 20), "enemy 010 | diff 001 | structur 110 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
			GUI.Label (new Rect (160, 525, 300, 20), "enemy 005 | diff 001 | structur 010 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
			GUI.Label (new Rect (160, 555, 300, 20), "enemy 010 | diff 001 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
			GUI.Label (new Rect (160, 585, 300, 20), "enemy 030 | diff 001 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
			GUI.Label (new Rect (160, 615, 300, 20), "enemy 005 | diff 001 | structur 055 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
			GUI.Label (new Rect (160, 645, 300, 20), "enemy 005 | diff 001 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
			GUI.Label (new Rect (160, 675, 300, 20), "enemy 005 | diff 001 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
			GUI.Label (new Rect (160, 705, 300, 20), "enemy 010 | diff 001 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
			GUI.Label (new Rect (160, 735, 300, 20), "enemy 015 | diff 001 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
			GUI.Label (new Rect (160, 765, 300, 20), "enemy 015 | diff 001 | structur 050 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
			GUI.Label (new Rect (160, 795, 300, 20), "enemy 010 | diff 001 | structur 000 | bubble 240", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
			GUI.Label (new Rect (160, 825, 300, 20), "enemy 015 | diff 001 | structur 305 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
			GUI.Label (new Rect (160, 855, 300, 20), "enemy 005 | diff 001 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
			GUI.Label (new Rect (160, 885, 300, 20), "enemy 020 | diff 001 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
			GUI.Label (new Rect (160, 915, 300, 20), "enemy 005 | diff 001 | structur 035 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
			GUI.Label (new Rect (160, 945, 300, 20), "enemy 005 | diff 001 | structur 045 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
			GUI.Label (new Rect (160, 975, 300, 20), "enemy 015 | diff 001 | structur 005 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
			GUI.Label (new Rect (160, 1005, 300, 20), "enemy 010 | diff 001 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
			GUI.Label (new Rect (160, 1035, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
			GUI.Label (new Rect (160, 1065, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
			GUI.Label (new Rect (160, 1095, 300, 20), "enemy 005 | diff 001 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
			GUI.Label (new Rect (160, 1125, 300, 20), "enemy 005 | diff 001 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
			GUI.Label (new Rect (160, 1155, 300, 20), "enemy 010 | diff 001 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
			GUI.Label (new Rect (160, 1185, 300, 20), "enemy 010 | diff 001 | structur 050 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
			GUI.Label (new Rect (160, 1215, 300, 20), "enemy 015 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
			GUI.Label (new Rect (160, 1245, 300, 20), "enemy 015 | diff 001 | structur 100 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
			GUI.Label (new Rect (160, 1275, 300, 20), "enemy 010 | diff 001 | structur 050 | bubble 025", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
			GUI.Label (new Rect (160, 1305, 300, 20), "enemy 005 | diff 001 | structur 000 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
			GUI.Label (new Rect (160, 1335, 300, 20), "enemy 010 | diff 001 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
			GUI.Label (new Rect (160, 1365, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
			GUI.Label (new Rect (160, 1395, 300, 20), "enemy 015 | diff 001 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
			GUI.Label (new Rect (160, 1425, 300, 20), "enemy 015 | diff 001 | structur 006 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
			GUI.Label (new Rect (160, 1455, 300, 20), "enemy 010 | diff 001 | structur 011 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
			GUI.Label (new Rect (160, 1485, 300, 20), "enemy 020 | diff 001 | structur 410 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
			GUI.Label (new Rect (160, 1515, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
			GUI.Label (new Rect (160, 1545, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
			GUI.Label (new Rect (160, 1575, 300, 20), "enemy 005 | diff 001 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
			GUI.Label (new Rect (160, 1605, 300, 20), "enemy 020 | diff 001 | structur 100 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
			GUI.Label (new Rect (160, 1635, 300, 20), "enemy 010 | diff 001 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
			GUI.Label (new Rect (160, 1665, 300, 20), "enemy 010 | diff 001 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
			GUI.Label (new Rect (160, 1695, 300, 20), "enemy 010 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
			GUI.Label (new Rect (160, 1725, 300, 20), "enemy 010 | diff 001 | structur 205 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
			GUI.Label (new Rect (160, 1755, 300, 20), "enemy 015 | diff 001 | structur 055 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
			GUI.Label (new Rect (160, 1785, 300, 20), "enemy 015 | diff 001 | structur 205 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
			GUI.Label (new Rect (160, 1815, 300, 20), "enemy 005 | diff 001 | structur 005 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
			GUI.Label (new Rect (160, 1845, 300, 20), "enemy 005 | diff 001 | structur 050 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
			GUI.Label (new Rect (160, 1875, 300, 20), "enemy 015 | diff 001 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
			GUI.Label (new Rect (160, 1905, 300, 20), "enemy 005 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
			GUI.Label (new Rect (160, 1935, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
			GUI.Label (new Rect (160, 1965, 300, 20), "enemy 010 | diff 001 | structur 050 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
			GUI.Label (new Rect (160, 1995, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
			GUI.Label (new Rect (160, 2025, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
			GUI.Label (new Rect (160, 2055, 300, 20), "enemy 010 | diff 001 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
			GUI.Label (new Rect (160, 2085, 300, 20), "enemy 010 | diff 001 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
			GUI.Label (new Rect (160, 2115, 300, 20), "enemy 010 | diff 001 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
			GUI.Label (new Rect (160, 2145, 300, 20), "enemy 010 | diff 001 | structur 000 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
			GUI.Label (new Rect (160, 2175, 300, 20), "enemy 010 | diff 001 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
			GUI.Label (new Rect (160, 2205, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
			GUI.Label (new Rect (160, 2235, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
			GUI.Label (new Rect (160, 2265, 300, 20), "enemy 010 | diff 001 | structur 200 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
			GUI.Label (new Rect (160, 2295, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
			GUI.Label (new Rect (160, 2325, 300, 20), "enemy 010 | diff 001 | structur 310 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
			GUI.Label (new Rect (160, 2355, 300, 20), "enemy 010 | diff 001 | structur 210 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
			GUI.Label (new Rect (160, 2385, 300, 20), "enemy 010 | diff 001 | structur 310 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
			GUI.Label (new Rect (160, 2415, 300, 20), "enemy 010 | diff 001 | structur 210 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
			GUI.Label (new Rect (160, 2445, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
			GUI.Label (new Rect (160, 2475, 300, 20), "enemy 010 | diff 001 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
			GUI.Label (new Rect (160, 2505, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
			GUI.Label (new Rect (160, 2535, 300, 20), "enemy 010 | diff 001 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
			GUI.Label (new Rect (160, 2565, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
			GUI.Label (new Rect (160, 2595, 300, 20), "enemy 010 | diff 001 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
			GUI.Label (new Rect (160, 2625, 300, 20), "enemy 010 | diff 001 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
			GUI.Label (new Rect (160, 2655, 300, 20), "enemy 025 | diff 001 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
			GUI.Label (new Rect (160, 2685, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
			GUI.Label (new Rect (160, 2715, 300, 20), "enemy 010 | diff 001 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
		}
			
		if (MenuScript.diff == 2){
		GUI.Label (new Rect (160, 15, 300, 20), "enemy 005 | diff 002 | structur 040 | bubble 015", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
		GUI.Label (new Rect (160, 45, 300, 20), "enemy 015 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
		GUI.Label (new Rect (160, 75, 300, 20), "enemy 005 | diff 002 | structur 250 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
		GUI.Label (new Rect (160, 105, 300, 20), "enemy 005 | diff 002 | structur 000 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
		GUI.Label (new Rect (160, 135, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
		GUI.Label (new Rect (160, 165, 300, 20), "enemy 025 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
		GUI.Label (new Rect (160, 195, 300, 20), "enemy 010 | diff 002 | structur 040 | bubble 015", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
		GUI.Label (new Rect (160, 225, 300, 20), "enemy 010 | diff 002 | structur 030 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
		GUI.Label (new Rect (160, 255, 300, 20), "enemy 010 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
		GUI.Label (new Rect (160, 285, 300, 20), "enemy 010 | diff 002 | structur 060 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
		GUI.Label (new Rect (160, 315, 300, 20), "enemy 005 | diff 002 | structur 010 | bubble 250", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
		GUI.Label (new Rect (160, 345, 300, 20), "enemy 015 | diff 002 | structur 015 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
		GUI.Label (new Rect (160, 375, 300, 20), "enemy 005 | diff 002 | structur 250 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
		GUI.Label (new Rect (160, 405, 300, 20), "enemy 005 | diff 002 | structur 000 | bubble 250", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
		GUI.Label (new Rect (160, 435, 300, 20), "enemy 020 | diff 002 | structur 000 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
		GUI.Label (new Rect (160, 465, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
		GUI.Label (new Rect (160, 495, 300, 20), "enemy 010 | diff 002 | structur 110 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
		GUI.Label (new Rect (160, 525, 300, 20), "enemy 005 | diff 002 | structur 010 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
		GUI.Label (new Rect (160, 555, 300, 20), "enemy 010 | diff 002 | structur 300 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
		GUI.Label (new Rect (160, 585, 300, 20), "enemy 030 | diff 002 | structur 200 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
		GUI.Label (new Rect (160, 615, 300, 20), "enemy 005 | diff 002 | structur 055 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
		GUI.Label (new Rect (160, 645, 300, 20), "enemy 005 | diff 002 | structur 005 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
		GUI.Label (new Rect (160, 675, 300, 20), "enemy 005 | diff 002 | structur 005 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
		GUI.Label (new Rect (160, 705, 300, 20), "enemy 010 | diff 002 | structur 005 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
		GUI.Label (new Rect (160, 735, 300, 20), "enemy 015 | diff 002 | structur 010 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
		GUI.Label (new Rect (160, 765, 300, 20), "enemy 015 | diff 002 | structur 050 | bubble 015", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
		GUI.Label (new Rect (160, 795, 300, 20), "enemy 010 | diff 002 | structur 000 | bubble 240", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
		GUI.Label (new Rect (160, 825, 300, 20), "enemy 015 | diff 002 | structur 305 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
		GUI.Label (new Rect (160, 855, 300, 20), "enemy 005 | diff 002 | structur 040 | bubble 015", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
		GUI.Label (new Rect (160, 885, 300, 20), "enemy 020 | diff 002 | structur 200 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
		GUI.Label (new Rect (160, 915, 300, 20), "enemy 005 | diff 002 | structur 035 | bubble 015", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
		GUI.Label (new Rect (160, 945, 300, 20), "enemy 005 | diff 002 | structur 045 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
		GUI.Label (new Rect (160, 975, 300, 20), "enemy 015 | diff 002 | structur 005 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
		GUI.Label (new Rect (160, 1005, 300, 20), "enemy 010 | diff 002 | structur 000 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
		GUI.Label (new Rect (160, 1035, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
		GUI.Label (new Rect (160, 1065, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
		GUI.Label (new Rect (160, 1095, 300, 20), "enemy 005 | diff 002 | structur 100 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
		GUI.Label (new Rect (160, 1125, 300, 20), "enemy 005 | diff 002 | structur 100 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
		GUI.Label (new Rect (160, 1155, 300, 20), "enemy 010 | diff 002 | structur 000 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
		GUI.Label (new Rect (160, 1185, 300, 20), "enemy 010 | diff 002 | structur 050 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
		GUI.Label (new Rect (160, 1215, 300, 20), "enemy 015 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
		GUI.Label (new Rect (160, 1245, 300, 20), "enemy 015 | diff 002 | structur 100 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
		GUI.Label (new Rect (160, 1275, 300, 20), "enemy 010 | diff 002 | structur 050 | bubble 025", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
		GUI.Label (new Rect (160, 1305, 300, 20), "enemy 005 | diff 002 | structur 000 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
		GUI.Label (new Rect (160, 1335, 300, 20), "enemy 010 | diff 002 | structur 300 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
		GUI.Label (new Rect (160, 1365, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 300", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
		GUI.Label (new Rect (160, 1395, 300, 20), "enemy 015 | diff 002 | structur 205 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
		GUI.Label (new Rect (160, 1425, 300, 20), "enemy 015 | diff 002 | structur 006 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
		GUI.Label (new Rect (160, 1455, 300, 20), "enemy 010 | diff 002 | structur 011 | bubble 010", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
		GUI.Label (new Rect (160, 1485, 300, 20), "enemy 020 | diff 002 | structur 410 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
		GUI.Label (new Rect (160, 1515, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
		GUI.Label (new Rect (160, 1545, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
		GUI.Label (new Rect (160, 1575, 300, 20), "enemy 005 | diff 002 | structur 100 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
		GUI.Label (new Rect (160, 1605, 300, 20), "enemy 020 | diff 002 | structur 100 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
		GUI.Label (new Rect (160, 1635, 300, 20), "enemy 010 | diff 002 | structur 200 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
		GUI.Label (new Rect (160, 1665, 300, 20), "enemy 010 | diff 002 | structur 000 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
		GUI.Label (new Rect (160, 1695, 300, 20), "enemy 010 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
		GUI.Label (new Rect (160, 1725, 300, 20), "enemy 010 | diff 002 | structur 205 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
		GUI.Label (new Rect (160, 1755, 300, 20), "enemy 015 | diff 002 | structur 055 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
		GUI.Label (new Rect (160, 1785, 300, 20), "enemy 015 | diff 002 | structur 205 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
		GUI.Label (new Rect (160, 1815, 300, 20), "enemy 005 | diff 002 | structur 005 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
		GUI.Label (new Rect (160, 1845, 300, 20), "enemy 005 | diff 002 | structur 050 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
		GUI.Label (new Rect (160, 1875, 300, 20), "enemy 015 | diff 002 | structur 005 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
		GUI.Label (new Rect (160, 1905, 300, 20), "enemy 005 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
		GUI.Label (new Rect (160, 1935, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
		GUI.Label (new Rect (160, 1965, 300, 20), "enemy 010 | diff 002 | structur 050 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
		GUI.Label (new Rect (160, 1995, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 300", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
		GUI.Label (new Rect (160, 2025, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
		GUI.Label (new Rect (160, 2055, 300, 20), "enemy 010 | diff 002 | structur 300 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
		GUI.Label (new Rect (160, 2085, 300, 20), "enemy 010 | diff 002 | structur 010 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
		GUI.Label (new Rect (160, 2115, 300, 20), "enemy 010 | diff 002 | structur 300 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
		GUI.Label (new Rect (160, 2145, 300, 20), "enemy 010 | diff 002 | structur 000 | bubble 300", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
		GUI.Label (new Rect (160, 2175, 300, 20), "enemy 010 | diff 002 | structur 300 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
		GUI.Label (new Rect (160, 2205, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
		GUI.Label (new Rect (160, 2235, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
		GUI.Label (new Rect (160, 2265, 300, 20), "enemy 010 | diff 002 | structur 200 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
		GUI.Label (new Rect (160, 2295, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
		GUI.Label (new Rect (160, 2325, 300, 20), "enemy 010 | diff 002 | structur 310 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
		GUI.Label (new Rect (160, 2355, 300, 20), "enemy 010 | diff 002 | structur 210 | bubble 200", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
		GUI.Label (new Rect (160, 2385, 300, 20), "enemy 010 | diff 002 | structur 310 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
		GUI.Label (new Rect (160, 2415, 300, 20), "enemy 010 | diff 002 | structur 210 | bubble 000", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
		GUI.Label (new Rect (160, 2445, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
		GUI.Label (new Rect (160, 2475, 300, 20), "enemy 010 | diff 002 | structur 205 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
		GUI.Label (new Rect (160, 2505, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
		GUI.Label (new Rect (160, 2535, 300, 20), "enemy 010 | diff 002 | structur 205 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
		GUI.Label (new Rect (160, 2565, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
		GUI.Label (new Rect (160, 2595, 300, 20), "enemy 010 | diff 002 | structur 105 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
		GUI.Label (new Rect (160, 2625, 300, 20), "enemy 010 | diff 002 | structur 205 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
		GUI.Label (new Rect (160, 2655, 300, 20), "enemy 025 | diff 002 | structur 005 | bubble 050", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
		GUI.Label (new Rect (160, 2685, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
		GUI.Label (new Rect (160, 2715, 300, 20), "enemy 010 | diff 002 | structur 100 | bubble 100", GUI.skin.label);
		GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
	}

	if (MenuScript.diff == 3){
			GUI.Label (new Rect (160, 15, 300, 20), "enemy 005 | diff 003 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
			GUI.Label (new Rect (160, 45, 300, 20), "enemy 015 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
			GUI.Label (new Rect (160, 75, 300, 20), "enemy 005 | diff 003 | structur 250 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
			GUI.Label (new Rect (160, 105, 300, 20), "enemy 005 | diff 003 | structur 000 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
			GUI.Label (new Rect (160, 135, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
			GUI.Label (new Rect (160, 165, 300, 20), "enemy 025 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
			GUI.Label (new Rect (160, 195, 300, 20), "enemy 010 | diff 003 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
			GUI.Label (new Rect (160, 225, 300, 20), "enemy 010 | diff 003 | structur 030 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
			GUI.Label (new Rect (160, 255, 300, 20), "enemy 010 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
			GUI.Label (new Rect (160, 285, 300, 20), "enemy 010 | diff 003 | structur 060 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
			GUI.Label (new Rect (160, 315, 300, 20), "enemy 005 | diff 003 | structur 010 | bubble 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
			GUI.Label (new Rect (160, 345, 300, 20), "enemy 015 | diff 003 | structur 015 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
			GUI.Label (new Rect (160, 375, 300, 20), "enemy 005 | diff 003 | structur 250 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
			GUI.Label (new Rect (160, 405, 300, 20), "enemy 005 | diff 003 | structur 000 | bubble 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
			GUI.Label (new Rect (160, 435, 300, 20), "enemy 020 | diff 003 | structur 000 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
			GUI.Label (new Rect (160, 465, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
			GUI.Label (new Rect (160, 495, 300, 20), "enemy 010 | diff 003 | structur 110 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
			GUI.Label (new Rect (160, 525, 300, 20), "enemy 005 | diff 003 | structur 010 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
			GUI.Label (new Rect (160, 555, 300, 20), "enemy 010 | diff 003 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
			GUI.Label (new Rect (160, 585, 300, 20), "enemy 030 | diff 003 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
			GUI.Label (new Rect (160, 615, 300, 20), "enemy 005 | diff 003 | structur 055 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
			GUI.Label (new Rect (160, 645, 300, 20), "enemy 005 | diff 003 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
			GUI.Label (new Rect (160, 675, 300, 20), "enemy 005 | diff 003 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
			GUI.Label (new Rect (160, 705, 300, 20), "enemy 010 | diff 003 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
			GUI.Label (new Rect (160, 735, 300, 20), "enemy 015 | diff 003 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
			GUI.Label (new Rect (160, 765, 300, 20), "enemy 015 | diff 003 | structur 050 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
			GUI.Label (new Rect (160, 795, 300, 20), "enemy 010 | diff 003 | structur 000 | bubble 240", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
			GUI.Label (new Rect (160, 825, 300, 20), "enemy 015 | diff 003 | structur 305 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
			GUI.Label (new Rect (160, 855, 300, 20), "enemy 005 | diff 003 | structur 040 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
			GUI.Label (new Rect (160, 885, 300, 20), "enemy 020 | diff 003 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
			GUI.Label (new Rect (160, 915, 300, 20), "enemy 005 | diff 003 | structur 035 | bubble 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
			GUI.Label (new Rect (160, 945, 300, 20), "enemy 005 | diff 003 | structur 045 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
			GUI.Label (new Rect (160, 975, 300, 20), "enemy 015 | diff 003 | structur 005 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
			GUI.Label (new Rect (160, 1005, 300, 20), "enemy 010 | diff 003 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
			GUI.Label (new Rect (160, 1035, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
			GUI.Label (new Rect (160, 1065, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
			GUI.Label (new Rect (160, 1095, 300, 20), "enemy 005 | diff 003 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
			GUI.Label (new Rect (160, 1125, 300, 20), "enemy 005 | diff 003 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
			GUI.Label (new Rect (160, 1155, 300, 20), "enemy 010 | diff 003 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
			GUI.Label (new Rect (160, 1185, 300, 20), "enemy 010 | diff 003 | structur 050 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
			GUI.Label (new Rect (160, 1215, 300, 20), "enemy 015 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
			GUI.Label (new Rect (160, 1245, 300, 20), "enemy 015 | diff 003 | structur 100 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
			GUI.Label (new Rect (160, 1275, 300, 20), "enemy 010 | diff 003 | structur 050 | bubble 025", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
			GUI.Label (new Rect (160, 1305, 300, 20), "enemy 005 | diff 003 | structur 000 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
			GUI.Label (new Rect (160, 1335, 300, 20), "enemy 010 | diff 003 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
			GUI.Label (new Rect (160, 1365, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
			GUI.Label (new Rect (160, 1395, 300, 20), "enemy 015 | diff 003 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
			GUI.Label (new Rect (160, 1425, 300, 20), "enemy 015 | diff 003 | structur 006 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
			GUI.Label (new Rect (160, 1455, 300, 20), "enemy 010 | diff 003 | structur 011 | bubble 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
			GUI.Label (new Rect (160, 1485, 300, 20), "enemy 020 | diff 003 | structur 410 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
			GUI.Label (new Rect (160, 1515, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
			GUI.Label (new Rect (160, 1545, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
			GUI.Label (new Rect (160, 1575, 300, 20), "enemy 005 | diff 003 | structur 100 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
			GUI.Label (new Rect (160, 1605, 300, 20), "enemy 020 | diff 003 | structur 100 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
			GUI.Label (new Rect (160, 1635, 300, 20), "enemy 010 | diff 003 | structur 200 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
			GUI.Label (new Rect (160, 1665, 300, 20), "enemy 010 | diff 003 | structur 000 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
			GUI.Label (new Rect (160, 1695, 300, 20), "enemy 010 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
			GUI.Label (new Rect (160, 1725, 300, 20), "enemy 010 | diff 003 | structur 205 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
			GUI.Label (new Rect (160, 1755, 300, 20), "enemy 015 | diff 003 | structur 055 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
			GUI.Label (new Rect (160, 1785, 300, 20), "enemy 015 | diff 003 | structur 205 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
			GUI.Label (new Rect (160, 1815, 300, 20), "enemy 005 | diff 003 | structur 005 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
			GUI.Label (new Rect (160, 1845, 300, 20), "enemy 005 | diff 003 | structur 050 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
			GUI.Label (new Rect (160, 1875, 300, 20), "enemy 015 | diff 003 | structur 005 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
			GUI.Label (new Rect (160, 1905, 300, 20), "enemy 005 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
			GUI.Label (new Rect (160, 1935, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
			GUI.Label (new Rect (160, 1965, 300, 20), "enemy 010 | diff 003 | structur 050 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
			GUI.Label (new Rect (160, 1995, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
			GUI.Label (new Rect (160, 2025, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
			GUI.Label (new Rect (160, 2055, 300, 20), "enemy 010 | diff 003 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
			GUI.Label (new Rect (160, 2085, 300, 20), "enemy 010 | diff 003 | structur 010 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
			GUI.Label (new Rect (160, 2115, 300, 20), "enemy 010 | diff 003 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
			GUI.Label (new Rect (160, 2145, 300, 20), "enemy 010 | diff 003 | structur 000 | bubble 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
			GUI.Label (new Rect (160, 2175, 300, 20), "enemy 010 | diff 003 | structur 300 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
			GUI.Label (new Rect (160, 2205, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
			GUI.Label (new Rect (160, 2235, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
			GUI.Label (new Rect (160, 2265, 300, 20), "enemy 010 | diff 003 | structur 200 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
			GUI.Label (new Rect (160, 2295, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
			GUI.Label (new Rect (160, 2325, 300, 20), "enemy 010 | diff 003 | structur 310 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
			GUI.Label (new Rect (160, 2355, 300, 20), "enemy 010 | diff 003 | structur 210 | bubble 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
			GUI.Label (new Rect (160, 2385, 300, 20), "enemy 010 | diff 003 | structur 310 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
			GUI.Label (new Rect (160, 2415, 300, 20), "enemy 010 | diff 003 | structur 210 | bubble 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
			GUI.Label (new Rect (160, 2445, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
			GUI.Label (new Rect (160, 2475, 300, 20), "enemy 010 | diff 003 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
			GUI.Label (new Rect (160, 2505, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
			GUI.Label (new Rect (160, 2535, 300, 20), "enemy 010 | diff 003 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
			GUI.Label (new Rect (160, 2565, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
			GUI.Label (new Rect (160, 2595, 300, 20), "enemy 010 | diff 003 | structur 105 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
			GUI.Label (new Rect (160, 2625, 300, 20), "enemy 010 | diff 003 | structur 205 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
			GUI.Label (new Rect (160, 2655, 300, 20), "enemy 025 | diff 003 | structur 005 | bubble 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
			GUI.Label (new Rect (160, 2685, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
			GUI.Label (new Rect (160, 2715, 300, 20), "enemy 010 | diff 003 | structur 100 | bubble 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
		}
			
			
			
			
			
			if (GUI.Button (new Rect (15, 15, 100, 20), "Level 01(S)")) {
				Application.LoadLevel ("LLevel1");
			}
			if (GUI.Button (new Rect (15, 45, 100, 20), "Level 02(S)")) {
				if (GDB.unlockLeavel >= 2) {
					Application.LoadLevel ("LLevel2");
				}
			}
			if (GUI.Button (new Rect (15, 75, 100, 20), "Level 03(S)")) {
				if (GDB.unlockLeavel >= 3) {
					Application.LoadLevel ("LLevel3");
				}
			}
			if (GUI.Button (new Rect (15, 105, 100, 20), "Level 04(S)")) {
				if (GDB.unlockLeavel >= 4) {
					Application.LoadLevel ("LLevel4");
				}
			}
			if (GUI.Button (new Rect (15, 135, 100, 20), "Level 05(M)")) {
				if (GDB.unlockLeavel >= 5) {
					Application.LoadLevel ("LLevel5");
				}
			}
			if (GUI.Button (new Rect (15, 165, 100, 20), "Level 06(M)")) {
				if (GDB.unlockLeavel >= 6) {
					Application.LoadLevel ("LLevel6");
				}
			}
			if (GUI.Button (new Rect (15, 195, 100, 20), "Level 07(S)")) {
				if (GDB.unlockLeavel >= 7) {
					Application.LoadLevel ("LLevel7");
				}
			}
			if (GUI.Button (new Rect (15, 225, 100, 20), "Level 08(S)")) {
				if (GDB.unlockLeavel >= 8) {
					Application.LoadLevel ("LLevel8");
				}
			}
			if (GUI.Button (new Rect (15, 255, 100, 20), "Level 09(S)")) {
				if (GDB.unlockLeavel >= 9) {
					Application.LoadLevel ("LLevel9");
				}
			}
			if (GUI.Button (new Rect (15, 285, 100, 20), "Level 10(M)")) {
				if (GDB.unlockLeavel >= 10) {
					Application.LoadLevel ("LLevel10");
				}
			}
			if (GUI.Button (new Rect (15, 315, 100, 20), "Level 11(M)")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel11");
				}
			}
			if (GUI.Button (new Rect (15, 345, 100, 20), "Level 12(M)")) {
				if (GDB.unlockLeavel >= 12) {
					Application.LoadLevel ("LLevel12");
				}
			}
			if (GUI.Button (new Rect (15, 375, 100, 20), "Level 13(S)")) {
				if (GDB.unlockLeavel >= 13) {
					Application.LoadLevel ("LLevel13");
				}
			}
			if (GUI.Button (new Rect (15, 405, 100, 20), "Level 14(S)")) {
				if (GDB.unlockLeavel >= 14) {
					Application.LoadLevel ("LLevel14");
				}
			}
			if (GUI.Button (new Rect (15, 435, 100, 20), "Level 15(S)")) {
				if (GDB.unlockLeavel >= 15) {
					Application.LoadLevel ("LLevel15");
				}
			}
			if (GUI.Button (new Rect (15, 465, 100, 20), "Level 16(S)")) {
				if (GDB.unlockLeavel >= 16) {
					Application.LoadLevel ("LLevel16");
				}
			}
			if (GUI.Button (new Rect (15, 495, 100, 20), "Level 17(M)")) {
				if (GDB.unlockLeavel >= 17) {
					Application.LoadLevel ("LLevel17");
				}
			}
			if (GUI.Button (new Rect (15, 525, 100, 20), "Level 18(S)")) {
				if (GDB.unlockLeavel >= 18) {
					Application.LoadLevel ("LLevel18");
				}
			}
			if (GUI.Button (new Rect (15, 555, 100, 20), "Level 19(M)")) {
				if (GDB.unlockLeavel >= 19) {
					Application.LoadLevel ("LLevel19");
				}
			}
			if (GUI.Button (new Rect (15, 585, 100, 20), "Level 20(M)")) {
				if (GDB.unlockLeavel >= 20) {
					Application.LoadLevel ("LLevel20");
				}
			}
			if (GUI.Button (new Rect (15, 615, 100, 20), "Level 21(S)")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel21");
				}
			}
			if (GUI.Button (new Rect (15, 645, 100, 20), "Level 22(S)")) {
				if (GDB.unlockLeavel >= 22) {
					Application.LoadLevel ("LLevel22");
				}
			}
			if (GUI.Button (new Rect (15, 675, 100, 20), "Level 23(S)")) {
				if (GDB.unlockLeavel >= 23) {
					Application.LoadLevel ("LLevel23");
				}
			}
			if (GUI.Button (new Rect (15, 705, 100, 20), "Level 24(S)")) {
				if (GDB.unlockLeavel >= 24) {
					Application.LoadLevel ("LLevel24");
				}
			}
			if (GUI.Button (new Rect (15, 735, 100, 20), "Level 25(M)")) {
				if (GDB.unlockLeavel >= 25) {
					Application.LoadLevel ("LLevel25");
				}
			}
			if (GUI.Button (new Rect (15, 765, 100, 20), "Level 26(S)")) {
				if (GDB.unlockLeavel >= 26) {
					Application.LoadLevel ("LLevel26");
				}
			}
			if (GUI.Button (new Rect (15, 795, 100, 20), "Level 27(M)")) {
				if (GDB.unlockLeavel >= 27) {
					Application.LoadLevel ("LLevel27");
				}
			}
			if (GUI.Button (new Rect (15, 825, 100, 20), "Level 28(M)")) {
				if (GDB.unlockLeavel >= 28) {
					Application.LoadLevel ("LLevel28");
				}
			}
			if (GUI.Button (new Rect (15, 855, 100, 20), "Level 29(S)")) {
				if (GDB.unlockLeavel >= 29) {
					Application.LoadLevel ("LLevel29");
				}
			}
			if (GUI.Button (new Rect (15, 885, 100, 20), "Level 30(M)")) {
				if (GDB.unlockLeavel >= 30) {
					Application.LoadLevel ("LLevel30");
				}
			}
			if (GUI.Button (new Rect (15, 915, 100, 20), "Level 31(S)")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel31");
				}
			}
			if (GUI.Button (new Rect (15, 945, 100, 20), "Level 32(S)")) {
				if (GDB.unlockLeavel >= 32) {
					Application.LoadLevel ("LLevel32");
				}
			}
			if (GUI.Button (new Rect (15, 975, 100, 20), "Level 33(M)")) {
				if (GDB.unlockLeavel >= 33) {
					Application.LoadLevel ("LLevel33");
				}
			}
			if (GUI.Button (new Rect (15, 1005, 100, 20), "Level 34(M)")) {
				if (GDB.unlockLeavel >= 34) {
					Application.LoadLevel ("LLevel34");
				}
			}
			if (GUI.Button (new Rect (15, 1035, 100, 20), "Level 35(M)")) {
				if (GDB.unlockLeavel >= 35) {
					Application.LoadLevel ("LLevel35");
				}
			}
			if (GUI.Button (new Rect (15, 1065, 100, 20), "Level 36(M)")) {
				if (GDB.unlockLeavel >= 36) {
					Application.LoadLevel ("LLevel36");
				}
			}
			if (GUI.Button (new Rect (15, 1095, 100, 20), "Level 37(S)")) {
				if (GDB.unlockLeavel >= 37) {
					Application.LoadLevel ("LLevel37");
				}
			}
			if (GUI.Button (new Rect (15, 1125, 100, 20), "Level 38(S)")) {
				if (GDB.unlockLeavel >= 38) {
					Application.LoadLevel ("LLevel38");
				}
			}
			if (GUI.Button (new Rect (15, 1155, 100, 20), "Level 39(M)")) {
				if (GDB.unlockLeavel >= 39) {
					Application.LoadLevel ("LLevel39");
				}
			}
			if (GUI.Button (new Rect (15, 1185, 100, 20), "Level 40(M)")) {
				if (GDB.unlockLeavel >= 40) {
					Application.LoadLevel ("LLevel40");
				}
			}
			if (GUI.Button (new Rect (15, 1215, 100, 20), "Level 41(S)")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel41");
				}
			}
			if (GUI.Button (new Rect (15, 1245, 100, 20), "Level 42(S)")) {
				if (GDB.unlockLeavel >= 42) {
					Application.LoadLevel ("LLevel42");
				}
			}
			if (GUI.Button (new Rect (15, 1275, 100, 20), "Level 43(S)")) {
				if (GDB.unlockLeavel >= 43) {
					Application.LoadLevel ("LLevel43");
				}
			}
			if (GUI.Button (new Rect (15, 1305, 100, 20), "Level 44(S)")) {
				if (GDB.unlockLeavel >= 44) {
					Application.LoadLevel ("LLevel44");
				}
			}
			if (GUI.Button (new Rect (15, 1335, 100, 20), "Level 45(M)")) {
				if (GDB.unlockLeavel >= 45) {
					Application.LoadLevel ("LLevel45");
				}
			}
			if (GUI.Button (new Rect (15, 1365, 100, 20), "Level 46(M)")) {
				if (GDB.unlockLeavel >= 46) {
					Application.LoadLevel ("LLevel46");
				}
			}
			if (GUI.Button (new Rect (15, 1395, 100, 20), "Level 47(M)")) {
				if (GDB.unlockLeavel >= 47) {
					Application.LoadLevel ("LLevel47");
				}
			}
			if (GUI.Button (new Rect (15, 1425, 100, 20), "Level 48(M)")) {
				if (GDB.unlockLeavel >= 48) {
					Application.LoadLevel ("LLevel48");
				}
			}
			if (GUI.Button (new Rect (15, 1455, 100, 20), "Level 49(M)")) {
				if (GDB.unlockLeavel >= 49) {
					Application.LoadLevel ("LLevel49");
				}
			}
			if (GUI.Button (new Rect (15, 1485, 100, 20), "Level 50(L)")) {
				if (GDB.unlockLeavel >= 50) {
					Application.LoadLevel ("LLevel50");
				}
			}
			if (GUI.Button (new Rect (15, 1515, 100, 20), "Level 51(M)")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel51");
				}
			}
			if (GUI.Button (new Rect (15, 1545, 100, 20), "Level 52(M)")) {
				if (GDB.unlockLeavel >= 52) {
					Application.LoadLevel ("LLevel52");
				}
			}
			if (GUI.Button (new Rect (15, 1575, 100, 20), "Level 53(S)")) {
				if (GDB.unlockLeavel >= 53) {
					Application.LoadLevel ("LLevel53");
				}
			}
			if (GUI.Button (new Rect (15, 1605, 100, 20), "Level 54(L)")) {
				if (GDB.unlockLeavel >= 54) {
					Application.LoadLevel ("LLevel54");
				}
			}
			if (GUI.Button (new Rect (15, 1635, 100, 20), "Level 55(M)")) {
				if (GDB.unlockLeavel >= 55) {
					Application.LoadLevel ("LLevel55");
				}
			}
			if (GUI.Button (new Rect (15, 1665, 100, 20), "Level 56(M)")) {
				if (GDB.unlockLeavel >= 56) {
					Application.LoadLevel ("LLevel56");
				}
			}
			if (GUI.Button (new Rect (15, 1695, 100, 20), "Level 57(M)")) {
				if (GDB.unlockLeavel >= 57) {
					Application.LoadLevel ("LLevel57");
				}
			}
			if (GUI.Button (new Rect (15, 1725, 100, 20), "Level 58(M)")) {
				if (GDB.unlockLeavel >= 58) {
					Application.LoadLevel ("LLevel58");
				}
			}
			if (GUI.Button (new Rect (15, 1755, 100, 20), "Level 59(L)")) {
				if (GDB.unlockLeavel >= 59) {
					Application.LoadLevel ("LLevel59");
				}
			}
			if (GUI.Button (new Rect (15, 1785, 100, 20), "Level 60(L)")) {
				if (GDB.unlockLeavel >= 60) {
					Application.LoadLevel ("LLevel60");
				}
			}
			if (GUI.Button (new Rect (15, 1815, 100, 20), "Level 61(M)")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel61");
				}
			}
			if (GUI.Button (new Rect (15, 1845, 100, 20), "Level 62(S)")) {
				if (GDB.unlockLeavel >= 62) {
					Application.LoadLevel ("LLevel62");
				}
			}
			if (GUI.Button (new Rect (15, 1875, 100, 20), "Level 63(S)")) {
				if (GDB.unlockLeavel >= 63) {
					Application.LoadLevel ("LLevel63");
				}
			}
			if (GUI.Button (new Rect (15, 1905, 100, 20), "Level 64(M)")) {
				if (GDB.unlockLeavel >= 64) {
					Application.LoadLevel ("LLevel64");
				}
			}
			if (GUI.Button (new Rect (15, 1935, 100, 20), "Level 65(L)")) {
				if (GDB.unlockLeavel >= 65) {
					Application.LoadLevel ("LLevel65");
				}
			}
			if (GUI.Button (new Rect (15, 1965, 100, 20), "Level 66(M)")) {
				if (GDB.unlockLeavel >= 66) {
					Application.LoadLevel ("LLevel66");
				}
			}
			if (GUI.Button (new Rect (15, 1995, 100, 20), "Level 67(L)")) {
				if (GDB.unlockLeavel >= 67) {
					Application.LoadLevel ("LLevel67");
				}
			}
			if (GUI.Button (new Rect (15, 2025, 100, 20), "Level 68(M)")) {
				if (GDB.unlockLeavel >= 68) {
					Application.LoadLevel ("LLevel68");
				}
			}
			if (GUI.Button (new Rect (15, 2055, 100, 20), "Level 69(L)")) {
				if (GDB.unlockLeavel >= 69) {
					Application.LoadLevel ("LLevel69");
				}
			}
			if (GUI.Button (new Rect (15, 2085, 100, 20), "Level 70(M)")) {
				if (GDB.unlockLeavel >= 70) {
					Application.LoadLevel ("LLevel70");
				}
			}
			if (GUI.Button (new Rect (15, 2115, 100, 20), "Level 71(M)")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel71");
				}
			}
			if (GUI.Button (new Rect (15, 2145, 100, 20), "Level 72(L)")) {
				if (GDB.unlockLeavel >= 72) {
					Application.LoadLevel ("LLevel72");
				}
			}
			if (GUI.Button (new Rect (15, 2175, 100, 20), "Level 73(M)")) {
				if (GDB.unlockLeavel >= 73) {
					Application.LoadLevel ("LLevel73");
				}
			}
			if (GUI.Button (new Rect (15, 2205, 100, 20), "Level 74(L)")) {
				if (GDB.unlockLeavel >= 74) {
					Application.LoadLevel ("LLevel74");
				}
			}
			if (GUI.Button (new Rect (15, 2235, 100, 20), "Level 75(M)")) {
				if (GDB.unlockLeavel >= 75) {
					Application.LoadLevel ("LLevel75");
				}
			}
			if (GUI.Button (new Rect (15, 2265, 100, 20), "Level 76(L)")) {
				if (GDB.unlockLeavel >= 76) {
					Application.LoadLevel ("LLevel76");
				}
			}
			if (GUI.Button (new Rect (15, 2295, 100, 20), "Level 77(L)")) {
				if (GDB.unlockLeavel >= 77) {
					Application.LoadLevel ("LLevel77");
				}
			}
			if (GUI.Button (new Rect (15, 2325, 100, 20), "Level 78(M)")) {
				if (GDB.unlockLeavel >= 78) {
					Application.LoadLevel ("LLevel78");
				}
			}
			if (GUI.Button (new Rect (15, 2355, 100, 20), "Level 79(L)")) {
				if (GDB.unlockLeavel >= 79) {
					Application.LoadLevel ("LLevel79");
				}
			}
			if (GUI.Button (new Rect (15, 2385, 100, 20), "Level 80(L)")) {
				if (GDB.unlockLeavel >= 80) {
					Application.LoadLevel ("LLevel80");
				}
			}
			if (GUI.Button (new Rect (15, 2415, 100, 20), "Level 81(M)")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel81");
				}
			}
			if (GUI.Button (new Rect (15, 2445, 100, 20), "Level 82(M)")) {
				if (GDB.unlockLeavel >= 82) {
					Application.LoadLevel ("LLevel82");
				}
			}
			if (GUI.Button (new Rect (15, 2475, 100, 20), "Level 83(L)")) {
				if (GDB.unlockLeavel >= 83) {
					Application.LoadLevel ("LLevel83");
				}
			}
			if (GUI.Button (new Rect (15, 2505, 100, 20), "Level 84(M)")) {
				if (GDB.unlockLeavel >= 84) {
					Application.LoadLevel ("LLevel84");
				}
			}
			if (GUI.Button (new Rect (15, 2535, 100, 20), "Level 85(L)")) {
				if (GDB.unlockLeavel >= 85) {
					Application.LoadLevel ("LLevel85");
				}
			}
			if (GUI.Button (new Rect (15, 2565, 100, 20), "Level 86(M)")) {
				if (GDB.unlockLeavel >= 86) {
					Application.LoadLevel ("LLevel86");
				}
			}
			if (GUI.Button (new Rect (15, 2595, 100, 20), "Level 87(M)")) {
				if (GDB.unlockLeavel >= 87) {
					Application.LoadLevel ("LLevel87");
				}
			}
			if (GUI.Button (new Rect (15, 2625, 100, 20), "Level 88(L)")) {
				if (GDB.unlockLeavel >= 88) {
					Application.LoadLevel ("LLevel88");
				}
			}
			if (GUI.Button (new Rect (15, 2655, 100, 20), "Level 89(M)")) {
				if (GDB.unlockLeavel >= 89) {
					Application.LoadLevel ("LLevel89");
				}
			}
			if (GUI.Button (new Rect (15, 2685, 100, 20), "Level 90(M)")) {
				if (GDB.unlockLeavel >= 90) {
					Application.LoadLevel ("LLevel90");
				}
			}
			if (GUI.Button (new Rect (15, 2715, 100, 20), "Level 91(M)")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel91");
				}
			}
		}

		///chi
		if (MenuScript.lang == 3) {
			if (GUI.Button (new Rect (610, 50, 150, 30), "字符")) {
				Application.LoadLevel ("PlayerMenu");
			}
			
			if (GUI.Button (new Rect (610, 90, 150, 30), "主菜单")) {
				Application.LoadLevel ("Menu");
			}
			
			if (GUI.Button (new Rect (640, 130, 100, 20), "(10)老板-1")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel92");
				}
			}
			if (GUI.Button (new Rect (640, 160, 100, 20), "(20)老板-2")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel93");
				}
			}
			if (GUI.Button (new Rect (640, 190, 100, 20), "(30)老板-3")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel94");
				}
			}
			if (GUI.Button (new Rect (640, 220, 100, 20), "(40)老板-4")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel95");
				}
			}
			if (GUI.Button (new Rect (640, 250, 100, 20), "(50)老板-5")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel96");
				}
			}
			if (GUI.Button (new Rect (640, 280, 100, 20), "(60)老板-6")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel97");
				}
			}
			if (GUI.Button (new Rect (640, 310, 100, 20), "(70)老板-7")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel98");
				}
			}
			if (GUI.Button (new Rect (640, 340, 100, 20), "(80)老板-8")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel99");
				}
			}
			if (GUI.Button (new Rect (640, 370, 100, 20), "(90)老板-9")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel100");
				}
			}
			if (GUI.Button (new Rect (640, 400, 100, 20), "主邪恶")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel101");
				}
			}
			
			
			if (GDB.unlockLeavel < 11) {
				GUI.DrawTexture (new Rect (610, 130, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 21) {
				GUI.DrawTexture (new Rect (610, 160, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 31) {
				GUI.DrawTexture (new Rect (610, 190, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 41) {
				GUI.DrawTexture (new Rect (610, 220, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 51) {
				GUI.DrawTexture (new Rect (610, 250, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 61) {
				GUI.DrawTexture (new Rect (610, 280, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 71) {
				GUI.DrawTexture (new Rect (610, 310, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 81) {
				GUI.DrawTexture (new Rect (610, 340, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 370, 20, 20), closed);
			}
			if (GDB.unlockLeavel < 91) {
				GUI.DrawTexture (new Rect (610, 400, 20, 20), closed);
			}
			
			
			
			
			
			
			
			scrollPosition = GUI.BeginScrollView (new Rect (1, 1, 570, Screen.height), scrollPosition, new Rect (0, 0, 500, 4000));
			
			if (MenuScript.diff <= 1) {
			GUI.Label (new Rect (160, 15, 300, 20), " 敌人 005 | 损伤 001 |  结构 040 |  泡泡 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
			GUI.Label (new Rect (160, 45, 300, 20), " 敌人 015 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
			GUI.Label (new Rect (160, 75, 300, 20), " 敌人 005 | 损伤 001 |  结构 250 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
			GUI.Label (new Rect (160, 105, 300, 20), " 敌人 005 | 损伤 001 |  结构 000 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
			GUI.Label (new Rect (160, 135, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
			GUI.Label (new Rect (160, 165, 300, 20), " 敌人 025 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
			GUI.Label (new Rect (160, 195, 300, 20), " 敌人 010 | 损伤 001 |  结构 040 |  泡泡 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
			GUI.Label (new Rect (160, 225, 300, 20), " 敌人 010 | 损伤 001 |  结构 030 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
			GUI.Label (new Rect (160, 255, 300, 20), " 敌人 010 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
			GUI.Label (new Rect (160, 285, 300, 20), " 敌人 010 | 损伤 001 |  结构 060 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
			GUI.Label (new Rect (160, 315, 300, 20), " 敌人 005 | 损伤 001 |  结构 010 |  泡泡 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
			GUI.Label (new Rect (160, 345, 300, 20), " 敌人 015 | 损伤 001 |  结构 015 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
			GUI.Label (new Rect (160, 375, 300, 20), " 敌人 005 | 损伤 001 |  结构 250 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
			GUI.Label (new Rect (160, 405, 300, 20), " 敌人 005 | 损伤 001 |  结构 000 |  泡泡 250", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
			GUI.Label (new Rect (160, 435, 300, 20), " 敌人 020 | 损伤 001 |  结构 000 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
			GUI.Label (new Rect (160, 465, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
			GUI.Label (new Rect (160, 495, 300, 20), " 敌人 010 | 损伤 001 |  结构 110 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
			GUI.Label (new Rect (160, 525, 300, 20), " 敌人 005 | 损伤 001 |  结构 010 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
			GUI.Label (new Rect (160, 555, 300, 20), " 敌人 010 | 损伤 001 |  结构 300 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
			GUI.Label (new Rect (160, 585, 300, 20), " 敌人 030 | 损伤 001 |  结构 200 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
			GUI.Label (new Rect (160, 615, 300, 20), " 敌人 005 | 损伤 001 |  结构 055 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
			GUI.Label (new Rect (160, 645, 300, 20), " 敌人 005 | 损伤 001 |  结构 005 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
			GUI.Label (new Rect (160, 675, 300, 20), " 敌人 005 | 损伤 001 |  结构 005 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
			GUI.Label (new Rect (160, 705, 300, 20), " 敌人 010 | 损伤 001 |  结构 005 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
			GUI.Label (new Rect (160, 735, 300, 20), " 敌人 015 | 损伤 001 |  结构 010 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
			GUI.Label (new Rect (160, 765, 300, 20), " 敌人 015 | 损伤 001 |  结构 050 |  泡泡 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
			GUI.Label (new Rect (160, 795, 300, 20), " 敌人 010 | 损伤 001 |  结构 000 |  泡泡 240", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
			GUI.Label (new Rect (160, 825, 300, 20), " 敌人 015 | 损伤 001 |  结构 305 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
			GUI.Label (new Rect (160, 855, 300, 20), " 敌人 005 | 损伤 001 |  结构 040 |  泡泡 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
			GUI.Label (new Rect (160, 885, 300, 20), " 敌人 020 | 损伤 001 |  结构 200 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
			GUI.Label (new Rect (160, 915, 300, 20), " 敌人 005 | 损伤 001 |  结构 035 |  泡泡 015", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
			GUI.Label (new Rect (160, 945, 300, 20), " 敌人 005 | 损伤 001 |  结构 045 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
			GUI.Label (new Rect (160, 975, 300, 20), " 敌人 015 | 损伤 001 |  结构 005 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
			GUI.Label (new Rect (160, 1005, 300, 20), " 敌人 010 | 损伤 001 |  结构 000 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
			GUI.Label (new Rect (160, 1035, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
			GUI.Label (new Rect (160, 1065, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
			GUI.Label (new Rect (160, 1095, 300, 20), " 敌人 005 | 损伤 001 |  结构 100 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
			GUI.Label (new Rect (160, 1125, 300, 20), " 敌人 005 | 损伤 001 |  结构 100 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
			GUI.Label (new Rect (160, 1155, 300, 20), " 敌人 010 | 损伤 001 |  结构 000 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
			GUI.Label (new Rect (160, 1185, 300, 20), " 敌人 010 | 损伤 001 |  结构 050 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
			GUI.Label (new Rect (160, 1215, 300, 20), " 敌人 015 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
			GUI.Label (new Rect (160, 1245, 300, 20), " 敌人 015 | 损伤 001 |  结构 100 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
			GUI.Label (new Rect (160, 1275, 300, 20), " 敌人 010 | 损伤 001 |  结构 050 |  泡泡 025", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
			GUI.Label (new Rect (160, 1305, 300, 20), " 敌人 005 | 损伤 001 |  结构 000 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
			GUI.Label (new Rect (160, 1335, 300, 20), " 敌人 010 | 损伤 001 |  结构 300 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
			GUI.Label (new Rect (160, 1365, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
			GUI.Label (new Rect (160, 1395, 300, 20), " 敌人 015 | 损伤 001 |  结构 205 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
			GUI.Label (new Rect (160, 1425, 300, 20), " 敌人 015 | 损伤 001 |  结构 006 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
			GUI.Label (new Rect (160, 1455, 300, 20), " 敌人 010 | 损伤 001 |  结构 011 |  泡泡 010", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
			GUI.Label (new Rect (160, 1485, 300, 20), " 敌人 020 | 损伤 001 |  结构 410 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
			GUI.Label (new Rect (160, 1515, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
			GUI.Label (new Rect (160, 1545, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
			GUI.Label (new Rect (160, 1575, 300, 20), " 敌人 005 | 损伤 001 |  结构 100 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
			GUI.Label (new Rect (160, 1605, 300, 20), " 敌人 020 | 损伤 001 |  结构 100 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
			GUI.Label (new Rect (160, 1635, 300, 20), " 敌人 010 | 损伤 001 |  结构 200 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
			GUI.Label (new Rect (160, 1665, 300, 20), " 敌人 010 | 损伤 001 |  结构 000 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
			GUI.Label (new Rect (160, 1695, 300, 20), " 敌人 010 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
			GUI.Label (new Rect (160, 1725, 300, 20), " 敌人 010 | 损伤 001 |  结构 205 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
			GUI.Label (new Rect (160, 1755, 300, 20), " 敌人 015 | 损伤 001 |  结构 055 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
			GUI.Label (new Rect (160, 1785, 300, 20), " 敌人 015 | 损伤 001 |  结构 205 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
			GUI.Label (new Rect (160, 1815, 300, 20), " 敌人 005 | 损伤 001 |  结构 005 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
			GUI.Label (new Rect (160, 1845, 300, 20), " 敌人 005 | 损伤 001 |  结构 050 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
			GUI.Label (new Rect (160, 1875, 300, 20), " 敌人 015 | 损伤 001 |  结构 005 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
			GUI.Label (new Rect (160, 1905, 300, 20), " 敌人 005 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
			GUI.Label (new Rect (160, 1935, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
			GUI.Label (new Rect (160, 1965, 300, 20), " 敌人 010 | 损伤 001 |  结构 050 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
			GUI.Label (new Rect (160, 1995, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
			GUI.Label (new Rect (160, 2025, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
			GUI.Label (new Rect (160, 2055, 300, 20), " 敌人 010 | 损伤 001 |  结构 300 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
			GUI.Label (new Rect (160, 2085, 300, 20), " 敌人 010 | 损伤 001 |  结构 010 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
			GUI.Label (new Rect (160, 2115, 300, 20), " 敌人 010 | 损伤 001 |  结构 300 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
			GUI.Label (new Rect (160, 2145, 300, 20), " 敌人 010 | 损伤 001 |  结构 000 |  泡泡 300", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
			GUI.Label (new Rect (160, 2175, 300, 20), " 敌人 010 | 损伤 001 |  结构 300 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
			GUI.Label (new Rect (160, 2205, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
			GUI.Label (new Rect (160, 2235, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
			GUI.Label (new Rect (160, 2265, 300, 20), " 敌人 010 | 损伤 001 |  结构 200 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
			GUI.Label (new Rect (160, 2295, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
			GUI.Label (new Rect (160, 2325, 300, 20), " 敌人 010 | 损伤 001 |  结构 310 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
			GUI.Label (new Rect (160, 2355, 300, 20), " 敌人 010 | 损伤 001 |  结构 210 |  泡泡 200", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
			GUI.Label (new Rect (160, 2385, 300, 20), " 敌人 010 | 损伤 001 |  结构 310 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
			GUI.Label (new Rect (160, 2415, 300, 20), " 敌人 010 | 损伤 001 |  结构 210 |  泡泡 000", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
			GUI.Label (new Rect (160, 2445, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
			GUI.Label (new Rect (160, 2475, 300, 20), " 敌人 010 | 损伤 001 |  结构 205 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
			GUI.Label (new Rect (160, 2505, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
			GUI.Label (new Rect (160, 2535, 300, 20), " 敌人 010 | 损伤 001 |  结构 205 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
			GUI.Label (new Rect (160, 2565, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
			GUI.Label (new Rect (160, 2595, 300, 20), " 敌人 010 | 损伤 001 |  结构 105 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
			GUI.Label (new Rect (160, 2625, 300, 20), " 敌人 010 | 损伤 001 |  结构 205 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
			GUI.Label (new Rect (160, 2655, 300, 20), " 敌人 025 | 损伤 001 |  结构 005 |  泡泡 050", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
			GUI.Label (new Rect (160, 2685, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
			GUI.Label (new Rect (160, 2715, 300, 20), " 敌人 010 | 损伤 001 |  结构 100 |  泡泡 100", GUI.skin.label);
			GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}
			
			if (MenuScript.diff == 2) {
				GUI.Label (new Rect (160, 15, 300, 20), " 敌人 005 | 损伤 002 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
				GUI.Label (new Rect (160, 45, 300, 20), " 敌人 015 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
				GUI.Label (new Rect (160, 75, 300, 20), " 敌人 005 | 损伤 002 |  结构 250 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
				GUI.Label (new Rect (160, 105, 300, 20), " 敌人 005 | 损伤 002 |  结构 000 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
				GUI.Label (new Rect (160, 135, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
				GUI.Label (new Rect (160, 165, 300, 20), " 敌人 025 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
				GUI.Label (new Rect (160, 195, 300, 20), " 敌人 010 | 损伤 002 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
				GUI.Label (new Rect (160, 225, 300, 20), " 敌人 010 | 损伤 002 |  结构 030 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
				GUI.Label (new Rect (160, 255, 300, 20), " 敌人 010 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
				GUI.Label (new Rect (160, 285, 300, 20), " 敌人 010 | 损伤 002 |  结构 060 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
				GUI.Label (new Rect (160, 315, 300, 20), " 敌人 005 | 损伤 002 |  结构 010 |  泡泡 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
				GUI.Label (new Rect (160, 345, 300, 20), " 敌人 015 | 损伤 002 |  结构 015 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
				GUI.Label (new Rect (160, 375, 300, 20), " 敌人 005 | 损伤 002 |  结构 250 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
				GUI.Label (new Rect (160, 405, 300, 20), " 敌人 005 | 损伤 002 |  结构 000 |  泡泡 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
				GUI.Label (new Rect (160, 435, 300, 20), " 敌人 020 | 损伤 002 |  结构 000 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
				GUI.Label (new Rect (160, 465, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
				GUI.Label (new Rect (160, 495, 300, 20), " 敌人 010 | 损伤 002 |  结构 110 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
				GUI.Label (new Rect (160, 525, 300, 20), " 敌人 005 | 损伤 002 |  结构 010 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
				GUI.Label (new Rect (160, 555, 300, 20), " 敌人 010 | 损伤 002 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
				GUI.Label (new Rect (160, 585, 300, 20), " 敌人 030 | 损伤 002 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
				GUI.Label (new Rect (160, 615, 300, 20), " 敌人 005 | 损伤 002 |  结构 055 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
				GUI.Label (new Rect (160, 645, 300, 20), " 敌人 005 | 损伤 002 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
				GUI.Label (new Rect (160, 675, 300, 20), " 敌人 005 | 损伤 002 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
				GUI.Label (new Rect (160, 705, 300, 20), " 敌人 010 | 损伤 002 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
				GUI.Label (new Rect (160, 735, 300, 20), " 敌人 015 | 损伤 002 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
				GUI.Label (new Rect (160, 765, 300, 20), " 敌人 015 | 损伤 002 |  结构 050 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
				GUI.Label (new Rect (160, 795, 300, 20), " 敌人 010 | 损伤 002 |  结构 000 |  泡泡 240", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
				GUI.Label (new Rect (160, 825, 300, 20), " 敌人 015 | 损伤 002 |  结构 305 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
				GUI.Label (new Rect (160, 855, 300, 20), " 敌人 005 | 损伤 002 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
				GUI.Label (new Rect (160, 885, 300, 20), " 敌人 020 | 损伤 002 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
				GUI.Label (new Rect (160, 915, 300, 20), " 敌人 005 | 损伤 002 |  结构 035 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
				GUI.Label (new Rect (160, 945, 300, 20), " 敌人 005 | 损伤 002 |  结构 045 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
				GUI.Label (new Rect (160, 975, 300, 20), " 敌人 015 | 损伤 002 |  结构 005 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
				GUI.Label (new Rect (160, 1005, 300, 20), " 敌人 010 | 损伤 002 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
				GUI.Label (new Rect (160, 1035, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
				GUI.Label (new Rect (160, 1065, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
				GUI.Label (new Rect (160, 1095, 300, 20), " 敌人 005 | 损伤 002 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
				GUI.Label (new Rect (160, 1125, 300, 20), " 敌人 005 | 损伤 002 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
				GUI.Label (new Rect (160, 1155, 300, 20), " 敌人 010 | 损伤 002 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
				GUI.Label (new Rect (160, 1185, 300, 20), " 敌人 010 | 损伤 002 |  结构 050 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
				GUI.Label (new Rect (160, 1215, 300, 20), " 敌人 015 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
				GUI.Label (new Rect (160, 1245, 300, 20), " 敌人 015 | 损伤 002 |  结构 100 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
				GUI.Label (new Rect (160, 1275, 300, 20), " 敌人 010 | 损伤 002 |  结构 050 |  泡泡 025", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
				GUI.Label (new Rect (160, 1305, 300, 20), " 敌人 005 | 损伤 002 |  结构 000 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
				GUI.Label (new Rect (160, 1335, 300, 20), " 敌人 010 | 损伤 002 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
				GUI.Label (new Rect (160, 1365, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
				GUI.Label (new Rect (160, 1395, 300, 20), " 敌人 015 | 损伤 002 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
				GUI.Label (new Rect (160, 1425, 300, 20), " 敌人 015 | 损伤 002 |  结构 006 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
				GUI.Label (new Rect (160, 1455, 300, 20), " 敌人 010 | 损伤 002 |  结构 011 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
				GUI.Label (new Rect (160, 1485, 300, 20), " 敌人 020 | 损伤 002 |  结构 410 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
				GUI.Label (new Rect (160, 1515, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
				GUI.Label (new Rect (160, 1545, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
				GUI.Label (new Rect (160, 1575, 300, 20), " 敌人 005 | 损伤 002 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
				GUI.Label (new Rect (160, 1605, 300, 20), " 敌人 020 | 损伤 002 |  结构 100 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
				GUI.Label (new Rect (160, 1635, 300, 20), " 敌人 010 | 损伤 002 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
				GUI.Label (new Rect (160, 1665, 300, 20), " 敌人 010 | 损伤 002 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
				GUI.Label (new Rect (160, 1695, 300, 20), " 敌人 010 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
				GUI.Label (new Rect (160, 1725, 300, 20), " 敌人 010 | 损伤 002 |  结构 205 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
				GUI.Label (new Rect (160, 1755, 300, 20), " 敌人 015 | 损伤 002 |  结构 055 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
				GUI.Label (new Rect (160, 1785, 300, 20), " 敌人 015 | 损伤 002 |  结构 205 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
				GUI.Label (new Rect (160, 1815, 300, 20), " 敌人 005 | 损伤 002 |  结构 005 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
				GUI.Label (new Rect (160, 1845, 300, 20), " 敌人 005 | 损伤 002 |  结构 050 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
				GUI.Label (new Rect (160, 1875, 300, 20), " 敌人 015 | 损伤 002 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
				GUI.Label (new Rect (160, 1905, 300, 20), " 敌人 005 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
				GUI.Label (new Rect (160, 1935, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
				GUI.Label (new Rect (160, 1965, 300, 20), " 敌人 010 | 损伤 002 |  结构 050 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
				GUI.Label (new Rect (160, 1995, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
				GUI.Label (new Rect (160, 2025, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
				GUI.Label (new Rect (160, 2055, 300, 20), " 敌人 010 | 损伤 002 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
				GUI.Label (new Rect (160, 2085, 300, 20), " 敌人 010 | 损伤 002 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
				GUI.Label (new Rect (160, 2115, 300, 20), " 敌人 010 | 损伤 002 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
				GUI.Label (new Rect (160, 2145, 300, 20), " 敌人 010 | 损伤 002 |  结构 000 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
				GUI.Label (new Rect (160, 2175, 300, 20), " 敌人 010 | 损伤 002 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
				GUI.Label (new Rect (160, 2205, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
				GUI.Label (new Rect (160, 2235, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
				GUI.Label (new Rect (160, 2265, 300, 20), " 敌人 010 | 损伤 002 |  结构 200 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
				GUI.Label (new Rect (160, 2295, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
				GUI.Label (new Rect (160, 2325, 300, 20), " 敌人 010 | 损伤 002 |  结构 310 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
				GUI.Label (new Rect (160, 2355, 300, 20), " 敌人 010 | 损伤 002 |  结构 210 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
				GUI.Label (new Rect (160, 2385, 300, 20), " 敌人 010 | 损伤 002 |  结构 310 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
				GUI.Label (new Rect (160, 2415, 300, 20), " 敌人 010 | 损伤 002 |  结构 210 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
				GUI.Label (new Rect (160, 2445, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
				GUI.Label (new Rect (160, 2475, 300, 20), " 敌人 010 | 损伤 002 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
				GUI.Label (new Rect (160, 2505, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
				GUI.Label (new Rect (160, 2535, 300, 20), " 敌人 010 | 损伤 002 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
				GUI.Label (new Rect (160, 2565, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
				GUI.Label (new Rect (160, 2595, 300, 20), " 敌人 010 | 损伤 002 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
				GUI.Label (new Rect (160, 2625, 300, 20), " 敌人 010 | 损伤 002 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
				GUI.Label (new Rect (160, 2655, 300, 20), " 敌人 025 | 损伤 002 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
				GUI.Label (new Rect (160, 2685, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
				GUI.Label (new Rect (160, 2715, 300, 20), " 敌人 010 | 损伤 002 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}
			
			if (MenuScript.diff == 3) {
				GUI.Label (new Rect (160, 15, 300, 20), " 敌人 005 | 损伤 003 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 15, 20, 20), boss);
				GUI.Label (new Rect (160, 45, 300, 20), " 敌人 015 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 45, 20, 20), mob);
				GUI.Label (new Rect (160, 75, 300, 20), " 敌人 005 | 损伤 003 |  结构 250 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 75, 20, 20), boss);
				GUI.Label (new Rect (160, 105, 300, 20), " 敌人 005 | 损伤 003 |  结构 000 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 105, 20, 20), boss);
				GUI.Label (new Rect (160, 135, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 135, 20, 20), boss);
				GUI.Label (new Rect (160, 165, 300, 20), " 敌人 025 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 165, 20, 20), mob);
				GUI.Label (new Rect (160, 195, 300, 20), " 敌人 010 | 损伤 003 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 195, 20, 20), boss);
				GUI.Label (new Rect (160, 225, 300, 20), " 敌人 010 | 损伤 003 |  结构 030 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 225, 20, 20), boss);
				GUI.Label (new Rect (160, 255, 300, 20), " 敌人 010 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 255, 20, 20), mob);
				GUI.Label (new Rect (160, 285, 300, 20), " 敌人 010 | 损伤 003 |  结构 060 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 285, 20, 20), boss);
				GUI.Label (new Rect (160, 315, 300, 20), " 敌人 005 | 损伤 003 |  结构 010 |  泡泡 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 315, 20, 20), boss);
				GUI.Label (new Rect (160, 345, 300, 20), " 敌人 015 | 损伤 003 |  结构 015 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 345, 20, 20), mob);
				GUI.Label (new Rect (160, 375, 300, 20), " 敌人 005 | 损伤 003 |  结构 250 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 375, 20, 20), boss);
				GUI.Label (new Rect (160, 405, 300, 20), " 敌人 005 | 损伤 003 |  结构 000 |  泡泡 250", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 405, 20, 20), boss);
				GUI.Label (new Rect (160, 435, 300, 20), " 敌人 020 | 损伤 003 |  结构 000 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 435, 20, 20), mob);
				GUI.Label (new Rect (160, 465, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 465, 20, 20), boss);
				GUI.Label (new Rect (160, 495, 300, 20), " 敌人 010 | 损伤 003 |  结构 110 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 495, 20, 20), boss);
				GUI.Label (new Rect (160, 525, 300, 20), " 敌人 005 | 损伤 003 |  结构 010 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 525, 20, 20), boss);
				GUI.Label (new Rect (160, 555, 300, 20), " 敌人 010 | 损伤 003 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 555, 20, 20), boss);
				GUI.Label (new Rect (160, 585, 300, 20), " 敌人 030 | 损伤 003 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 585, 20, 20), mob);
				GUI.Label (new Rect (160, 615, 300, 20), " 敌人 005 | 损伤 003 |  结构 055 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 615, 20, 20), boss);
				GUI.Label (new Rect (160, 645, 300, 20), " 敌人 005 | 损伤 003 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 645, 20, 20), boss);
				GUI.Label (new Rect (160, 675, 300, 20), " 敌人 005 | 损伤 003 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 675, 20, 20), boss);
				GUI.Label (new Rect (160, 705, 300, 20), " 敌人 010 | 损伤 003 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 705, 20, 20), mob);
				GUI.Label (new Rect (160, 735, 300, 20), " 敌人 015 | 损伤 003 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 735, 20, 20), mob);
				GUI.Label (new Rect (160, 765, 300, 20), " 敌人 015 | 损伤 003 |  结构 050 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 765, 20, 20), boss);
				GUI.Label (new Rect (160, 795, 300, 20), " 敌人 010 | 损伤 003 |  结构 000 |  泡泡 240", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 795, 20, 20), boss);
				GUI.Label (new Rect (160, 825, 300, 20), " 敌人 015 | 损伤 003 |  结构 305 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 825, 20, 20), boss);
				GUI.Label (new Rect (160, 855, 300, 20), " 敌人 005 | 损伤 003 |  结构 040 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 855, 20, 20), boss);
				GUI.Label (new Rect (160, 885, 300, 20), " 敌人 020 | 损伤 003 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 885, 20, 20), mob);
				GUI.Label (new Rect (160, 915, 300, 20), " 敌人 005 | 损伤 003 |  结构 035 |  泡泡 015", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 915, 20, 20), boss);
				GUI.Label (new Rect (160, 945, 300, 20), " 敌人 005 | 损伤 003 |  结构 045 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 945, 20, 20), boss);
				GUI.Label (new Rect (160, 975, 300, 20), " 敌人 015 | 损伤 003 |  结构 005 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 975, 20, 20), boss);
				GUI.Label (new Rect (160, 1005, 300, 20), " 敌人 010 | 损伤 003 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1005, 20, 20), boss);
				GUI.Label (new Rect (160, 1035, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1035, 20, 20), mob);
				GUI.Label (new Rect (160, 1065, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1065, 20, 20), mob);
				GUI.Label (new Rect (160, 1095, 300, 20), " 敌人 005 | 损伤 003 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1095, 20, 20), boss);
				GUI.Label (new Rect (160, 1125, 300, 20), " 敌人 005 | 损伤 003 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1125, 20, 20), boss);
				GUI.Label (new Rect (160, 1155, 300, 20), " 敌人 010 | 损伤 003 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1155, 20, 20), boss);
				GUI.Label (new Rect (160, 1185, 300, 20), " 敌人 010 | 损伤 003 |  结构 050 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1185, 20, 20), boss);
				GUI.Label (new Rect (160, 1215, 300, 20), " 敌人 015 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1215, 20, 20), mob);
				GUI.Label (new Rect (160, 1245, 300, 20), " 敌人 015 | 损伤 003 |  结构 100 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1245, 20, 20), mob);
				GUI.Label (new Rect (160, 1275, 300, 20), " 敌人 010 | 损伤 003 |  结构 050 |  泡泡 025", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1275, 20, 20), boss);
				GUI.Label (new Rect (160, 1305, 300, 20), " 敌人 005 | 损伤 003 |  结构 000 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1305, 20, 20), boss);
				GUI.Label (new Rect (160, 1335, 300, 20), " 敌人 010 | 损伤 003 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1335, 20, 20), boss);
				GUI.Label (new Rect (160, 1365, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1365, 20, 20), boss);
				GUI.Label (new Rect (160, 1395, 300, 20), " 敌人 015 | 损伤 003 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1395, 20, 20), boss);
				GUI.Label (new Rect (160, 1425, 300, 20), " 敌人 015 | 损伤 003 |  结构 006 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1425, 20, 20), mob);
				GUI.Label (new Rect (160, 1455, 300, 20), " 敌人 010 | 损伤 003 |  结构 011 |  泡泡 010", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1455, 20, 20), mob);
				GUI.Label (new Rect (160, 1485, 300, 20), " 敌人 020 | 损伤 003 |  结构 410 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1485, 20, 20), boss);
				GUI.Label (new Rect (160, 1515, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1515, 20, 20), boss);
				GUI.Label (new Rect (160, 1545, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1545, 20, 20), boss);
				GUI.Label (new Rect (160, 1575, 300, 20), " 敌人 005 | 损伤 003 |  结构 100 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1575, 20, 20), boss);
				GUI.Label (new Rect (160, 1605, 300, 20), " 敌人 020 | 损伤 003 |  结构 100 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1605, 20, 20), boss);
				GUI.Label (new Rect (160, 1635, 300, 20), " 敌人 010 | 损伤 003 |  结构 200 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1635, 20, 20), mob);
				GUI.Label (new Rect (160, 1665, 300, 20), " 敌人 010 | 损伤 003 |  结构 000 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1665, 20, 20), boss);
				GUI.Label (new Rect (160, 1695, 300, 20), " 敌人 010 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1695, 20, 20), mob);
				GUI.Label (new Rect (160, 1725, 300, 20), " 敌人 010 | 损伤 003 |  结构 205 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1725, 20, 20), boss);
				GUI.Label (new Rect (160, 1755, 300, 20), " 敌人 015 | 损伤 003 |  结构 055 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1755, 20, 20), boss);
				GUI.Label (new Rect (160, 1785, 300, 20), " 敌人 015 | 损伤 003 |  结构 205 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1785, 20, 20), boss);
				GUI.Label (new Rect (160, 1815, 300, 20), " 敌人 005 | 损伤 003 |  结构 005 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1815, 20, 20), boss);
				GUI.Label (new Rect (160, 1845, 300, 20), " 敌人 005 | 损伤 003 |  结构 050 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1845, 20, 20), boss);
				GUI.Label (new Rect (160, 1875, 300, 20), " 敌人 015 | 损伤 003 |  结构 005 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1875, 20, 20), mob);
				GUI.Label (new Rect (160, 1905, 300, 20), " 敌人 005 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1905, 20, 20), boss);
				GUI.Label (new Rect (160, 1935, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1935, 20, 20), boss);
				GUI.Label (new Rect (160, 1965, 300, 20), " 敌人 010 | 损伤 003 |  结构 050 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1965, 20, 20), boss);
				GUI.Label (new Rect (160, 1995, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 1995, 20, 20), boss);
				GUI.Label (new Rect (160, 2025, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2025, 20, 20), mob);
				GUI.Label (new Rect (160, 2055, 300, 20), " 敌人 010 | 损伤 003 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2055, 20, 20), boss);
				GUI.Label (new Rect (160, 2085, 300, 20), " 敌人 010 | 损伤 003 |  结构 010 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2085, 20, 20), mob);
				GUI.Label (new Rect (160, 2115, 300, 20), " 敌人 010 | 损伤 003 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2115, 20, 20), boss);
				GUI.Label (new Rect (160, 2145, 300, 20), " 敌人 010 | 损伤 003 |  结构 000 |  泡泡 300", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2145, 20, 20), boss);
				GUI.Label (new Rect (160, 2175, 300, 20), " 敌人 010 | 损伤 003 |  结构 300 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2175, 20, 20), boss);
				GUI.Label (new Rect (160, 2205, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2205, 20, 20), boss);
				GUI.Label (new Rect (160, 2235, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2235, 20, 20), boss);
				GUI.Label (new Rect (160, 2265, 300, 20), " 敌人 010 | 损伤 003 |  结构 200 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2265, 20, 20), boss);
				GUI.Label (new Rect (160, 2295, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2295, 20, 20), boss);
				GUI.Label (new Rect (160, 2325, 300, 20), " 敌人 010 | 损伤 003 |  结构 310 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2325, 20, 20), mob);
				GUI.Label (new Rect (160, 2355, 300, 20), " 敌人 010 | 损伤 003 |  结构 210 |  泡泡 200", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2355, 20, 20), boss);
				GUI.Label (new Rect (160, 2385, 300, 20), " 敌人 010 | 损伤 003 |  结构 310 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2385, 20, 20), boss);
				GUI.Label (new Rect (160, 2415, 300, 20), " 敌人 010 | 损伤 003 |  结构 210 |  泡泡 000", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2415, 20, 20), mob);
				GUI.Label (new Rect (160, 2445, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2445, 20, 20), boss);
				GUI.Label (new Rect (160, 2475, 300, 20), " 敌人 010 | 损伤 003 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2475, 20, 20), boss);
				GUI.Label (new Rect (160, 2505, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2505, 20, 20), boss);
				GUI.Label (new Rect (160, 2535, 300, 20), " 敌人 010 | 损伤 003 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2535, 20, 20), boss);
				GUI.Label (new Rect (160, 2565, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2565, 20, 20), boss);
				GUI.Label (new Rect (160, 2595, 300, 20), " 敌人 010 | 损伤 003 |  结构 105 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2595, 20, 20), boss);
				GUI.Label (new Rect (160, 2625, 300, 20), " 敌人 010 | 损伤 003 |  结构 205 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2625, 20, 20), boss);
				GUI.Label (new Rect (160, 2655, 300, 20), " 敌人 025 | 损伤 003 |  结构 005 |  泡泡 050", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2655, 20, 20), mob);
				GUI.Label (new Rect (160, 2685, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2685, 20, 20), boss);
				GUI.Label (new Rect (160, 2715, 300, 20), " 敌人 010 | 损伤 003 |  结构 100 |  泡泡 100", GUI.skin.label);
				GUI.DrawTexture (new Rect (460, 2715, 20, 20), boss);
			}
			
			
			
			if (GUI.Button (new Rect (15, 15, 100, 20), "水平 01(S)")) {
				Application.LoadLevel ("LLevel1");
			}
			if (GUI.Button (new Rect (15, 45, 100, 20), "水平 02(S)")) {
				if (GDB.unlockLeavel >= 2) {
					Application.LoadLevel ("LLevel2");
				}
			}
			if (GUI.Button (new Rect (15, 75, 100, 20), "水平 03(S)")) {
				if (GDB.unlockLeavel >= 3) {
					Application.LoadLevel ("LLevel3");
				}
			}
			if (GUI.Button (new Rect (15, 105, 100, 20), "水平 04(S)")) {
				if (GDB.unlockLeavel >= 4) {
					Application.LoadLevel ("LLevel4");
				}
			}
			if (GUI.Button (new Rect (15, 135, 100, 20), "水平 05(M)")) {
				if (GDB.unlockLeavel >= 5) {
					Application.LoadLevel ("LLevel5");
				}
			}
			if (GUI.Button (new Rect (15, 165, 100, 20), "水平 06(M)")) {
				if (GDB.unlockLeavel >= 6) {
					Application.LoadLevel ("LLevel6");
				}
			}
			if (GUI.Button (new Rect (15, 195, 100, 20), "水平 07(S)")) {
				if (GDB.unlockLeavel >= 7) {
					Application.LoadLevel ("LLevel7");
				}
			}
			if (GUI.Button (new Rect (15, 225, 100, 20), "水平 08(S)")) {
				if (GDB.unlockLeavel >= 8) {
					Application.LoadLevel ("LLevel8");
				}
			}
			if (GUI.Button (new Rect (15, 255, 100, 20), "水平 09(S)")) {
				if (GDB.unlockLeavel >= 9) {
					Application.LoadLevel ("LLevel9");
				}
			}
			if (GUI.Button (new Rect (15, 285, 100, 20), "水平 10(M)")) {
				if (GDB.unlockLeavel >= 10) {
					Application.LoadLevel ("LLevel10");
				}
			}
			if (GUI.Button (new Rect (15, 315, 100, 20), "水平 11(M)")) {
				if (GDB.unlockLeavel >= 11) {
					Application.LoadLevel ("LLevel11");
				}
			}
			if (GUI.Button (new Rect (15, 345, 100, 20), "水平 12(M)")) {
				if (GDB.unlockLeavel >= 12) {
					Application.LoadLevel ("LLevel12");
				}
			}
			if (GUI.Button (new Rect (15, 375, 100, 20), "水平 13(S)")) {
				if (GDB.unlockLeavel >= 13) {
					Application.LoadLevel ("LLevel13");
				}
			}
			if (GUI.Button (new Rect (15, 405, 100, 20), "水平 14(S)")) {
				if (GDB.unlockLeavel >= 14) {
					Application.LoadLevel ("LLevel14");
				}
			}
			if (GUI.Button (new Rect (15, 435, 100, 20), "水平 15(S)")) {
				if (GDB.unlockLeavel >= 15) {
					Application.LoadLevel ("LLevel15");
				}
			}
			if (GUI.Button (new Rect (15, 465, 100, 20), "水平 16(S)")) {
				if (GDB.unlockLeavel >= 16) {
					Application.LoadLevel ("LLevel16");
				}
			}
			if (GUI.Button (new Rect (15, 495, 100, 20), "水平 17(M)")) {
				if (GDB.unlockLeavel >= 17) {
					Application.LoadLevel ("LLevel17");
				}
			}
			if (GUI.Button (new Rect (15, 525, 100, 20), "水平 18(S)")) {
				if (GDB.unlockLeavel >= 18) {
					Application.LoadLevel ("LLevel18");
				}
			}
			if (GUI.Button (new Rect (15, 555, 100, 20), "水平 19(M)")) {
				if (GDB.unlockLeavel >= 19) {
					Application.LoadLevel ("LLevel19");
				}
			}
			if (GUI.Button (new Rect (15, 585, 100, 20), "水平 20(M)")) {
				if (GDB.unlockLeavel >= 20) {
					Application.LoadLevel ("LLevel20");
				}
			}
			if (GUI.Button (new Rect (15, 615, 100, 20), "水平 21(S)")) {
				if (GDB.unlockLeavel >= 21) {
					Application.LoadLevel ("LLevel21");
				}
			}
			if (GUI.Button (new Rect (15, 645, 100, 20), "水平 22(S)")) {
				if (GDB.unlockLeavel >= 22) {
					Application.LoadLevel ("LLevel22");
				}
			}
			if (GUI.Button (new Rect (15, 675, 100, 20), "水平 23(S)")) {
				if (GDB.unlockLeavel >= 23) {
					Application.LoadLevel ("LLevel23");
				}
			}
			if (GUI.Button (new Rect (15, 705, 100, 20), "水平 24(S)")) {
				if (GDB.unlockLeavel >= 24) {
					Application.LoadLevel ("LLevel24");
				}
			}
			if (GUI.Button (new Rect (15, 735, 100, 20), "水平 25(M)")) {
				if (GDB.unlockLeavel >= 25) {
					Application.LoadLevel ("LLevel25");
				}
			}
			if (GUI.Button (new Rect (15, 765, 100, 20), "水平 26(S)")) {
				if (GDB.unlockLeavel >= 26) {
					Application.LoadLevel ("LLevel26");
				}
			}
			if (GUI.Button (new Rect (15, 795, 100, 20), "水平 27(M)")) {
				if (GDB.unlockLeavel >= 27) {
					Application.LoadLevel ("LLevel27");
				}
			}
			if (GUI.Button (new Rect (15, 825, 100, 20), "水平 28(M)")) {
				if (GDB.unlockLeavel >= 28) {
					Application.LoadLevel ("LLevel28");
				}
			}
			if (GUI.Button (new Rect (15, 855, 100, 20), "水平 29(S)")) {
				if (GDB.unlockLeavel >= 29) {
					Application.LoadLevel ("LLevel29");
				}
			}
			if (GUI.Button (new Rect (15, 885, 100, 20), "水平 30(M)")) {
				if (GDB.unlockLeavel >= 30) {
					Application.LoadLevel ("LLevel30");
				}
			}
			if (GUI.Button (new Rect (15, 915, 100, 20), "水平 31(S)")) {
				if (GDB.unlockLeavel >= 31) {
					Application.LoadLevel ("LLevel31");
				}
			}
			if (GUI.Button (new Rect (15, 945, 100, 20), "水平 32(S)")) {
				if (GDB.unlockLeavel >= 32) {
					Application.LoadLevel ("LLevel32");
				}
			}
			if (GUI.Button (new Rect (15, 975, 100, 20), "水平 33(M)")) {
				if (GDB.unlockLeavel >= 33) {
					Application.LoadLevel ("LLevel33");
				}
			}
			if (GUI.Button (new Rect (15, 1005, 100, 20), "水平 34(M)")) {
				if (GDB.unlockLeavel >= 34) {
					Application.LoadLevel ("LLevel34");
				}
			}
			if (GUI.Button (new Rect (15, 1035, 100, 20), "水平 35(M)")) {
				if (GDB.unlockLeavel >= 35) {
					Application.LoadLevel ("LLevel35");
				}
			}
			if (GUI.Button (new Rect (15, 1065, 100, 20), "水平 36(M)")) {
				if (GDB.unlockLeavel >= 36) {
					Application.LoadLevel ("LLevel36");
				}
			}
			if (GUI.Button (new Rect (15, 1095, 100, 20), "水平 37(S)")) {
				if (GDB.unlockLeavel >= 37) {
					Application.LoadLevel ("LLevel37");
				}
			}
			if (GUI.Button (new Rect (15, 1125, 100, 20), "水平 38(S)")) {
				if (GDB.unlockLeavel >= 38) {
					Application.LoadLevel ("LLevel38");
				}
			}
			if (GUI.Button (new Rect (15, 1155, 100, 20), "水平 39(M)")) {
				if (GDB.unlockLeavel >= 39) {
					Application.LoadLevel ("LLevel39");
				}
			}
			if (GUI.Button (new Rect (15, 1185, 100, 20), "水平 40(M)")) {
				if (GDB.unlockLeavel >= 40) {
					Application.LoadLevel ("LLevel40");
				}
			}
			if (GUI.Button (new Rect (15, 1215, 100, 20), "水平 41(S)")) {
				if (GDB.unlockLeavel >= 41) {
					Application.LoadLevel ("LLevel41");
				}
			}
			if (GUI.Button (new Rect (15, 1245, 100, 20), "水平 42(S)")) {
				if (GDB.unlockLeavel >= 42) {
					Application.LoadLevel ("LLevel42");
				}
			}
			if (GUI.Button (new Rect (15, 1275, 100, 20), "水平 43(S)")) {
				if (GDB.unlockLeavel >= 43) {
					Application.LoadLevel ("LLevel43");
				}
			}
			if (GUI.Button (new Rect (15, 1305, 100, 20), "水平 44(S)")) {
				if (GDB.unlockLeavel >= 44) {
					Application.LoadLevel ("LLevel44");
				}
			}
			if (GUI.Button (new Rect (15, 1335, 100, 20), "水平 45(M)")) {
				if (GDB.unlockLeavel >= 45) {
					Application.LoadLevel ("LLevel45");
				}
			}
			if (GUI.Button (new Rect (15, 1365, 100, 20), "水平 46(M)")) {
				if (GDB.unlockLeavel >= 46) {
					Application.LoadLevel ("LLevel46");
				}
			}
			if (GUI.Button (new Rect (15, 1395, 100, 20), "水平 47(M)")) {
				if (GDB.unlockLeavel >= 47) {
					Application.LoadLevel ("LLevel47");
				}
			}
			if (GUI.Button (new Rect (15, 1425, 100, 20), "水平 48(M)")) {
				if (GDB.unlockLeavel >= 48) {
					Application.LoadLevel ("LLevel48");
				}
			}
			if (GUI.Button (new Rect (15, 1455, 100, 20), "水平 49(M)")) {
				if (GDB.unlockLeavel >= 49) {
					Application.LoadLevel ("LLevel49");
				}
			}
			if (GUI.Button (new Rect (15, 1485, 100, 20), "水平 50(L)")) {
				if (GDB.unlockLeavel >= 50) {
					Application.LoadLevel ("LLevel50");
				}
			}
			if (GUI.Button (new Rect (15, 1515, 100, 20), "水平 51(M)")) {
				if (GDB.unlockLeavel >= 51) {
					Application.LoadLevel ("LLevel51");
				}
			}
			if (GUI.Button (new Rect (15, 1545, 100, 20), "水平 52(M)")) {
				if (GDB.unlockLeavel >= 52) {
					Application.LoadLevel ("LLevel52");
				}
			}
			if (GUI.Button (new Rect (15, 1575, 100, 20), "水平 53(S)")) {
				if (GDB.unlockLeavel >= 53) {
					Application.LoadLevel ("LLevel53");
				}
			}
			if (GUI.Button (new Rect (15, 1605, 100, 20), "水平 54(L)")) {
				if (GDB.unlockLeavel >= 54) {
					Application.LoadLevel ("LLevel54");
				}
			}
			if (GUI.Button (new Rect (15, 1635, 100, 20), "水平 55(M)")) {
				if (GDB.unlockLeavel >= 55) {
					Application.LoadLevel ("LLevel55");
				}
			}
			if (GUI.Button (new Rect (15, 1665, 100, 20), "水平 56(M)")) {
				if (GDB.unlockLeavel >= 56) {
					Application.LoadLevel ("LLevel56");
				}
			}
			if (GUI.Button (new Rect (15, 1695, 100, 20), "水平 57(M)")) {
				if (GDB.unlockLeavel >= 57) {
					Application.LoadLevel ("LLevel57");
				}
			}
			if (GUI.Button (new Rect (15, 1725, 100, 20), "水平 58(M)")) {
				if (GDB.unlockLeavel >= 58) {
					Application.LoadLevel ("LLevel58");
				}
			}
			if (GUI.Button (new Rect (15, 1755, 100, 20), "水平 59(L)")) {
				if (GDB.unlockLeavel >= 59) {
					Application.LoadLevel ("LLevel59");
				}
			}
			if (GUI.Button (new Rect (15, 1785, 100, 20), "水平 60(L)")) {
				if (GDB.unlockLeavel >= 60) {
					Application.LoadLevel ("LLevel60");
				}
			}
			if (GUI.Button (new Rect (15, 1815, 100, 20), "水平 61(M)")) {
				if (GDB.unlockLeavel >= 61) {
					Application.LoadLevel ("LLevel61");
				}
			}
			if (GUI.Button (new Rect (15, 1845, 100, 20), "水平 62(S)")) {
				if (GDB.unlockLeavel >= 62) {
					Application.LoadLevel ("LLevel62");
				}
			}
			if (GUI.Button (new Rect (15, 1875, 100, 20), "水平 63(S)")) {
				if (GDB.unlockLeavel >= 63) {
					Application.LoadLevel ("LLevel63");
				}
			}
			if (GUI.Button (new Rect (15, 1905, 100, 20), "水平 64(M)")) {
				if (GDB.unlockLeavel >= 64) {
					Application.LoadLevel ("LLevel64");
				}
			}
			if (GUI.Button (new Rect (15, 1935, 100, 20), "水平 65(L)")) {
				if (GDB.unlockLeavel >= 65) {
					Application.LoadLevel ("LLevel65");
				}
			}
			if (GUI.Button (new Rect (15, 1965, 100, 20), "水平 66(M)")) {
				if (GDB.unlockLeavel >= 66) {
					Application.LoadLevel ("LLevel66");
				}
			}
			if (GUI.Button (new Rect (15, 1995, 100, 20), "水平 67(L)")) {
				if (GDB.unlockLeavel >= 67) {
					Application.LoadLevel ("LLevel67");
				}
			}
			if (GUI.Button (new Rect (15, 2025, 100, 20), "水平 68(M)")) {
				if (GDB.unlockLeavel >= 68) {
					Application.LoadLevel ("LLevel68");
				}
			}
			if (GUI.Button (new Rect (15, 2055, 100, 20), "水平 69(L)")) {
				if (GDB.unlockLeavel >= 69) {
					Application.LoadLevel ("LLevel69");
				}
			}
			if (GUI.Button (new Rect (15, 2085, 100, 20), "水平 70(M)")) {
				if (GDB.unlockLeavel >= 70) {
					Application.LoadLevel ("LLevel70");
				}
			}
			if (GUI.Button (new Rect (15, 2115, 100, 20), "水平 71(M)")) {
				if (GDB.unlockLeavel >= 71) {
					Application.LoadLevel ("LLevel71");
				}
			}
			if (GUI.Button (new Rect (15, 2145, 100, 20), "水平 72(L)")) {
				if (GDB.unlockLeavel >= 72) {
					Application.LoadLevel ("LLevel72");
				}
			}
			if (GUI.Button (new Rect (15, 2175, 100, 20), "水平 73(M)")) {
				if (GDB.unlockLeavel >= 73) {
					Application.LoadLevel ("LLevel73");
				}
			}
			if (GUI.Button (new Rect (15, 2205, 100, 20), "水平 74(L)")) {
				if (GDB.unlockLeavel >= 74) {
					Application.LoadLevel ("LLevel74");
				}
			}
			if (GUI.Button (new Rect (15, 2235, 100, 20), "水平 75(M)")) {
				if (GDB.unlockLeavel >= 75) {
					Application.LoadLevel ("LLevel75");
				}
			}
			if (GUI.Button (new Rect (15, 2265, 100, 20), "水平 76(L)")) {
				if (GDB.unlockLeavel >= 76) {
					Application.LoadLevel ("LLevel76");
				}
			}
			if (GUI.Button (new Rect (15, 2295, 100, 20), "水平 77(L)")) {
				if (GDB.unlockLeavel >= 77) {
					Application.LoadLevel ("LLevel77");
				}
			}
			if (GUI.Button (new Rect (15, 2325, 100, 20), "水平 78(M)")) {
				if (GDB.unlockLeavel >= 78) {
					Application.LoadLevel ("LLevel78");
				}
			}
			if (GUI.Button (new Rect (15, 2355, 100, 20), "水平 79(L)")) {
				if (GDB.unlockLeavel >= 79) {
					Application.LoadLevel ("LLevel79");
				}
			}
			if (GUI.Button (new Rect (15, 2385, 100, 20), "水平 80(L)")) {
				if (GDB.unlockLeavel >= 80) {
					Application.LoadLevel ("LLevel80");
				}
			}
			if (GUI.Button (new Rect (15, 2415, 100, 20), "水平 81(M)")) {
				if (GDB.unlockLeavel >= 81) {
					Application.LoadLevel ("LLevel81");
				}
			}
			if (GUI.Button (new Rect (15, 2445, 100, 20), "水平 82(M)")) {
				if (GDB.unlockLeavel >= 82) {
					Application.LoadLevel ("LLevel82");
				}
			}
			if (GUI.Button (new Rect (15, 2475, 100, 20), "水平 83(L)")) {
				if (GDB.unlockLeavel >= 83) {
					Application.LoadLevel ("LLevel83");
				}
			}
			if (GUI.Button (new Rect (15, 2505, 100, 20), "水平 84(M)")) {
				if (GDB.unlockLeavel >= 84) {
					Application.LoadLevel ("LLevel84");
				}
			}
			if (GUI.Button (new Rect (15, 2535, 100, 20), "水平 85(L)")) {
				if (GDB.unlockLeavel >= 85) {
					Application.LoadLevel ("LLevel85");
				}
			}
			if (GUI.Button (new Rect (15, 2565, 100, 20), "水平 86(M)")) {
				if (GDB.unlockLeavel >= 86) {
					Application.LoadLevel ("LLevel86");
				}
			}
			if (GUI.Button (new Rect (15, 2595, 100, 20), "水平 87(M)")) {
				if (GDB.unlockLeavel >= 87) {
					Application.LoadLevel ("LLevel87");
				}
			}
			if (GUI.Button (new Rect (15, 2625, 100, 20), "水平 88(L)")) {
				if (GDB.unlockLeavel >= 88) {
					Application.LoadLevel ("LLevel88");
				}
			}
			if (GUI.Button (new Rect (15, 2655, 100, 20), "水平 89(M)")) {
				if (GDB.unlockLeavel >= 89) {
					Application.LoadLevel ("LLevel89");
				}
			}
			if (GUI.Button (new Rect (15, 2685, 100, 20), "水平 90(M)")) {
				if (GDB.unlockLeavel >= 90) {
					Application.LoadLevel ("LLevel90");
				}
			}
			if (GUI.Button (new Rect (15, 2715, 100, 20), "水平 91(M)")) {
				if (GDB.unlockLeavel >= 91) {
					Application.LoadLevel ("LLevel91");
				}
			}
		}



		if (GDB.unlockLeavel >= 2) {
			GUI.DrawTexture (new Rect (120, 15, 20, 20), open);
		}
		if (GDB.unlockLeavel < 2) {
			GUI.DrawTexture (new Rect (120, 45, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 3) {
			GUI.DrawTexture (new Rect (120, 45, 20, 20), open);
		}
		if (GDB.unlockLeavel < 3) {
			GUI.DrawTexture (new Rect (120, 75, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 4) {
			GUI.DrawTexture (new Rect (120, 75, 20, 20), open);
		}
		if (GDB.unlockLeavel < 4) {
			GUI.DrawTexture (new Rect (120, 105, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 5) {
			GUI.DrawTexture (new Rect (120, 105, 20, 20), open);
		}
		if (GDB.unlockLeavel < 5) {
			GUI.DrawTexture (new Rect (120, 135, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 6) {
			GUI.DrawTexture (new Rect (120, 135, 20, 20), open);
		}
		if (GDB.unlockLeavel < 6) {
			GUI.DrawTexture (new Rect (120, 165, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 7) {
			GUI.DrawTexture (new Rect (120, 165, 20, 20), open);
		}
		if (GDB.unlockLeavel < 7) {
			GUI.DrawTexture (new Rect (120, 195, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 8) {
			GUI.DrawTexture (new Rect (120, 195, 20, 20), open);
		}
		if (GDB.unlockLeavel < 8) {
			GUI.DrawTexture (new Rect (120, 225, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 9) {
			GUI.DrawTexture (new Rect (120, 225, 20, 20), open);
		}
		if (GDB.unlockLeavel < 9) {
			GUI.DrawTexture (new Rect (120, 255, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 10) {
			GUI.DrawTexture (new Rect (120, 255, 20, 20), open);
		}
		if (GDB.unlockLeavel < 10) {
			GUI.DrawTexture (new Rect (120, 285, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 11) {
			GUI.DrawTexture (new Rect (120, 285, 20, 20), open);
		}
		if (GDB.unlockLeavel < 11) {
			GUI.DrawTexture (new Rect (120, 315, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 12) {
			GUI.DrawTexture (new Rect (120, 315, 20, 20), open);
		}
		if (GDB.unlockLeavel < 12) {
			GUI.DrawTexture (new Rect (120, 345, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 13) {
			GUI.DrawTexture (new Rect (120, 345, 20, 20), open);
		}
		if (GDB.unlockLeavel < 13) {
			GUI.DrawTexture (new Rect (120, 375, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 14) {
			GUI.DrawTexture (new Rect (120, 375, 20, 20), open);
		}
		if (GDB.unlockLeavel < 14) {
			GUI.DrawTexture (new Rect (120, 405, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 15) {
			GUI.DrawTexture (new Rect (120, 405, 20, 20), open);
		}
		if (GDB.unlockLeavel < 15) {
			GUI.DrawTexture (new Rect (120, 435, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 16) {
			GUI.DrawTexture (new Rect (120, 435, 20, 20), open);
		}
		if (GDB.unlockLeavel < 16) {
			GUI.DrawTexture (new Rect (120, 465, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 17) {
			GUI.DrawTexture (new Rect (120, 465, 20, 20), open);
		}
		if (GDB.unlockLeavel < 17) {
			GUI.DrawTexture (new Rect (120, 495, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 18) {
			GUI.DrawTexture (new Rect (120, 495, 20, 20), open);
		}
		if (GDB.unlockLeavel < 18) {
			GUI.DrawTexture (new Rect (120, 525, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 19) {
			GUI.DrawTexture (new Rect (120, 525, 20, 20), open);
		}
		if (GDB.unlockLeavel < 19) {
			GUI.DrawTexture (new Rect (120, 555, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 20) {
			GUI.DrawTexture (new Rect (120, 555, 20, 20), open);
		}
		if (GDB.unlockLeavel < 20) {
			GUI.DrawTexture (new Rect (120, 585, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 21) {
			GUI.DrawTexture (new Rect (120, 585, 20, 20), open);
		}
		if (GDB.unlockLeavel < 21) {
			GUI.DrawTexture (new Rect (120, 615, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 22) {
			GUI.DrawTexture (new Rect (120, 615, 20, 20), open);
		}
		if (GDB.unlockLeavel < 22) {
			GUI.DrawTexture (new Rect (120, 645, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 23) {
			GUI.DrawTexture (new Rect (120, 645, 20, 20), open);
		}
		if (GDB.unlockLeavel < 23) {
			GUI.DrawTexture (new Rect (120, 675, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 24) {
			GUI.DrawTexture (new Rect (120, 675, 20, 20), open);
		}
		if (GDB.unlockLeavel < 24) {
			GUI.DrawTexture (new Rect (120, 705, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 25) {
			GUI.DrawTexture (new Rect (120, 705, 20, 20), open);
		}
		if (GDB.unlockLeavel < 25) {
			GUI.DrawTexture (new Rect (120, 735, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 26) {
			GUI.DrawTexture (new Rect (120, 735, 20, 20), open);
		}
		if (GDB.unlockLeavel < 26) {
			GUI.DrawTexture (new Rect (120, 765, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 27) {
			GUI.DrawTexture (new Rect (120, 765, 20, 20), open);
		}
		if (GDB.unlockLeavel < 27) {
			GUI.DrawTexture (new Rect (120, 795, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 28) {
			GUI.DrawTexture (new Rect (120, 795, 20, 20), open);
		}
		if (GDB.unlockLeavel < 28) {
			GUI.DrawTexture (new Rect (120, 825, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 29) {
			GUI.DrawTexture (new Rect (120, 825, 20, 20), open);
		}
		if (GDB.unlockLeavel < 29) {
			GUI.DrawTexture (new Rect (120, 855, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 30) {
			GUI.DrawTexture (new Rect (120, 855, 20, 20), open);
		}
		if (GDB.unlockLeavel < 30) {
			GUI.DrawTexture (new Rect (120, 885, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 31) {
			GUI.DrawTexture (new Rect (120, 885, 20, 20), open);
		}
		if (GDB.unlockLeavel < 31) {
			GUI.DrawTexture (new Rect (120, 915, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 32) {
			GUI.DrawTexture (new Rect (120, 915, 20, 20), open);
		}
		if (GDB.unlockLeavel < 32) {
			GUI.DrawTexture (new Rect (120, 945, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 33) {
			GUI.DrawTexture (new Rect (120, 945, 20, 20), open);
		}
		if (GDB.unlockLeavel < 33) {
			GUI.DrawTexture (new Rect (120, 975, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 34) {
			GUI.DrawTexture (new Rect (120, 975, 20, 20), open);
		}
		if (GDB.unlockLeavel < 34) {
			GUI.DrawTexture (new Rect (120, 1005, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 35) {
			GUI.DrawTexture (new Rect (120, 1005, 20, 20), open);
		}
		if (GDB.unlockLeavel < 35) {
			GUI.DrawTexture (new Rect (120, 1035, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 36) {
			GUI.DrawTexture (new Rect (120, 1035, 20, 20), open);
		}
		if (GDB.unlockLeavel < 36) {
			GUI.DrawTexture (new Rect (120, 1065, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 37) {
			GUI.DrawTexture (new Rect (120, 1065, 20, 20), open);
		}
		if (GDB.unlockLeavel < 37) {
			GUI.DrawTexture (new Rect (120, 1095, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 38) {
			GUI.DrawTexture (new Rect (120, 1095, 20, 20), open);
		}
		if (GDB.unlockLeavel < 38) {
			GUI.DrawTexture (new Rect (120, 1125, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 39) {
			GUI.DrawTexture (new Rect (120, 1125, 20, 20), open);
		}
		if (GDB.unlockLeavel < 39) {
			GUI.DrawTexture (new Rect (120, 1155, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 40) {
			GUI.DrawTexture (new Rect (120, 1155, 20, 20), open);
		}
		if (GDB.unlockLeavel < 40) {
			GUI.DrawTexture (new Rect (120, 1185, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 41) {
			GUI.DrawTexture (new Rect (120, 1185, 20, 20), open);
		}
		if (GDB.unlockLeavel < 41) {
			GUI.DrawTexture (new Rect (120, 1215, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 42) {
			GUI.DrawTexture (new Rect (120, 1215, 20, 20), open);
		}
		if (GDB.unlockLeavel < 42) {
			GUI.DrawTexture (new Rect (120, 1245, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 43) {
			GUI.DrawTexture (new Rect (120, 1245, 20, 20), open);
		}
		if (GDB.unlockLeavel < 43) {
			GUI.DrawTexture (new Rect (120, 1275, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 44) {
			GUI.DrawTexture (new Rect (120, 1275, 20, 20), open);
		}
		if (GDB.unlockLeavel < 44) {
			GUI.DrawTexture (new Rect (120, 1305, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 45) {
			GUI.DrawTexture (new Rect (120, 1305, 20, 20), open);
		}
		if (GDB.unlockLeavel < 45) {
			GUI.DrawTexture (new Rect (120, 1335, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 46) {
			GUI.DrawTexture (new Rect (120, 1335, 20, 20), open);
		}
		if (GDB.unlockLeavel < 46) {
			GUI.DrawTexture (new Rect (120, 1365, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 47) {
			GUI.DrawTexture (new Rect (120, 1365, 20, 20), open);
		}
		if (GDB.unlockLeavel < 47) {
			GUI.DrawTexture (new Rect (120, 1395, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 48) {
			GUI.DrawTexture (new Rect (120, 1395, 20, 20), open);
		}
		if (GDB.unlockLeavel < 48) {
			GUI.DrawTexture (new Rect (120, 1425, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 49) {
			GUI.DrawTexture (new Rect (120, 1425, 20, 20), open);
		}
		if (GDB.unlockLeavel < 49) {
			GUI.DrawTexture (new Rect (120, 1455, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 50) {
			GUI.DrawTexture (new Rect (120, 1455, 20, 20), open);
		}
		if (GDB.unlockLeavel < 50) {
			GUI.DrawTexture (new Rect (120, 1485, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 51) {
			GUI.DrawTexture (new Rect (120, 1485, 20, 20), open);
		}
		if (GDB.unlockLeavel < 51) {
			GUI.DrawTexture (new Rect (120, 1515, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 52) {
			GUI.DrawTexture (new Rect (120, 1515, 20, 20), open);
		}
		if (GDB.unlockLeavel < 52) {
			GUI.DrawTexture (new Rect (120, 1545, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 53) {
			GUI.DrawTexture (new Rect (120, 1545, 20, 20), open);
		}
		if (GDB.unlockLeavel < 53) {
			GUI.DrawTexture (new Rect (120, 1575, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 54) {
			GUI.DrawTexture (new Rect (120, 1575, 20, 20), open);
		}
		if (GDB.unlockLeavel < 54) {
			GUI.DrawTexture (new Rect (120, 1605, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 55) {
			GUI.DrawTexture (new Rect (120, 1605, 20, 20), open);
		}
		if (GDB.unlockLeavel < 55) {
			GUI.DrawTexture (new Rect (120, 1635, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 56) {
			GUI.DrawTexture (new Rect (120, 1635, 20, 20), open);
		}
		if (GDB.unlockLeavel < 56) {
			GUI.DrawTexture (new Rect (120, 1665, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 57) {
			GUI.DrawTexture (new Rect (120, 1665, 20, 20), open);
		}
		if (GDB.unlockLeavel < 57) {
			GUI.DrawTexture (new Rect (120, 1695, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 58) {
			GUI.DrawTexture (new Rect (120, 1695, 20, 20), open);
		}
		if (GDB.unlockLeavel < 58) {
			GUI.DrawTexture (new Rect (120, 1725, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 59) {
			GUI.DrawTexture (new Rect (120, 1725, 20, 20), open);
		}
		if (GDB.unlockLeavel < 59) {
			GUI.DrawTexture (new Rect (120, 1755, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 60) {
			GUI.DrawTexture (new Rect (120, 1755, 20, 20), open);
		}
		if (GDB.unlockLeavel < 60) {
			GUI.DrawTexture (new Rect (120, 1785, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 61) {
			GUI.DrawTexture (new Rect (120, 1785, 20, 20), open);
		}
		if (GDB.unlockLeavel < 61) {
			GUI.DrawTexture (new Rect (120, 1815, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 62) {
			GUI.DrawTexture (new Rect (120, 1815, 20, 20), open);
		}
		if (GDB.unlockLeavel < 62) {
			GUI.DrawTexture (new Rect (120, 1845, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 63) {
			GUI.DrawTexture (new Rect (120, 1845, 20, 20), open);
		}
		if (GDB.unlockLeavel < 63) {
			GUI.DrawTexture (new Rect (120, 1875, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 64) {
			GUI.DrawTexture (new Rect (120, 1875, 20, 20), open);
		}
		if (GDB.unlockLeavel < 64) {
			GUI.DrawTexture (new Rect (120, 1905, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 65) {
			GUI.DrawTexture (new Rect (120, 1905, 20, 20), open);
		}
		if (GDB.unlockLeavel < 65) {
			GUI.DrawTexture (new Rect (120, 1935, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 66) {
			GUI.DrawTexture (new Rect (120, 1935, 20, 20), open);
		}
		if (GDB.unlockLeavel < 66) {
			GUI.DrawTexture (new Rect (120, 1965, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 67) {
			GUI.DrawTexture (new Rect (120, 1965, 20, 20), open);
		}
		if (GDB.unlockLeavel < 67) {
			GUI.DrawTexture (new Rect (120, 1995, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 68) {
			GUI.DrawTexture (new Rect (120, 1995, 20, 20), open);
		}
		if (GDB.unlockLeavel < 68) {
			GUI.DrawTexture (new Rect (120, 2025, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 69) {
			GUI.DrawTexture (new Rect (120, 2025, 20, 20), open);
		}
		if (GDB.unlockLeavel < 69) {
			GUI.DrawTexture (new Rect (120, 2055, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 70) {
			GUI.DrawTexture (new Rect (120, 2055, 20, 20), open);
		}
		if (GDB.unlockLeavel < 70) {
			GUI.DrawTexture (new Rect (120, 2085, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 71) {
			GUI.DrawTexture (new Rect (120, 2085, 20, 20), open);
		}
		if (GDB.unlockLeavel < 71) {
			GUI.DrawTexture (new Rect (120, 2115, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 72) {
			GUI.DrawTexture (new Rect (120, 2115, 20, 20), open);
		}
		if (GDB.unlockLeavel < 72) {
			GUI.DrawTexture (new Rect (120, 2145, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 73) {
			GUI.DrawTexture (new Rect (120, 2145, 20, 20), open);
		}
		if (GDB.unlockLeavel < 73) {
			GUI.DrawTexture (new Rect (120, 2175, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 74) {
			GUI.DrawTexture (new Rect (120, 2175, 20, 20), open);
		}
		if (GDB.unlockLeavel < 74) {
			GUI.DrawTexture (new Rect (120, 2205, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 75) {
			GUI.DrawTexture (new Rect (120, 2205, 20, 20), open);
		}
		if (GDB.unlockLeavel < 75) {
			GUI.DrawTexture (new Rect (120, 2235, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 76) {
			GUI.DrawTexture (new Rect (120, 2235, 20, 20), open);
		}
		if (GDB.unlockLeavel < 76) {
			GUI.DrawTexture (new Rect (120, 2265, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 77) {
			GUI.DrawTexture (new Rect (120, 2265, 20, 20), open);
		}
		if (GDB.unlockLeavel < 77) {
			GUI.DrawTexture (new Rect (120, 2295, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 78) {
			GUI.DrawTexture (new Rect (120, 2295, 20, 20), open);
		}
		if (GDB.unlockLeavel < 78) {
			GUI.DrawTexture (new Rect (120, 2325, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 79) {
			GUI.DrawTexture (new Rect (120, 2325, 20, 20), open);
		}
		if (GDB.unlockLeavel < 79) {
			GUI.DrawTexture (new Rect (120, 2355, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 80) {
			GUI.DrawTexture (new Rect (120, 2355, 20, 20), open);
		}
		if (GDB.unlockLeavel < 80) {
			GUI.DrawTexture (new Rect (120, 2385, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 81) {
			GUI.DrawTexture (new Rect (120, 2385, 20, 20), open);
		}
		if (GDB.unlockLeavel < 81) {
			GUI.DrawTexture (new Rect (120, 2415, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 82) {
			GUI.DrawTexture (new Rect (120, 2415, 20, 20), open);
		}
		if (GDB.unlockLeavel < 82) {
			GUI.DrawTexture (new Rect (120, 2445, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 83) {
			GUI.DrawTexture (new Rect (120, 2445, 20, 20), open);
		}
		if (GDB.unlockLeavel < 83) {
			GUI.DrawTexture (new Rect (120, 2475, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 84) {
			GUI.DrawTexture (new Rect (120, 2475, 20, 20), open);
		}
		if (GDB.unlockLeavel < 84) {
			GUI.DrawTexture (new Rect (120, 2505, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 85) {
			GUI.DrawTexture (new Rect (120, 2505, 20, 20), open);
		}
		if (GDB.unlockLeavel < 85) {
			GUI.DrawTexture (new Rect (120, 2535, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 86) {
			GUI.DrawTexture (new Rect (120, 2535, 20, 20), open);
		}
		if (GDB.unlockLeavel < 86) {
			GUI.DrawTexture (new Rect (120, 2565, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 87) {
			GUI.DrawTexture (new Rect (120, 2565, 20, 20), open);
		}
		if (GDB.unlockLeavel < 87) {
			GUI.DrawTexture (new Rect (120, 2595, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 88) {
			GUI.DrawTexture (new Rect (120, 2595, 20, 20), open);
		}
		if (GDB.unlockLeavel < 88) {
			GUI.DrawTexture (new Rect (120, 2625, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 89) {
			GUI.DrawTexture (new Rect (120, 2625, 20, 20), open);
		}
		if (GDB.unlockLeavel < 89) {
			GUI.DrawTexture (new Rect (120, 2655, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 90) {
			GUI.DrawTexture (new Rect (120, 2655, 20, 20), open);
		}
		if (GDB.unlockLeavel < 90) {
			GUI.DrawTexture (new Rect (120, 2685, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 91) {
			GUI.DrawTexture (new Rect (120, 2685, 20, 20), open);
		}
		if (GDB.unlockLeavel < 91) {
			GUI.DrawTexture (new Rect (120, 2715, 20, 20), closed);
		}
		if (GDB.unlockLeavel >= 92) {
			GUI.DrawTexture (new Rect (120, 2715, 20, 20), open);
		}






		GUI.EndScrollView();

	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
