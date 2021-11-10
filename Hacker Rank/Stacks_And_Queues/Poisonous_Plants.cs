using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Stacks_And_Queues
{
	public static class Poisonous_Plants
	{
		private static Stopwatch timer = new Stopwatch();
		private static StreamWriter writer = new StreamWriter(@"result.txt");
		public static void DoSomething()
		{
			StreamReader input = new StreamReader(@"poisonous.txt");
			var line = input.ReadLine();
			var items = line.Split(" ").Select(Int32.Parse).ToArray();



			//var temp = poisonousPlants(new List<int>() { 6, 5, 8, 4, 7, 10, 9 }); //2
			//poisonousPlants(new List<int>() { 1,1,1,1,1,1 });//0
			//poisonousPlants(new List<int>() { 20, 5, 6, 15, 2, 2, 17, 2, 11, 5, 14, 5, 10, 9, 19, 12, 5 });//4
			//poisonousPlants(new List<int>() { 1, 20, 5, 10, 11, 12 });//2
			//poisonousPlants(new List<int>() { 6, 12, 12, 8, 8, 7 });//5
			//var r = poisonousPlants(new List<int>() { 2, 11, 5, 14, 5, 10, 9, 19, 12, 5 });//4
			//poisonousPlants(new List<int>() { 6,5,8,7,4,7,3,1,1,10 });//4

			

			
			//var answer = poisonousPlants(new List<int>() { 2, 11, 5, 14, 5 });
			//writer.WriteLine("ans: " + answer);
			//writer.WriteLine("------------------------------------------");
			//var answer1 = poisonousPlants3(new List<int>() { 2, 11, 5, 14, 5 });
			//writer.WriteLine("ans: " + answer1);
			//writer.Close();

			timer = new Stopwatch();
			timer.Start();
			poisonousPlants(new List<int>() { 4,5,6, 3,4,2,1,0 });
			timer.Stop();
			writer.WriteLine(timer.Elapsed);


		}



		public static int poisonousPlants(List<int> p)
		{
			int n = p.Count;
			List<int> days = new List<int>(new int[n]);
			int min = p[0];
			int max = 0;
			Stack<int> s = new Stack<int>();

			s.Push(0);

			for (int index = 1; index < n; index++)
			{
				if (p[index] > p[index-1])
				{
					days[index] = 1;
				}

				min = min < p[index] ? min : p[index];

				while (s.Count > 0 && p[s.Peek()] >= p[index])
				{
					if (p[index] > min)
					{
						days[index] = days[index] > days[s.Peek()] + 1 ? days[index] : days[s.Peek()] + 1;
					}
					s.Pop();
				}

				max = max > days[index] ? max : days[index];
				s.Push(index);
			}

			return max;
		}


		public static int poisonousPlants3(List<int> p)
		{
			int n = p.Count;
			List<int> days = new List<int>(new int[n]);
			int min = p[0];
			int max = 0;
			int j = 0;

			//PrintListWithIndex(p, -1, -1, "List is:");
			for (int i = 1; i < n; i++)
			{
				//PrintListWithIndex(p, i, i - 1, "--");
				if (p[i] > p[i - 1])
				{
					days[i] = 1;
				}
				min = min < p[i] ? min : p[i];

				int temp = j;
				int x = j;
				//PrintListWithIndex(p, temp, i, "");
				while (temp > j-x && p[temp] >= p[i])
				{
					if (p[i] > min)
					{
						//PrintListWithIndex(p, i, temp, "days");
						days[i] = days[i] > days[temp] + 1 ? days[i] : days[temp] + 1;
					}
					--temp;
				}
				max = max > days[i] ? max : days[i];
				++x;
				++j;
			}
			return max;
		}


		private static void PrintListWithIndex(List<int> p, int x, int y, string info = null)
		{
			if (info != null)
			{
				writer.WriteLine(info);
			}

			for (int i = 0; i < p.Count; i++)
			{
				if (i == x || i == y)
				{
					writer.Write($"|{p[i]}| ");
				}
				else
				{
					writer.Write($"{p[i]} ");
				}
			}
			
			writer.WriteLine();

		}



	}
}
