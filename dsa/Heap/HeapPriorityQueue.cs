using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Heap
{
	public class HeapPriorityQueue
	{
		//heap is reperesented in C# using priority queue 
		// build heap and all can be done with priority queue by default
		public void HeapWithPQ()
		{
			int[] arr = { 9, 6, 8, 2, 10, 3, 4, 7, 1, 5 };
			int[] arr2 = { 9, 6, 8, 2, 10, 3, 4, 7, 1, 5 };

			PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
			DecendingOrderSort(arr, heap);
			AscendingOrderSort(arr2, heap);

			PrintHeap(arr,"Decending order sort");
			PrintHeap(arr2, "Ascending order sort");
		}

		private static void PrintHeap(int[] arr, string mes)
		{
			Console.WriteLine(mes);

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

			Console.WriteLine();	
		}

		private static void DecendingOrderSort(int[] arr, PriorityQueue<int, int> heap)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				heap.Enqueue(arr[i], arr[i]);
			}

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				arr[i] = heap.Dequeue();
			}
		}

		private static void AscendingOrderSort(int[] arr, PriorityQueue<int, int> heap)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				heap.Enqueue(arr[i], arr[i]);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = heap.Dequeue();
			}
		}
	}
}
