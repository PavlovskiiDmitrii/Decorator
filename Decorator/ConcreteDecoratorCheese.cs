using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorCheese : Decorator1
    {
        public ConcreteDecoratorCheese(Component component)
            : base (component)
        {

        }
        int cheese = 50;
        public override int Operation()
        {
            return cheese + base.Operation();
        }
    }
}
