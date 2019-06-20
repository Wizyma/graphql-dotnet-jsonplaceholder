using GraphQL;
using GraphQL.Types;
using JsonPlaceholder.Infrastructure.Queries.Query;

namespace JsonPlaceholder.Infrastructure.Queries.Schemas
{
    public class JsonPlaceholderSchema : Schema
    {
        public JsonPlaceholderSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<JsonPlaceholderQuery>();
        }
    }
}
