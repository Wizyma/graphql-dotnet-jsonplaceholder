﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JsonPlaceholder.Infrastructure.Repositories.Posts.Models;

namespace JsonPlaceholder.Infrastructure.Repositories.Posts
{
    public class JsonPlaceholderProxyPost : JsonPlaceholderProxy
    {
        public JsonPlaceholderProxyPost() : base("posts") { }

        public async Task<List<Post>> GetAllAsync()
        {
            return await Get<List<Post>>();
        }

        public async Task<List<Post>> GetByUserId(long id)
        {
            return await Get<List<Post>>($"?userId={id}");
        }
    }
}
