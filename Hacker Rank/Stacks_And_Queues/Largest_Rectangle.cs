using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
	public static class Largest_Rectangle
	{

		public static void DoSomething()
		{
			List<int> h = new List<int>() { 11, 11, 10, 10, 10 };

			var max = largestRectangle(h);
		}

		public static long largestRectangle(List<int> h)
		{
			int max = 0;
			int ahead = 0;
			int behind = 0;

			for (int i = 0; i < h.Count; i++)
			{
				//go forward until you hit lower
				for (int forward = i + 1; forward < h.Count; forward++)
				{
					if (h[forward] >= h[i])
					{
						++ahead;
					}
					else
					{
						break;
					}
				}
				//go backwards until you hit lower
				for (int backward = i - 1; backward >= 0; backward--)
				{
					if (h[backward] >= h[i])
					{
						++behind;
					}
					else
					{
						break;
					}
				}

				//find current rectangle based on what building you are at
				var current = h[i] * (ahead + behind) + h[i];
				ahead = 0;
				behind = 0;
				max = Math.Max(max, current);
			}

			return max;
		}



	}//
}//
