using System;

namespace ExercicioDoisClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = media = (f1.salario + f2.salario) / 2.0;

            media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salario medio: " + media.ToString("F2"));
        }
    }
}