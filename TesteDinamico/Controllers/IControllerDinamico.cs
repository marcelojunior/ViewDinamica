using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteDinamico.Models;

namespace TesteDinamico.Controllers
{
    public interface IControllerDinamico
    {
        /// <summary>
        /// Renderiza tela de formulario
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto">Objeto que ira renderizar na view</param>
        ActionResult RetornaView<T>(T objeto) where T : IDinamicoViewModel;

        /// <summary>
        /// Renderiza DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista">lista de objetos para renderizar</param>
        ActionResult RetornaView<T>(List<T> lista) where T : IDinamicoViewModel;

        /// <summary>
        /// Gera as colunas usadas para renderizar o DataTable nos indexes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <returns></returns>
        Dictionary<string, string> GerarColunas<T>(List<T> lista) where T : IDinamicoViewModel;
    }
}