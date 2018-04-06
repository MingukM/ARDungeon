using System;

namespace AssemblyCSharp
{
	public class Magician: Character
	{
		protected int magicAffinity;

		public Magician ()
		{
			magicAffinity = 10;
			totalMp = totalMp + 10;
			intell = intell + 5;
			pow = pow - 5;
		}
	}
}

