using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class Backspace_String_Compare
	{
		public bool BackspaceCompare(string s, string t)
		{
			//"a#c"
			//"c"
			List<char> s1 = new List<char>();
			List<char> s2 = new List<char>();

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '#')
				{
					if (s1.Count > 0)
					{
						s1.RemoveAt(s1.Count - 1);
					}
				}
				else
					s1.Add(s[i]);
			}
			for (int i = 0; i < t.Length; i++)
			{

				if (t[i] == '#')
				{
					if (s2.Count > 0)
					{
						s2.RemoveAt(s2.Count -1);
					}
				}
				else
					s2.Add(t[i]);

			}

			string s_1 = new string(s1.ToArray());
			string t_1 = new string(s2.ToArray());
			return s_1.Equals(t_1);

		}

	}
}
