using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	internal class Longest_SubSeq_Without_Repetition
	{
		public void Longest()
		{
			List<string> inputs = new List<string>()
			{
				"abcabcbb",
				"bbbbb",
				"pwwkew"
			};

			foreach (string input in inputs)
			{
				Console.WriteLine("Input: " + input);
				int pointer = 0;
				var tracker = new Dictionary<char, int>();
				int left = 0;
				int maxLength = 0;

				while (left < input.Length)
				{
					var currentChar = input[left];
					if (tracker.ContainsKey(currentChar))
					{
						pointer = Math.Max(left, tracker[currentChar] + 1);
					}

					tracker[currentChar] = left;
					var sub = input.Substring(pointer, left - pointer + 1).Length;
					maxLength = Math.Max(maxLength, sub);
					left++;
				}

				Console.WriteLine("Max Length: " + maxLength);
			}
		}
	}
}
