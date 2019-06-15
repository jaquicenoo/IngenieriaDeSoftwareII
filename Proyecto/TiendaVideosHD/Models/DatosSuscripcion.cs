using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DatosSuscripcion
    {
        public int Id { get; set; }
        public int Costo { get; set; }
        public double Descuento { get; set; }
        public string Nombre { get; set; }
        public int Tiempo { get; set; }
    }
}
