using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TiendaVideosHD.Persistencia.Gateways;

namespace TiendaVideosHD.Persistencia.Repositorio
{
    public class ArticulosGateway:BaseRepository,IArticulosGateway
    {
        public ArticulosGateway(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Articulo>> ListAsync()
        {
            return await _context.Articulos.ToListAsync();
        }
    }
}
