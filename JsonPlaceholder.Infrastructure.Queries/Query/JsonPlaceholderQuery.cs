using GraphQL.Types;
using JsonPlaceholder.Infrastructure.Queries.Types;
using JsonPlaceholder.Infrastructure.Repositories.Users;
using System.Linq;
using JsonPlaceholder.Infrastructure.Queries.Models.Users;
using JsonPlaceholder.Infrastructure.Repositories.Posts;
using JsonPlaceholder.Infrastructure.Queries.Models.Posts;

namespace JsonPlaceholder.Infrastructure.Queries.Query
{
    public class JsonPlaceholderQuery : ObjectGraphType
    {
        public JsonPlaceholderQuery()
        {
            Field<ListGraphType<UserType>>(
              "users",
              resolve: context => new JsonPlaceholderProxyUser().GetAllAsync().ContinueWith(t => t.Result.Select(User.From).ToList()),
              description: "Get all users !"
            );

            Field<ListGraphType<PostType>>("posts",
               resolve: ctx => new JsonPlaceholderProxyPost().GetAllAsync().ContinueWith(t => t.Result.Select(Post.From).ToList()));
        }
    }
}
