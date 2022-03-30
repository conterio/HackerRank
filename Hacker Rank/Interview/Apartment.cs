using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class Apartment
	{
		public static void DoSomething()
		{

			Block[] blocks = new Block[]
			{
				new Block(true, false, false),
				new Block(false, false, true),
				new Block(false, true, false),
				new Block(true, false, false),
			};

			string[] req = new string[]
			{
				"gym",
				"school",
				"store"
			};

			var result = FindBlock(blocks, req);

		}




		public static int FindBlock(Block [] blocks, string [] requirements)
		{
			int blockCount = blocks.Length;
			int weight = 0;
			List<string> reqList = new List<string>(requirements);
			List<int> blockWeight = new List<int>();

			for (int i = 0; i < blockCount; i++)
			{

				foreach (var req in reqList)
				{
					if (HasReq(blocks[i], req))
					{
						reqList.Remove(req);
					}
				}

				if (reqList.Count <= 0)
				{
					return i;
				}

				for (int j = 1; j < blockCount; j++)
				{
					
					foreach (var req in reqList)
					{
						if (HasReq(blocks[j], req))
						{
							weight += 1;
							reqList.Remove(req);
						}
					}

					if (reqList.Count <= 0)
					{
						blockWeight[i] = weight;
						weight = 0;
						reqList = new List<string>(requirements);
						break;
					}
				}
				blockWeight[i] = int.MaxValue;
			}

			int value = blockWeight.Min();
			return blockWeight.IndexOf(value);

		}

		private static bool HasReq(Block block, string req)
		{
			switch (req)
			{
				case "gym":
					return block.Gym;
				case "school":
					return block.School;
				case "store":
					return block.Store;
				default:
					return false;
			}
		}

		public class Block
		{
			public Block(bool gym, bool school, bool store)
			{
				Gym = gym;
				School = school;
				Store = store;
			}

			public bool Gym { get; set; }
			public bool School { get; set; }
			public bool Store { get; set; }
		}



		
	}
}
