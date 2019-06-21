using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class DatosUsuario
    {
		[Key]
		public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroCelular { get; set; }
        public string NumeroIdentificacion { get; set; }
    }
}
