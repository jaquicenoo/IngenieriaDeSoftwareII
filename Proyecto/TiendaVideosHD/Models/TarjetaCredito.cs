using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum Franquicia
    {
        Visa = 1,
        Matercard = 2,
        DinersClub = 3
    }
    public class TarjetaCredito
    {
        public string NumeroTarjeta { get; set; }
        public string NombreTarjeta { get; set; }
        public int CodigoVerificacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Franquicia Franquicia { get; set; }
    }
}
