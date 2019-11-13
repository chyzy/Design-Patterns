namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface ICountryBuilder
    {
        ICityBuilder InCountry(string country);
    }
}
