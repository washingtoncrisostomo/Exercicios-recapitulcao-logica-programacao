using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            float val = float.Parse(Console.ReadLine());

            int cod2 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            float val2 = float.Parse(Console.ReadLine());

            float total = (num * val) + (num2 * val2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));


        }
    }
}
