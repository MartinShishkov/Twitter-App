namespace Twitter.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Twitter.Models;

    public class TwitterDbContext : IdentityDbContext<User>
    {
        public TwitterDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Reply> Replies { get; set; }

        public IDbSet<UserMessage> UserMessages { get; set; } 
    }
}
