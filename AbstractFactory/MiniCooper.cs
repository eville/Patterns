using System;


namespace AbstractFactory
{
    internal class MiniCooper: IAuto
    {
        private string messageOn = "Mini Cooper is turned on.";

        private string messageOff = "Mini Cooper is turned on.";
        public MiniCooper()
        {

        }

        public void TurnOn()
        {
            Console.WriteLine(messageOn);
        }

        public void TurnOff()
        {
            Console.WriteLine(messageOff);
        }

        internal void AddLuxuryPackage()
        {

            this.messageOn =
                "Mini Cooper S with leather upholstery is turned on. 1.6 Liters of brutal force is churning.";
                   
        }

        internal void AddSportsPackage()
        {
            this.messageOn = "Mini Cooper S is turned on. 1.6 Liters of brutal force is churning.";

        }
    }
}