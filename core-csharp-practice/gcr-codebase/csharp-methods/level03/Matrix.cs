using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Matrix
{
    internal class MatrixProgram
    {
        // Method to create a random matrix
        public static double[,] CreateRandomMatrix(int rows, int cols)
        {
            double[,] m = new double[rows, cols];
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = r.Next(1, 10);
                }
            }
            return m;
        }

        // Method to add two matrices
        public static double[,] Add(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[i, j] = A[i, j] + B[i, j];
                }
            }
            return result;
        }

        // Method to subtract two matrices
        public static double[,] Subtract(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[i, j] = A[i, j] - B[i, j];
                }
            }
            return result;
        }

        // Method to multiply two matrices
        public static double[,] Multiply(double[,] A, double[,] B)
        {
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);
            int c2 = B.GetLength(1);

            double[,] result = new double[r1, c2];

            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < c1; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        // Method to find transpose of a matrix
        public static double[,] Transpose(double[,] A)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] T = new double[c, r];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    T[j, i] = A[i, j];
                }
            }
            return T;
        }

        // Method to find determinant of a 2x2 matrix
        public static double Determinant2x2(double[,] M)
        {
            return M[0, 0] * M[1, 1] - M[0, 1] * M[1, 0];
        }

        // Method to find determinant of a 3x3 matrix
        public static double Determinant3x3(double[,] M)
        {
            double a = M[0, 0], b = M[0, 1], c = M[0, 2];
            double d = M[1, 0], e = M[1, 1], f = M[1, 2];
            double g = M[2, 0], h = M[2, 1], i = M[2, 2];

            return a * (e * i - f * h)
                 - b * (d * i - f * g)
                 + c * (d * h - e * g);
        }

        // Method to find inverse of 2x2 matrix
        public static double[,] Inverse2x2(double[,] M)
        {
            double det = Determinant2x2(M);
            if (det == 0) return null;

            double[,] inv = new double[2, 2];

            inv[0, 0] = M[1, 1] / det;
            inv[0, 1] = -M[0, 1] / det;
            inv[1, 0] = -M[1, 0] / det;
            inv[1, 1] = M[0, 0] / det;

            return inv;
        }

        // Method to find inverse of 3x3 matrix
        public static double[,] Inverse3x3(double[,] M)
        {
            double det = Determinant3x3(M);
            if (det == 0) return null;

            double[,] inv = new double[3, 3];

            inv[0, 0] = (M[1, 1] * M[2, 2] - M[1, 2] * M[2, 1]) / det;
            inv[0, 1] = -(M[1, 0] * M[2, 2] - M[1, 2] * M[2, 0]) / det;
            inv[0, 2] = (M[1, 0] * M[2, 1] - M[1, 1] * M[2, 0]) / det;

            inv[1, 0] = -(M[0, 1] * M[2, 2] - M[0, 2] * M[2, 1]) / det;
            inv[1, 1] = (M[0, 0] * M[2, 2] - M[0, 2] * M[2, 0]) / det;
            inv[1, 2] = -(M[0, 0] * M[2, 1] - M[0, 1] * M[2, 0]) / det;

            inv[2, 0] = (M[0, 1] * M[1, 2] - M[0, 2] * M[1, 1]) / det;
            inv[2, 1] = -(M[0, 0] * M[1, 2] - M[0, 2] * M[1, 0]) / det;
            inv[2, 2] = (M[0, 0] * M[1, 1] - M[0, 1] * M[1, 0]) / det;

            return inv;
        }

        // Method to display matrix
        public static void Display(double[,] M)
        {
            int r = M.GetLength(0);
            int c = M.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows for Matrix A:");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns for Matrix A:");
            int c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter rows for Matrix B:");
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns for Matrix B:");
            int c2 = int.Parse(Console.ReadLine());

            double[,] A = CreateRandomMatrix(r1, c1);
            double[,] B = CreateRandomMatrix(r2, c2);

            Console.WriteLine("\nMatrix A:");
            Display(A);

            Console.WriteLine("\nMatrix B:");
            Display(B);

            if (r1 == r2 && c1 == c2)
            {
                Console.WriteLine("\nA + B:");
                Display(Add(A, B));

                Console.WriteLine("\nA - B:");
                Display(Subtract(A, B));
            }

            if (c1 == r2)
            {
                Console.WriteLine("\nA × B:");
                Display(Multiply(A, B));
            }

            Console.WriteLine("\nTranspose of A:");
            Display(Transpose(A));

            if (r1 == 2 && c1 == 2)
            {
                Console.WriteLine("\nDeterminant of A (2x2): " + Determinant2x2(A));
                Console.WriteLine("Inverse of A:");
                Display(Inverse2x2(A));
            }

            if (r1 == 3 && c1 == 3)
            {
                Console.WriteLine("\nDeterminant of A (3x3): " + Determinant3x3(A));
                Console.WriteLine("Inverse of A:");
                Display(Inverse3x3(A));
            }
        }
    }
}

