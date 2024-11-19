using DAL01;
using Ejercio01ASP.Models;
using ENT01;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercio01ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<ClsPersona> listaPersonas = new List<ClsPersona>();
            try
            {
                listaPersonas = ListadosDal.ObtieneListadoPersonasDal();
                
            }
            catch (Exception ex)
            {
                //TODO mostrar error
            }
            return View(listaPersonas);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
