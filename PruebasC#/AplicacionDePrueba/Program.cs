// See https://aka.ms/new-console-template for more information
using System;

namespace Consola
{
    public class ConsolaMain
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Hello, World!");
            String input = Console.ReadLine();
            Console.WriteLine(input);

        }
    }
}
