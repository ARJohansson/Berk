using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Administrator
    {
        public int AdministratorID { get; set; }
        private List<string> overSees = new List<String>();
        private List<Comment> comments = new List<Comment>();
        private List<Message> messages = new List<Message>();

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime becameAdmin { get; set; }

        public List<string> OverSees { get { return overSees; } }
        public List<Comment> Comments { get { return comments; } }
        public List<Message> Messages { get { return messages; } }
    
    }
}
