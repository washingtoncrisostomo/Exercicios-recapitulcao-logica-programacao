using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            senha = Console.ReadLine();
            while (senha != "2002")
            {
                
                Console.WriteLine("Senha Inválida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
