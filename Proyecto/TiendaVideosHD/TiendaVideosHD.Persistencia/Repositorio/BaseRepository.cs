﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaVideosHD.Persistencia.Repositorio
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
