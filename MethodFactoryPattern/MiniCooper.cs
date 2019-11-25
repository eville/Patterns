using System;

namespace MethodFactoryPattern
{
    internal class MiniCooper: IAuto
    {
        public string Name { private set;  get; }
        public MiniCooper(string name)
        {
            this.Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine("Mini Cooper is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Mini Cooper is turned off.");
        }
    }
}