using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class FindHighLow
	{
		public static void DoSomething()
		{
			var result = HighLow(new int[] { 1, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7 }, 1);
		}


		private static int FindLow(int[] arr, int key)
		{
			int low = 0;
			int high = arr.Length -1;
			int mid = high / 2;


			while(low <= high)
			{
				var midValue = arr[mid];

				if (midValue < key)
					low = mid + 1;
				else
					high = mid - 1;

				mid = low + (high - low) / 2;
			}

			if (low < arr.Length && arr[low] == key)
				return low;

			return -1;
		}

		private static int FindHigh(int[] arr, int key)
		{
			int low = 0;
			int high = arr.Length - 1;
			int mid = high / 2;

			while(low <= high)
			{
				var midValue = arr[mid];

				if (midValue <= key)
					low = mid + 1;
				else
					high = mid - 1;

				mid = low + (high - low) / 2;
			}

			if (high < arr.Length && arr[high] == key)
				return high;

			return -1;
		}

		private static (int,int) HighLow(int[] arr, int key)
		{

			int low = FindLow(arr, key);
			int high = FindHigh(arr, key);

			return (low, high);


			//[index][value]
			//[0][1]
			//[1][1]
			//[2][1]
			//time complexity: O(log(n))
			//space complexity: O(n)
			var result = (-1, -1);

			Dictionary<int, int> dictionary = new Dictionary<int, int>();

			int index = 0;
			foreach (var num in arr)
			{
				dictionary.Add(index, num);
				++index;
			}
			
			var list = dictionary.Where(x => x.Value == key).ToList();

			if (list.Count == 0)
				return result;
			else if (list.Count == 1)
				return (list[0].Key, list[0].Key);
			else
				return (list[0].Key, list[list.Count -1].Key);



			//time complexity: O(n) where n is size of arr
			//space complexity: O(1)
			//int low = -1;
			//int high = -1;
			bool isFirstInstance = true;

			//loop through arr checking if key matches
			//if the key is higher continue
			//if the key is the value & is first instance set low
			//if the key is the value & not the first instance we will set the high
			//repeat until the key is higher than the value

			for (int i = 0; i < arr.Length; ++i)
			{
				if (key > arr[i])
					continue;
				if (key == arr[i] && isFirstInstance)
				{
					low = i;
					high = i;
					isFirstInstance = false;
				}
				else if (key == arr[i])
					high = i;
				if (key < arr[i])
					break;
			}

			return (low, high);
		}

	}
}
