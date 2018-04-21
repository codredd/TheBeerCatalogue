using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BreweryFacade:BreweryInterface
    {
        WebClient client = new WebClient();
        private string beerUrl = "http://api.brewerydb.com/v2/breweries?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

        public BreweryList GetBrewery()
        {
            string responseList = client.DownloadString(beerUrl);

            BreweryList brewery = Newtonsoft.Json.JsonConvert.DeserializeObject<BreweryList>(responseList);
            return brewery;
        }
    }
}