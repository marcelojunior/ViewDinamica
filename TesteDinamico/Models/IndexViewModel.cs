using System.Collections.Generic;

namespace TesteDinamico.Models
{
    public class IndexViewModel
    {
        public IDinamicoViewModel Filtro { get; set; }
        public Dictionary<string, string> Colunas { get; set; }
    }

    
}