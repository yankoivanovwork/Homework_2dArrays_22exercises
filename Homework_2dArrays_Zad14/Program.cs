using System;
using System.Linq;

namespace Homework_2dArrays_Zad14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа за масив 1");
            int[] arrayNumbersOne = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Въведете числа за масив 2");
            int[] arrayNumbersTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arrayNumbersOne.Length == arrayNumbersTwo.Length)
            {
                for (int i = 0; i < arrayNumbersOne.Length; i++)
                {
                    if (arrayNumbersOne[i] != arrayNumbersTwo[i])
                    {
                        Console.WriteLine("Масивите НЕ са еднакви!");
                        break;
                    }
                }
                Console.WriteLine("Масивите са еднакви.");
            }
            else
            {
                Console.WriteLine("Дължината на първия масив не отговаря на дължината на втория!");
            }
        }
    }
}
