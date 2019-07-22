using System;
using System.Linq;

namespace Homework_2dArrays_Zad4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lowestNumberIndex = 0;
            double lowestNumber = double.MinValue;

            Console.WriteLine("Въведете произволен брой числа с десетична запетая на един ред разделени със 'space': ");
            double[] arrayRandomNumbers = Console.ReadLine().Replace(".", ",").Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arrayRandomNumbers.Length; i++)
            {
                lowestNumber = int.MinValue;
                for (int j = i; j < arrayRandomNumbers.Length; j++)
                {
                    if (lowestNumber < arrayRandomNumbers[j])
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
                Console.Write(arrayRandomNumbers[i] + " ");
            }

            for (int i = arrayRandomNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayRandomNumbers[i] + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}
