namespace AbstractFactory
{
    public interface IAutoFactory
    {
        IAuto CreateSportsCar();
        IAuto CreateLuxuryCar();
        IAuto CreateEconomyCar();
    }
}
