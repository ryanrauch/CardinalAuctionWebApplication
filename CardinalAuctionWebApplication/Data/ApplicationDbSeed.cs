using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalAuctionWebApplication.Data
{
    public static class ApplicationDbSeed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Companies.Any())
            {
                return;
            }

        }
    }
}
