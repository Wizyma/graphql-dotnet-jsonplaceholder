using System;
using System.Collections.Generic;
using GraphQL.Types;
using JsonPlaceholder.Api.GraphQLInfra.Models.Posts;

namespace JsonPlaceholder.Api.GraphQLInfra.Models.Users
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }
        public List<Post> Posts { get; set; }

        public static User From(Repositories.Users.Models.User user)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                Phone = user.Phone,
                Website = user.Website,
                Address = Address.From(user.Address),
                Company = Company.From(user.Company),
            };
        }
    }
}
