using Stacks_and_Queues;
using Stacks_And_Queues;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Test
{
	public class Poisonous_plants_Should
	{
		public StreamReader input;
		public StreamReader answers;
		public Poisonous_plants_Should()
		{

		}

		public static IEnumerable<object[]> Data => new List<object[]>
		{
			new object[] { new List<int>() { 6, 5, 8, 4, 7, 10, 9 }, 2 },
			new object[] { new List<int>() { 6, 5, 8, 4, 7, 10, 9 }, 2 },
			new object[] { new List<int>() { 6, 5, 8, 4, 7, 10, 9 }, 2 },
			new object[] { new List<int>() { 6, 5, 8, 4, 7, 10, 9 }, 2 },

		};


		//poisonousPlants(new List<int>() { 6, 5, 8, 4, 7, 10, 9 }); //2
		//poisonousPlants(new List<int>() { 1,1,1,1,1,1 });//0
		//poisonousPlants(new List<int>() { 20, 5, 6, 15, 2, 2, 17, 2, 11, 5, 14, 5, 10, 9, 19, 12, 5 });//4
		//poisonousPlants(new List<int>() { 1, 20, 5, 10, 11, 12 });//2
		[Theory]
		//[InlineData(new List<int>() { 6, 5, 8, 4, 7, 10, 9 }, 2)]
		//[InlineData(new List<int>() {1,2 })]
		[MemberData(nameof(Data))]
		
		public void Handle_These_Cases(List<int> list, int expectedDays)
		{
			var result = Poisonous_Plants.poisonousPlants(list);

			Assert.Equal(expectedDays, result);
		}


		







	}//
}//
