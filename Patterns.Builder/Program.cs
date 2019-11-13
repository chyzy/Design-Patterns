using System;
using Patterns.Builder.Fluent_Builders.Address_Builder;

namespace Patterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = AddressBuilder
                .CreateAddress()
                .InCountry("Poland")
                .InCityOf("Poznań")
                .WithPostalCode("61-854")
                .AtStreet("Zielona")
                .InHouseNumber("29A")
                .InFlatNumber("14")
                .Build();

            Console.WriteLine(address);

            Console.ReadKey();
        }
    }
}
