using System;

namespace ExercicioUmClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();       

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
           
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais veha: " + p2.nome);
            }
        }
    }
}