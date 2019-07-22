using System;

namespace Homework_2dArrays_Zad13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) && matrixRank >= 2)
            {
                int numberCounter = 1;
                int[,] matrixOne = new int[matrixRank, matrixRank];
                int[,] matrixTwo = new int[matrixRank, matrixRank];
                int[,] matrixCombine = new int[matrixRank, matrixRank];

                numberCounter = 1;
                Console.WriteLine("Матрица 1");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + numberCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixOne[i, j]);
                        numberCounter++;
                    }
                }

                numberCounter = 1;
                Console.WriteLine("Матрица 2");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + numberCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixTwo[i, j]);
                        numberCounter++;
                    }
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        for (int k = 0; k < matrixRank; k++)
                        {
                            matrixCombine[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                        }
                    }
                }

                Console.WriteLine("Умножение на матрици 1 и 2: ");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write(matrixCombine[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
