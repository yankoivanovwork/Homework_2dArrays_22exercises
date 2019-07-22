using System;

namespace Homework_2dArrays_Zad20
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) & matrixRank >= 2)
            {
                int triangleIndex = -1;
                int lowestNumber = int.MaxValue;
                int numberCounter = 1;
                int[,] matrixNumbers = new int[matrixRank, matrixRank];
                int[,] resultTriangleInMatrix = FillMatrixWithZeros(matrixRank);

                ///sumForEachTriangle index
                ///0 nad glaven diagonal
                ///1 pod glaven diagonal
                ///2 nad glaven ogledalen diagonal
                ///3 pod glaven ogledalen diagonal
                int[] sumForEachTriangle = new int[4];

                Console.WriteLine("Матрица: ");
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("Число " + numberCounter + ":");
                        int.TryParse(Console.ReadLine(), out matrixNumbers[i, j]);
                        numberCounter++;
                    }
                }

                //sum za triangle nad glaven diagonal
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank - i; j++)
                    {
                        sumForEachTriangle[0] += matrixNumbers[j, j + i];
                    }
                }

                //sum za triangle pod glaven diagonal
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank - i; j++)
                    {
                        sumForEachTriangle[1] += matrixNumbers[j + i, j];
                    }
                }

                //sum za triangle nad glaven ogledalen diagonal
                for (int i = matrixRank - 1; i >= 0; i--)
                {
                    for (int j = 0; j < (i + 1) ; j++)
                    {
                        sumForEachTriangle[2] += matrixNumbers[j, i - j];
                    }
                }

                //sum za triangle pod glaven ogledalen diagonal
                for (int i = matrixRank - 1; i >= 0; i--)
                {
                    for (int j = 0; j < (i + 1); j++)
                    {
                        if (i == 1)
                        {
                            sumForEachTriangle[3] += matrixNumbers[j + i, 2 * i - j];
                            continue;
                        }
                        else if (i == 0)
                        {
                            sumForEachTriangle[3] += matrixNumbers[2, 2];
                            continue;
                        }

                        sumForEachTriangle[3] += matrixNumbers[i - j, j];
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (lowestNumber > sumForEachTriangle[i])
                    {
                        lowestNumber = sumForEachTriangle[i];
                        triangleIndex = i;
                    }
                }

                if (triangleIndex == 0)
                {
                    resultTriangleInMatrix = TriangleAboveMainDiagonal(matrixNumbers);
                }
                else if (triangleIndex == 1)
                {
                    resultTriangleInMatrix = TriangleBelowMainDiagonal(matrixNumbers);
                }
                else if (triangleIndex == 2)
                {
                    resultTriangleInMatrix = TriangleAboveReflectedMainDiagonal(matrixNumbers);
                }
                else
                {
                    resultTriangleInMatrix = TriangleBelowReflectedMainDiagonal(matrixNumbers);
                }

                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write(resultTriangleInMatrix[i, j] + " ");
                    }
                    Console.Write(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private static int[,] FillMatrixWithZeros(int matrixRank)
        {
            int[,] matrix = new int[matrixRank, matrixRank];

            for (int i = 0; i < matrixRank; i++)
            {
                for (int j = 0; j < matrixRank; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            return matrix;   
        }

        private static int[,] TriangleAboveMainDiagonal(int[,] matrixNumbers)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1) - i; j++)
                {
                    resultMatrix[j, j + i] = matrixNumbers[j, j + i];
                }
            }

            return resultMatrix;
        }

        private static int[,] TriangleBelowMainDiagonal(int[,] matrixNumbers)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1) - i; j++)
                {
                    resultMatrix[j + i, j] = matrixNumbers[j + i, j];
                }
            }

            return resultMatrix;
        }

        private static int[,] TriangleAboveReflectedMainDiagonal(int[,] matrixNumbers)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = matrixNumbers.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    resultMatrix[j, i - j] = matrixNumbers[j, i - j];
                }
            }

            return resultMatrix;
        }

        private static int[,] TriangleBelowReflectedMainDiagonal(int[,] matrixNumbers)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = matrixNumbers.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    if (i == 1)
                    {
                        resultMatrix[j + i, 2 * i - j] = matrixNumbers[j + i, 2 * i - j];
                        continue;
                    }
                    else if (i == 0)
                    {
                        resultMatrix[2, 2] = matrixNumbers[2, 2];
                        continue;
                    }

                    resultMatrix[i - j, j] = matrixNumbers[i - j, j];
                }
            }

            return resultMatrix;
        }
    }
}