﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TheBeerCatalogue.Business
{
    public interface BeerInterface
    {
        async HttpResponseMessage GetBeer();
    }
}
