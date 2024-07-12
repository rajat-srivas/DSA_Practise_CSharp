using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Sorting
{
	internal class SelectionSort
	{

		public int[] Sort(int[] arr)
		{
			var input = arr;
			//Get minimum and bring it to front, repeat of remaining array
			int length = input.Length;

			for(int i = 0; i< length; i++)
			{
				int minimum = i;

				for(int j = i+1; j< length; j++)
				{
					if (input[j] < input[minimum])
						minimum = j;
				}

				Swap(input, i, minimum);

			}

			return input;
		}

		private void Swap(int[] input, int i, int minimum)
		{
			int temp = input[i];
			input[i] = input[minimum];
			input[minimum] = temp;
		}
	}
}
