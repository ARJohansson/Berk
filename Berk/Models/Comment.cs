using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime TimeStamp { get; set; }
        public Member MemberName { get; set; }
        public Administrator Admin { get; set; }
        public Location Place { get; set; }
        // public string Sender { get; set; }
    }
}
