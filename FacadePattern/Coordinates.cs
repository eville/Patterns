namespace FacadePattern
{
    public class Coordinates
    {
        public double Latitude { private set; get; }
        public double Longitude { private set; get; }
        public Coordinates(double latitude = 0, double longitude = 0)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
