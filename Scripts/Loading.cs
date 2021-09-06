using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	private AsyncOperation async = null; 
	private bool isLoading = false; 
	public string levelName = ""; 
	public Texture backgroundBar; 
	public Texture lineBar; 
	public Texture GUITextureBackground; 

	private int number;
	
	private IEnumerator _Start(){ 
		Debug.Log( "Loading... " ); 
		async = Application.LoadLevelAsync( levelName ); 
		while( !async.isDone ){ 
			Debug.Log( string.Format( "Loading {0}%", async.progress*100 ) ); 
			yield return null; 
		} 
		Debug.Log( "Loading complete" ); 
		isLoading = false; 
		yield return async; 
	} 

	void Start () {

		number = Random.Range (1, 26);
	}
	




	private void OnGUI(){ 




		if(GUITextureBackground != null) 
		
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), GUITextureBackground); 


		if( !isLoading ){ 

			///rus
			if (MenuScript.lang == 1) {
			GUI.Label(new Rect( (Screen.width / 2)-135, (Screen.height / 2) + (Screen.height / 3), 512, 30),"НАЖМИТЕ ПРОБЕЛ (КОСНИТЕСЬ ЭКРАНА)"); 

			if (number == 1) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: твердые структурные строения не могут быть сдвинуты с места ни игроком, ни врагами. При этом снаряды приведений могут пролететь сквозь них, а снаряды игрока не могут.");
			}
			if (number == 2) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: пузыри могут передвигать и игроки, и враги. При этом снаряды призраков не могут пролететь сквозь пузырь. Зато снаряды игрока легко пролетают через пузыри.");
			}
			if (number == 3) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: заработанные на уровне монеты, рубины и очки убитых врагов зачисляются в общую копилку вне зависимости от того пройден ли уровень, не пройден, либо прерван.");
			}
			if (number == 4) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: легендарных персонажей всего 3 в игре. Чтобы их заполучить придется изрядно потрудиться. Каждый из таких персонажей способен выжить на любом уровне.");
			}
			if (number == 5) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Информация: единственный создатель данной игры - Знак Александр Сергеевич.");
			}
			if (number == 6) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Информация: в игре использован уникальный метод под названием FullRandom. Шанс на прохождение полностью идентичного уровня составляет не боле 0,000001%.");
			}
			if (number == 7) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Информация: в игре используется уникальная мощнейшая система искусственного интеллекта. Не исключено, что привидения из игры скоро захватят мир =)");
			}
			if (number == 8) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: выход игрока за пределы экрана камеры (за пределы ринга сражения) беспощадно мгновенно уничтожит игрока, как труса сбежавшего с поля боя.");
			}
			if (number == 9) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: прохождение того или иного уровня будет намного легче, если у вас будет в наличии персонаж, способности которого соответствуют обстановке в уровне.");
			}
			if (number == 10) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: все персонажи с пометкой (2) могут быть приобретены только после покупки основного персонажа с тем же именем.");
			}
			if (number == 11) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: не жалейте денег на покупку улучшенного персонажа. Улучшенный персонаж более эффективен, чем даже сильный стандартный персонаж.");
			}
			if (number == 12) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: специальные смайлики существуют в единственном варианте. Как правило, они отличается оригинальной способностью, которой не обладают другие.");
			}
			if (number == 13) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: коллекционные смайлики не отличаются выдающимися способностями. Как правило, имеют уникальное оружие и существуют для коллекционирования.");
			}
			if (number == 14) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: старайтесь преследовать одного врага, т.к. если он сможет убежать за пределы ринга сражения, на его месте появится новый враг с полным здоровьем.");
			}
			if (number == 15) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: буквы на кнопках уровня обозначают его размер, т.е. масштаб физического пространства на уровне. S - маленький, M - средний и L - большой.");
			}
			if (number == 16) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: комментарии к уровню - это количество объектов на уровне одновременно, кроме силы (максимально возможный урон от врага за одно попадание).");
			}
			if (number == 17) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: если Вы решите вернуться к прохождению уровня, который уже прошли, то все пройденные уровни после этого снова станут заблокированы.");
			}
			if (number == 18) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: старайтесь передвигаться по всему уровню. Так у Вас больше шансов найти рубины, а также больше аптечек (каждая добавит +4 к текущему здоровью).");
			}
			if (number == 19) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: отнимать здоровье у персонажа могут только выстрелы врагов. Все другие столкновения влияют только на вашу ориентацию на уровне.");
			}
			if (number == 20) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: в сражениях с боссами за пределы ринга (края экрана) ни Вам, ни врагам убежать не удасться (покончить с собой также не получится).");
			}
			if (number == 21) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: если Вам не хватает монет или рубинов на новую покупку - сражайтесь с боссами, за победу над которыми дают валюту в качестве награды.");
			}
			if (number == 22) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: если Вас не устраивает скорость Вашего персонажа - ищите зеленое зелье на уровнях. Оно значительно ускорит смайлик на некоторое время.");
			}
			if (number == 23) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Подсказка: здоровье вашего персонажа останется не тронутым, пока у него есть броня! Очки брони отнимаются при попадании в персонажа врагами. Можно пополнять бонусами броми на уровне");
			}
			if (number == 24) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Изумруды - уникальная валюта, которую вы можете обменять на любую другую валюту в магазине (вход со страницы выбора персонажа). Даются за активность в игре, получаемую за сбор бонусов");
			}
			if (number == 25) {
				GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Сапфиры: за каждый новый уровень игрока вы получаете 10 сапфиров, за которые можно улучшать урон, здоровье, скорость и броню сразу у ВСЕХ персонажей (вход со страницы выбора уровней)");
			}

			}

			///eng
			if (MenuScript.lang == 2) {
				GUI.Label(new Rect( (Screen.width / 2)-135, (Screen.height / 2) + (Screen.height / 3), 512, 30),"PRESS THE SPACEBAR (TAP THE SCREEN)"); 
				
				if (number == 1) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: solid structural construction cannot be placed with neither player nor enemies. The shells of ghosts can fly through them, and the shells of the player can't.");
				}
				if (number == 2) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: bubbles can move players and enemies. The shells of ghosts can't pass through the bubble. But the shells of the player easily fly through the bubbles.");
				}
				if (number == 3) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: earned coins, rubies and points of killed enemies are credited to the General piggy Bank regardless of whether the level is passed, not passed, or interrupted.");
				}
				if (number == 4) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Hint: legendary characters are only 3 in the game. To get them will have to work hard. Each of these characters is able to survive at any level.");
				}
				if (number == 5) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Information: the only Creator of this game - Alex Znak.");
				}
				if (number == 6) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Information: the game uses a unique method called FullRandom. The chance to pass completely identical level is not more than 0.000001%.");
				}
				if (number == 7) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Information: the game uses a unique powerful system of artificial intelligence. It is possible that the ghosts of the game will soon capture the world =)");
				}
				if (number == 8) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Hint: the output of the player outside the screen of the camera (outside the ring of battle) mercilessly instantly destroy the player as the coward fled from the battlefield.");
				}
				if (number == 9) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Hint: the passage of a level will be much easier if you have a character whose abilities match the situation in the level.");
				}
				if (number == 10) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Hint: all characters marked (2) can only be purchased after purchasing the main character of the same name.");
				}
				if (number == 11) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: do not spare money to buy an improved character. An improved character is more effective than even a strong standard character.");
				}
				if (number == 12) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: special emoticons exist in a single version. They usually has an original ability that others do not possess.");
				}
				if (number == 13) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: collectible emoticons do not have outstanding abilities. As a rule, have unique weapons and are there for collecting.");
				}
				if (number == 14) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: try to chase one enemy, because if he will be able to escape outside the ring of battle, in its place will appear a new enemy with full health.");
				}
				if (number == 15) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: the letters on the level buttons indicate its size, i.e. the scale of the physical space at the level. S-small, M-medium and L - large.");
				}
				if (number == 16) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: comments on a level are the number of objects on the level at the same time, except for the strength (maximum possible damage from the enemy for one hit).");
				}
				if (number == 17) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: if you decide to return to the passage of the level that has already passed, then all passed levels will be blocked again.");
				}
				if (number == 18) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: try to move around the level. So You have more chance find rubies, and also more first aid kits (each will add +4 to current health).");
				}
				if (number == 19) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: take away the health of the character can only shoot enemies. All other collisions only affect your level orientation.");
				}
				if (number == 20) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: in the battles with the bosses outside the ring (the edge of the screen) neither You nor the enemy can not escape (kill yourself also will not work).");
				}
				if (number == 21) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: if you do not have enough coins or rubies for a new purchase - fight with the bosses, for the victory over which the currency is given as a reward.");
				}
				if (number == 22) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: if you are not satisfied with the speed of your character - look for the green potion on the levels. It will greatly speed up the smiley face for a while.");
				}
				if (number == 23) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Tip: your character’s health will remain untouched as long as he has armor! Points of armor are taken away when enemies enter the character. You can replenish armor bonuses at the level of");
				}
				if (number == 24) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Emeralds are a unique currency that you can exchange for any other currency in the store (entrance from the character selection page). Given for activity in the game, obtained for the collection of bonuses");
				}
				if (number == 25) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "Sapphires: for each new player level you get 10 sapphires, for which you can improve the damage, health, speed and armor at once from ALL characters (entrance from the level selection page)");
				}

			}

			///chi
			if (MenuScript.lang == 3) {
				GUI.Label(new Rect( (Screen.width / 2)-135, (Screen.height / 2) + (Screen.height / 3), 512, 30),"                   祝你好运(击屏幕)"); 
				
				if (number == 1) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：固建筑结构不能被置于与没有玩家也不是敌人。 炮弹的鬼魂可以飞行通过它们，和炮弹的玩家不可能的。");
				}
				if (number == 2) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：气泡可以移动者和敌人。 炮弹的鬼不能通过在泡沫。 但炮弹的放轻松通过的气泡。");
				}
				if (number == 3) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：获得级别的硬币和宝石点杀死敌人被记入普通基金，无论它是否传递的水平，失败，或中止。");
				}
				if (number == 4) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：传说中的人物只有3个在游戏中。 让他们将必须努力工作。 每个人物可以存在任何级别。");
				}
				if (number == 5) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "信息:唯一的创造者这个游戏-迹象亚历山大。");
				}
				if (number == 6) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "信息:游戏中使用的唯一方法称为FullRandom的。 机会的完全相同的通道水平的不是更多的0,000001%以上。");
				}
				if (number == 7) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "信息:一个强大的独特的人工智能系统。 这可能是鬼魂从游戏很快就会接管全世界=)");
				}
				if (number == 8) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：输出的播放器以外的屏幕上的摄像机(外环的战斗)立即无情地摧毁播放的懦夫逃离了战场。");
				}
				if (number == 9) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：通过一个级别就会容易得多，如果你有一个可用的字符，能力，这对应于情况的水平。");
				}
				if (number == 10) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：所有的人物标记(2)仅可购买之后，购买的主要角色，同名称。");
				}
				if (number == 11) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：没有备用钱购买的优越性。 提高字符的更为有效，甚至比强烈的标准字符。");
				}
				if (number == 12) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：特别笑脸那是一个选项。 他们通常有一个原始的能力，其他人不具备的。");
				}
				if (number == 13) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：收藏家的表情没有什么不同的非凡能力。 作为一项规则，具有独特的武器和有收集。");
				}
				if (number == 14) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：尝试追逐一个敌人，因为如果他能逃脱以外的环的战斗中，在它的地方会出现一个新的敌人有充分的健康。");
				}
				if (number == 15) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：上的字母按级别分别表示其大小，即规模的物理空间的水平。 S-小，M-媒体和L-大。");
				}
				if (number == 16) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：评论意见级的对象的数量的水平的同时，但该力量(尽可能最大破坏的敌人一击的)。");
				}
				if (number == 17) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：如果你决定回来的通道水平，它已经通过了所有的水平之后，将会再次被阻止。");
				}
				if (number == 18) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：尽量移动的水平。 让你有更多的机会找到红宝石，以及更多的工具包(每增加了+4到目前的健康)。");
				}
				if (number == 19) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：减去从健康的角色可以只开枪。 所有其他冲突只影响了你的态度的水平。");
				}
				if (number == 20) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：老板的战斗以外的环(边的屏幕)无论是你还是敌人逃跑就不会取得成功(以自杀也不工作)。");
				}
				if (number == 21) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：如果没有足够的硬币或红宝石来购买新的老板，战胜这给货币作为奖励。");
				}
				if (number == 22) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：如果你不满意的速度你的角色-寻找绿色的药水上的水平。 这将加快的笑脸。");
				}
				if (number == 23) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "提示：只要他有盔甲，你的角色的健康就会保持不变！当敌人进入角色时，装甲点被带走。你可以在水平上补充溴奖金");
				}
				if (number == 24) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "祖母绿是一种独特的货币，您可以在商店中换取任何其他货币（从角色选择页面进入）。鉴于游戏中的活动，获得奖金的收集");
				}
				if (number == 25) {
					GUI.Label(new Rect( (Screen.width / 2)-300, (Screen.height / 2) + (Screen.height / 2)-170, 600, 50), "蓝宝石：对于每个新的玩家等级，你获得10颗蓝宝石，你可以从所有角色（从等级选择页面进入）一次性提高伤害，健康，速度和护甲");
				}
			}


			if (Input.touchCount>0)
			{ 
				isLoading = true; 
				StartCoroutine("_Start"); 
			} 



			if(Input.GetKeyDown(KeyCode.Space)){ 
				isLoading = true; 
				StartCoroutine("_Start"); 
			} 


		} else{ 
			GUI.Label(new Rect( (Screen.width / 2) -50, (Screen.height / 2) + (Screen.height / 3)-20, 512, 30),"L O A D I N G . . . ."); 
			GUI.DrawTexture( new Rect( (Screen.width / 2) -300, (Screen.height / 2) + (Screen.height / 3), 600, 20 ), backgroundBar, ScaleMode.StretchToFill, true, 1F); 
			GUI.DrawTexture( new Rect( (Screen.width / 2) -300, (Screen.height / 2) + (Screen.height / 3), async.progress*600, 20 ), lineBar, ScaleMode.StretchToFill, true, 1F); 
		} 
	} 
}
