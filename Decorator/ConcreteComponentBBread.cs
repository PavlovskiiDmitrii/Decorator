using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponentBBread : Component
    {
        public override int Operation()
        {
            return 110;
        }
    }
}
