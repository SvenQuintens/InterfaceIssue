namespace InterfaceIssue.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal price { get; set; }

        public ICollection<Package> Packages { get; set; } = new List<Package>();
    }
}
