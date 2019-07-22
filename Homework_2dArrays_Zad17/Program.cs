using System;

namespace Homework_2dArrays_Zad17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStrings;

            if (int.TryParse(Console.ReadLine(), out numberOfStrings))
            {
                int counter = 0;
                string selectedString = string.Empty;
                string[] arrayOfStringRows = new string[numberOfStrings];

                for (int i = 0; i < arrayOfStringRows.Length; i++)
                {
                    arrayOfStringRows[i] = Console.ReadLine();
                }

                while (counter < arrayOfStringRows.Length)
                {
                    counter = 0;

                    for (int i = 0; i < numberOfStrings; i++)
                    {
                        if (i < numberOfStrings - 2)
                        {
                            if (CompareStrings(arrayOfStringRows[i], arrayOfStringRows[i + 1]) == 1)
                            {
                                selectedString = arrayOfStringRows[i + 1];
                                arrayOfStringRows[i + 1] = arrayOfStringRows[i];
                                arrayOfStringRows[i] = selectedString;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        else
                        {
                            if (CompareStrings(arrayOfStringRows[i - 1], arrayOfStringRows[i]) == 1)
                            {
                                selectedString = arrayOfStringRows[i];
                                arrayOfStringRows[i] = arrayOfStringRows[i - 1];
                                arrayOfStringRows[i - 1] = selectedString;
                                continue;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                    }
                }

                Console.WriteLine("Result: ");
                for (int i = 0; i < arrayOfStringRows.Length; i++)
                {
                    Console.WriteLine(arrayOfStringRows[i]);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public static int CompareStrings(string stringOne, string stringTwo)
        {
            if (stringOne == stringTwo)
                return 0;
            if (stringOne == null)
                return -1;
            if (stringTwo == null)
                return 1;

            int counter = 0;
            int minimumLength = 0;

            if (stringOne.Length < stringTwo.Length)
            {
                minimumLength = stringOne.Length;
            }
            else
            {
                minimumLength = stringTwo.Length;
            }

            while (counter < minimumLength)
            {
                if (stringOne[counter] > stringTwo[counter])
                    return 1;
                if (stringOne[counter] < stringTwo[counter])
                    return -1;

                counter++;
            }

            if (stringOne.Length > stringTwo.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}