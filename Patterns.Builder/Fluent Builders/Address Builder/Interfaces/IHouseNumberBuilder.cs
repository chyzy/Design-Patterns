namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface IHouseNumberBuilder
    {
        IAddressOptionalValuesBuilder InHouseNumber(string houseNumber);
    }
}
