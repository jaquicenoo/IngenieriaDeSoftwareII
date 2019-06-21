using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideosHD.Persistencia.Gateways;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Persistencia.Repositorio
{
    public class ArticulosGateway:BaseRepository,IArticulosGateway
    {
        public ArticulosGateway(TiendaVideosHDContext context) : base(context)
        {
        }
        public async Task<Articulo> GetAsync(int Id)
        {
            return await Task.Run(() => {
                var query = _context.Articulos.Include(b => b.DatosArticulo).Where(X => X.Id == Id);
                return query.FirstOrDefault();
            });
                       
        }
        public async Task<IEnumerable<Articulo>> ListAsync()
        {
            return await _context.Articulos.Include(b => b.DatosArticulo).ToListAsync<Articulo>();
        }
        public async Task<EFResponse<Articulo>> SaveAsync(Articulo articulo)
        {
            try
            {
                var response = await _context.Articulos.AddAsync(articulo);
                _context.SaveChanges();
                return new EFResponse<Articulo>(articulo);
            }
            catch (Exception ex)
            {
                return new EFResponse<Articulo>(false, "Error al guardad el articulo", articulo);
            }
          
        }
    }
}
