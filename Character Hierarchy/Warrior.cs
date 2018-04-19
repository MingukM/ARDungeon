using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior: Character {
	
	protected float swordFighting;

	public Warrior (){
		className = "Warrior";
		swordFighting = 10f;
	}

	public float SwordFighting{ get; set;}
}

