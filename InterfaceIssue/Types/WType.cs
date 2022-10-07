using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class WType : TypeBase<W>
    {
        protected override void Configure(IObjectTypeDescriptor<W> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Implements<ProductType>();
        }
    }
}
