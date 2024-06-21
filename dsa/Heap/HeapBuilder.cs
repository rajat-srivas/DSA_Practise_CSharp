using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Heap
{
	public class HeapBuilder
	{
		public void Heap(int[] arr)
		{
			
			BuildHeap(arr);

			HeapSort(arr);

			HeapPriorityQueue pq = new HeapPriorityQueue();
			pq.HeapWithPQ();

			return;
		}

		private void HeapSort(int[] arr)
		{
			int length = arr.Length;

			for(int i = length-1;i > 0; i--)
			{
				int temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;

				//we move the largest element to end as it always be on top in max heap
				//we mvoe the end element to top and then heapify it to its correct position
				//and repeat so that always the largest keeps going to end and we continue on remaining sub arrya
				//sending i in lenght as thats what we want to lookinto and not the last one
				Heapify(arr, i, 0);
			}

			PrintHeap(arr, "Sorted Heap");
		}

		public void BuildHeap(int[] arr)
		{
			

			//Max heap => root is bigger than both child
			// for 0 based index 
			//root = (i-1)/2
			//left child = 2n + 1
			//right child = 2n + 2
			//number of leaf nodes = (n/2) -1;

			//in a heap leaf nodes are already correct so we dont need to put them in place
			//so loop can start from 0 to n/2-1

			int index = (arr.Length / 2) - 1;
			for (int i = index; i >= 0; i--)
			{
				Heapify(arr, arr.Length, i);
			}

			PrintHeap(arr, "New Max Heap");

			return;
		}

		private static void PrintHeap(int[] arr, string message)
		{
			Console.WriteLine(message);

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}

		private void Heapify(int[] arr, int length, int i)
		{
			//let largest be root 
			int largest = i;
			int leftChild = (2 * i) + 1;
			int rightChild = (2 * i) + 2;

			if (leftChild < length && arr[largest] < arr[leftChild])
			{
				largest = leftChild;
			}

			if(rightChild < length && arr[largest] < arr[rightChild])
			{
				largest = rightChild;
			}

			if(largest != i)
			{
				int temp = arr[i];
				arr[i] = arr[largest];
				arr[largest] = temp;

				Heapify(arr, length, largest);
			}
		}
	}
}
