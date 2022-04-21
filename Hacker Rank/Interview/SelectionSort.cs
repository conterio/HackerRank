using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class SelectionSort
	{
		public static void DoSomething()
		{
			var arr = new int[] { 4, 11, 6, 13, 10 };
			arr = Sort(arr);
		}

		//memory complexity O(n)
		private static int[] Sort(int[] arr)
		{
			if (arr == null)
				return null;
			if (arr.Length == 0 || arr.Length == 1)
				return arr;

			int n = arr.Length;

			for (int i = 0; i < n - 1; i++)
			{
				int index = i;
				for (int j = i + 1; j < n; j++)
					if (arr[j] < arr[index])
						index = j;

				int smallerNumber = arr[index];
				arr[index] = arr[i];
				arr[i] = smallerNumber;
			}


			List<int> sortedGroup = new List<int>();  //-> some address on the heap []
			List<int> unsortedGroup = new List<int>(arr);

			while (unsortedGroup.Count > 0)
			{
				var smallest = unsortedGroup.Min();
				sortedGroup.Add(smallest);
				unsortedGroup.Remove(smallest);
			}
			
			return sortedGroup.ToArray();
		}


	}
}
