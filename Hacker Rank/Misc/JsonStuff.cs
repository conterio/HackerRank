using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Misc
{
	public static class JsonStuff
	{
		public static void DoSomething()
		{
			List<List<string>> data = new List<List<string>>()
			{
				new List<string>() { "Tom",	"25", "Blonde" },
				new List<string>() { "Tom", "25", "Blonde" },
				new List<string>() { "Tom", "25", "Blonde" },
				new List<string>() { "Tom", "25", "Blonde" },
			};

			var json = ConvertToJsonObject(data);
		}


		private static string ConvertToJsonObject(List<List<string>> obj)
		{


			return "";
		}
		
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string HairColor { get; set; }
	}
}
