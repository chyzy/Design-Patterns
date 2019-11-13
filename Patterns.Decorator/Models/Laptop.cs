using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Models
{
    public class Laptop : ComputerBase
    {
        public override int Price { get; } = 200;
        public override void Startup()
        {
            Console.WriteLine("Laptop startup");
        }
    }
}
