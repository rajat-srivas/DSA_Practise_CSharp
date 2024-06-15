using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Three_Sum_Problem
	{

		public (int, int, int) ThreeSumProblem(List<int> input, int expectedSum)
		{
			input.Sort();
			for (int i = 0; i < input.Count - 3; i++)
			{
				int leftIndex = i + 1;
				int rightIndex = input.Count - 1;
				while (leftIndex < rightIndex)
				{
					int left = input[leftIndex];
					int right = input[rightIndex];
					int currentSum = input[i] + left + right;

					if (currentSum == expectedSum)
					{
						return (input[i], left, right);
					}
					else if (currentSum < expectedSum)
					{
						left += 1;
					}
					else
					{
						right -= 1;
					}
				}
			}

			return (0, 0, 0);
		}
	}
}
