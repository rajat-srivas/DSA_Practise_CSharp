using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	//Move zeros to end without changing the relative order of other elements
	//0,1,0,3,13 => 1,3,13,0,0
	public class Move_Zeros_To_End
	{
		public int[] MoveZeroToEnd(int[] input)
		{
			int left = 0;
			int right = left + 1;
			while(left < input.Length && right < input.Length)
			{
				if (input[left] == 0 && input[right] == 0)
				{
					right += 1;
				}
				else if (input[left] == 0 && input[right] != 0)
				{
					Swap(input, left,right);
					left += 1;
					right += 1;
				}
                else
                {
					left += 1;
					right += 1;
				}
            }

			return input;
		}

		private static void Swap(int[] input, int left, int right)
		{
			int temp = input[right];
			input[right] = input[left];
			input[left] = temp;
		}
	}
}
