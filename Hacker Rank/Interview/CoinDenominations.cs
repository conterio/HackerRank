using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class CoinDenominations
	{
		public static void DoSomething()
		{
			Coin_Denominations(new int[] {1,2 },4);
		}
		//1 1 1 1 1
		//1 1 2
		//2 2


		private static int Coin_Denominations(int [] denominations, int amount)
		{
			int[] solution = new int[amount + 1];
			solution[0] = 1;

			foreach (var den in denominations)
			{
				for (int i = den; i < amount + 1; ++i)
				{
					solution[i] += solution[i - den];
				}
			}

			return solution[amount];
		}

	}
}