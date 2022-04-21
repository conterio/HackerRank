using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class FileLookUp
	{

		public static void DoSomething()
		{
			var results = GetFiles(@"D:\Test", "file");
		}


		//time complexity O(1) space complexity O(n)
		private static List<string> GetFiles(string path, string search)
		{
			var results = new List<string>();
			var files = Directory.GetFiles(path);
			var matchedFiles = files.Where(x => x.ToLower().Contains(search.ToLower())).ToList();
			results.AddRange(matchedFiles);


			var directories = Directory.GetDirectories(path);

			if (directories.Length > 0)
			{
				foreach (var dir in directories)
				{
					results.AddRange(GetFiles(dir, search));
				}
			}

			return results;
		}
	}
}
