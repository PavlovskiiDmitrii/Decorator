using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorVegetables : Decorator1
    {
        public ConcreteDecoratorVegetables(Component component)
            :base(component)
        {

        }
        int Vegetables = 60;
        public override int Operation()
        {
            return Vegetables + base.Operation();
        }
    }
}
