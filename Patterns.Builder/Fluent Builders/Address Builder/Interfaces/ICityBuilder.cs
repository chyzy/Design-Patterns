namespace Patterns.Builder.Fluent_Builders.Address_Builder.Interfaces
{
    public interface ICityBuilder
    {
        IPostalCodeBuilder InCityOf(string city);
    }
}
