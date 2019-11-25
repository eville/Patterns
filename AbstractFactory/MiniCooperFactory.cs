namespace AbstractFactory
{
    public class MiniCooperFactory: IAutoFactory
    {
        public IAuto CreateEconomyCar()
        {
            var mini = new MiniCooper();
            return mini;
        }

        public IAuto CreateLuxuryCar()
        {
            var mini = new MiniCooper();
            mini.AddLuxuryPackage();
            return mini;
        }

        public IAuto CreateSportsCar()
        {
            var mini = new MiniCooper();
            mini.AddSportsPackage();
            return mini;
        }

    }
}
