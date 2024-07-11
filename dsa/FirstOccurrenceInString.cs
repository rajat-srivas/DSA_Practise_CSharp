using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	internal class FirstOccurrenceInString
	{
		public void FirstIndex()
		{
			string input = "mississippi";
			string sample = "issip";

			int i = 0;
			int s = 0;

			int answer = GetIndex(input, sample, i, s);
			Console.WriteLine(answer);
			
		}

		private int GetIndex(string haystack, string needle, int i, int s)
		{
			int matchStart = 0;
			while(i < haystack.Length && s < needle.Length)
			{
				if (haystack[i] == needle[s])
				{

					i++;
					s++;
				}
				else
				{
					matchStart++;
					i = matchStart;
					s = 0;
				}
			}

			if (s == needle.Length)
				return i - s ;
            else
            {
				return -1;
            }
        }
	}
}
