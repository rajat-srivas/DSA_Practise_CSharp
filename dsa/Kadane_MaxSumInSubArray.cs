using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Kadane_MaxSumInSubArray
	{
		public void CalculateMaxSumInSubArray(int[] subArray)
		{
			int sum = 0;
			int maxSum = int.MinValue;
			int start = -1;
			int end = -1;

			for(int i = 0; i < subArray.Length; i++)
			{
				if (sum == 0)
					start = i;

				sum = sum + subArray[i];

				if(maxSum < sum)
				{
					maxSum = sum;
					end = i;
				}

				if (sum < 0) sum = 0;
			}

			Console.WriteLine("Max Sum = " + maxSum);
			Console.Write("SubArray = ");
			for (int i = start; i <= end; i++)
			{
				Console.Write(subArray[i] + ", ");
			}

		}
	}
}
