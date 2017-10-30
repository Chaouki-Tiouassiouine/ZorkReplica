using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintMethod();
            Console.ReadKey();

        }

        public static void PrintMethod()
        {

            Console.WriteLine("Hoi");
            Console.ReadLine();

            string result = Console.ReadLine();

            Console.WriteLine(result);
            Console.WriteLine(String.Format("dit was het resultaat: {0}", result));

            string multiline = @"Hallo        Jup";

        }
    }
}