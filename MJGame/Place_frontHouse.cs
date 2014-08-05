using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	class Place_frontHouse : Place
	{
		public Place_frontHouse()
		{
			introText= "You are standing in front of a shitty-looking rural house.";
		
			groundItems.Add(new Item("anal lubricant"));
			groundItems.Add(new Item("peanut butter"));
			groundItems.Add(new Item("riding crop"));
			groundItems.Add(new Item("small kitten"));
		}

		public override bool HandleInput_Place(string inp)
		{
			
			if (inp == "open door" || inp == "open" || inp == "go in")
			{
				Program.foyer.Arrived();
				return true;
			}

			if (inp == "go to the yard")
			{
				Program.yard.Arrived();
				return true;
			}

			return false;
		}
		
	}
}
