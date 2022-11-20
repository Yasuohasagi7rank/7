using System;

namespace _4._52
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            Console.WriteLine("Длина: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ширина: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Диаметр: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((c + 2) < a && (c + 2) < b)
            {
                Console.WriteLine("Вася сможет");
            } 
            else
            {
                Console.WriteLine("Вася не сможет");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
