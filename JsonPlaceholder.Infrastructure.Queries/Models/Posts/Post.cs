using System;
using JsonPlaceholder.Infrastructure.Queries.Models.Users;

namespace JsonPlaceholder.Infrastructure.Queries.Models.Posts
{
    public class Post
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }

        public static Post From(Repositories.Posts.Models.Post post)
        {
            return new Post
            {
                Id = post.Id,
                UserId = post.UserId,
                Title = post.Title,
                Body = post.Body,
            };
        }
    }
}
