using GraphQL;
using GraphQL.Types;
using JsonPlaceholder.Api.GraphQLInfra.Query;

namespace JsonPlaceholder.Api.GraphQLInfra.Schemas
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
