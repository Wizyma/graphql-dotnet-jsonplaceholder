using System.Collections.Generic;
using System.Threading.Tasks;
using JsonPlaceholder.Api.Repositories.Posts.Models;

namespace JsonPlaceholder.Api.Repositories.Posts
{
    public class JsonPlaceholderProxyPost : JsonPlaceholderProxy
    {
        public JsonPlaceholderProxyPost() : base("posts") { }

        public async Task<List<Post>> GetAllAsync()
        {
            return await Get<Post>();
        }

        public async Task<List<Post>> GetByUserId(long id)
        {
            return await Get<Post>($"userId={id}");
        }
    }
}
