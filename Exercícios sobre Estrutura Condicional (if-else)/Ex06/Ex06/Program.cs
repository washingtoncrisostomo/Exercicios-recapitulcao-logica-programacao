﻿using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            Console.WriteLine("Digite um valor: ");
            n = float.Parse(Console.ReadLine());

            if(n >= 0 && n <= 25)
            {
                Console.WriteLine(" Intervalo(0, 25]");
            }
            else if (n >= 25 && n <= 50)
            {
                Console.WriteLine(" Intervalo(25, 50]");
            }
            else if (n >= 50 && n <= 75)
            {
                Console.WriteLine(" Intervalo(50, 75]");
            }
            else if (n >= 75 && n <= 100)
            {
                Console.WriteLine(" Intervalo(75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
