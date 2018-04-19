using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage: Character {
	
	protected float magicPower;

	public Mage () {
		className = "Mage";
		magicPower = 10f;
		totalMp = totalMp * 2;
	}

	public float MagicPower { get; set; }
}

