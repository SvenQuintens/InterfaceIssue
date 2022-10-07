using InterfaceIssue.Entities;

namespace InterfaceIssue
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class ProductQueries
    {
        public Task<IQueryable<Product>> GetProductsAsync()
        {
            var result = new List<Product> { new A { Name = "Test" }, new B { Name = "test" } };
            return Task.FromResult(result.AsQueryable());
        }
    }
}
