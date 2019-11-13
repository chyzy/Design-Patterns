using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Decorator.Models;

namespace Patterns.Decorator.Decorators
{
    public class DecoratorBase : ComputerBase
    {
        public DecoratorBase(ComputerBase computer)
        {
            _computer = computer;
        }

        protected ComputerBase _computer;

        public override int Price => _computer.Price;

        public override void Startup()
        {
            _computer.Startup();
        }
    }
}
