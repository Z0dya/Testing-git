using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите значение x");
            x = Convert.ToInt32(Console.ReadLine());
            y = 5 * x;
            Console.WriteLine(y);
        }
    }
}
