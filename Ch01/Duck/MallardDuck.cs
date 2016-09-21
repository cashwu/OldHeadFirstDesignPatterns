using System;
using Ch01.Fly;

namespace Ch01.Duck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack.Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
