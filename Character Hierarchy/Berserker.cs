using System;

namespace AssemblyCSharp
{
	public class Berserker: Warrior
	{
		public Berserker (){
			className = "Berserker";
		}

		void Berserk(bool ib){
			if (ib) {
				power = power * 2;
				dexterity = dexterity / 2;
				defense = defense / 2;
			}
		}
	}
}

