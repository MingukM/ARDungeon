using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
	protected string characterName;
	protected string className;

	protected int characterLvl;
	protected float exp;

	// variables for character health point
	protected float totalHp;
	protected float currentHp;

	// variables for character magic point
	protected float totalMp;
	protected float currentMp;

	// variables for character parameter
	protected float power;
	protected float defense;
	protected float intelligence;
	protected float dexterity;
	protected float luck;

	public Character() {
		
		className = "Novice";
		characterLvl = 1;
		exp = 0;

		totalHp = 100;
		currentHp = totalHp;

		totalMp = 100;
		currentMp = totalMp;

		power = 3;
		defense = 2;
		intelligence = 3;
		dexterity = 2;
		luck = 3;
	}

	public string ClassName { get; set; }

	public int CharacterLvl { get; set; }

	public float Exp { get; set; }

	// getter and setter for total hp of character
	public float TotalHp { get; set; }

	// getter and setter for total mp of character
	public float TotalMp { get; set; }

	// getter and setter for current hp of character
	public float CurrentHp{ get; set;}

	// getter and setter for current mp of character
	public float CurrentMp{ get; set; }

	// getter and setter for power
	public float Power { get; set; }

	// getter and setter for defense
	public float Defense { get; set; }

	// getter and setter for intelligence
	public float Intelligence { get; set; }

	// getter and setter for dexterity
	public float Dexterity { get; set; }

	// getter and setter for luck
	public float Luck { get; set; }
}