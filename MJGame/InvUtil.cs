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
			while (i < Inventory.invList.Count)
			{
				Console.WriteLine(Inventory.invList[i].label);
				i = i + 1;
			}
		}
	}
	
}
