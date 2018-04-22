using System;
using System.Net;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BreweryFacade:BreweryInterface
    {
        WebClient client = new WebClient();
        BreweryList brewery = null;
        private string beerUrl = "http://api.brewerydb.com/v2/breweries?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

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