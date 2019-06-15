using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum EstadosArticulo
    {
        Bueno = 1,
        Regular = 2,
        LigeroDeterioro = 3,
        MuyDeteriorado = 4
    }
    public class Articulo
    {
        public int Id { get; set; }
        public DatosArticulo DatosArticulo { get; set; }
        public EstadosArticulo EstadoArticulo { get; set; }
    }
}
