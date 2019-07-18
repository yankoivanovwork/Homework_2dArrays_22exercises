using System;
using System.Linq;

namespace Homework_2dArrays_Zad20
{
    class Program
    {
        static void Main(string[] args)
        {
            //namefix - zad22*
            int startNumber = 1;
            int endNumber = 1000000;
            long totalSum = ((long)endNumber * ((long)startNumber + (long)endNumber) / 2);
            long missingNumber = 0;
            long orderedArraySum = 0;
            Random randomNumber = new Random();

            long[] orderedArray = new long[endNumber];
            int randomGeneratedNumber = randomNumber.Next(startNumber, endNumber);

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i == randomGeneratedNumber)
                {
                    orderedArray[i - 1] = 0;
                }
                else
                {
                    orderedArray[i - 1] = i;
                }
            }

            Console.WriteLine("Total Sum of numbers 1 - 1 000 000 is: " + totalSum);

            Console.WriteLine("Sum() of the array with missing number is: " + orderedArray.Sum());

            for (int i = 0; i < endNumber; i++)
            {
                orderedArraySum += orderedArray[i];
            }

            Console.WriteLine("Manual sum of the array with missing number is: " + orderedArraySum);

            missingNumber = totalSum - orderedArraySum;

            Console.WriteLine();

            if (missingNumber == randomGeneratedNumber)
            {
                Console.WriteLine("Result from 'totalSum - arraySum' number is: " + missingNumber);

                Console.WriteLine("Generated missing number is: " + randomGeneratedNumber);
            }
        }
    }
}
