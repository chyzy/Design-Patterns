using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Models
{
    public abstract class ComputerBase
    {
        public abstract int Price { get; }

        public abstract void Startup();

    }
}
