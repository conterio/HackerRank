using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class KthPermutation
	{
		public static void DoSomething()
		{
			FindPerm(new List<char> { 'a', 'b', 'c' }, 3, "");

			FindMissingNubmer(new[] { 3, 7, 1, 2, 8, 4, 5 });
		}

		private static void FindPerm(List<char> list, int permAtIndex, string v2)
		{
			string input = new string(list.ToArray());
			var permutations = Permutation(input);

			Console.WriteLine(permutations[permAtIndex]);
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
			}

			for (int i = 0; i < rest.Length; i++)
			{
				result.AddRange(Permutation(rest.Remove(i, 1), prefix + rest[i]));
			}

			return result;
		}



		//O(2n)  O(n)
		private static void FindMissingNubmer(int[] arr)
		{
			var expectedSum = 0;// number * (number + 1) / 2;
			for (int j = 1; j <= arr.Length + 1; ++j)
			{
				expectedSum += j;
			}
			var actualSum = arr.Sum();

			var result = expectedSum - actualSum;

		}

	}
}
