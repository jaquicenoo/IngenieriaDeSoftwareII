using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        /// <summary>
        /// Vista inicial listado de articulos
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Detalle de articulo
        /// </summary>
        /// <returns></returns>
        public IActionResult Detalle()
        {
            return View();
        } 
        /// <summary>
        /// Alquilar articulos
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Alquilar()
        {
            if(!ModelState.IsValid)
            {
                return View("Detalle");
            }
            return RedirectToAction("Index", "Home");
        }
        /// <summary>
        /// Comprar articulos
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Comprar()
        {
            if (!ModelState.IsValid)
            {
                return View("Detalle");
            }
            return RedirectToAction("Index", "Home");
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
