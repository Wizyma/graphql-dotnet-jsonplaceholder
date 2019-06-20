using System;
using GraphQL.Types;
using JsonPlaceholder.Infrastructure.Repositories.Users.Models;

namespace JsonPlaceholder.Infrastructure.Queries.Types
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
