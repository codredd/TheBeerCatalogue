﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TheBeerCatalogue.Business
{
    public class BeerFacade : BeerInterface
    {
        HttpClient client = new HttpClient();
        private string beerUrl = "http://api.brewerydb.com/v2/beers?key=ee8a1a84bc76fd7d7ae6dd0dc45583e3";

        public async Task<BeerEntity> GetBeer()
        {
            HttpResponseMessage response =await client.GetAsync(beerUrl);

            if(response.IsSuccessStatusCode)
            {
                return response;
            }

            else return null;
            //throw new NotImplementedException();
        }
    }
}
