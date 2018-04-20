using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBeerCatalogue.Business;

namespace TheBeerCatalogue.Controllers
{
    public class BeerController : Controller
    {
        private readonly BeerInterface _beerInterface;
        public BeerController(BeerInterface beerInterface)
        {
            _beerInterface = beerInterface;
        }

        public ActionResult GetBeer()
        {
            return View();
        }
        // GET: Beer
        public ActionResult Index()
        {
            return View();
        }
    }
}