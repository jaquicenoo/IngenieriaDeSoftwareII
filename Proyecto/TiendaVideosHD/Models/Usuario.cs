using System;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DatosUsuario DatosUsuario { get; set; }
    }
}
