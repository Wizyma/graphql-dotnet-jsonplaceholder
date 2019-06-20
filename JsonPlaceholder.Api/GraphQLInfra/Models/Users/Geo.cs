using System;

namespace JsonPlaceholder.Api.GraphQLInfra.Models.Users
{
    public class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }

        public static Geo From(Repositories.Users.Models.Geo geo)
        {
            return new Geo
            {
                Lat = geo.Lat,
                Lng = geo.Lng,
            };
        }
    }
}
