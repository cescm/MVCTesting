using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            //return View();
            return "Hello from store. Index()";
        }
        
        //GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            //return View();
            //return "Hello from store. Browse()";
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return message;
        }

        public string Details(int ID)
        {
            //return View();
            //return "Hello from store. Details()";
            string message = "Store.Details, ID= " + ID;
            return message;
        }
    }
}