using System;
using GraphQL.Types;
using JsonPlaceholder.Api.GraphQLInfra.Models.Posts;
using JsonPlaceholder.Api.Repositories.Users;
using System.Linq;
using JsonPlaceholder.Api.GraphQLInfra.Models.Users;

namespace JsonPlaceholder.Api.GraphQLInfra.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType ()
        {
            Name = "Post";
            Description = "Posts ";
            Field(p => p.Id, nullable: false).Description("Id of the post");
            Field(p => p.Title, nullable: true);
            Field(p => p.Body, nullable: true);
            Field(p => p.UserId, nullable: false);
            Field<UserType>("user", resolve: ctx => new JsonPlaceholderProxyUser().GetUser(ctx.Source.Id).ContinueWith(t => User.From(t.Result)));
        }
    }
}
