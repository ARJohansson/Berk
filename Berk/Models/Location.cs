using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        private List<Comment> comments = new List<Comment>();

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Comment> Commments { get { return comments; } }

    }
}
