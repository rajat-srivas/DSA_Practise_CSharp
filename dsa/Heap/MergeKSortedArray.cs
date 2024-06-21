using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Heap
{
	public class MergeKSortedArray
	{
		public void Merge()
		{
			var input = new List<List<int>>()
			{
				new List<int>(){1,5,6,7},
				new List<int>(){4,8,12,16},
				new List<int>(){3,9},
				new List<int>(){11,15,16},
				new List<int>(){20,21,22,27},
				new List<int>(){23,26,28,31}
			};

			//4*4 

			List<int> answer = new List<int>();

			PriorityQueue<Item, int> pq = new PriorityQueue<Item, int>();

			//add the first column of each array into the queue
			//we are starting with first column as we know all arrays are already sorted
			//so overall sorted item will also be in the first column itself
			for (int i = 0; i < 6; i++)
			{
				var item = new Item(input[i][0], i, 0);
				pq.Enqueue(item, item.data);
			}

			while(pq.Count > 0)
			{
				//get the smallest item
				var tempItem = pq.Peek();

				//add it to our answer list
				answer.Add(tempItem.data);

				//remove the smallest item just added from the queue
				pq.Dequeue();

				//add next column of the row who item was just remvoed
				//this is just a way to go one by one in the for columns since we added only one column data
				//whichever row,column item is remvoed, next row.column+1 item is added.
				int i = tempItem.rowIndex;
				int j = tempItem.columnIndex;

				//checking j+1 to make sure that this row has not already been completly traversed
				if (j + 1 < input[i].Count)
				{
					var newItem = new Item(input[i][j + 1], i, j + 1);
					pq.Enqueue(newItem, newItem.data);
				}
			}

            foreach (var item in answer)
            {
				Console.Write(item + " ");
            }
        }
	}

	public class Item
	{
		public int data { get; set; }
		public int rowIndex{ get; set; }
		
		public int columnIndex { get; set; }
		
		public Item(int data, int rowIndex, int columnIndex)
		{
			this.data = data;
			this.rowIndex = rowIndex;
			this.columnIndex = columnIndex;
		}
	}


}
