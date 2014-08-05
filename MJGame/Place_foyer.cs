using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	class Place_foyer : Place
	{ 
		bool dogDead = false;

		
		protected override string GetIntroText()
		{
			if (dogDead == false )
			{
			return "A large dog is sitting in the entrance. He looks at you and says, \"What do you want, fucka?\"";
			}

			else //if (dogDead == true )
			{
			return "Flies lazily buzz around the dea dog carcass. You think to yourself, \"Good riddance asshole!\"";
			}
		}
		public override bool HandleInput_Place(string inp)
		{
			if (dogDead == false)
			{
				if (inp == "greet kindly" || inp == "say hello")
				{
					Console.WriteLine(" Get out of my house you ape!");
					return true;
				}
				else if (inp == "go down hall" || inp == "jump over dog")
				{
					Console.WriteLine("The dog briskly jumps in front of you and blocks your way");
					return true;
				}
				else if (inp == "go outside")
				{
					Program.frontHouse.Arrived();
					return true;
				}
				else if (inp == "give biscuit")
				{

					Console.Clear();
					Console.WriteLine(" The dog catches the buiscuit you tossed him, munches quietly and promptly dies on the carpet.");
					dogDead = true;

					return true;

				}
			}
			else //if (dogDead == true) 
			{
				if (inp == "go down hall" || inp == "jump over dog")
				{
					Program.hallway.Arrived();
					return true;
				}
					
				else if (inp == "go outside")
				{
					Program.frontHouse.Arrived();
					return true;
				}
			}
			return false;
		}
	}
}
