using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaVideosHD.Persistencia.Repositorio
{
    public class EFResponse<T>
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T Response { get; set; }

        public EFResponse(bool success, string message,T response)
        {
            Success = success;
            Message = message;
            Response = response;
        }
        /// <summary>
        /// Creación exitosa
        /// </summary>
        /// <param name="response"></param>
        public EFResponse(T response) : this(true, string.Empty, response)
        { }

    }
}

