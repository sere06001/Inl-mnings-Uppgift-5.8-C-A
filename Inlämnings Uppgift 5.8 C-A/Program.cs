using System;
namespace Uppgift5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {1253, 22265, 312, 4964, 58120};
            string tal1 = ints[0].ToString();
            string tal2 = ints[1].ToString();
            string tal3 = ints[2].ToString();
            string tal4 = ints[3].ToString();
            string tal5 = ints[4].ToString();
            foreach (var letter in tal1)
            {
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (var letter in tal2)
            {
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (var letter in tal3)
            {
                
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (var letter in tal4)
            {
                
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (var letter in tal5)
            {
                
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Thread.Sleep(1000);
        }
    }
}