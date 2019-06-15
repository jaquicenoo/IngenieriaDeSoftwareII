using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Suscripcion
    {
        public int Id { get; set; }
        public DateTime FechaSuscripcion { get; set; }
        public Usuario Usuario { get; set; }
        public DatosSuscripcion DatosSuscripcion { get; set; }

    }
}
