using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class ProductType : InterfaceType<Product>
    {
        protected override void Configure(IInterfaceTypeDescriptor<Product> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name(nameof(Product));

            descriptor.Field(b => b.Id).Type<NonNullType<UuidType>>();

            descriptor.Ignore(b => b.CreatedOn);
            descriptor.Ignore(b => b.LastUpdated);
        }
    }
}
