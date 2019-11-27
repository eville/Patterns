using System;
using System.Collections.Generic;
using System.Text;

namespace MethodFactoryPattern
{
    public class MiniCooperFactory: IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var mini = new MiniCooper("Mini Cooper 5");           
            return mini;
        }

    }
}
