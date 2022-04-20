using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class PossibleBrackets
	{
		public static void DoSomething()
		{
			printBrackets(3);
		}

		private static void printBrackets(int n)
		{
			List<List<char>> result = new List<List<char>>();
			List<char> output = new List<char>();

			printUsingRecursion(n, 0, 0, output, result);

			print(result);
		}

		private static void printUsingRecursion(int n, int leftCount, int rightCount, List<char> output, List<List<char>> result)
		{
			if (leftCount >= n && rightCount >= n)
			{
				var temp = new List<char>(output);
				result.Add(temp);
			}

			if (leftCount < n)
			{
				output.Add('{');
				printUsingRecursion(n, leftCount + 1, rightCount, output, result);
				output.RemoveAt(output.Count - 1);
			}

			if (rightCount < leftCount)
			{
				output.Add('}');
				printUsingRecursion(n, leftCount, rightCount + 1, output, result);
				output.RemoveAt(output.Count - 1);
			}
		}

		static void print(List<List<char>> arr)
		{
			foreach (var row in arr)
			{
				foreach (var item in row)
				{
					Console.Write(item.ToString() + " ");
				}
				Console.WriteLine();
			}
		}


	}
}
