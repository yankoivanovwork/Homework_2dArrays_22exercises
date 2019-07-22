using System;

namespace Homework_2dArrays_Zad19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) & matrixRank >= 2)
            {
                int zeroCount = 0;
                int numberCounter = 1;
                int[,] matrixSparse = new int[matrixRank, matrixRank];

                Console.WriteLine("Матрица: ");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + numberCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixSparse[i, j]);
                        numberCounter++;
                    }
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        if (matrixSparse[i, j] == 0)
                        {
                            zeroCount++;
                        }
                    }
                }

                if (zeroCount > matrixSparse.Length / 2)
                {
                    Console.WriteLine("Матрицата е sparse - " + (((double)zeroCount / (double)matrixSparse.Length) * 100).ToString("F2") + "%");
                }
                else
                {
                    Console.WriteLine("Матрицата е dense - " + ((((double)matrixSparse.Length - (double)zeroCount) / (double)matrixSparse.Length) * 100).ToString("F2") + "%");
                }
            }
        }
    }
}
