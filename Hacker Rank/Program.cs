using Stacks_And_Queues;
using String_Manipulation;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Stacks_and_Queues.Arrays;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stacks & Queues
            //Run_Balanced_Brackets();
            //Run_Two_Stacks();
            //Run_Largest_Rectangle();
            //Run_Min_Max_Riddle();
            //Run_Castle_On_The_Grid();
            //Run_Poisonous_Plants();

            //Arrays
            //Run_New_Year_Chaos();
            Run_Array_Manipulation();

            //String Manipulation
            //Run_Making_Anagrams();
            //Run_Alternating_Characters();


            //Playground.DoSomething();

        }

		private static void Run_Array_Manipulation()
		{
            Array_Manipulation.DoSomething();

        }

		private static void Run_New_Year_Chaos()
		{
            New_Year_Chaos.DoSomething();
		}

		private static void Run_Poisonous_Plants()
		{
            Poisonous_Plants.DoSomething();

        }

		private static void Run_Alternating_Characters()
		{
            Alternating_Characters.DoSomething();
		}

		private static void Run_Making_Anagrams()
		{
            Making_Anagrams.DoSomething();
		}

		private static void Run_Castle_On_The_Grid()
		{
            Castle_On_The_Grid.DoSomething();
		}

		private static void Run_Min_Max_Riddle()
		{
            Min_Max_Riddle.DoSomething();
		}

		private static void Run_Largest_Rectangle()
		{
            Largest_Rectangle.DoSomething();
		}

		private static void Run_Two_Stacks()
		{
            StreamReader input = new StreamReader(@"two_stacks.txt");
            var count = int.Parse(input.ReadLine());
            for (int i = 0; i < count; ++i)
            {
                var line = input.ReadLine();
                A_Tale_Of_Two_Stacks.DoSomething(line);
            }
        }

		private static void Run_Balanced_Brackets()
		{
            var result = Balanced_Brackets.isBalanced("{[()]}");
        }



	}//
}//



/*
        string line;
        while ((line = Console.ReadLine()) != null && line != "") {}
*/
