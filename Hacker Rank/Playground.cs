using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
	public static class Playground
	{

		public static void DoSomething()
		{
			//I want to see what index has the most items biggest to the right

			int[] arr = new int[] {1,2,3,4,5,0,9,8,7,6 };
			Stack<int> stack = new Stack<int>();
			int[] counts = new int[arr.Length];
			stack.Push(1);
		

			for (int i = 0; i < arr.Length; i++)
			{
				int currentCount = 0;

				while (stack.Count > 0)
				{
					if (arr[i] < arr[stack.Peek()])
					{
						++currentCount;
						//stack.p
					}
				}

			}




		}

	}




}


/* stack playground
 * //go forward until I hit something lower
			int[] arr = new int[] { 6, 3, 1, 2, 5, 4, 0 };
			int[] dis = new int[arr.Length];
			Stack<int> stack = new Stack<int>();

			//1 1 4 3 1 1 0

			for (int index = arr.Length - 1; index >= 0;  index--)
			{
				while (stack.Count > 0 && arr[stack.Peek()] > arr[index])
				{
					stack.Pop();
				}

				if (stack.Count > 0)
				{
					dis[index] = stack.Peek();
				}


				stack.Push(index);
			}

			for (int i = 0; i < dis.Length; i++)
			{
				dis[i] = dis[i] - i;
			}
*/