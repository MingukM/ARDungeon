using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMage: Mage {

	protected float darkMagick;

	public DarkMage () {
		className = "DarkMage";
		darkMagick = 5f;
		magicPower = darkMagick * 1.5f  + magicPower ;
	}

	public float DarkMagic { get; set; }
}
