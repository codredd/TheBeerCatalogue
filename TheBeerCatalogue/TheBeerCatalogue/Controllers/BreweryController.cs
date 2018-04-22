using System;
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
            JsonResult result = null;

            try
            {
                BreweryList brewery = _breweryInterface.GetBrewery();
                result = Json(brewery.data, JsonRequestBehavior.AllowGet);
            }

            catch (Exception)
            {
                
            }

            return result ;
        }


    }
}