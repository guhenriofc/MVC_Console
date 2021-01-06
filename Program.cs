using System;
using MVC_Console.Controller;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProdutos();
        }
    }
}
