using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class NullAuto : IAuto
    {
        
        public void TurnOff()
        {
            Console.WriteLine("No engine to start.");
        }

        public void TurnOn()
        {
            Console.WriteLine("No engine to stop.");
        }
    }
}
