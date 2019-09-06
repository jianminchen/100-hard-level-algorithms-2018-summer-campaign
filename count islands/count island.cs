using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[3, 3] { {1,2,3},{2, 2,3},{3, 3,3}};
            var islandCount = CountIslands(matrix); 
        }

        /// <summary>
        /// count how many islands
        /// assuming that values are bigger than 0
        /// using -1 to mark visit in the array
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int CountIslands(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return 0; 
            }

            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);

            var islandCount = 0; 

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var visit = matrix[row, col];
                    if (visit == -1) // visited
                    {
                        continue; 
                    }

                    runDFS(matrix, rows, columns, row, col, visit);
                    islandCount++; 
                }
            }

            return islandCount; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <param name="origin"></param>
        private static void runDFS(int[,] matrix, int rows, int columns, int currentRow, int currentCol, int origin)
        {
            // base case
            if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= columns || matrix[currentRow, currentCol] == -1 || matrix[currentRow, currentCol] != origin)
            {
                return; 
            }

            // mark visited
            matrix[currentRow, currentCol] = -1;

            runDFS(matrix, rows, columns, currentRow,     currentCol - 1, origin); // left
            runDFS(matrix, rows, columns, currentRow,     currentCol + 1, origin); // right
            runDFS(matrix, rows, columns, currentRow - 1, currentCol, origin); // up
            runDFS(matrix, rows, columns, currentRow + 1, currentCol, origin); // down
        }
    }
}
