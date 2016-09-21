using System;

namespace Ch01.Quack
{
    class MuteQuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
