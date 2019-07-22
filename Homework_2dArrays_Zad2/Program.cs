using System;
using System.Linq;

namespace Homework_2dArrays_Zad2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lowestNumberIndex = 0;
            int lowestNumber = int.MaxValue;

            Console.WriteLine("Въведете произволен брой целочислени числа на един ред разделени със 'space': ");
            int[] arrayRandomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

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

            for (int i = arrayRandomNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayRandomNumbers[i] + " ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
