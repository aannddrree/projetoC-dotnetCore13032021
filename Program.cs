using System;
using projetoC_dotnetCore.Model;

namespace projetoC_dotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdução");

            Pessoa p = new Pessoa();

            Console.Write("Id: ");
            p.Id = int.Parse(Console.ReadLine());
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            p.Telefone = Console.ReadLine();
            
            Console.WriteLine(p);


        }
    }
}
