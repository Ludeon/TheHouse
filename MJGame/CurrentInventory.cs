using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	static class CurrentInventory
	{
		public static Item[] inventory = new Item[10];

		public static void Initialize() 
		{

			Item biscuit = new Item();
			biscuit.label = "cyanide laced dog biscuit";
			inventory[0] = biscuit;

			inventory[1] = new Item("anal lubricant");
			inventory[2] = new Item("peanut butter");
			inventory[3] = new Item("riding crop");
			inventory[4] = new Item("small kitten");
			inventory[5] = new Item("shiv");
			inventory[6] = new Item("The Bible");
			inventory[7] = new Item("bloody used condom");
			inventory[8] = new Item("Manet art work");
	
		}
	}
}
