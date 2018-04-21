using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeerCatalogue.Models;

namespace TheBeerCatalogue.Business
{
    public interface BreweryInterface
    {
        BreweryList GetBrewery();
    }
}
