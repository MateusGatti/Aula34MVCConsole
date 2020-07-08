using System;
using Aula34MVCConsole.Controllers;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Listar();
            System.Console.WriteLine("-------------");
            produtos.Filtrar("3500");
        }
    }
}
