using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Sorting
{
	internal class InsertionSort
	{
		// place an element in its correct position in every iteration, by moving it left 
	
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

			for(int i = 0; i < length; i++)
			{
				int j = i;
				while (j > 0 && input[j] < input[j-1])
				{
					Swap(input, j, j - 1);
					j--;
				}
				
			}

			return input;
		}
	}
}
