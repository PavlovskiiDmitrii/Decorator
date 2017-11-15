using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorSauce : Decorator1
    {
        public ConcreteDecoratorSauce(Component component)
            :base(component)
        {

        }

        int Sauce = 50;
        public override int Operation()
        {
            return Sauce + base.Operation();
        }
    }
}
