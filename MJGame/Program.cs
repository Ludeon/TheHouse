using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	class Program
	{
		static string[] inventory = new string[10];

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

			//PAGE 2
			page2:
			Console.Clear();

			Console.WriteLine("You are standing in front of a rural house. It is ramshackle and shitty-looking.");

			string inp;
			inp = GetInput();

			if (inp == "open door" || inp == "open" || inp == "go in")
			{
				//PAGE 3a
				Console.Clear();
				Console.WriteLine("A large dog is sitting in the entrance. He looks at you and says, \"What do you want, fucka?\"");

				string inp3a = GetInput();

				if (inp3a == "greet kindly" || inp3a == "say hello")
				{ Console.WriteLine(" Get out of my house you ape!");
				}


				if (inp3a == "give biscuit")
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
				goto page2;
			}
			

			Console.ReadKey();
		}




		//=================================================


		static string GetInput()
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
				Writeinventory();
				goto start;
			}

			return playerInput;
		}

		static void Writeinventory()
		{
			int invcount = 0;

			loopstart:

			Console.WriteLine(inventory[invcount]);
			invcount = invcount + 1;
			if (invcount == 9) return; 
			goto loopstart;

		}


	}
}















