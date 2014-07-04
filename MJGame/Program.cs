using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	static class Program
	{
		public static string[] inventory = new string[10];
		
		// Create all places
		public static Place_frontHouse frontHouse = new Place_frontHouse();
		public static Place_yard yard = new Place_yard();
		public static Place_foyer foyer = new Place_foyer();
		public static Place_hallway hallway = new Place_hallway();





		static void Initialize() 
		{
			inventory[0] = "cyanide laced dog biscuit";
			inventory[1] = "anal lubricant";
			inventory[2] = "peanut butter";
			inventory[3] = " riding crop";
			inventory[4] = "small kitten";
			inventory[5] = "shiv";
			inventory[6] = " The Bible";
			inventory[7] = "bloody used condom";
			inventory[8] = " Manet art work";
	
		}
		
		static void Main(string[] args)
		{
			Initialize();

			//PAGE 1
			Console.WriteLine("MJ's Game");
			Console.WriteLine("by MJ Gandier");
			Console.WriteLine("assisted by Tynan Sylvester (flunky)");
			Console.WriteLine();
			Console.WriteLine("Press a key to begin.");
			Console.ReadKey();


			//Start the game
			frontHouse.Arrived();
	
						

			Console.ReadKey();
		}




		//=================================================


		public static string GetInput()
		{
			int numBadInputs = 0;

			start:
			Console.Write("> ");

			string playerInput;
			playerInput = Console.ReadLine();

			if (playerInput == "")
			{
				numBadInputs = numBadInputs + 1;

				if (numBadInputs % 5 == 0)
				{
					Console.WriteLine("Stop being a dick.");
				//	Console.WriteLine("A meteor falls from the sky and kills you.\n\nThe end.");
				}

				Console.WriteLine("Please decide.");
				goto start;
			}

			if (playerInput == "inventory")
			{
				InvUtil.Writeinventory();


				goto start;
			}

			return playerInput;
		}
	}





	public static class InvUtil
	{
		public static void Writeinventory()
		{
			int invcount = 0;

			loopstart:

			Console.WriteLine(Program.inventory[invcount]);
			invcount = invcount + 1;
			if (invcount == 9) return; 
			goto loopstart;

		}
	}
}









