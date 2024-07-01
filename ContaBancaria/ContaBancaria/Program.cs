using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Entre o número da conta: ");
            c.Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            c.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            c.Deposito = double.Parse(Console.ReadLine());
        }
    }
}