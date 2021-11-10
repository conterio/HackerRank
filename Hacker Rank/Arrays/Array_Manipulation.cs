using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Arrays
{
	public static class Array_Manipulation
	{

		public static void DoSomething()
		{
			var result = arrayManipulation(4, new List<List<int>>()
			{
				new List<int>(){2,3,603},
				new List<int>(){1,1,286},
				new List<int>(){4,4,882},
			});

			//StreamReader file = new StreamReader("mani.txt");
			//var line = file.ReadLine();
			//var firstLine = line.Split(" ").Select(Int32.Parse).ToArray();

			//List<List<int>> queries = new List<List<int>>();

			//while (!file.EndOfStream)
			//{
			//	var item = file.ReadLine().Split(" ").Select(Int32.Parse).ToList();
			//	queries.Add(item);
			//}

			////2497169732
			//var result = arrayManipulation(firstLine[0], queries);

		}



		//looking at the array from left to right, you take the value in the current position and apply it to every position to the right of it
		//this array
		/*
		 how it looks at every interation
		[0 0 0 0 0 0 0 0 0 0 ]
		[3 0 0 0 0 -3 0 0 0 0 ]
		[3 0 0 7 0 -3 0 0 -7 0 ]
		[3 0 0 7 0 -2 0 0 -7 -1 ]
		vs populating every index
		[3 3 3 10 10 8 8 8 1 0 ]
		*/
public static long arrayManipulation(int n, List<List<int>> queries)
{
	long[] arr = new long[n+1];

	foreach (var query in queries)
	{
		int start = query[0];
		int end = query[1];
		int add = query[2];

		//only populate the start index and end index
		//because everything to the right of the first index we add that value to it
		//and everything right of the end index is minus this value
		arr[start - 1] += add;
		arr[end] -= add;
	}

	long sum = 0;
	long max = 0;

	for (int i = 0; i < n; i++)
	{
		sum += arr[i];
		max = Math.Max(max, sum);
	}


	return max;
}

public static void printArr(long [] arr)
{
	Console.Write("[");
	foreach (var item in arr)
	{
		Console.Write($"{item} ");
	}
	Console.Write("]");
	Console.WriteLine();

}


}
}
/*
* 			long[] arr = new long[n];

	foreach (var query in queries)
	{
		long start = query[0] - 1;
		long end = query[1];
		long add = query[2];

		for (long i = start; i < end; i++)
		{
			arr[i] += add;
		}
	}

	return arr.Max();
*/