using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIslandByShape_IdeaII
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[2, 4] { { 1, 2, 3, 4 }, { 2, 2, 4, 4 } };
            var islandCount = CountIslandByShape(matrix);
        }

        /// <summary>
        /// count how many islands
        /// assuming that values are bigger than 0
        /// using -1 to mark visit in the array
        /// 
        /// For example, 
        /// 1 2 3 4
        /// 2 2 4 4
        /// Two islands are the same
        /// 1 and 3
        /// Another two islands are the same since they have same shape
        ///   2
        /// 2 2
        /// and 
        ///   4
        /// 4 4
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int CountIslandByShape(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return 0;
            }

            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            var shapes = new HashSet<string>(); 

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

                    var shape = new StringBuilder();
                    
                    runDFS(matrix, rows, columns, row, col, visit, shape, 'C');

                    var current = shape.ToString(); 
                    if(shapes.Contains(current))
                    {
                        continue;
                    }
                    else
                    {
                        shapes.Add(current); 
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        /// <summary>
        /// Shape can be defined by DFS direction using serialized string 
        /// CDL - current -> Down -> Left
        /// Four directions - L, R, U, D
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <param name="origin"></param>
        private static void runDFS(int[,] matrix, int rows, int columns, int currentRow, int currentCol, int origin, StringBuilder shape, char direction)
        {
            // base case
            if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= columns || matrix[currentRow, currentCol] == -1 || matrix[currentRow, currentCol] != origin)
            {
                return;
            }

            // mark visited
            matrix[currentRow, currentCol] = -1;

            // append direction
            shape.Append(direction.ToString()); 

            runDFS(matrix, rows, columns, currentRow, currentCol - 1, origin, shape, 'L'); // left
            runDFS(matrix, rows, columns, currentRow, currentCol + 1, origin, shape, 'R'); // right
            runDFS(matrix, rows, columns, currentRow - 1, currentCol, origin, shape, 'U'); // up
            runDFS(matrix, rows, columns, currentRow + 1, currentCol, origin, shape, 'D'); // down
        }
    }
}
