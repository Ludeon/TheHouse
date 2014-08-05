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

		public static Item GetNamed(string itemName)
		{
			int i = 0;
			while (i < invList.Count)
			{
				if (invList[i].label == itemName)
					return invList[i];
				i = i + 1;
			}
			return null;
		}


		public static void Drop(Item itemToDrop)
		{
			invList.Remove(itemToDrop);

			//----

			Program.curPlace.groundItems.Add(itemToDrop);

		
		}
		public static void Take(Item itemToTake)
		{
			invList.Add(itemToTake);

			//----

			Program.curPlace.groundItems.Remove(itemToTake);


		}

	}
}
