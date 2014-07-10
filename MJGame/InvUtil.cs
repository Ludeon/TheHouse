using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJGame
{
	
	public static class InvUtil
	{

		public static void Writeinventory()
		{
			int i = 0;

			loopstart:

			Console.WriteLine(CurrentInventory.inventory[i].label);
			i = i + 1;
			if (i == 9) return; 
			goto loopstart;

		}
	}
	
}
