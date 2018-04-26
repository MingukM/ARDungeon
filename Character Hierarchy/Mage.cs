using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage: Character {
	
	protected float magicPower;

	public Mage () {
		className = "Mage";
		magicPower = 10f;
	}

	public float MagicPower { get; set; }
}

