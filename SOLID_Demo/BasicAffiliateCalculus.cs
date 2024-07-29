using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class BasicAffiliateCalculus : Calculator
    {
        public BasicAffiliateCalculus(ILogger logger, IReportEngine reportEngine) : base(logger, reportEngine)
        {
        }

        public override void Calculate(Affiliate affiliate)
        {
            _logger.Log("Calculating the basic affiliate's total commission");
            _reportEngine.TotalCommission = affiliate.TotalSales * .15m;
        }
    }
}
