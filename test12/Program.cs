using System;

namespace test12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            int b = a % 2;

            if (b == 0)
            {
                Console.WriteLine("Вы ввели четное число!");
            }
            else
            {
                Console.WriteLine("Вы ввели не четное число!");
            }
        }
    }
}
