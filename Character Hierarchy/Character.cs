using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
	protected string characterName;
	protected string className;

	protected int characterLvl;
	protected float exp;

	public Character() {
		
		className = "Novice";
		characterLvl = 1;
		exp = 0;
	}

	public string ClassName { get; set; }

	public int CharacterLvl { get; set; }

	public float Exp { get; set; }
}