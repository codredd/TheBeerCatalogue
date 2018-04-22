using System;
using System.Net;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BeerFacade : BeerInterface
    {
        WebClient client = new WebClient();
        BeerList beer = null;
        private string beerUrl = "http://api.brewerydb.com/v2/beers?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

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
