using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            raio = double.Parse(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A = " + area.ToString("F4"));
        }
    }
}
