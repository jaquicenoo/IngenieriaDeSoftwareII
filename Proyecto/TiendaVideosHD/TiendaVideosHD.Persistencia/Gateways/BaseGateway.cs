using System;
using System.Collections.Generic;
using System.Text;
using TiendaVideosHD.Persistencia.Repositorio;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Persistencia.Gateways
{
	public class BaseGateway
	{
        private readonly TiendaVideosHDContext _context;
		public ArticulosGateway ArticulosGateway { get; set; }

        public BaseGateway()
        {
            _context = new TiendaVideosHDContext();
            ArticulosGateway = new ArticulosGateway(_context);
        }
	}
}
