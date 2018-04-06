using System;

namespace AssemblyCSharp
{
	public class Character
	{
		// variables for character level
		protected int lvl;
		protected int exp;

		// variables for character health point
		protected int totalHp;
		protected int currentHp;

		// variables for character magic point
		protected int totalMp;
		protected int currentMp;

		// variables for character parameter
		protected int pow;
		protected int def;
		protected int intell;
		protected int dex;
		protected int luc;

		// constructor
		public Character ()
		{
			lvl = 1;
			exp = 0;

			totalHp = 100;
			currentHp = totalHp;

			totalHp = 100;
			currentMp = totalMp;

			pow = 0;
			intell = 0;
			dex = 0;
			luc = 0;

		}

		// getter for total hp of character
		int getTotalHp(){
			return totalHp;
		}

		// getter for total mp of character
		int getTotalMp(){
			return totalMp;
		}

		// getter and setter for current hp of character
		void setCurrentHp(int hp){

			currentHp = hp;
		}

		int getCurrentHp(){
			return currentHp;
		}

		// getter and setter for current mp of character
		void setCurrentMp(int mp){
			currentMp = mp;
		}

		int getCurrentMp(){
			return currentMp;
		}
	}
}

