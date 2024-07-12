using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Sorting
{
	internal class SortArray
	{
		public void Sorting()
		{
			var input = new int[] { 10, 5, 8, 11, 2, 6, 7, 13, 19, 5, 3, 1, 35 };

			PrintArray("Unsorted array", input);

			

			SelectionSort sort = new SelectionSort();
			int[] sorted1 = sort.Sort(input);

			PrintArray("Selection Sort", sorted1);

			BubbleSort sortb = new BubbleSort();
			int[] sorted2 = sortb.Sort(input);

			PrintArray("Bubble Sort", sorted2);

			InsertionSort sorti = new InsertionSort();
			int[] sorted3 = sorti.Sort(input);

			PrintArray("Insertion Sort", sorted3);

			HeapSort sorth = new HeapSort();
			sorth.Sort();
		}

		private void PrintArray(string msg, int[] input)
		{
			Console.WriteLine();
			Console.WriteLine(msg);
			foreach (var item in input)
			{
				Console.Write(item + " ");
			}
		}

	}
}
