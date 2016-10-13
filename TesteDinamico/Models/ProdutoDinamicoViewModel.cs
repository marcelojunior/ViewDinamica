using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteDinamico.Models
{
    public class ProdutoDinamicoViewModel : IDinamicoViewModel
    {
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }
        [Display(Name = "Valor do produto")]
        public decimal Valor { get; set; }
        [Display(Name = "Quantidade do produto")]
        public decimal Quantidade { get; set; }
    }
}