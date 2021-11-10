using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
	/// <summary>
	/// https://www.geeksforgeeks.org/difference-between-bfs-and-dfs/
	/// </summary>
	public static class Castle_On_The_Grid
	{
		private static int[,] map;
		private static int row;
		private static int column;
		private static HashSet<(int, int)> visited;
		//key in dictionary is a node & the value is the previous node that way you can trace it back to the start
		//while not start node then previous = previous[previous]
		private static Dictionary<(int, int), (int, int)> previous = new Dictionary<(int, int),(int, int)>();
		public static void DoSomething()
		{
			minimumMoves(new List<string>() {
			".X..XX...X",
			"X.........",
			".X.......X",
			"..........",
			"........X.",
			".X...XXX..",
			".....X..XX",
			".....X.X..",
			"..........",
			".....X..XX" }, 9, 1, 9, 6);
		}

		public static int minimumMoves(List<string> grid, int startX, int startY, int goalX, int goalY)
		{
			row = grid[0].Length;
			column = grid.Count;
			map = new int[row, column];

			visited = new HashSet<(int, int)>();
			Queue<(int, int)> process = new Queue<(int, int)>();


			for (int i = 0; i < grid.Count; i++)
			{
				for (int j = 0; j < grid.Count; j++)
				{
					map[i,j] = grid[i][j] == 'X' ? 1 : 0;
				}
			}

			visited.Add((startX, startY));
			process.Enqueue((startX, startY));

			while (process.Count > 0)
			{
				var root = process.Dequeue();
				
				var unvisitedNeighbors = GetUnvisitedNeighbors(root);

				foreach (var neighbor in unvisitedNeighbors)
				{
					if (goalX == neighbor.Item1 && goalY == neighbor.Item2)
					{
						int count = 2;
						var current = previous[root];
						while(current.Item1 != startX || current.Item2 != startY)
						{
							++count;
							current = previous[current];
						}
						return count;
					}
					process.Enqueue((neighbor.Item1, neighbor.Item2));
					previous[neighbor] = root;
				}

			}
			return 0;
		}

		private static List<(int, int)> GetUnvisitedNeighbors((int x, int y) coord)
		{
			List<(int, int)> neighbors = new List<(int, int)>();
			List<(int, int)> newNeighbors = new List<(int, int)>();
			int x = coord.x;
			int y = coord.y;

			//get right neighbors
			for (int i = x + 1; i < row; i++)
			{
				if (map[i,y] == 0)
				{
					neighbors.Add((i, y));
				}
				else if (map[i,y] == 1)
				{
					break;
				}
			}
			//get left neighbors
			for (int i = x - 1; i >= 0; i--)
			{
				if (map[i, y] == 0)
				{
					neighbors.Add((i, y));
				}
				else if (map[i, y] == 1)
				{
					break;
				}
			}
			//get above neighboors
			for (int i = y + 1; i < column; i++)
			{
				if (map[x, i] == 0)
				{
					neighbors.Add((x, i));
				}
				else if (map[x,i] == 1)
				{
					break;
				}
			}
			for (int i = y - 1; i >= 0; i--)
			{
				if (map[x, i] == 0)
				{
					neighbors.Add((x, i));
				}
				else if (map[x, i] == 1)
				{
					break;
				}
			}

			foreach (var neighbor in neighbors)
			{
				if (!visited.Contains((neighbor.Item1, neighbor.Item2)))
				{
					visited.Add((neighbor.Item1, neighbor.Item2));
					newNeighbors.Add((neighbor.Item1, neighbor.Item2));
				}
				
			}

			return newNeighbors;
		}



	}//
}//
