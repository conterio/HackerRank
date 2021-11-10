using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
	public static class Alternating_Characters
	{
		public static void DoSomething()
		{
			alternatingCharacters("AAABBB");
		}


		public static int alternatingCharacters(string s)
		{
			char current = ' ';
			int delete = 0;
			if (s.Length > 0)
			{
				current = s[0];
			}

			for (int i = 1; i < s.Length; i++)
			{
				if (current == s[i])
				{
					++delete;
				}
				else
				{
					current = s[i];
				}
				
			}

			return delete;
		}



	}
}
