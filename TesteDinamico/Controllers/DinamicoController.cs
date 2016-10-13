using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteDinamico.Models;

namespace TesteDinamico.Controllers
{
    public class DinamicoController : Controller, IControllerDinamico
    {
        public Dictionary<string, string> GerarColunas<T>(List<T> lista) where T : IDinamicoViewModel
        {
            var dicionario = new Dictionary<string, string>();
            var tipoDaLista = lista.GetType().GetGenericArguments().Single();

            foreach (var attr in tipoDaLista.GetProperties())
            {
                var attribute = attr.GetCustomAttributes(typeof(DisplayAttribute), true).Cast<DisplayAttribute>().Single();
                dicionario.Add(attr.Name, attribute.Name);
            }

            return dicionario;
        }

        public ActionResult RetornaView<T>(List<T> lista) where T : IDinamicoViewModel
        {
            var tipoDaLista = lista.GetType().GetGenericArguments().Single();
            var IndexVM = new IndexViewModel();

            IDinamicoViewModel Filtro = (IDinamicoViewModel)Activator.CreateInstance(tipoDaLista);

            IndexVM.Filtro = Filtro;
            IndexVM.Colunas = GerarColunas(lista);

            return View("~/Views/Dinamico/Index.cshtml", IndexVM);
        }

        public ActionResult RetornaView<T>(T objeto) where T : IDinamicoViewModel
        {
            throw new NotImplementedException();
        }
    }
}