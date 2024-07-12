using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Sorting
{
	internal class BubbleSort
	{
		//push the maximum to the end
	
		private void Swap(int[] input, int i, int minimum)
		{
			int temp = input[i];
			input[i] = input[minimum];
			input[minimum] = temp;
		}
		public int[] Sort(int[] arr)
		{
			var input = arr;

			int length = input.Length;

			for(int i = 0; i < length -1; i++)
			{
				for(int j = 0; j<length - i -1; j++)
				{
					if (input[j] > input[j + 1])
					{
						Swap(input, j, j + 1);
					}
				}
			}

			return input;
		}
	}
}
