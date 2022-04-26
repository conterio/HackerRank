using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
	public static class Balanced_Brackets
	{
		public static void DoSomething()
		{
			var result = IsBalanced("{[()]}");
		}
		public static string IsBalanced(string s)
		{

			if (s.StartsWith("}") || s.StartsWith("]") || s.StartsWith(")"))
			{
				return "NO";
			}

			Stack<char> stack = new Stack<char>();

			foreach (var character in s)
			{
				char top = ' ';
				if (stack.Count > 0)
					top = stack.Peek();
				switch (character)
				{
					case '{':
						stack.Push(character);
						break;

					case '[':
						stack.Push(character);
						break;

					case '(':
						stack.Push(character);
						break;

					case '}':
						if (top != '{')
							return "NO";
						else
							stack.Pop();
						break;
					case ']':
						if (top != '[')
							return "NO";
						else
							stack.Pop();
						break;
					case ')':
						if (top != '(')
							return "NO";
						else
							stack.Pop();
						break;
					default:
						throw new Exception("Invalid Input String");
				}
			}
			if (stack.Count > 0)
			{
				return "NO";
			}
			return "YES";
			
		}




	}
}
