﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    #region enumeraciones
    public enum TiposArticulo
    {
        Libro = 1,
        Pelicula = 2,
        Cd = 3,
        Dvd = 4
    }
    public  enum Generos
    {
        Accion = 1 ,
        CienciFiccion = 2 ,
        Comedia = 3,
        Romance = 4,
        Musical = 5,
        Terror = 6,
        Historia = 7
    }
    #endregion
    public class DatosArticulo
    {
		#region propiedades
		[Key]
		public int Id{ get; set; }
        public string Titulo { get; set; }
        public double Precio { get; set; }
        public int Genero { get; set; }
        public int TipoArticulo { get; set; }
        //public List<Enum> Generos { get; set; }
        #endregion
        public DatosArticulo()
        {

        }
    }
}
