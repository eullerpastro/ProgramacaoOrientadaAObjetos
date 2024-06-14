using System;
using System.Globalization;

namespace FuncionariosDaNewCapacitacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionarios = new Funcionarios();

            Console.WriteLine("Dados do funcionário: ");
            Console.Write("Nome: ");
            funcionarios.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            funcionarios.Idade = int.Parse(Console.ReadLine());
            Console.Write("Função: ");
            funcionarios.Funcao = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarios.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionarios.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionarios);

            Console.WriteLine();
            Console.Write("Digite a quantidade de acréscimo de Imposto: ");
            double imp = double.Parse(Console.ReadLine());
            funcionarios.AdicionarImposto(imp);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionarios);

            Console.WriteLine();
            Console.Write("Digite a quantidade de remoção de Imposto: ");
            imp = double.Parse(Console.ReadLine());
            funcionarios.RemoverImposto(imp);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionarios);
        }
    }
}