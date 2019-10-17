using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class VIP
    {
        public int VIPID { get; set; }

        public string Name { get; set; }
        public string Reason { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateOfDeath { get; set; }
    }
}
