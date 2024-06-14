using System;
using System.Globalization;

namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2"));

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + a.NotaFinal().ToString("F2")
                + " PONTOS");
            }
        }
    }
}