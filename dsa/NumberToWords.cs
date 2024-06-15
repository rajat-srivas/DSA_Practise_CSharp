using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class NumberToWords
	{
		public static Dictionary<int, string> dict = new Dictionary<int, string>();
		
		public void GetWordsFromNumber(int number)
		{
			int num = number;

			if (num == 0) Console.WriteLine("Zero");
			InitDict();

			var r = Convert(num);
			Console.WriteLine(r.Substring(0, r.Length - 1));
		}
		public static string Convert(int num)
		{

			foreach (var key in dict.Keys)
			{
				if (num >= key)
				{
					var res = dict[key] + " " + Convert(num % key);
					Console.WriteLine(res);
					if (num >= 100) res = Convert(num / key) + res;
					return res;
				}
			}

			return "";

		}

		private static void InitDict()
		{
			dict.Add(10000000, "Crore");
			dict.Add(100000, "Lakh");
			dict.Add(1000, "Thousand");
			dict.Add(100, "Hundred");
			dict.Add(90, "Ninety");
			dict.Add(80, "Eighty");
			dict.Add(70, "Seventy");
			dict.Add(60, "Sixty");
			dict.Add(50, "Fifty");
			dict.Add(40, "Forty");
			dict.Add(30, "Thirty");
			dict.Add(20, "Twenty");
			dict.Add(19, "Nineteen");
			dict.Add(18, "Eighteen");
			dict.Add(17, "Seventeen");
			dict.Add(16, "Sixteen");
			dict.Add(15, "Fifteen");
			dict.Add(14, "Fourteen");
			dict.Add(13, "Thirteen");
			dict.Add(12, "Twelve");
			dict.Add(11, "Eleven");
			dict.Add(10, "Ten");
			dict.Add(9, "Nine");
			dict.Add(8, "Eight");
			dict.Add(7, "Seven");
			dict.Add(6, "Six");
			dict.Add(5, "Five");
			dict.Add(4, "Four");
			dict.Add(3, "Three");
			dict.Add(2, "Two");
			dict.Add(1, "One");

		}
	}
}
