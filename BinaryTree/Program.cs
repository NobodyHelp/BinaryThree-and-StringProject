using System;
using System.Diagnostics;
using System.IO;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Task1.txt";
            Stopwatch stopwatch = new Stopwatch();
            int[] array = new int[9] { 5, 3, 7, 4, 1, 2, 8, 6, 9 };
            var tree = new Tree<int>();
            foreach (var item in array)
            {
                tree.Add(item);
            }

            foreach (var item in array)
            {
                File.AppendAllText(path, item.ToString() + ", ");
            }

            Console.Write("Префиксный обход: ");
            stopwatch.Start();
            foreach (var item in tree.Preorder())
            {                
                Console.Write(item + ", ");
            }
            stopwatch.Stop();
            TimeSpan prefixTime = stopwatch.Elapsed;
            Console.WriteLine("Время затраченное на префиксный обход: " + prefixTime);
            Console.ReadLine();

            
            Console.Write("Постфиксный обход: ");
            stopwatch.Restart();
            foreach (var item in tree.Postorder())
            {
                Console.Write(item + ", ");
            }
            stopwatch.Stop();
            TimeSpan postfixTime = stopwatch.Elapsed;
            Console.WriteLine("Время затраченное на постфиксный обход: " + postfixTime);
            Console.ReadLine();

            
            Console.Write("Инфиксный обход: ");
            stopwatch.Restart();
            foreach (var item in tree.Inorder())
            {
                Console.Write(item + ", ");
            }
            stopwatch.Stop();
            TimeSpan infixTime = stopwatch.Elapsed;
            Console.WriteLine("Время затраченное на инфиксный обход: " + infixTime);
            Console.ReadLine();

            
            Console.Write("Обход в ширину: ");
            stopwatch.Restart();
            foreach (var item in tree.LevelOrderTraversal())
            {
                Console.Write(item + ", ");
            }
            stopwatch.Stop();
            TimeSpan widhtTime = stopwatch.Elapsed;
            Console.WriteLine("Время затраченное на обход в ширину: " + widhtTime);
            Console.ReadLine();


            if (prefixTime > widhtTime || postfixTime > widhtTime || infixTime > widhtTime)            
                Console.WriteLine("Обход в глубину выполнился быстрее");            
            else
                Console.WriteLine("Обход в ширину выполнился быстрее");
            Console.ReadLine();


            Console.Write("Простые числа в дереве: ");
            foreach (int item in array)
            {                
                if (IsSimple(item)) 
                {
                    Console.Write(item + ", ");                    
                }                
            }
            Console.ReadKey();
        }

        private static bool IsSimple(int N)
        {            
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}
