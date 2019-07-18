using System;
using System.Linq;

namespace Homework_2dArrays_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowestNumberIndex = 0;
            double lowestNumber = double.MaxValue;

            Console.WriteLine("Въведете произволен брой числа с десетична запетая на един ред разделени със 'space': ");
            double[] arrayRandomNumbers = Console.ReadLine().Replace(".", ",").Split().Select(double.Parse).ToArray();

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
                Console.Write(arrayRandomNumbers[i] + " ");
            }

            Console.Write(Environment.NewLine);

            for (int i = arrayRandomNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayRandomNumbers[i] + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}
