using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero: ");
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Horas: ");
            float horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor da hora: ");
            float valor = float.Parse(Console.ReadLine());
            float salario = horas * valor;


            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2"));


        }
    }
}
