using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

	protected string className;

	protected int characterLvl;
	protected int exp;

	// variables for character health point
	protected int totalHp;
	protected int currentHp;

	// variables for character magic point
	protected int totalMp;
	protected int currentMp;

	// variables for character parameter
	protected int power;
	protected int defense;
	protected int intelligence;
	protected int dexterity;
	protected int luck;

	// constructor
	public Character ()
	{
		className = "Novice";

		totalHp = 100;
		currentHp = totalHp;
	
		totalHp = 100;
		currentMp = totalMp;

	}

	// getter for total hp of character
	int TotalHp(){
		return totalHp;
	}

	// getter for total mp of character
	int TotalMp(){
		return totalMp;
	}

	// getter and setter for current hp of character
	int CurrentHp{
		get{return currentHp;}
		set{currentHp = value;}
	}

	// getter and setter for current mp of character
	int CurrentMp{
		get{ return currentMp; }
		set{ currentMp = value; } 
	}

	// getter and setter for power
	int Power {
		get{ return power; }
		set{ power = value; }
	}

	// getter and setter for defense
	int Defense {
		get{ return defense; }
		set{ defense = value; }
	}

	// getter and setter for intelligence
	int Intelligence {
		get{ return intelligence; }
		set{ intelligence = value; }
	}

	// getter and setter for dexterity
	int Dexterity {
		get{ return dexterity; }
		set{ dexterity = value; }
	}

	// getter and setter for luck
	int Luck {
		get{ return luck; }
		set{ luck = value; }
	}
}


