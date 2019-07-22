using System;

namespace Homework_2dArrays_Zad9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст на един ред: ");
            string reverseLine = Console.ReadLine();
            string[] reverseStringWords = reverseLine.Split();

            for (int i = reverseLine.Length - 1; i >= 0; i--)
            {
                Console.Write(reverseLine[i]);
            }

            Console.Write(Environment.NewLine);

            for (int i = reverseStringWords.Length - 1; i >= 0; i--)
            {
                Console.Write(reverseStringWords[i] + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}
