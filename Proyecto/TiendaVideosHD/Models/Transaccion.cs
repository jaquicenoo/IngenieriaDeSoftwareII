using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public DatosArticulo Articulo { get; set; }
        public Usuario Usuario { get; set; } 

    }
}
