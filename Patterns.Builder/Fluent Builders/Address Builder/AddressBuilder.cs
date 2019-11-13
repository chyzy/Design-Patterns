using Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces;
using Patterns.Builder.Models;

namespace Patterns.Builder.Fluent_Builders.Address_Builder
{
    public class AddressBuilder : ICountryBuilder, ICityBuilder, IPostalCodeBuilder, IStreetBuilder, IHouseNumberBuilder, IAddressOptionalValuesBuilder
    {
        public static ICountryBuilder CreateAddress()
        {
            return new AddressBuilder();
        }

        private AddressBuilder()
        {
            
        }

        #region Builder Properties

        private string _country;
        private string _city;
        private string _postalCode;
        private string _street;
        private string _houseNumber;
        private string _flatNumber;
        private string _remarks;

        #endregion

        #region Builder 
        public ICityBuilder InCountry(string country)
        {
            _country = country;
            return this;
        }

        public IPostalCodeBuilder InCityOf(string city)
        {
            _city = city;
            return this;
        }

        public IStreetBuilder WithPostalCode(string postalCode)
        {
            _postalCode = postalCode;
            return this;
        }

        public IHouseNumberBuilder AtStreet(string street)
        {
            _street = street;
            return this;
        }

        public IAddressOptionalValuesBuilder InHouseNumber(string houseNumber)
        {
            _houseNumber = houseNumber;
            return this;
        }

        public IAddressOptionalValuesBuilder InFlatNumber(string flatNumber)
        {
            _flatNumber = flatNumber;
            return this;
        }

        public IAddressOptionalValuesBuilder Remarks(string remarks)
        {
            _remarks = remarks;
            return this;
        }
        #endregion

        public Address Build()
        {
            return new Address()
            {
                Country = _country,
                City = _city,
                PostalCode = _postalCode,
                Street = _street,
                HouseNumber = _houseNumber,
                FlatNumber = _flatNumber
            };
        }
    }
}
