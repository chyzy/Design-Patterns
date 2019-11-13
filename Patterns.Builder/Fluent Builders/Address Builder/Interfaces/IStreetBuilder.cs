namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface IStreetBuilder
    {
        IHouseNumberBuilder AtStreet(string street);
    }
}
