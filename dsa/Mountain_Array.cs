using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Mountain_Array
	{
		public bool ValidMountainArray()
		{
			int[] arr = new int[] { 1, 3, 2 };
			int left = 0;
			bool peakFound = false;

			while (left <= arr.Length - 1 && left + 1 <= arr.Length - 1)
			{
				if (peakFound)
				{
					if (arr[left] >= arr[left + 1])
					{
						left += 1;

					}
					if (arr[left] < arr[left + 1])
					{
						return false;
					}
				}
				else
				{
					if (arr[left] <= arr[left + 1])
					{
						left += 1;
					}
					else if (arr[left] > arr[left + 1])
					{
						peakFound = true;
						left += 1;
					}
				}


			}

			return peakFound;
		}
	}
}
	//int[] input = new int[] { 1,3,2};
	//int left = 0;
	//bool peakFound = false;

	//while (left <= input.Length - 1 && left+1 <= input.Length -1)
	//{

	//	if (peakFound)
	//	{
	//		if (input[left] >= input[left + 1])
	//		{
	//			left += 1;

	//		}
	//		if (input[left] < input[left + 1])
	//		{
	//			return false;
	//		}
	//	}
	//	else
	//	{
	//		if (input[left] <= input[left + 1])
	//		{
	//			left += 1;
	//		}
	//		else if (input[left] > input[left + 1])
	//		{
	//			peakFound = true;
	//			left += 1;
	//		}
	//	}


	//}

	//return peakFound;}}


