using System;
using System.Net;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BeerFacade : BeerInterface
    {
        WebClient client = new WebClient();
        BeerList beer = null;
        private string beerUrl = "http://api.brewerydb.com/v2/beers?key=<put your Brewery DB API here>";

        public BeerList GetBeer()
        {
            try
            {
                string responseList = client.DownloadString(beerUrl);

                beer = Newtonsoft.Json.JsonConvert.DeserializeObject<BeerList>(responseList);
            }

            catch(Exception)
            {

            }
            
            return beer;
        }
    }
}
