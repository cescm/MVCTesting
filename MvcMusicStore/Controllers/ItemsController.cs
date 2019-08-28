using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcMusicStore.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            List<Items> it = new List<Items>()
            {
                new Items() { Id=1, Nombre="Item1"},
                new Items() { Id = 2, Nombre = "Item2" },
                new Items() { Id = 3, Nombre = "Item3" }
            };
            ViewBag.Message = "Valor pasado por ViewBag";
            return View(it);
        }
    }
}