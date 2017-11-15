using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Decorator;

namespace DecoratorTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void OnlyWBread()
        {
            Component sub = new ConcreteComponentWBread();
            Assert.AreEqual(sub.Operation(),100);
        }

        [Test]
        public void OnlyBBread()
        {
            Component sub = new ConcreteComponentBBread();
            Assert.AreEqual(sub.Operation(), 110);
        }

        [Test]
        public void CheeseWBread()
        {
            Component sub = new ConcreteDecoratorCheese(new ConcreteComponentWBread());
            Assert.AreEqual(sub.Operation(), 150);
        }
        [Test]
        public void MushroomsWBread()
        {
            Component sub = new ConcreteDecoratorMushrooms(new ConcreteComponentWBread());
            Assert.AreEqual(sub.Operation(), 170);
        }
        [Test]
        public void SouceWBread()
        {
            Component sub = new ConcreteDecoratorSauce(new ConcreteComponentWBread());
            Assert.AreEqual(sub.Operation(), 150);
        }
        [Test]
        public void VegebetalssWBread()
        {
            Component sub = new ConcreteDecoratorVegetables(new ConcreteComponentWBread());
            Assert.AreEqual(sub.Operation(), 160);
        }
        [Test]
        public void VegebetalssCheesMushroomsSauceWBread()
        {
            Component sub = new ConcreteDecoratorVegetables(new ConcreteDecoratorMushrooms (new ConcreteDecoratorCheese(new ConcreteDecoratorSauce(new ConcreteComponentWBread()))));
            Assert.AreEqual(sub.Operation(), 330);
        }
    }
}
