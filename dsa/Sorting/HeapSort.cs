using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Sorting
{
	internal class HeapSort
	{
		public void Sort()
		{
			int[] input = { 9, 6, 8, 2, 10, 3, 4, 7, 1, 5 };

			int lenght = input.Length;

			//build heap

			int index = (lenght / 2) - 1;

			for(int i = index; i>= 0; i--)
			{
				Heapify(input, lenght, i);
			}

			Console.WriteLine();
			Console.WriteLine("Heap" + Environment.NewLine);
			for (int i = 0; i < input.Length; i++)
			{
				Console.Write(input[i] + " ");
			}
			Console.WriteLine();

			//heap sort
			for (int i = lenght -1; i > 0; i--)
			{
				Swap(input, 0, i);
				Heapify(input, i, 0);
			}

			Console.WriteLine();
			Console.WriteLine("Heap Sort");
			foreach (var item in input)
			{
				Console.Write(item + " ");
			}


		}

		private void Heapify(int[] input, int n, int i)
		{
			int largest = i;
			int leftChild = (2 * i) + 1;
			int rightChild = (2 * i) + 2;

            if (leftChild < n && input[largest]< input[leftChild])
            {
				largest = leftChild;
            }

			if (rightChild < n && input[largest] < input[rightChild])
			{
				largest = rightChild;
			}

			if(largest != i)
			{
				Swap(input, i, largest);
				Heapify(input, n, largest);
			}
		}

		private void Swap(int[] input, int i, int minimum)
		{
			int temp = input[i];
			input[i] = input[minimum];
			input[minimum] = temp;
		}
	}
}
