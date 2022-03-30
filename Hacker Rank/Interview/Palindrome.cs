using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class Palindrome
	{

		static string str = "racecar";




		public static void DoSomething()
		{
			IsPalindrome(str);
		}


		private static bool IsPalindrome(string str)
		{
			var reversedstr = new String(str.Reverse().ToArray());



			var result = str.SequenceEqual(str.Reverse());

			return result;
		}

	}
}
