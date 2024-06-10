using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace FilmesPreferidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmes f1 = new Filmes();
            Filmes f2 = new Filmes();
            Filmes f3 = new Filmes();
            Filmes f4 = new Filmes();
            Filmes f5 = new Filmes();

            Console.WriteLine("Quais são os seus 5 filmes favoritos? ");
            Console.WriteLine("Ocupando a quinta colocação: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Diretor: ");
            f1.diretor = Console.ReadLine();
            Console.Write("Lancamento: ");
            f1.lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ocupando a quarta colocação: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Diretor: ");
            f2.diretor = Console.ReadLine();
            Console.Write("Lancamento: ");
            f2.lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ocupando a terceira colocação: ");
            Console.Write("Nome: ");
            f3.nome = Console.ReadLine();
            Console.Write("Diretor: ");
            f3.diretor = Console.ReadLine();
            Console.Write("Lancamento: ");
            f3.lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ocupando a segunda colocação: ");
            Console.Write("Nome: ");
            f4.nome = Console.ReadLine();
            Console.Write("Diretor: ");
            f4.diretor = Console.ReadLine();
            Console.Write("Lancamento: ");
            f4.lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ocupando a primeira colocação: ");
            Console.Write("Nome: ");
            f5.nome = Console.ReadLine();
            Console.Write("Diretor: ");
            f5.diretor = Console.ReadLine();
            Console.Write("Lancamento: ");
            f5.lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Esses são os seus cinco filmes favoritos!");
        }
    }
}