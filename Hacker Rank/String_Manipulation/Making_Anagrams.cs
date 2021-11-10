using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
	public static class Making_Anagrams
	{
		public static void DoSomething()
		{
			string a = "fcrxzwscanmligyxyvym";
			string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

			//keep track of how many times we delete
			int delete = 0;
			var intersect = a.Intersect(b).ToList();

			//get all the char deletions for string a
			string newstringA = "";
			for (int i = 0; i < a.Length; i++)
			{
				if (intersect.Contains(a[i]))
				{
					newstringA = newstringA + a[i];
				}
			}
			delete += a.Length - newstringA.Length;

			//get all the char deletions for string b
			string newstringB = "";
			for (int i = 0; i < b.Length; i++)
			{
				if (intersect.Contains(b[i]))
				{
					newstringB = newstringB + b[i];
				}
			}
			delete += b.Length - newstringB.Length;

			//remove the extra characters that string a or string b has
			foreach (var chr in intersect)
			{
				var stringACount = newstringA.Count(x => x == chr);
				var stringBCount = newstringB.Count(x => x == chr);

				delete += Math.Abs(stringACount - stringBCount);
			}



			//sort string alphabetically
			//var sortA = String.Concat(a.OrderBy(c => c));
			//var sortB = String.Concat(b.OrderBy(c => c));



		}
	}
}
