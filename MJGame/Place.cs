using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	abstract class Place
	{
		//Vars
		protected string introText;
		public List<Item> groundItems = new List<Item>();

		//Methods
		public void Arrived()
		{
			Program.curPlace = this;

			Console.Clear();
			Console.WriteLine( GetIntroText() );
			Console.WriteLine("On the ground:");

			int i = 0;
			while (i < groundItems.Count)
			{
				Console.WriteLine(groundItems[i].label);
				i = i + 1;
			}

			string inp = Program.GetInput();
			HandleInput( inp );
			HandleGlobalInput( inp);
		}

		protected virtual string GetIntroText()
		{
			return introText;
		}
		
		private void HandleGlobalInput(string inp)
		{
			if (inp.Substring(0, 5) == "drop ")
			{ 
				Item chosenItem = null;

				string itemName = inp.Substring(5); 
				
				int i = 0;
				while (i < Inventory.invList.Count)
				{
					if (Inventory.invList[i].label == itemName)
						chosenItem=Inventory.invList[i];
					i = i +1;
				}

				Inventory.Drop( chosenItem );
			}
		
		}

		protected abstract void HandleInput(string inp);
	}


	class Place_frontHouse : Place
	{
		public Place_frontHouse()
		{
			introText= "You are standing in front of a rural house. It is ramshackle and shitty-looking.";
		
			groundItems.Add(new Item("anal lubricant"));
			groundItems.Add(new Item("peanut butter"));
			groundItems.Add(new Item("riding crop"));
			groundItems.Add(new Item("small kitten"));
		}

		protected override void HandleInput(string inp)
		{
			
			if (inp == "open door" || inp == "open" || inp == "go in")
			{
				Program.foyer.Arrived();
			
			}

			if (inp == "go to the yard")
			{
				Program.yard.Arrived();
			}
		}
		
	}



	class Place_yard : Place
	 {
		public Place_yard()
		{
			introText= "A collection of cement dinosaurs stare balefully back at you from the yard.\n\nThey terrify you. You decide to enter the house.";
		}
		
		
		protected override void HandleInput(string inp)
		{
			Program.frontHouse.Arrived();
		}
	 }
	
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
		
		protected override void HandleInput(string inp)
		{
			if (dogDead == false) 
			{
				if (inp == "greet kindly" || inp == "say hello")
				{
					Console.WriteLine(" Get out of my house you ape!");
					string inp2 = Program.GetInput();
					HandleInput( inp2 );
				}
				else if (inp == "go down hall" || inp == "jump over dog")
				{
					Console.WriteLine("The dog briskly jumps in front of you and blocks your way");
					string inp2 = Program.GetInput();
					HandleInput( inp2 );
				}
				else if (inp == "go outside" )
				{
					Program.frontHouse.Arrived();
				}
				else if (inp == "give biscuit")
				{
					
					Console.Clear();
					Console.WriteLine(" The dog catches the buiscuit you tossed him, munches quietly and promptly dies on the carpet.");
					dogDead = true;

					string inp2 = Program.GetInput();
					HandleInput( inp2 );
				}
			}
			else //if (dogDead == true) 
			{
				if (inp == "go down hall" || inp == "jump over dog")
				{
					Program.hallway.Arrived();
				}
				else if (inp == "go outside")
				{
					Program.frontHouse.Arrived();
				}
			}
		}
	}
	


	class Place_hallway : Place
	{
		protected override string GetIntroText()
		{
			return " this part of the game is not finished yet. now go back and marvel at the fact that the game knows that the dog is dead or not!!!!";
		}

		protected override void HandleInput(string inp)
		{

		}
	}
}
