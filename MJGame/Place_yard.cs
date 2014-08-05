using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	class Place_yard : Place
	 {
		public Place_yard()
		{
			introText= "A collection of cement dinosaurs stare balefully back at you from the yard.\n\nThey terrify you.";
		}
		
		
		public override bool HandleInput_Place(string inp)
		{
			
			if (inp == "go back to the front door" || inp == " go back")
			{
			Program.frontHouse.Arrived();
			return true;
			}

			else if (inp == "explore yard" || inp == "climb dinosaurs")
			{
				Console.WriteLine("You are too terrified to get past the dinosaurs.");
			}
			return false;
		}
	 }
}
