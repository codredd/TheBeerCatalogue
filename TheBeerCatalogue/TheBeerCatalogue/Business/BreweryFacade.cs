using System;
using System.Net;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BreweryFacade:BreweryInterface
    {
        WebClient client = new WebClient();
        BreweryList brewery = null;
        private string beerUrl = "http://api.brewerydb.com/v2/breweries?key=<put your Brewery DB API here>";

        public BreweryList GetBrewery()
        {
            try
            {
                string responseList = client.DownloadString(beerUrl);

                brewery = Newtonsoft.Json.JsonConvert.DeserializeObject<BreweryList>(responseList);
            }

            catch (Exception)
            {

            }
            
            return brewery;
        }
    }
}
