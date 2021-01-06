using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){

            //List<Produto> produtos = produto.Ler();
            //produtoView.Listar(produtos);
            produtoView.Listar(produto.Ler());

        }
         public void Cadastrar(){

            produto.Inserir(produtoView.CadastrarProdutos());

         }
    }
}