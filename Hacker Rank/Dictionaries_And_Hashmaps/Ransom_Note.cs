using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Dictionaries_And_Hashmaps
{
	public static class Ransom_Note
	{
		public static void DoSomething()
		{
			checkMagazine(new List<string>() { "two", "times", "three", "is", "not", "four" },
				new List<string>() { "two", "times", "two", "is", "four" });
		}

		public static void checkMagazine(List<string> magazine, List<string> note)
		{
			Dictionary<string, int> magazineHas = new Dictionary<string, int>();

			foreach (var word in magazine)
			{
				if (magazineHas.ContainsKey(word))
				{
					magazineHas[word] += 1;
				}
				else
				{
					magazineHas.Add(word, 1);
				}

			}


			foreach (var word in note)
			{
				if (!magazineHas.ContainsKey(word))
				{
					Console.WriteLine("No");
					return;
				}

				if (magazineHas[word] == 1)
				{
					magazineHas.Remove(word);
				}
				else
				{
					magazineHas[word] -= 1;
				}
			}

			Console.WriteLine("Yes");

		}










	}
}
