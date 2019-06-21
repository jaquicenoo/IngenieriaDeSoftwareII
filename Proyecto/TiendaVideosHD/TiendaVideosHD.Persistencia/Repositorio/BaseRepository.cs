using System;
using System.Collections.Generic;
using System.Text;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Persistencia.Repositorio
{
    public abstract class BaseRepository
    {
        protected readonly TiendaVideosHDContext _context;

        public BaseRepository(TiendaVideosHDContext context)
        {
            _context = context;
        }
    }
}
