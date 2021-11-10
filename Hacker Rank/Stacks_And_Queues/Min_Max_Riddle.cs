using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
	public static class Min_Max_Riddle
	{
		
		public static void DoSomething()
		{
			long[] arr = new long[] {2, 6, 1, 12 };

			var result = riddle(arr);
		}

		//2 2 4 4
		//-1 0 -1 2
		//2 1 4 1

		//stack
		//2  -> list of ints
		//6
		//1
		//12

		//2 6
		//6 1
		//1 12

		//2 6 1
		//6 1 12

		//2 6 1 12
		public static long[] riddle(long[] arr)
		{
            int n = arr.Length;
            // Used to find previous and next smaller
            Stack<int> myStack = new Stack<int>();

            // Arrays to store previous
            // and next smaller
            int[] left = new int[n];
            int[] right = new int[n];

            // Initialize elements of left[]
            // and right[]
            for (int i = 0; i < n; i++)
            {
                left[i] = -1;
                right[i] = n;
            }

            //1 2 3 4 5
            // Fill elements of left[] using logic discussed on
            // https://www.geeksforgeeks.org/next-greater-element/
            for (int i = 0; i < n; i++)
            {
                while (myStack.Count > 0 && arr[myStack.Peek()] >= arr[i])
                {
                    myStack.Pop();
                }

                if (myStack.Count > 0)
                {
                    left[i] = myStack.Peek();
                }

                myStack.Push(i);
            }

            // Empty the stack as stack is going
            // to be used for right[]
            while (myStack.Count > 0)
            {
                myStack.Pop();
            }

            // Fill elements of right[] using
            // same logic
            for (int i = n - 1; i >= 0; i--)
            {
                while (myStack.Count > 0 && arr[myStack.Peek()] >= arr[i])
                {
                    myStack.Pop();
                }

                if (myStack.Count > 0)
                {
                    right[i] = myStack.Peek();
                }

                myStack.Push(i);
            }

            // Create and initialize answer array
            long[] ans = new long[n + 1];
            for (int i = 0; i <= n; i++)
            {
                ans[i] = 0;
            }

            // Fill answer array by comparing
            // minimums of all lengths computed
            // using left[] and right[]
            for (int i = 0; i < n; i++)
            {
                // length of the interval
                int len = right[i] - left[i] - 1;

                // arr[i] is a possible answer for
                // this length 'len' interval, check x
                // if arr[i] is more than max for 'len'
                ans[len] = Math.Max(ans[len], arr[i]);
            }

            // Some entries in ans[] may not be
            // filled yet. Fill them by taking
            // values from right side of ans[]
            for (int i = n - 1; i >= 1; i--)
            {
                ans[i] = Math.Max(ans[i], ans[i + 1]);
            }

            // Print the result
            for (int i = 1; i <= n; i++)
            {
                Console.Write(ans[i] + " ");
            }
            var temp = ans.Skip(1).ToArray();
            return ans;
        }


		public static long[] riddle1(long[] arr)
		{
			List<long> answers = new List<long>();
			Stack<List<long>> windows = new Stack<List<long>>();
			int n = arr.Length;

			for (int i = 1; i < n + 1; i++)
			{
				//create window
				for (int j = 0; j < n + 1 - i; j++)
				{
					var temp = arr.Skip(j).Take(i).ToList();
					windows.Push(temp);
				}

				long maxOfMin = 0;
				//get min of each window
				while (windows.Count > 0)
				{
					var window = windows.Pop();
					var min = window.Min();
					maxOfMin = Math.Max(maxOfMin, min);
				}

				//get max of the min
				answers.Add(maxOfMin);
			}


			return answers.ToArray();

		}





	}
}
