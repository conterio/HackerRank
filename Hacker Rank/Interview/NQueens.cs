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
            int dim;

			for (int i = 0; i < 100; ++i)
			{
                int[,] board = new int[i, i];
                var result = SolveNQueens(board, 0);

                Console.WriteLine($"{i}x{i} is {result}");
            }
            

        }


		private static bool SolveNQueens(int[,] board, int col)
        {
            int n = board.GetLength(0);
            /* base case: If all queens are placed
            then return true */
            if (col >= n)
                return true;

            /* Consider this column and try placing
            this queen in all rows one by one */
            for (int i = 0; i < n; i++)
            {
                /* Check if the queen can be placed on
                board[i,col] */
                if (isSafe(board, i, col))
                {
                    /* Place this queen in board[i,col] */
                    board[i, col] = 1;

                    /* recur to place rest of the queens */
                    if (SolveNQueens(board, col + 1) == true)
                        return true;

                    /* If placing queen in board[i,col]
                    doesn't lead to a solution then
                    remove queen from board[i,col] */
                    board[i, col] = 0; // BACKTRACK
                }
            }

            /* If the queen can not be placed in any row in
            this column col, then return false */
            return false;
        }


        private static bool isSafe(int[,] board, int row, int col)
        {
            int n = board.GetLength(0);
            int i, j;

            /* Check this row on left side */
            for (i = 0; i < col; i++)
                if (board[row, i] == 1)
                    return false;

            /* Check upper diagonal on left side */
            for (i = row, j = col; i >= 0 &&
                 j >= 0; i--, j--)
                if (board[i, j] == 1)
                    return false;

            /* Check lower diagonal on left side */
            for (i = row, j = col; j >= 0 &&
                          i < n; i++, j--)
                if (board[i, j] == 1)
                    return false;

            return true;
        }


    }
}
