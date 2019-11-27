using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class CarNotFoundException: Exception
    {
        public CarNotFoundException()
        {

        }
        public CarNotFoundException(string message)
            :base(message)
        {

        }

        public CarNotFoundException(string message, Exception inner)
        : base(message, inner)
        {

        }
    }
}
