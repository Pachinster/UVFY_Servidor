﻿using System;
using System.Collections.Generic;

namespace UVFYAuth.Models
{
    public partial class Genero
    {
        public Genero()
        {
            AlbumGenero = new HashSet<AlbumGenero>();
            CancionGenero = new HashSet<CancionGenero>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlbumGenero> AlbumGenero { get; set; }
        public virtual ICollection<CancionGenero> CancionGenero { get; set; }
    }
}
