﻿using System;

namespace Ch01
{
    internal class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            throw new NotImplementedException();
        }
    }
}