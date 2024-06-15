using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dsa
{
	internal class RecursivePalindrome
	{
		public bool CheckPalindrome(string s)
		{
			s = "A man, a plan, a canal: Panama";
			string pattern = "[^a-zA-Z0-9]";
			s = Regex.Replace(s, pattern, "").ToLower();

			Console.WriteLine(s);

			return IsPalindrome(s);
		}
		private static bool IsPalindrome(string s)
		{
			int start = 0;
			int end = s.Length - 1;


			if (s.Length <= 1) return true;
			string remaining = s.Substring(start + 1, end - start - 1);
			Console.WriteLine(remaining);
			if (s[start] == s[end] && IsPalindrome(remaining))
			{
				return true;
			}
			return false;
		}
	}
}
