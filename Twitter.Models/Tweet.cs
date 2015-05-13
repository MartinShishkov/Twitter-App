using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Tweet
    {
        private ICollection<Reply> _replies; 

        public Tweet()
        {
            this._replies = new HashSet<Reply>();
        }

        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public int Reports { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Reply> Replies
        {
            get { return this._replies; }
            private set { this._replies = value; }
        }
    }
}
