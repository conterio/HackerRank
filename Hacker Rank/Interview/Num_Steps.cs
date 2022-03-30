using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class Num_Steps
	{

		/*
		 
		steps 1,2 (how many steps you can take)

		        __________
		      __|4   |   1|__
		    __|3     |      2|__
		  __|2       |         3|__
		__|1         |            4|____


		c[0] = 1 [0, 0]
		c[1] = 1 [0, 1]
		c[2] = 2 [0,1,2], [0,2]
		c[3] = 3 [0,1,2,3], [0,1,3], [0,2,3]
		c[4] = 5 [0,1,2,3,4], [0,1,2,4], [0,1,3,4] [0,2,3,4], [0,2,4]
		c[5] = 8
		c[6] = 13

		This is fibbinaci

		*/
		internal static void DoSomething()
		{
			int n = 4;
			int[] set = new int[] { 1, 2, 3 };

			var result = NumSteps1(n, set);
		}

		public static int NumSteps1(int numberOfStairs, int[] steps)
		{
			int[] cache = new int[numberOfStairs + 1];
			
			cache[0] = 1;

			for (int i = 0; i < numberOfStairs + 1; i++)
			{
				int sum = 0;
				foreach (var step in steps)
				{
					if (i - step >= 0)
						sum += cache[i - step];
				}
				cache[i] += sum;
			}

			return cache[numberOfStairs];
		}


		public static int NumSteps(int numberOfStairs, int[] steps)
		{

			if (numberOfStairs < 0)
				return 0;
			else if (numberOfStairs == 0  || numberOfStairs == 1)
				return 1;
			else
			{
				int sum = 0;
				foreach (var step in steps)
				{
					sum += NumSteps(numberOfStairs - step, steps);
				}
				return sum;
			}
		}


	}
}
