using System.Collections.Generic;
using Aula34MVCConsole.Models;

namespace Aula34MVCConsole.Views
{
    public class ProdutoView
    {
        
        /// <summary>
        /// Mostra no console os itens do CSV
        /// </summary>
        /// <param name="lista">Lista com preço e nome dos itens do CSV</param>
        public void MostrarNoConsole(List<Produto> lista){

            foreach(Produto item in lista){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }

        }

    }
}