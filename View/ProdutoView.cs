using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){

            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine("-----------------");
                
            }


        }

        public Produto CadastrarProdutos(){

            Produto produto = new Produto();

            Console.Write($"Digite o código do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write($"Digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}