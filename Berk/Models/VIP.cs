using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class VIP
    {
        public int VIPID { get; set; }
        public string Alive = "alive";
        public string Dead = "deceased";

        public string Name { get; set; }
        public string Reason { get; set; }
        public string Link { get; set; }
        public bool IsAlive { get; set; }
    }
}
