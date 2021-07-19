using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo ;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            areaTrianguloRetangulo = (A * C) / 2;
            areaCirculo = Math.PI * Math.Pow(C, 2);
            areaTrapezio = ((A + B) * C) / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));


        }
    }
}
