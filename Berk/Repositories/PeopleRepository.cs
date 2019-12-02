using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;
using Microsoft.EntityFrameworkCore;

namespace Berk.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private AppDbContext context;
        private static List<VIP> people = new List<VIP>();

        public List<VIP> VIPs { get { return context.VIPs.ToList(); } }

        public PeopleRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddPeople(VIP vip)
        {
            context.VIPs.Add(vip);
            context.SaveChanges();
        }

        public VIP GetPersonByName(string name)
        {
            VIP vip;
            vip = context.VIPs.First(p => p.Name == name);
            return vip;
        }

    }
}
