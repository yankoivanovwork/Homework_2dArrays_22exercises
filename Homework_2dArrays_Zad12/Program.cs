using System;

namespace Homework_2dArrays_Zad12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) && matrixRank >= 2)
            {
                int elementCounter = 1;
                int[,] matrixOne = new int[matrixRank, matrixRank];
                int[,] matrixTwo = new int[matrixRank, matrixRank];
                int[,] matrixCombine = new int[matrixRank, matrixRank];

                elementCounter = 1;
                Console.WriteLine("Матрица 1");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + elementCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixOne[i, j]);
                        elementCounter++;
                    }
                }

                elementCounter = 1;
                Console.WriteLine("Матрица 2");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + elementCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixTwo[i, j]);
                        elementCounter++;
                    }
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        matrixCombine[i, j] = matrixOne[i, j] + matrixTwo[i, j];
                    }
                }

                Console.WriteLine("Сбор от матрици 1 и 2: ");
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
