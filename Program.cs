using System;

namespace GitHubConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("New line added");
            Add(19, 9);
        }
        static void Add(int num1, int num2)
        {
            Console.WriteLine("Sum is {0}", num1 + num2);
        }
    }
}
