using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TiendaVideosHD.Web.Controllers
{
    public class ArticulosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}