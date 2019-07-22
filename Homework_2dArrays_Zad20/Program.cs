using System;

namespace Homework_2dArrays_Zad20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixRank = 0;

            if (int.TryParse(Console.ReadLine(), out matrixRank) & matrixRank >= 2)
            {
                ///triangleIndex
                /// 0 nad glaven diagonal
                /// 1 pod glaven diagonal
                /// 2 nad glaven ogledalen diagonal
                /// 3 pod glaven ogledalen diagonal

                int triangleIndex = -1;
                int lowestNumber = int.MaxValue;
                int numberCounter = 1;
                int[,] matrixNumbers = new int[matrixRank, matrixRank];
                int[,] resultTriangleInMatrix = FillMatrixWithZeros(matrixRank);

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

                sumForEachTriangle[0] = SumForTriangleAboveOrBelowMainDiagonal(matrixNumbers, 0);
                sumForEachTriangle[1] = SumForTriangleAboveOrBelowMainDiagonal(matrixNumbers, 1);

                sumForEachTriangle[2] = SumForTriangleAboveOrBelowReflectedMainDiagonal(matrixNumbers, 2);
                sumForEachTriangle[3] = SumForTriangleAboveOrBelowReflectedMainDiagonal(matrixNumbers, 3);

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
                    resultTriangleInMatrix = TriangleMainDiagonal(matrixNumbers, true);
                }
                else if (triangleIndex == 1)
                {
                    resultTriangleInMatrix = TriangleMainDiagonal(matrixNumbers, false);
                }
                else if (triangleIndex == 2)
                {
                    resultTriangleInMatrix = TriangleReflectedMainDiagonal(matrixNumbers, true);
                }
                else
                {
                    resultTriangleInMatrix = TriangleReflectedMainDiagonal(matrixNumbers, false);
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

        private static int SumForTriangleAboveOrBelowMainDiagonal(int[,] matrixNumbers, int triangleIndex)
        {
            int sumForTriangle = 0;

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1) - i; j++)
                {
                    if (triangleIndex == 0)
                    {
                        sumForTriangle += matrixNumbers[j, j + i];
                    }
                    else
                    {
                        sumForTriangle += matrixNumbers[j + i, j];
                    }
                }
            }

            return sumForTriangle;
        }

        private static int SumForTriangleAboveOrBelowReflectedMainDiagonal(int[,] matrixNumbers, int triangleIndex)
        {
            int sumForTriangle = 0;

            for (int i = matrixNumbers.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    if (triangleIndex == 2)
                    {
                        sumForTriangle += matrixNumbers[j, i - j];
                    }
                    else
                    {
                        if (i == 1)
                        {
                            sumForTriangle += matrixNumbers[j + i, 2 * i - j];
                            continue;
                        }
                        else if (i == 0)
                        {
                            sumForTriangle += matrixNumbers[2, 2];
                            continue;
                        }

                        sumForTriangle += matrixNumbers[i - j, j];
                    }
                }
            }

            return sumForTriangle;
        }

        private static int[,] TriangleMainDiagonal(int[,] matrixNumbers, bool triangleAbove)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1) - i; j++)
                {
                    if (triangleAbove)
                    {
                        resultMatrix[j, j + i] = matrixNumbers[j, j + i];
                    }
                    else
                    {
                        resultMatrix[j + i, j] = matrixNumbers[j + i, j];
                    }
                }
            }

            return resultMatrix;
        }

        private static int[,] TriangleReflectedMainDiagonal(int[,] matrixNumbers, bool triangleAbove)
        {
            int[,] resultMatrix = new int[matrixNumbers.GetLength(0), matrixNumbers.GetLength(1)];

            for (int i = matrixNumbers.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    if (triangleAbove)
                    {
                        resultMatrix[j, i - j] = matrixNumbers[j, i - j];
                    }
                    else
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
            }

            return resultMatrix;
        }
    }
}