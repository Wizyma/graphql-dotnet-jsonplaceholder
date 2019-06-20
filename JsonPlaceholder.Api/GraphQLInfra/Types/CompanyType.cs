using System;
using GraphQL.Types;
using JsonPlaceholder.Api.Repositories.Users.Models;

namespace JsonPlaceholder.Api.GraphQLInfra.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Name = "Company";
            Description = "Company ";
            Field(c => c.Bs, nullable: true);
            Field(c => c.CatchPhrase, nullable: true);
            Field(c => c.Name, nullable: true);
        }
    }
}
