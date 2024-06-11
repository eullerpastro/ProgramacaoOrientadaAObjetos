using System;

namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Area de x = " + areax.ToString("F4"));
            Console.WriteLine("Area de y = " + areay.ToString("F4"));

            if (areax > areay)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}