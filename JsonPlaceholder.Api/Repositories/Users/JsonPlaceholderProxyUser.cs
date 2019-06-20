using System.Collections.Generic;
using System.Threading.Tasks;
using JsonPlaceholder.Api.Repositories.Users.Models;

namespace JsonPlaceholder.Api.Repositories.Users
{
    public class JsonPlaceholderProxyUser : JsonPlaceholderProxy
    {
        public JsonPlaceholderProxyUser() : base("users") { }

        public async Task<List<User>> GetAllAsync()
        {
            return await Get<List<User>>();
        }

        public async Task<User> GetUser(long id)
        {
            return await Get<User>($"/{id}");
        }
    }
}
