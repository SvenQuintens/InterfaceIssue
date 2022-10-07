using InterfaceIssue.Entities;

namespace InterfaceIssue
{
    [Node]
    [ExtendObjectType(typeof(Package))]
    public class PackageNode
    {
        [NodeResolver]
        public Task<Package> GetPackageByIdAsync(
            Guid id,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(new Package());
        }
    }
}
