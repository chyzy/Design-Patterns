using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Decorator.Models;

namespace Patterns.Decorator.Decorators
{
    public class SSDDecorator : DecoratorBase
    {
        public SSDDecorator(ComputerBase computer) : base(computer)
        {

        }

        public override int Price => base.Price + 150;
        public override void Startup()
        {
            base.Startup();
            Console.WriteLine("SSD Startup");
        }

        
    }
}
