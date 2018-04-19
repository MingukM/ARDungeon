  using System;

public class Berserker: Warrior
{
	private float berserk = 10;

	public Berserker (){
		className = "Berserker";

		totalHp = totalHp + 200;
		totalMp = totalMp - 200;

		power = power * ( 1 + berserk / 10);
		defense = defense / ( 1 + berserk / 10);
		dexterity = dexterity / ( 1 + berserk / 10);
		intelligence = berserk / 3;
	}
}

