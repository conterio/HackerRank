using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Dictionaries_And_Hashmaps
{
	public static class Two_Strings
	{
		public static void DoSomething()
		{
			twoStrings("abc", "azz");
		}

		public static string twoStrings(string s1, string s2)
		{
			var hash1 = s1.ToHashSet();
			var hash2 = s2.ToHashSet();

			var result = s1.Intersect(s2).ToList();

			foreach (var character in hash1)
			{
				if (hash2.Contains(character))
				{
					return "YES";
				}
			}

			return "NO";
		}














	}
}
