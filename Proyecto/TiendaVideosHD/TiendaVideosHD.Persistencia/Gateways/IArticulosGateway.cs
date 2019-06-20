using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVideosHD.Persistencia.Gateways
{
    interface IArticulosGateway
    {
        Task<IEnumerable<Articulo>> ListAsync();
    }
}
