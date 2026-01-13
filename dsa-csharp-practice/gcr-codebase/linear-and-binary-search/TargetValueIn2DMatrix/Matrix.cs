using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.TargetValueIn2DMatrix
{
    internal class Matrix
    {
        int[,] matrix;
        int Rows;
        int Cols;

        public void Input()
        {
            Console.WriteLine("Enter the Rows of matrix");
            Rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Coloumns of matrix");
            Cols = int.Parse(Console.ReadLine());

            matrix = new int[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.WriteLine("Enter the Number of matrix");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void FindTarget()
        {
            Input();
            Console.WriteLine("Enter the Target Value");
            int target = int.Parse(Console.ReadLine());

            int left = 0, right = Rows * Cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int row = mid / Cols;
                int col = mid % Cols;

                if (matrix[row, col] == target)
                {
                    Console.WriteLine($"Target Found! , {matrix[row, col]}");
                    return;
                }

                else if (matrix[row, col] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine("Target Was not Found");
        }
    }
}
