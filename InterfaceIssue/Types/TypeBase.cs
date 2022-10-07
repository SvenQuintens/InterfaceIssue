using InterfaceIssue.Entities;

namespace InterfaceIssue.Types
{
    public abstract class TypeBase<T> : ObjectType<T> where T : EntityBase
    {
        protected override void Configure(IObjectTypeDescriptor<T> descriptor)
        {
            descriptor.Field(b => b.Id).Type<NonNullType<UuidType>>();

            descriptor.Ignore(b => b.CreatedOn);
            descriptor.Ignore(b => b.LastUpdated);
        }
    }
}
