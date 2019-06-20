using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Types;
using JsonPlaceholder.Api.GraphQLInfra.Models.Posts;
using JsonPlaceholder.Api.GraphQLInfra.Models.Users;
using JsonPlaceholder.Api.Repositories.Posts;
using System.Linq;

namespace JsonPlaceholder.Api.GraphQLInfra.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";
            Description = "User ";
            Field<AddressType>("address");
            Field<CompanyType>("company");
            Field(u => u.Email, nullable: true);
            Field(u => u.Id, nullable: true);
            Field(u => u.Name, nullable: true);
            Field(u => u.Phone, nullable: true);
            Field(u => u.Username, nullable: true);
            Field(u => u.Website, nullable: true);
            Field<ListGraphType<PostType>>("posts", resolve: ctx => new JsonPlaceholderProxyPost().GetByUserId(ctx.Source.Id).ContinueWith(t => t.Result.Select(Post.From).ToList()));
        }
    }
}
