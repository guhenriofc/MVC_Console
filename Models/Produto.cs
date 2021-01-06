using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private string PATH = "Database/Produto.csv";


        public Produto (){

            string pasta = PATH.Split("/")[0];
            //Verificar se a pasta existe
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            // Verificar se o arquivo existe
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }

        }

        public List<Produto> Ler(){

            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");
                Produto prod1 = new Produto();
                prod1.Codigo = int.Parse(atributos[0]);
                prod1.Nome = atributos[0];
                prod1.Preco = float.Parse(atributos[0]);

                produtos.Add(prod1);

            }
            
            return produtos;
        }
        

    }
}