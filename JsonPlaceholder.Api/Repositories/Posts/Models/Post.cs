using System;
namespace JsonPlaceholder.Api.Repositories.Posts.Models
{
    public class Post
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
