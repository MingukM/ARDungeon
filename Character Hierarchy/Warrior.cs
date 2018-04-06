using System;

namespace AssemblyCSharp
{
	public class Warrior: Character
	{
		protected int swordProficiency;

		public Warrior ()
		{
			swordProficiency = 10;

			pow = pow + 10;
			dex = dex - 5;
		}

		int getSwordProficiency(){
			return swordProficiency;
		}

		void setSwordProficiency(int sp){
			swordProficiency = sp;
		}


	}
}

