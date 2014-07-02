using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	abstract class Place
	{
		protected string introText;


		protected abstract void HandleInput(string inp);

		public void Arrived()
		{
			Console.Clear();
			Console.WriteLine(introText);
			
			string inp;
			inp = Program.GetInput();
			
			HandleInput( inp );
		}

		


	}


	class Place_frontHouse : Place
	{
		public Place_frontHouse()
		{
			introText= "You are standing in front of a rural house. It is ramshackle and shitty-looking.";
		}

		protected override void HandleInput(string inp)
		{
			
			if (inp == "open door" || inp == "open" || inp == "go in")
			{
				//PAGE 3a
				Console.Clear();
				Console.WriteLine("A large dog is sitting in the entrance. He looks at you and says, \"What do you want, fucka?\"");

				string inp3a = Program.GetInput();

				if (inp3a == "greet kindly" || inp3a == "say hello")
				{ Console.WriteLine(" Get out of my house you ape!");

				}
				else if (inp3a == "give biscuit")
				{//PAGE 4
				Console.Clear();
				Console.WriteLine(" The dog catches the buiscuit you tossed him, munches quietly and promptly dies on the carpet. \n You proceed down the hall.");
				}
			
			}
			if (inp == "go to the yard")
			{
				//PAGE 3b
				Console.Clear();
				Console.WriteLine("A collection of cement dinosaurs stare balefully back at you from the yard.\n\nThey terrify you. You decide to enter the house.");
				Console.ReadKey();
				Arrived();
			}
		}
	}


}
