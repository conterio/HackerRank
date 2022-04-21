using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class NQueens
	{
		public static void DoSomething()
		{

			for (int i = 0; i < 100; ++i)
			{
                int[,] board = new int[i, i];
                var result = SolveNQueens(board);

                Console.WriteLine($"{i}x{i} is {result}");
            }
            

        }


		private static bool SolveNQueens(int[,] board, int col = 0)
        {
            int n = board.GetLength(0);

            if (col == n)
                return true;

            for (int i = 0; i < n; i++)
            {

                if (isSafe(board, i, col))
                {
                    board[i, col] = 1;

                    if (SolveNQueens(board, col + 1) == true)
                        return true;

                    board[i, col] = 0;
                }
            }

            return false;
        }


        private static bool isSafe(int[,] board, int row, int col)
        {
            int n = board.GetLength(0);
            int i, j;

            /* Check this row on left side */
            for (i = col; i >= 0; i--)
            {
                if (board[row, i] == 1)
                    return false;
            }

            /* Check upper diagonal on left side */
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            /* Check lower diagonal on left side */
            for (i = row, j = col; j >= 0 && i < n; i++, j--)
                if (board[i, j] == 1)
                    return false;

            return true;
        }


    }
}
