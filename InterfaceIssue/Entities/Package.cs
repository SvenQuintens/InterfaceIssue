namespace InterfaceIssue.Entities
{
    public class Package : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
