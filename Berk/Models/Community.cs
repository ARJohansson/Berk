﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class Community
    {
        public int CommunityID { get; set; }
        private List<Member> admins = new List<Member>();
        private List<VIP> vips = new List<VIP>();
        private List<Location> locations = new List<Location>();
        private List<History> histories = new List<History>();

        public string Name { get; set; }
        public DateTime Est { get; set; }

        public List<Member> Administrators { get { return admins; } }
        public List<VIP> VIPs { get { return vips; } }
        public List<Location> Locations { get { return locations; } }
        public List<History> Histories { get { return histories; } }
    }
}
