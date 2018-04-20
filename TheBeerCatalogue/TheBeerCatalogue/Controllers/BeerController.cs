using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
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

        public BeerController() { }

        public Task<BeerList> GetBeer()
        {
            BeerFacade obj = new BeerFacade();
            return obj.GetBeer();
        }
    }
}