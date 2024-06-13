using System;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a Largura e a altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area());
            Console.WriteLine("PERIMETRO = " + r.Perimetro());
            Console.WriteLine("DIAGONAL = " + r.Diagonal());
        }
    }
}