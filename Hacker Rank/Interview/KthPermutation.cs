using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class KthPermutation
	{
		private static int count = 0;
		public static void DoSomething()
		{
			FindPerm(new List<char> { 'a', 'b', 'c' }, 3, "");
			var result = Permutation("abcd");
		}

		private static void FindPerm(List<char> list, int v1, string v2)
		{
			string input = new string(list.ToArray());
			var permutations = Permutation(input);

			Console.WriteLine(permutations[v1]);
		}


		//5 * 4 * 3 * 2 * 1
		private static int Factorial(int n)
		{
			if (n == 1 || n == 0)
			{
				return 1;
			}

			return n * Factorial(n - 1);
		}

		private static List<string> Permutation(string rest, string prefix = "")
		{
			List<string> result = new List<string>();
			if (string.IsNullOrEmpty(rest))
			{
				result.Add(prefix);
				++count;

				if (count == 3)
				{
					Console.WriteLine(prefix);
				}
			}

			for (int i = 0; i < rest.Length; i++)
			{
				result.AddRange(Permutation(rest.Remove(i, 1), prefix + rest[i]));
			}

			return result;
		}

	}
}
