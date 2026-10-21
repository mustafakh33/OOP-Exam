using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Helpers
{
    public class ConsoleInput
    {
        public static int ReadInt( string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);

                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.WriteLine($"Please enter a number from {min} to {max}.");
            }
        }

        public static string ReadText(string message)
        {
            while (true)
            {
                Console.Write(message);

                string input = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}
