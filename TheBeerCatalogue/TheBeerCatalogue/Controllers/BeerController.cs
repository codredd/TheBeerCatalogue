using System;
using System.Web.Mvc;
using TheBeerCatalogue.Business;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Controllers
{
    public class BeerController : Controller
    {
        private readonly BeerInterface _beerInterface;
        public BeerController(BeerInterface beerInterface)
        {
            _beerInterface = beerInterface;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        //GET: Beer
        public JsonResult GetBeer()
        {
            JsonResult result = null;
            try
            {
                BeerList beerList = _beerInterface.GetBeer();
                result = Json(beerList.data, JsonRequestBehavior.AllowGet);
            }
            
            catch(Exception)
            {

            }

            return result;

        }
    }
}