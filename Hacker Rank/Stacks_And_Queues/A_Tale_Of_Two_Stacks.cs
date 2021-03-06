using System;
using System.Collections.Generic;
using System.IO;

namespace Stacks_and_Queues
{
	public static class A_Tale_Of_Two_Stacks
	{

		public static void DoSomething()
		{
			StreamReader input = new StreamReader(@"two_stacks.txt");
			var count = int.Parse(input.ReadLine());
			for (int i = 0; i < count; ++i)
			{
				var line = input.ReadLine();
				TwoSTacks(line);
			}
		}


		//enque stack just takes in the pushed items
		public static Stack<int> EnqueStack = new Stack<int>();
		//deque just peeks and pops
		public static Stack<int> DequeStack = new Stack<int>();
		
		private static void TwoSTacks(string line)
		{
			var items = line.Split(' ');

			switch (items[0])
			{
				case "1":
					Put(int.Parse(items[1]));
					break;
				case "2":
					Pop();
					break;
				case "3":
					Peek();
					break;
			}

		}

		public static void Put(int n)
		{
			EnqueStack.Push(n);
		}

		public static void Pop()
		{
			if (DequeStack.Count == 0)
			{
				EnqueToDequeStacks();
			}
			DequeStack.Pop();
		}

		public static void Peek()
		{
			
			if (DequeStack.Count == 0)
			{
				EnqueToDequeStacks();
			}
			Console.WriteLine(DequeStack.Peek());
		}

		// We only want to reverse the first stack when the 2nd stack is empty.
		public static void EnqueToDequeStacks()
		{
			while (EnqueStack.Count > 0)
			{
				DequeStack.Push(EnqueStack.Pop()); //pop off the enque stack to empty it out & populate the deque stack
			}
		}



	}//
}//
