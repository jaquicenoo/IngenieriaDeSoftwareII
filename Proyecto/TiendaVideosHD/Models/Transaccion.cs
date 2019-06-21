﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Transaccion
    {
		[Key]
		public int Id { get; set; }
        public DatosArticulo Articulo { get; set; }
        public Usuario Usuario { get; set; } 

    }
}
