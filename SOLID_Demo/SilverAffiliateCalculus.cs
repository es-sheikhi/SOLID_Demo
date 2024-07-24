using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class SilverAffiliateCalculus : Calculator
    {
        public SilverAffiliateCalculus(Logger logger, ReportEngine reportEngine) : base(logger, reportEngine)
        {
        }

        public override void Calculate(Affiliate affiliate)
        {
            _logger.Log("Calculating the silver affiliate's total commission");
            if (affiliate.ItemsSold > 10)
            {
                _reportEngine.TotalCommission = affiliate.TotalSales * .25m;
            }
            else
            {
                _reportEngine.TotalCommission = affiliate.TotalSales * .20m;
            }
        }
    }
}
