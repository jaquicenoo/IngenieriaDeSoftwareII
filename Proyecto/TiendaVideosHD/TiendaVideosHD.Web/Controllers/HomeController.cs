using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using TiendaVideosHD.Persistencia.Gateways;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        /// <summary>
        /// gateway base contiene gateway de entidades
        /// </summary>
        private readonly BaseGateway _context;
        public HomeController(BaseGateway context)
        {
            _context = context;
        }
        /// <summary>
        /// Vista inicial listado de articulos
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            IEnumerable<Articulo> model = new List<Articulo>();
            model = await _context.ArticulosGateway.ListAsync();
            return View(model);
        }
        /// <summary>
        /// Detalle de articulo
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Detalle(int Id)
        {
            Articulo model = new Articulo();
            model = await _context.ArticulosGateway.GetAsync(Id);
            return View(model);
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
