using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        private Member member = new Member();

        // public string Sender { get; set; }
        public string MessageText { get; set; }
        public DateTime Sent { get; set; }
        public string MemberName { get; set; }
        //public Administrator Admin { get; set; }
    }
}
