using System;
using GraphQL.Types;
using JsonPlaceholder.Api.Repositories.Users.Models;

namespace JsonPlaceholder.Api.GraphQLInfra.Types
{
    public class GeoType : ObjectGraphType<Geo>
    {
        public GeoType()
        {
            Name = "Geo";
            Description = "Geo ";
            Field(g => g.Lat, nullable: true);
            Field(g => g.Lng, nullable: true);
        }
    }
}
