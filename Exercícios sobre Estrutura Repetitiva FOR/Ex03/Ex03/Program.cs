using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                double n1 = double.Parse(numeros[0]);
                double n2 = double.Parse(numeros[1]);
                double n3 = double.Parse(numeros[2]);

                double m = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(m.ToString("F1"));
            }
        }
    }
}
