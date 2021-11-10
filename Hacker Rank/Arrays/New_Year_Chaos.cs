using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Arrays
{
	public static class New_Year_Chaos
	{

		private static Stopwatch stopwatch = new Stopwatch();
		private static Stopwatch stopwatch1 = new Stopwatch();
		public static void DoSomething()
		{
			var file = new StreamReader(@"newyear.txt");

			List<int> input = new List<int>(file.ReadLine().Split(" ").Select(Int32.Parse).ToArray());

			minimumBribes(input);
			//minimumBribes(new List<int>() { 1, 2, 3 });
		}

		public static void minimumBribes(List<int> q)
		{
			int bribes = 0;

			int expectedFirst = 1;
			int expectedSecond = 2;
			int expectedThird = 3;

			for (int i = 0; i < q.Count; i++)
			{
				if (q[i] == expectedFirst)
				{
					expectedFirst = expectedSecond;
					expectedSecond = expectedThird;
					++expectedThird;
				}
				else if (q[i] == expectedSecond)
				{
					++bribes;
					expectedSecond = expectedThird;
					++expectedThird;
				}
				else if (q[i] == expectedThird)
				{
					bribes += 2;
					++expectedThird;
				}
				else
				{
					Console.WriteLine("Too chaotic");
				}

			}

			Console.WriteLine(bribes);

		}







	}

}