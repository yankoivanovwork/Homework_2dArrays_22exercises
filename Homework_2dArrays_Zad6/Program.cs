using System;
using System.Linq;

namespace Homework_2dArrays_Zad6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lowestNumberIndex = 0;
            int lowestNumber = int.MaxValue;

            Console.WriteLine("Въведете произволен брой цели числа на един ред разделени със 'space': ");
            int[] arrayRandomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int arithmeticValue = (arrayRandomNumbers.Sum() / arrayRandomNumbers.Length);

            for (int i = 0; i < arrayRandomNumbers.Length; i++)
            {
                lowestNumber = int.MaxValue;
                for (int j = i; j < arrayRandomNumbers.Length; j++)
                {
                    if (lowestNumber > arrayRandomNumbers[j])
                    {
                        lowestNumber = arrayRandomNumbers[j];
                        lowestNumberIndex = j;
                    }
                }
                arrayRandomNumbers[lowestNumberIndex] = arrayRandomNumbers[i];
                arrayRandomNumbers[i] = lowestNumber;
            }

            for (int i = 0; i < arrayRandomNumbers.Length; i++)
            {
                if (arrayRandomNumbers[i] > arithmeticValue && arrayRandomNumbers[i] < (arithmeticValue * 2))
                {
                    Console.Write(arrayRandomNumbers[i] + " ");
                }
            }
            Console.Write(Environment.NewLine);
        }
    }
}
