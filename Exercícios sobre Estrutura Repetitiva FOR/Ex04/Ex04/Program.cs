using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                double n1 = double.Parse(numeros[0]);
                double n2 = double.Parse(numeros[1]);
                if (n2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(n1/n2);
                }
            }
        }
    }
}
