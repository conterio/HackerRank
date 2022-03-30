using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class _2Sum
	{
		static _2Sum()
		{
			int[] nums = new int[] { 3, 7, 5, 1, 8, 9, 6, 2 };
			var length = nums.Length;
			int target = 16;
			int[] indices = new int[2];

			//key - index value
			//value = index

			Dictionary<int, int> results = new();

			//T: O(n) Space complexitity: O(n)
			for (int i = 0; i < length; i++)
			{
				int first = nums[i];
				int second = target - first;

				if (results.TryGetValue(second, out int value))
				{
					indices = new[] { value, i };
				}

				results[first] = i;
			}




			//Time complexitity: Space complexitity: O(2^n) O(1)

			//for (int i = 0; i < nums.Length; i++)
			//{
			//	for (int j = 0; j < nums.Length; j++)
			//	{
			//		if (nums[i] + nums[j] == target)
			//		{
			//			indices[0] = i;
			//			indices[1] = j;
			//		}
			//	}
			//}

			Console.WriteLine(indices);
		}
	}
}
