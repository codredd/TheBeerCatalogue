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

        public JsonResult GetBeer()
        {
            BeerList beerList = _beerInterface.GetBeer();
            return Json(beerList.data, JsonRequestBehavior.AllowGet);
        }
    }
}