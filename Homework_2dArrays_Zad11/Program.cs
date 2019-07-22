using System;

namespace Homework_2dArrays_Zad11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] array2d = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] array2dThreeRow = new int[,] { { 1, 12, 3 }, { 44, 5, 6 }, { 7, 21, 9 } };
            int[,] array2dFourRow = new int[,] { { 1, 5, 3, 4 }, { 5, 3, 7, 12 }, { 9, 10, 55, 12 }, { 13, 14, 67, 16 } };

            Console.WriteLine("2x2");
            CalculateDeterminant(array2d);
            Console.WriteLine("3x3");
            CalculateDeterminant(array2dThreeRow);
            Console.WriteLine("4x4");
            CalculateDeterminant(array2dFourRow);
        }

        public static void CalculateDeterminant(int[,] matrix)
        {
            int a = 0;
            int b = 0;
            int[,] result = new int[2, matrix.GetLength(0)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = 1;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, k = matrix.GetLength(0) - 1; j < matrix.GetLength(0); j++, k--)
                {
                    result[0, i] *= matrix[j, ((j + i) % matrix.GetLength(0))];
                    result[1, i] *= matrix[j, ((k + i) % matrix.GetLength(0))];
                }
            }

            if (matrix.GetLength(0) == 2)
            {
                a = result[0, 0];
                b = result[1, 0];
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    a += result[0, i];

                    if (i == 0)
                    {
                        b = result[1, i];
                    }
                    else
                    {
                        b -= result[1, i];
                    }
                }
            }

            Console.WriteLine("Result: " + (a - b));
        }
    }
}
