using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator.Models
{
    public class PersonalComputer : ComputerBase
    {
        public override int Price { get; } = 100;

        public override void Startup()
        {
            Console.WriteLine("Startup");
        }
    }
}
