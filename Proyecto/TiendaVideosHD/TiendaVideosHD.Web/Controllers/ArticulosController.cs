using System;
using System.Collections.Generic;
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
    public class ArticulosController : Controller
    {
		/// <summary>
		/// gateway base contiene gateway de entidades
		/// </summary>
		private readonly BaseGateway _context;
		public ArticulosController(BaseGateway context)
		{
			_context = context;
		}
		/// <summary>
		/// lista los articulos
		/// </summary>
		/// <returns></returns>
        public async Task<IActionResult> Index()
        {
            IEnumerable<Articulo> model = new List<Articulo>();
            model = await _context.ArticulosGateway.ListAsync();
            return View(model);
        }
		public IActionResult CrearArticulo()
		{
			return View();
		}
		/// <summary>
		/// Creación de articulos
		/// </summary>
		/// <param name="articulo"></param>
		/// <returns></returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CrearArticulo(ArticulosViewModel model)
		{
			try
			{
                Articulo articulo = new Articulo();
                articulo.EstadoArticulo = model.EstadoArticulo;
                articulo.DatosArticulo = new DatosArticulo
                {
                    Genero = model.Genero,
                    Precio = model.Precio,
                    TipoArticulo = model.TipoArticulo,
                    Titulo = model.Titulo
                };
                await _context.ArticulosGateway.SaveAsync(articulo);
			}
			catch (Exception)
			{
			}
            return RedirectToAction("Index");
        }
    }
}