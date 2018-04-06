using System;

namespace AssemblyCSharp
{
	public class Berserker: Warrior
	{
		private bool isBerserk;

		public Berserker ()
		{
			isBerserk = true;
		}

		int berserk(bool ib){
			if (ib) {
				pow = pow * 2;
				dex = dex / 2;
				def = def / 2;
			}
		}
	}
}

