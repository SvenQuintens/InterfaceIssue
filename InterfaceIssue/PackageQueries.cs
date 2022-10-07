using InterfaceIssue.Entities;

namespace InterfaceIssue
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class PackageQueries
    {
        public Task<IQueryable<Package>> GetPackagesAsync()
        {
            return default;
        }
    }
}
