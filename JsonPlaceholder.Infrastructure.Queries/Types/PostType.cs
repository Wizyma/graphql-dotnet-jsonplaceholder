using GraphQL.Types;
using JsonPlaceholder.Infrastructure.Queries.Models.Posts;
using JsonPlaceholder.Infrastructure.Repositories.Users;
using JsonPlaceholder.Infrastructure.Queries.Models.Users;

namespace JsonPlaceholder.Infrastructure.Queries.Types
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
