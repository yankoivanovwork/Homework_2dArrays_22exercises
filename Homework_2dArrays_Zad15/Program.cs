using System;
using System.Linq;

namespace Homework_2dArrays_Zad15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool arraysAreDifferent = false;
            Console.WriteLine("Въведете числа за масив 1");
            int[] arrayNumbersOne = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Въведете числа за масив 2");
            int[] arrayNumbersTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arrayNumbersOne.Length == arrayNumbersTwo.Length)
            {
                int[] distinctArrayOne = arrayNumbersOne.Distinct().ToArray();
                int[] distinctArrayTwo = arrayNumbersTwo.Distinct().ToArray();

                Array.Sort(distinctArrayOne);
                Array.Sort(distinctArrayTwo);

                if (distinctArrayOne.Count() == distinctArrayTwo.Count())
                {
                    for (int i = 0; i < distinctArrayOne.Count(); i++)
                    {
                        if (distinctArrayOne[i] != distinctArrayTwo[i])
                        {
                            arraysAreDifferent = true;
                            break;
                        }
                        else
                        {
                            if (arrayNumbersOne.Select(ano => ano == distinctArrayOne[i]).Count() != arrayNumbersTwo.Select(ant => ant == distinctArrayTwo[i]).Count())
                            {
                                arraysAreDifferent = true;
                                break;
                            }
                        }
                    }

                    Console.WriteLine(arraysAreDifferent ? "Масивите НЕ са еднакви!" : "Масивите са еднакви.");
                }
            }
            else
            {
                Console.WriteLine("Дължината на първия масив не отговаря на дължината на втория!");
            }
        }
    }
}
