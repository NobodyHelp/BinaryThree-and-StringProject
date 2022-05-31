using System;

namespace StringProject
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringEnd();

            Console.WriteLine("Введите первую строку");
            string first = Console.ReadLine();

            Console.WriteLine("Введите вторую строку");
            string second = Console.ReadLine();
            
            bool result = sb.StrEnd(first, second);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

