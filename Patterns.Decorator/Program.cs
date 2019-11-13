using System;
using Patterns.Decorator.Decorators;
using Patterns.Decorator.Models;

namespace Patterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new PersonalComputer();

            var pcWithRAM = new RAMDecorator(computer);
            var pcWithSSD = new SSDDecorator(pcWithRAM);

            pcWithSSD.Startup();

            Console.ReadKey();
        }
    }
}
