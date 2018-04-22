using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using TheBeerCatalogue.Business;
using TheBeerCatalogue.Controllers;


namespace TheBeerCatalogue.Tests.Controllers
{
    [TestClass]
    public class BeerControllerTest
    {
        private readonly BeerInterface _beerInterface = new BeerFacade();

        [TestMethod]
        public void Index()
        {
            // Initialize controller
            BeerController controller = new BeerController(_beerInterface);

            // Call the method
            ViewResult result = controller.Index() as ViewResult;

            //Assert the result
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetBeer()
        {
            // Initialize controller
            BeerController controller = new BeerController(_beerInterface);

            // Call the method
            JsonResult result = controller.GetBeer() as JsonResult;

            //Assert the result
            Assert.IsNotNull(result);

        }
    }
}
