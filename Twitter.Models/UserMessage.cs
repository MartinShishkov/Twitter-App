using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    [Table("UserMessages")]
    public class UserMessage
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public string SenderId { get; set; }
        public virtual User Sender { get; set; }

        public string RecipientId { get; set; }
        public virtual User Recipient { get; set; }
    }
}
