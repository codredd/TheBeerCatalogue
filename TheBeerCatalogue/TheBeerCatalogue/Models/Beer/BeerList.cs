using System.Collections.Generic;

namespace TheBeerCatalogue.Models
{
    public class BeerList
    {
        public int currentPage { get; set; }
        public int numberOfPages { get; set; }
        public int totalResults { get; set; }
        public List<Beer> data { get; set; }
        public string status { get; set; }
    }
}