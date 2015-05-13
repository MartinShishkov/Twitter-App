using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Twitter.Models
{
    public class User : IdentityUser
    {
        private ICollection<User> _followers;
        private ICollection<User> _followingUsers; 

        public User()
        {
            this._followers = new HashSet<User>();
            this._followingUsers = new HashSet<User>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<User> Followers
        {
            get { return this._followers; }
            private set { this._followers = value; }
        }

        public virtual ICollection<User> FollowingUsers
        {
            get { return this._followingUsers; }
            set { this._followingUsers = value; }
        } 
    }
}
