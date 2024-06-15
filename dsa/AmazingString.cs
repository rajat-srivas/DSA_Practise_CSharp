using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	internal class AmazingString
	{
		public void IsAmazingString()
		{
			string one = "PAPAINOEL";
			string two = "JOULUPUKKI";
			var combine = "JOULNAPAOILELUPUKKI".ToList();

			if (one.Length + two.Length != combine.Count)
			{
				Console.WriteLine("false");
			}

			foreach (char c in one)
			{
				int index = combine.IndexOf(c);

				if (index == -1)
					Console.WriteLine("Not enough " + c);
				else
					combine.Remove(c);
			}

			foreach (char c in two)
			{
				int index = combine.IndexOf(c);

				if (index == -1)
					Console.WriteLine("Not enough " + c);
				else
					combine.Remove(c);
			}

			if (combine.Count > 0)
			{
				Console.WriteLine("Extra characters present");
			}

			Console.WriteLine("Contains");


			Console.ReadKey();
		}
	}
}
