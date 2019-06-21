using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TiendaVideosHD.Persistencia.Repositorio;

namespace TiendaVideosHD.Persistencia.Gateways
{
    public interface IArticulosGateway
    {
        Task<IEnumerable<Articulo>> ListAsync();
        Task<EFResponse<Articulo>> SaveAsync(Articulo articulo);
        Task<Articulo> GetAsync(int Id);

    }
}
