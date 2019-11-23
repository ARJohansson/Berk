using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public interface IPeopleRepository
    {
        List<VIP> VIPs { get; }
        void AddPeople(VIP vip);
        void AddPeopleInfo();
        VIP GetPersonByName(string name);
    }
}
