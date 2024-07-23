using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    internal class Affiliate
    {
        public int AffiliateId { get; set; }
        public decimal TotalSales { get; set; }
        public AffiliateLevel Level { get; set; }
        public int ItemsSold { get; set; }
        public string TopSellingCategory { get; set; }
    }
}
