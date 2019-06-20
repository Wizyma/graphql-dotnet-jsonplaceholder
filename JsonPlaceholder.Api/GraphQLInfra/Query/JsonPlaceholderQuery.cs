using System;
using GraphQL.Types;
using JsonPlaceholder.Api.GraphQLInfra.Types;
using JsonPlaceholder.Api.Repositories.Users;
using System.Linq;
using JsonPlaceholder.Api.GraphQLInfra.Models.Users;
using JsonPlaceholder.Api.Repositories.Posts;
using JsonPlaceholder.Api.GraphQLInfra.Models.Posts;

namespace JsonPlaceholder.Api.GraphQLInfra.Query
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
