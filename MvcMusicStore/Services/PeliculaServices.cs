using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Services
{
    public class PeliculaServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                titulo = "Pelicula 1",
                duracion = 120,
                pais = "España",
                fecha = new DateTime(2017, 06, 01)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var peli1 = new Pelicula()
            {
                titulo = "Pelicula 1",
                duracion = 120,
                pais = "España",
                fecha = new DateTime(2017, 06, 01)
            };
            var peli2 = new Pelicula()
            {
                titulo = "Pelicula 2",
                duracion = 130,
                pais = "Francia",
                fecha = new DateTime(1960, 01, 03)
            };
            return new List<Pelicula>()
            {
                peli1,peli2
            };
        }
    }
}