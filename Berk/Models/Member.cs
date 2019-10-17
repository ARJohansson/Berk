using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        private List<Comment> comments = new List<Comment>();
        private List<Message> messages = new List<Message>();
        private List<String> oversees = new List<string>();

        public bool IsAdmin { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Joined { get; set; }
        public DateTime becameAdmin { get; set; }

        public List<Comment> Comments { get { return comments; } }
        public List<Message> Messages { get { return messages; } }
        public List<String> Oversees { get { return oversees; } }

    }
}
