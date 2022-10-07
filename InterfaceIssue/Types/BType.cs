using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class BType : TypeBase<B>
    {
        protected override void Configure(IObjectTypeDescriptor<B> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Implements<ProductType>();
        }
    }
}
