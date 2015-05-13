using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int TweetId { get; set; }
        public virtual Tweet Tweet { get; set; }
    }
}
