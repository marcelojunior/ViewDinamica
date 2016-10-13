using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteDinamico.Models
{
    public class ProdutoViewModel : IDinamicoViewModel
    {
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }

        [Display(Name = "Preco do produto")]
        public decimal Preco { get; set; }

        [Display(Name = "Estoque do produto")]
        public decimal Estoque { get; set; }
    }
}