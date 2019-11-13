using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Decorator.Models;

namespace Patterns.Decorator.Decorators
{
    public class RAMDecorator : DecoratorBase
    {
        public RAMDecorator(ComputerBase computer) : base(computer)
        {
        }

        public override int Price => base.Price + 50;
        public override void Startup()
        {
            base.Startup();
            Console.WriteLine("RAM Startup");
        }
    }
}
