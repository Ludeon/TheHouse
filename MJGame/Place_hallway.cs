using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	class Place_hallway : Place
	{
		protected override string GetIntroText()
		{
			return " this part of the game is not finished yet. now go back and marvel at the fact that the game knows that the dog is dead or not!!!!";
		}

		public override bool HandleInput_Place(string inp)
		{
			return false;
		}

		
	}
	
}
