using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Magician: Character
{
	protected int magicAffinity;
	protected int mPow;

	public Magician ()
	{
		className = "Mage";
		magicAffinity = 10;
		mPow = 10;
	}
}

