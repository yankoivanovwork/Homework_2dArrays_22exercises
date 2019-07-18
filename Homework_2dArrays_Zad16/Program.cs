using System;
using System.Linq;

namespace Homework_2dArrays_Zad16
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedIndex = -1;
            char selectedChar;

            char[] entryString = Console.ReadLine().ToArray();

            for (int i = 0; i < entryString.Length; i++)
            {
                selectedChar = char.MaxValue;

                for (int j = i; j < entryString.Length; j++)
                {
                    if (selectedChar > entryString[j])
                    {
                        selectedChar = entryString[j];
                        selectedIndex = j;
                    }
                }
                entryString[selectedIndex] = entryString[i];
                entryString[i] = selectedChar;
            }

            for (int i = 0; i < entryString.Length; i++)
            {
                Console.Write(entryString[i]);
            }
            Console.WriteLine();
        }
    }
}