using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class CType : TypeBase<C>
    {
        protected override void Configure(IObjectTypeDescriptor<C> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Implements<ProductType>();
        }
    }
}
