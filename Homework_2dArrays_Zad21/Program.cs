using System;

namespace Homework_2dArrays_Zad21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) & matrixRank >= 2)
            {
                int numberCounter = 1;
                bool matrixIsReflexive = true;
                int[,] matrixReflection = new int[matrixRank, matrixRank];

                Console.WriteLine("Матрица: ");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + numberCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixReflection[i, j]);
                        numberCounter++;
                    }
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    if (!(matrixReflection[i, i] == 1))
                    {
                        matrixIsReflexive = false;
                        break;
                    }
                }

                if (matrixIsReflexive)
                    Console.WriteLine("Matrix is reflexive.");
                else
                    Console.WriteLine("Matrix is NOT reflexive!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
