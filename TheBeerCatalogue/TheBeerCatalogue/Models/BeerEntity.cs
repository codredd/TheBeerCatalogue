using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBeerCatalogue.Models
{
    public class BeerEntity
    {
        public string Id;
        public string Name;
        public string Description;
        public string FoodPairings;
        public string OriginalGravity;
        public string Abv;
        public string Ibu;
        public int GlasswareId;
        public string Glass;
        public int StyleId;
        public string Style;
        public string IsOrganic;
        public string Labels;
        public string ServingTemperature;
        public string ServingTemperatureDisplay;
        public string Status;
        public string StatusDisplay;
        public string AvailableId;
        public string Available;
        public string BeerVariationId;
        public int year;
    }
}