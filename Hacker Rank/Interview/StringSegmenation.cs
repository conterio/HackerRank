using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class StringSegmenation
	{
		public static void DoSomething()
		{
			//Segmenation("foobarbuzzPop", new HashSet<string>() { "bar", "buzz", "foo" });
			reverseString(new char[] {'t','e','s','t','i','n','g' });
		}

		//input string must be fully in the dictionary, but the dictionary doesn't need to all be used up
		private static bool Segmenation(string input, HashSet<string> hash)
		{
			if (hash.Contains(input))
			{
				return true;
			}

			for (int i = 0; i < input.Length; ++i)
			{
				string comparision = input.Substring(0, i);
				if (hash.Contains(comparision))
				{
					string restOfstring = input.Substring(i);
					return Segmenation(restOfstring, hash);
				}
			}

			return false;
		}

		//time = O(n) memory = O(1)
		private static void reverseString(char[] input)
		{
			var split = input.ToString().Split(' ');

			string result = "";


			//t    e    s    t
			//0000 0001 0002 0003

			//swap
			//int a = first char;
			//int b = last char;
			//swap
			//int temp = a;
			//a = b;
			//b = temp;

			foreach (var word in split)
			{
				result += new string(word.Reverse().ToArray() + " ");
			}

			result = result.Trim();
		}

		//hello world
		//dlrow olleh
		//olleh dlrow
	}
}
