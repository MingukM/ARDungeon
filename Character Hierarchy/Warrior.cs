using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior: Character
{
	protected int swordProficiency;

	public Warrior (){
		className = "Warrior";
		swordProficiency = 10;
	}

	int SwordProficiency{
		get{ return swordProficiency; }
		set{ swordProficiency = value; }
	}
}

