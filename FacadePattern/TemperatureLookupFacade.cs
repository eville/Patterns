namespace FacadePattern
{
    public class TemperatureLookupFacade
    {
        readonly WeatherService weatherService;
        readonly GeoLookupService geoLookupService;
        readonly EnglishMetricsConverter converter;
        public TemperatureLookupFacade(): 
            this(new WeatherService(), new GeoLookupService(), new EnglishMetricsConverter())
        {}

        public TemperatureLookupFacade
            (WeatherService weatherService, GeoLookupService geoLookupService, EnglishMetricsConverter converter)
        {
            this.weatherService = weatherService;
            this.geoLookupService = geoLookupService;
            this.converter = converter;
        }

        public LocalTemperature  GetTemperature(string zipCode)
        {
            var coords = geoLookupService.GetCoordinates(zipCode);
            var city = geoLookupService.GetCityForZipCode(zipCode);
            var country = geoLookupService.GetCountryForZipCode(zipCode);

            var farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celcius = converter.FarenheitToCelcius(farenheit);

            var localTemperature = new LocalTemperature()
            { 
                Farenheit = farenheit,
                Celcius = celcius,
                City = city,
                Country = country
            };

            return localTemperature;
        }
    }
}
