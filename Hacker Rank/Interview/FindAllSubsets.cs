using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class FindAllSubsets
	{
		public static void DoSomething()
		{
			List<char> list = new List<char>() { '☼', '¥', '♂' };
			List<HashSet<char>> sets = new List<HashSet<char>>();

			FindSubsets(list, sets);

			//[0] = {}
			//[1] = {1}
			//[2] = {2}
			//[3] = {1,2}
			//[4] = {1,3}
			//[5] = {2, 3}
			//[6] = {3}
			//[7] = {1,2,3}
		}

		//time and space complexity are
		//O(n * 2^n) n number of items in our list & m number of sub sets 2^n
		private static void FindSubsets(List<char> list, List<HashSet<char>> sets)
		{
			sets.Add(new HashSet<char>());
			int numberOfSubsets = (int)Math.Pow(2, list.Count);
			
			for (int i = 1; i < numberOfSubsets; ++i)
			{
				HashSet<char> set = new HashSet<char>();
				for (int j = 0; j < list.Count; ++j)
				{
					if (get_bit(i, j) == 1)
					{
						char x = list[j];
						set.Add(x);
					}
				}
				sets.Add(set);
			}
		}

		private static int get_bit(int num, int bit)
		{
			int temp = (1 << bit);
			temp = temp & num;
			if (temp == 0)
			{
				return 0;
			}
			return 1;
		}

	}
}
