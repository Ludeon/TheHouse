using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	static class InputProcessor
	{
		public static bool HandleInput_Inventory(string inp)
		{
			if (inp == "inventory")
			{
				InvUtil.Writeinventory();
				return true;
			}

			if (inp.Length > 5 && inp.Substring(0, 5) == "drop ")
			{
				string itemName = inp.Substring(5);
				Item chosenItem = Inventory.GetNamed(itemName);

				
				if (chosenItem == null)
				{
					Console.WriteLine("You are not carrying that item");
					return true;
				}
				Inventory.Drop(chosenItem);
				Console.WriteLine("You threw the item down in an ungovernable rage.");
				return true;
			}

			if (inp.Length > 5 && inp.Substring(0, 5) == "take ")
			{
				Item chosenItem = null;
				string itemName = inp.Substring(5);

				int i = 0;
				while (i < Program.curPlace.groundItems.Count)
				{
					if (Program.curPlace.groundItems[i].label == itemName)
						chosenItem = Program.curPlace.groundItems[i];
					i = i + 1;
				}
				if (chosenItem == null)
				{
					Console.WriteLine("That item is not here");
					return true;
				}

				Inventory.Take(chosenItem);
				Console.WriteLine("The item has been taken");
				return true;
			}
			

			if (inp == "quit game")
			{
				Program.wantExit = true;
				return true;
			}
			return false;
		}
		
	}
}
