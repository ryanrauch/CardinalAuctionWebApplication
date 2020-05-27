using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalAuctionWebApplication.Data.Models
{
    public class Section
    {
        public Guid SectionId { get; set; }
        public Guid BarId { get; set; }
        public Bar Bar { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
