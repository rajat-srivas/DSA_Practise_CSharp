using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Heap
{
	public class HeapProblem
	{
		public void KthElement()
		{
			int[] arr = new int[11] { 1, 3, 5, 2, 9, 6, 11, 56, 23, 10, 7 };
			//say size of the arr is n
			//for kth smallest, create a max heap of first k element in the array
			//for this heap largest will be root
			//now for remaining items i.e. from index k+1 to n-1
			//one by one if next item is less than current top, remove current top from heap and add new item
			//once the iteration is over kth smallest will be at top of the heap 
			Console.WriteLine("Input Array");

			KthSmallest(arr, 6);

			KthLargest(arr, 3);
		}

		private void KthLargest(int[] arr, int k)
		{
			var pq = new PriorityQueue<int, int>();

			for (int i = 0; i < arr.Length; i++)
			{
				pq.Enqueue(arr[i], arr[i]);
				if (pq.Count > k)
				{
					pq.Dequeue();
				}
			}

			Console.WriteLine(Environment.NewLine + k + " Largest number: ");
			Console.Write(pq.Peek());

		}

		private static void KthSmallest(int[] arr, int k)
		{
			var pq = new PriorityQueue<int, int>();

			for (int i = 0; i < k; i++)
			{
				pq.Enqueue(arr[i], -arr[i]);
			}

			for (int i = k; i < arr.Length; i++)
			{
				var heighest = pq.Dequeue();
				pq.Enqueue(heighest, -heighest);
				if (arr[i] < heighest)
				{
					pq.Dequeue();
					pq.Enqueue(arr[i], -arr[i]);
				}
			}

			

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

			Console.WriteLine(Environment.NewLine + k + " smallest number: ");
			Console.Write(pq.Peek());
		}
	}

}
