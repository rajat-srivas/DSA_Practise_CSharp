using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class LongestSubsequence
	{
		public void LongestCommonSubsequence(string text1, string text2)
		{
			int longest = Compare(text1, text2, 0, 0);
			Console.WriteLine("Longest Subsequence of " + text1  + " & " + text2 + ": " + longest);

		}

		public int Compare(string text, string text2, int i, int j)
		{
			if (i == text.Length)
				return 0;

			if (j == text2.Length)
				return 0;

			int answer = 0;

			if (text[i] == text2[j])
			{
				answer = 1 + Compare(text, text2, i + 1, j + 1);
			}
			else
			{
				answer = Math.Max(Compare(text, text2, i + 1, j), Compare(text, text2, i, j + 1));
			}

			return answer;
		}
	}
}
