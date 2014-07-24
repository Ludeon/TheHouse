using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	static class Inventory
	{
		public static List<Item> invList = new List<Item>();

		public static void Initialize() 
		{

			Item biscuit = new Item();
			biscuit.label = "cyanide laced dog biscuit";
			invList.Add(biscuit);

			invList.Add(new Item("shiv"));
			invList.Add(new Item("The Bible"));
			invList.Add(new Item("bloody used condom"));
			invList.Add(new Item("Manet art work"));
	
		}


		public static void Drop(Item itemToDrop)
		{
			invList.Remove(itemToDrop);

			//----

			Program.curPlace.groundItems.Add(itemToDrop);

		
		}

	}
}
