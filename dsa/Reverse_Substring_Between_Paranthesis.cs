using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Reverse_Substring_Between_Paranthesis
	{
		public void ReverseString()
		{
			//input (ab(cda)a)
			//output  => two step (abadca) =>  acdaba

			StringBuilder input = new StringBuilder("(u(love)i)");

			Console.WriteLine("Input string: " + input.ToString());

			Stack<int> stack = new Stack<int>();	

			for(int i =0; i< input.Length; i++)
			{
				if (input[i] == '(')
					stack.Push(i);
				else if (input[i] == ')')
				{
					int j = stack.Pop();
					input =  ReverseSubstring(input, j + 1, i - 1);
				}
				
			}

			input.Replace('('.ToString(), string.Empty).Replace(')'.ToString(), string.Empty);
			Console.WriteLine(input.ToString());
		}

		private StringBuilder ReverseSubstring(StringBuilder input, int start, int end)
		{
			while(start <= end)
			{
				var temp = input[start];
				input[start] = input[end];
				input[end] = temp;
				start++;
				end--;
			}

			return input;
		}
	}
}
