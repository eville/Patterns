using System;
using System.Collections.Generic;
using System.Text;

namespace MethodFactoryPattern
{
    public class BMW : IAuto
    {
        public string Name { private set; get; }
        public BMW(string name)
        {
            this.Name = name ?? throw new ArgumentNullException("name");
        }
        public void TurnOff()
        {
            Console.WriteLine( $"The {Name} is up and running with a mighty whirl!");
        }

        public void TurnOn()
        {
            Console.WriteLine($"The {Name} is shutting down!");
        }
    }
}
