using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class History
    {
        public int HistoryId { get; set; }
        public string HistoryText { get; set; }
        public DateTime Posted { get; set; }
    }
}
