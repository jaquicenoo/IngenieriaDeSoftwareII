using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaVideosHD.Web.Models
{
	public class ArticulosViewModel
	{
		[Required]
		public string Titulo { get; set; }
		[Required]
		[DataType(DataType.Currency)]
		public double Precio { get; set; }
		[Required]
		[Display(Name = "Tipo de genero")]
		public int Genero { get; set; }
		[Required]
		[Display(Name = "Tipo de Articulos")]
		public int TipoArticulo { get; set; }
		[Required]
		[Display(Name = "Estado del articulo")]
		public int EstadoArticulo { get; set; }
	}
}
