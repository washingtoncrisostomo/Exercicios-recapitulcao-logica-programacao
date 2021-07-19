using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, alcool=0, gasolina=0, diesel=0;
            cod = int.Parse(Console.ReadLine());
            while (cod != 4)
            {
                cod = int.Parse(Console.ReadLine());
                if (cod == 1)
                {
                    alcool++;
                }
                else if (cod == 2)
                {
                    gasolina++;
                }
                else if(cod == 0)
                {
                    diesel++;
                }
                else if (cod == 4)
                {
                    Console.WriteLine("Muito Obrigado");
                    Console.WriteLine("Alcool: "+alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                }
            }

        }
    }
}
