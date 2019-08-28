using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            ViewBag.Message = "Your contact page.";
            var p = new Persona() { edad = 35, Nombre = "Juan Carlos", Empleado=true, nacimiento=new DateTime(1976,01,04) };
            ViewBag.Propiedad = p;

            return View();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int edad { get; set; }
            public bool Empleado { get; set; }
            public DateTime nacimiento { get; set; }
        }
    }
}