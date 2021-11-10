using Stacks_and_Queues;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Test
{
	public class Balanced_Brackets_Should
	{
		public StreamReader input;
		public StreamReader answers;
		public Balanced_Brackets_Should()
		{
			input = new StreamReader(@"input.txt");
			answers = new StreamReader(@"answers.txt");
		}

		[Theory]
		[InlineData("{{}(", "NO")]
		public void Handle_Case_With_Extra_Characters(string s, string expected)
		{
			var result = Balanced_Brackets.isBalanced(s);

			Assert.Equal(expected, result);
		}


		[Fact]
		public void Run_Balanced_Brackets()
		{
			var count = File.ReadLines(@"input.txt").Count();

			for (int i = 0; i < count; ++i)
			{
				var inputLine = input.ReadLine();
				var answerLine = answers.ReadLine();

				var result = Balanced_Brackets.isBalanced(inputLine);

				Assert.Equal(answerLine, result);
			}
		}







	}//
}//
