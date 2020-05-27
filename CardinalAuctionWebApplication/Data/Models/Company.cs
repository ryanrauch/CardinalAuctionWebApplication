using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalAuctionWebApplication.Data.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
