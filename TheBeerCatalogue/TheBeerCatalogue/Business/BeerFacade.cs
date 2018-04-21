using System.Net;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BeerFacade : BeerInterface
    {
        WebClient client = new WebClient();
        private string beerUrl = "http://api.brewerydb.com/v2/beers?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

        public BeerList GetBeer()
        {
            string responseList = client.DownloadString(beerUrl);

            BeerList beer = Newtonsoft.Json.JsonConvert.DeserializeObject<BeerList>(responseList);
            return beer;
        }
    }
}
