namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface IPostalCodeBuilder
    {
        IStreetBuilder WithPostalCode(string postalCode);
    }
}
