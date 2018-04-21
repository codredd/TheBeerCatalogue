using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBeerCatalogue.Business;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Controllers
{
    public class BreweryController : Controller
    {
        private readonly BreweryInterface _breweryInterface;
        public BreweryController(BreweryInterface beerInterface)
        {
            _breweryInterface = beerInterface;
        }

        // GET: Brewery
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBrewery()
        {
            BreweryList brewery = _breweryInterface.GetBrewery();
            return Json(brewery.data, JsonRequestBehavior.AllowGet);
        }


    }
}