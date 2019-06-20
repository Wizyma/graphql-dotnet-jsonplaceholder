using System;
using GraphQL.Types;
using JsonPlaceholder.Infrastructure.Repositories.Users.Models;

namespace JsonPlaceholder.Infrastructure.Queries.Types
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
