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

			
		}

		protected virtual string GetIntroText()
		{
			return introText;
		}
		
		

		public abstract bool HandleInput_Place(string inp);
	}

		
		
	


	
}
