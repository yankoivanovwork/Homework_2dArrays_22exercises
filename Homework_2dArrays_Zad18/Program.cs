using System;

namespace Homework_2dArrays_Zad18
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank))
            {
                int numberCounter = 1;
                bool matricesAreNotEqual = false;
                int[,] matrixOne = new int[matrixRank, matrixRank];
                int[,] matrixTwo = new int[matrixRank, matrixRank];

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
                    }
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        if (matrixOne[i, j] == matrixTwo[i, j])
                        {
                            matricesAreNotEqual = true;
                            break;
                        }
                    }

                    if (matricesAreNotEqual)
                        break;
                }

                Console.WriteLine(matricesAreNotEqual ? "Матриците са еднакви." : "Въведените матрици НЕ са еднакви.");
            }
        }
    }
}
