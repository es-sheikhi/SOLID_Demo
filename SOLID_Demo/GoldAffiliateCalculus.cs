using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class GoldAffiliateCalculus:Calculator
    {
        public GoldAffiliateCalculus(Logger logger, ReportEngine reportEngine):base(logger, reportEngine)
        {
        }

        public override void Calculate(Affiliate affiliate)
        {
            _logger.Log("Calculating the gold affiliate's total commission");
            if (affiliate.ItemsSold > 20)
            {
                _reportEngine.TotalCommission = affiliate.TotalSales * .50m;
            }
            else if (affiliate.ItemsSold > 10)
            {
                _reportEngine.TotalCommission = affiliate.TotalSales * .40m;
            }
            else
            {
                _reportEngine.TotalCommission = affiliate.TotalSales * .30m;
            }
        }
    }
}
