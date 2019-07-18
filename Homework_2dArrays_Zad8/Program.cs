using System;

namespace Homework_2dArrays_Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRank = 0;

            Console.Write("Въведете ранк на матрицата: ");
            if (int.TryParse(Console.ReadLine(), out matrixRank) && matrixRank >= 2)
            {
                int result = 0;
                int elementCounter = 0;
                int[,] matrixRandomNumbers = new int[matrixRank, matrixRank];

                elementCounter = 1;
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + elementCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixRandomNumbers[i, j]);
                        elementCounter++;
                    }
                }

                //matrixRandomNumbers.GetLength(0)
                for (int i = 0, j = matrixRank - 1; i < matrixRank; i++, j--)
                {
                    result += matrixRandomNumbers[i, j];
                }

                Console.WriteLine("Резултат: " + result);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
