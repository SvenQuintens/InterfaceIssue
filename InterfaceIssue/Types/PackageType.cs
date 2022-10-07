using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class PackageType : TypeBase<Package>
    {
        protected override void Configure(IObjectTypeDescriptor<Package> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Products).Type<ProductType>();
        }
    }
}
