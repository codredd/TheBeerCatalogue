using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public interface BeerInterface
    {
        Task<BeerList> GetBeer();
    }
}
