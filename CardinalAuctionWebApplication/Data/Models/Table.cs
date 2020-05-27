using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalAuctionWebApplication.Data.Models
{
    public class Table
    {
        public Guid TableId { get; set; }
        public Guid SectionId { get; set; }
        public Section Section { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
