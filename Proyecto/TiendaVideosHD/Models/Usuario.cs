using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Usuario
    {
		[Key]
		public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DatosUsuario DatosUsuario { get; set; }
    }
}
