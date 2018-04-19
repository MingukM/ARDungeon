using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight: Warrior {

	protected int swordProficiency;

	public Knight (){
		className = "Knight";
		swordProficiency = 5;
		power = power * (1 + swordProficiency / 10);
		dexterity = dexterity * (1 + swordProficiency / 20);
	}

	public int SwordProficiency{ get; set;}
}

