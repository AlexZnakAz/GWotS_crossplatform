using UnityEngine;
using System.Collections;

public class Staff : MonoBehaviour {


	public Texture2D ghost;

	public Texture2D elixir;
	public Texture2D medic;
	public Texture2D star;
	public Texture2D arm;

	public Texture2D coin;
	public Texture2D ruby;

	public Texture2D back;

	public float originalWidth = 1000.0f; 
	public float originalHeight = 665.0f; 
	Vector3 scale; 




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


		///rus
		if (MenuScript.lang == 1) {
			GUI.DrawTexture (new Rect (110, 50, 70, 40), ghost);
			GUI.Label (new Rect (200, 50, 600, 40), " - отображение текущего количества убитых вами врагов на уровне (в процессе прохождения уровня), а также отображение общего количества врагов (очков) в меню.", GUI.skin.label);

			GUI.Label (new Rect (125, 100, 70, 20), "ВСЕГО", GUI.skin.label);
			GUI.Label (new Rect (200, 100, 600, 40), " - отображение общего количества убитых врагов (очков) в процессе прохождения уровня (не обновляется в процессе прохождения уровня).", GUI.skin.label);

			GUI.Label (new Rect (125, 150, 70, 20), "НУЖНО", GUI.skin.label);
			GUI.Label (new Rect (200, 150, 600, 40), " - отображения количества врагов, которые необходимо убить для того, что бы уровень считался пройденным (в процессе прохождения).", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 200, 50, 50), coin);
			GUI.Label (new Rect (200, 200, 600, 40), " - отображение количества собранных монет (наиболее частая валюта) в режиме реального времени в процессе игры на уровнях и в меню.", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 270, 50, 50), ruby);
			GUI.Label (new Rect (200, 270, 600, 40), " - отображение количества собранных рубинов (редкая валюта) в режиме реального времени в процессе игры на уровнях и в меню.", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 340, 50, 50), medic);
			GUI.Label (new Rect (200, 340, 600, 40), " - бонус, иногда появляющийся в процессе прохождения уровня, который добавляет незначительное количество здоровья. Суммируется и независит от максимального здоровья.", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 410, 50, 50), star);
			GUI.Label (new Rect (200, 410, 600, 40), " - бонус, иногда появляющийся в процессе прохождения уровня, который добавляет некоторое количество опыта (опыт отображен в процентном выражении в процессе уровня).", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 480, 50, 50), elixir);
			GUI.Label (new Rect (200, 480, 600, 40), " - бонус, иногда появляющийся в процессе прохождения уровня, который значительно увеличивает скорость персонажа на протяжении некоторого времени.", GUI.skin.label);

			GUI.DrawTexture (new Rect (120, 550, 50, 50), arm);
			GUI.Label (new Rect (200, 550, 600, 40), " - бонус брони. Если у Вас есть броня, когда в Вас попадают враги, сначала вычитаются очки брони, только затем здоровье. Броня имеет накопительный эффект.", GUI.skin.label);

			if (GUI.Button (new Rect (400, 600, 200, 50), "Назад")) {
				Application.LoadLevel ("Menu");
			}
		}


		///eng
		if (MenuScript.lang == 2) {
			GUI.DrawTexture (new Rect (110, 50, 70, 40), ghost);
			GUI.Label (new Rect (200, 50, 600, 40), " - displays the current number of enemies you kill at the level (as you progress through the level), and displays the total number of enemies (points) in the menu.", GUI.skin.label);
			
			GUI.Label (new Rect (125, 100, 70, 20), "TOTAL", GUI.skin.label);
			GUI.Label (new Rect (200, 100, 600, 40), " - displays the total number of enemies killed (points) during the passage of the level (not updated during the passage of the level).", GUI.skin.label);
			
			GUI.Label (new Rect (125, 150, 70, 20), "NEED", GUI.skin.label);
			GUI.Label (new Rect (200, 150, 600, 40), " - display the number of enemies that must be killed in order for the level to be considered passed (in the process of passing).", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 200, 50, 50), coin);
			GUI.Label (new Rect (200, 200, 600, 40), " - display the number of coins collected (the most frequent currency) in real time during the game at the levels and in the menu.", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 270, 50, 50), ruby);
			GUI.Label (new Rect (200, 270, 600, 40), " - display the number of collected rubies (rare currency) in real time during the game at the levels and in the menu.", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 340, 50, 50), medic);
			GUI.Label (new Rect (200, 340, 600, 40), " - bonus, sometimes appearing in the process of passing a level that adds a small amount of health. It is summarized and independent from the maximum health.", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 410, 50, 50), star);
			GUI.Label (new Rect (200, 410, 600, 40), " - bonus, sometimes appearing in the process of passing the level, which adds a certain amount of experience (experience is displayed in percentage terms in the process of the level).", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 480, 50, 50), elixir);
			GUI.Label (new Rect (200, 480, 600, 40), " - bonus, sometimes appearing in the process of passing the level, which significantly increases the speed of the character for some time.", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 550, 50, 50), arm);
			GUI.Label (new Rect (200, 550, 600, 40), " - bonus armor. If you have armor when enemies hit you, the armor points are deducted first, only then health. Armor has a cumulative effect.", GUI.skin.label);
			
			if (GUI.Button (new Rect (400, 600, 200, 50), "Back")) {
				Application.LoadLevel ("Menu");
			}
		}

		///CHI
		if (MenuScript.lang == 3) {
			GUI.DrawTexture (new Rect (110, 50, 70, 40), ghost);
			GUI.Label (new Rect (200, 50, 600, 40), " - 显示当前数目的被杀害敌人的水平上(在通过一级)，并且还显示总的敌人数量(磅)在菜单中。", GUI.skin.label);
			
			GUI.Label (new Rect (125, 100, 70, 20), "只是", GUI.skin.label);
			GUI.Label (new Rect (200, 100, 600, 40), " - 显示总量的敌人打死(分)的过程中传递的水平(不更新进程的通过水平)。", GUI.skin.label);
			
			GUI.Label (new Rect (125, 150, 70, 20), "需要", GUI.skin.label);
			GUI.Label (new Rect (200, 150, 600, 40), " - 显示数量的敌人，你必须杀死在了这一水平被认为是已经完成(通过的)。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 200, 50, 50), coin);
			GUI.Label (new Rect (200, 200, 600, 40), " - 显示数字的收集硬币(最常见的货币)的实时在游戏的菜单。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 270, 50, 50), ruby);
			GUI.Label (new Rect (200, 270, 600, 40), " - 显示数字的收集红宝石(罕见的货币)的实时在游戏的菜单。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 340, 50, 50), medic);
			GUI.Label (new Rect (200, 340, 600, 40), " - 奖励，有时出现在通过的水平，从而增加微量的健康。 累积和独立的最高健康。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 410, 50, 50), star);
			GUI.Label (new Rect (200, 410, 600, 40), " - 奖励，有时出现在通过的水平，这将增加一定量的经验(经验显示作为一个百分比在过程)。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 480, 50, 50), elixir);
			GUI.Label (new Rect (200, 480, 600, 40), " - 奖励，有时出现在通过一定水平，大大增加速度的角色对于一些时间。", GUI.skin.label);
			
			GUI.DrawTexture (new Rect (120, 550, 50, 50), arm);
			GUI.Label (new Rect (200, 550, 600, 40), " - 奖金的铠甲。 如果你有盔甲的时候你进入敌人的第一点中扣除的盔甲然后健康。 盔甲有一个累积效应。", GUI.skin.label);
			
			if (GUI.Button (new Rect (400, 600, 200, 50), "前")) {
				Application.LoadLevel ("Menu");
			}
		}

	}


}