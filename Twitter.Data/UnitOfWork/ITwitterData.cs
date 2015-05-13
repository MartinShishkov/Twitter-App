using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Twitter.Data.Repositories;
using Twitter.Models;

namespace Twitter.Data.UnitOfWork
{
    public interface ITwitterData
    {
        IRepository<User> Users { get; }

        IRepository<Tweet> Tweets { get; }

        IRepository<Reply> Replies { get; }

        IRepository<UserMessage> UserMessages { get; }
            
        IUserStore<User> UserStore { get; }

        void SaveChanges();
    }
}
