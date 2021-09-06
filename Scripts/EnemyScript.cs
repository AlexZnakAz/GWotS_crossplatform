using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private WeaponScriptEnemy[] weapons;

	void Awake ()
	{

		weapons = GetComponentsInChildren <WeaponScriptEnemy> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (WeaponScriptEnemy weapon in weapons) {
	
			if (weapon != null && weapon.CanAttack) {
				weapon.Attack (true);
			}
		}
	}
}
