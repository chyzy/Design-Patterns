using Patterns.Builder.Models;

namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface IAddressOptionalValuesBuilder
    {
        IAddressOptionalValuesBuilder InFlatNumber(string flatNumber);

        IAddressOptionalValuesBuilder Remarks(string remarks);

        Address Build();
    }
}
