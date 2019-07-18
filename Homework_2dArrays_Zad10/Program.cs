using System;
using System.Linq;

namespace Homework_2dArrays_Zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedIndex = -1;
            int selectedAsciiChar = char.MaxValue;

            char[] entryString = Console.ReadLine().ToArray();

            for (int i = 0; i < entryString.Length; i++)
            {
                selectedAsciiChar = char.MaxValue;

                for (int j = i; j < entryString.Length; j++)
                {
                    if (selectedAsciiChar > entryString[j])
                    {
                        selectedAsciiChar = entryString[j];
                        selectedIndex = j;
                    }
                }
                entryString[selectedIndex] = entryString[i];
                entryString[i] = (char)selectedAsciiChar;
            }

            for (int i = 0; i < entryString.Length; i++)
            {
                Console.Write(entryString[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
