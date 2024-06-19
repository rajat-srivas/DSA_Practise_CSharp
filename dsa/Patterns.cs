using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Patterns
	{
		public void PrintPatterns()
		{
			//outer loop  => connected to number of rows in patterns
			//inner loop => somehow connected to number of columns in patterns
			//1 3 5 7
			//		*
			//	  * * *
			//	* * * * *
			// * * * * * * *			
			//   * * * * * * * * *
			int n = 5;
			for (int i = 1; i <= n; i++)
			{

				for (int k = 1; k <= n - i; k++)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= (i * 2) - 1; k++)
				{
					Console.Write("*");
				}

				//for (int k = 1; k <= n; k++)
				//{
				//	Console.Write(" ");
				//}

				Console.WriteLine();

			}

			Console.WriteLine(Environment.NewLine);
			
			//inverted pattern

			for (int i = 0; i <= n; i++)
			{
				for(int j = 0; j<i;j++)
				{
					Console.Write(" ");
				}
				
				for(int j = 1;j<=(n*2)-(2*i)-1;j++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}
	}
}
