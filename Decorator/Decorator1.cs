using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract  class Decorator1 : Component
    {
        public Component component;
        public Decorator1(Component component)
        {
            this.component = component;
        }
        public override int Operation()
        {
            return component.Operation();
        }
    }
}
