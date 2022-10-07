namespace InterfaceIssue.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LastUpdated { get; set; }
    }
}
