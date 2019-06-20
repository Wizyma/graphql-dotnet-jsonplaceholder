using System;

namespace JsonPlaceholder.Infrastructure.Queries.Models.Users
{
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }

        public static Address From(Repositories.Users.Models.Address address)
        {
            return new Address
            {
                Suite = address.Suite,
                Street = address.Street,
                City = address.City,
                Zipcode = address.City,
                Geo = Geo.From(address.Geo),
            };
        }
    }
}
