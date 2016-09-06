using System;

namespace Ch01
{
    class MuteQuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
