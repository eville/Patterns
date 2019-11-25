using System;

namespace FacadePattern
{
    public class GeoLookupService
    {
        public Coordinates GetCoordinates(string zipCode)
        {
            return new Coordinates();
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Kaunas";
        }

        public string GetCountryForZipCode(string zipCode)
        {
            return "Lithuania";
        }
    }
}
