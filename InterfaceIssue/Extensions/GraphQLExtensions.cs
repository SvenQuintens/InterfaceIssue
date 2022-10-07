using HotChocolate.Execution.Configuration;

namespace InterfaceIssue.Extensions
{
    public static class GraphQLExtensions
    {
        public static IRequestExecutorBuilder AddGraphQLTypeExtensions(this IRequestExecutorBuilder builder, Type typeToSearch)
        {
            var types = typeToSearch.Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsInheritedFrom(typeToSearch));

            foreach (var type in types)
            {
                builder.AddTypeExtension(type);
            }

            return builder;
        }

        private static bool IsInheritedFrom(this Type type, Type Lookup)
        {
            var baseType = type.BaseType;
            if (baseType == null)
                return false;

            if (baseType.IsGenericType
                    && baseType.GetGenericTypeDefinition() == Lookup)
                return true;

            return baseType.IsInheritedFrom(Lookup);
        }
    }
}
