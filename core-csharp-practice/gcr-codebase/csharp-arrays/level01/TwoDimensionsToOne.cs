using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.arrays.level01
{
    internal class TwoDimensionsToOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the rows ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coloumns");
            int coloumns = int.Parse(Console.ReadLine());

            int[,] twoD = new int[rows, coloumns];
            int[] oneD = new int[rows * coloumns];

            int idx = 0;

            // Taking input from user for the matrix
            Console.WriteLine("\nEnter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumns; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    twoD[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //copying elements of 2d array to one d array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumns; j++)
                {
                    oneD[idx] = twoD[i, j];
                    idx++;
                }
            }

            // displaying the 2d array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumns; j++)
                {
                    Console.Write(twoD[i, j] + " ");
                }

            }

            // Displaying the 1D array
            Console.WriteLine("\n1D Array Elements:");
            for (int i = 0; i < oneD.Length; i++)
            {
                Console.Write(oneD[i] + " ");
            }
        }
    }
}
