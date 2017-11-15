using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorMushrooms : Decorator1
    {
        public ConcreteDecoratorMushrooms(Component component)
            :base(component)
        {

        }
        int Mushrooms = 70;
        public override int Operation()
        {
            return Mushrooms + base.Operation();
        }
    }
}
