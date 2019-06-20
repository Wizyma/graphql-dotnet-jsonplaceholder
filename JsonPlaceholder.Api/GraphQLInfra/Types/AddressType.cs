using System;
using GraphQL.Types;
using JsonPlaceholder.Api.Repositories.Users.Models;

namespace JsonPlaceholder.Api.GraphQLInfra.Types
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Name = "Address";
            Description = "Address ";
            Field(a => a.City, nullable: true);
            Field<GeoType>("geo");
            Field(a => a.Street, nullable: true);
            Field(a => a.Suite, nullable: true);
            Field(a => a.Zipcode, nullable: true);
        }
    }
}
