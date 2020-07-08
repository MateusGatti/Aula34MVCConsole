using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {
        
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        /// <summary>
        /// Lista todos os itens do CSV
        /// </summary>
        public void Listar(){

            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
 
        }

        /// <summary>
        /// Filtra os itens do CSV
        /// </summary>
        /// <param name="termo">Um ou mais itens com o termo selecionado</param>
        public void Filtrar(string termo){

            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);

        }

    }
}