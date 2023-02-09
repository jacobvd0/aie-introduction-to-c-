using System;

namespace IntroProgram // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for first and last name

            Console.WriteLine("Hello! What's your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("Cool! What's your last name?");
            var lastName = Console.ReadLine();

            // Clear the console then tell them their name.

            Console.Clear();
            Console.WriteLine($"Nice to meet you {firstName} {lastName} \n\nPress any key to quit!");
            Console.ReadKey();
        }
    }
}