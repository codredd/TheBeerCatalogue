using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public class BeerFacade : BeerInterface
    {
        WebClient client = new WebClient();
        private string beerUrl = "http://api.brewerydb.com/v2/beers?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

        public async Task<BeerList> GetBeer()
        {
            string responseList = client.DownloadString(beerUrl);

            BeerList beer = Newtonsoft.Json.JsonConvert.DeserializeObject<BeerList>(responseList);
            return beer;
        }
    }
}
