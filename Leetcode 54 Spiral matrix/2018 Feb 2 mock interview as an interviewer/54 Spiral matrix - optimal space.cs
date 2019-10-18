using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTestcase();
        }

        public static void RunTestcase()
        {
            var spiral = MatrixSpiralPrint(new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } });
            Debug.Assert(String.Join(",", spiral).CompareTo("123456789") == 0);
        }

        /// <summary>
        /// Leetcode 54: Spiral Matrix
        /// Using directions array for four directions, and then use four variables 
        /// to set up boundary of the matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[] MatrixSpiralPrint(int[,] matrix)
        {
            if (matrix == null)
            {
                return new int[0];
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            var spiral = new int[rows * columns];

            var directions = new int[4, 2] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

            if (rows == 0 || columns == 0)
            {
                return spiral;
            }

            int top = 0;
            int bottom = rows - 1;
            int left = 0;
            int right = columns - 1;

            int total = rows * columns;
            int index = 0;
            int x = 0, y = 0;

            int direction = 0;

            while (index < total)
            {
                spiral[index++] = matrix[x, y];

                int newX = x + directions[direction, 0];
                int newY = y + directions[direction, 1];

                var isInRange = newX >= top && newX <= bottom && newY >= left && newY <= right;

                if (!isInRange)
                {
                    switch (direction)
                    {
                        case 0:
                            top++;
                            break;
                        case 1:
                            right--;
                            break;
                        case 2:
                            bottom--;
                            break;
                        case 3:
                            left++;
                            break;
                    }

                    direction = (direction + 1) % 4;
                }

                x += directions[direction, 0];
                y += directions[direction, 1];
            }

            return spiral;
        }
    }
}