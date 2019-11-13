using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder.Models
{
    public class Address
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string FlatNumber { get; set; }

        public string PostalCode { get; set; }

        public override string ToString()
        {
            return
                $"{Street} " +
                $"{HouseNumber}" +
                $"{(string.IsNullOrWhiteSpace(FlatNumber) ? String.Empty : $"/{FlatNumber}")}" +
                $", {PostalCode}" +
                $" {City}" +
                $", {Country}";
        }
    }
}
