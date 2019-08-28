using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Pelicula
    {
        public string titulo { get; set; }
        public int duracion { get; set; }
        public string pais { get; set; }
        public DateTime fecha { get; set; }

    }
}