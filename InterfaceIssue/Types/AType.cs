using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public class AType : TypeBase<A>
    {
        protected override void Configure(IObjectTypeDescriptor<A> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Implements<ProductType>();
        }
    }
}
