using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight: Warrior {

	protected int swordProficiency;

	public Knight (){
		className = "Knight";
		swordProficiency = 5;
	}

	public int SwordProficiency{ get; set;}
}

