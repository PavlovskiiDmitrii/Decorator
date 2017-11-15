using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponentWBread : Component
    {
        public override int Operation()
        {
            return 100;
        }
    }
}
