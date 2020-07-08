using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula34MVCConsole.Models
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
       private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
    
        /// <summary>
        /// Lê os itens do CSV
        /// </summary>
        /// <returns>lista com os itens do CSV</returns>
        public List<Produto> Ler()
        {
          
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {

                
                string[] dado = linha.Split(";");

                
                Produto p = new Produto();
                p.Codigo = Int32.Parse(SepararDado(dado[0]));
                p.Nome = SepararDado(dado[1]);
                p.Preco = float.Parse(SepararDado(dado[2]));

                produtos.Add(p);
            }

            produtos = produtos.OrderBy(z => z.Codigo).ToList();
            return produtos;

        }
        private string SepararDado(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
    }
}