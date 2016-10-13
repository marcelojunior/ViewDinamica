using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteDinamico.Models;

namespace TesteDinamico.Controllers
{
    public class ProdutosController : DinamicoController
    {
        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = new List<ProdutoViewModel>();

            for (int i = 0; i < 5; i++)
            {
                var produto = new ProdutoViewModel();
                produto.Nome = $"Produto {i}";
                produto.Preco = 10 + i;
                produto.Estoque = 2 + i;
                produtos.Add(produto);
            }

            return RetornaView(produtos);
        }
    }
}