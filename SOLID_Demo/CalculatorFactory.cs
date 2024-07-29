using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class CalculatorFactory
    {
        public static Calculator Create(Affiliate affiliateInfo, Logger logger, ReportEngine reportEngine)
        {
            switch (affiliateInfo.Level)
            {
                case AffiliateLevel.Basic:
                    return new BasicAffiliateCalculus(logger, reportEngine);
                case AffiliateLevel.Silver:
                    return new SilverAffiliateCalculus(logger, reportEngine);
                case AffiliateLevel.Gold:
                    return new GoldAffiliateCalculus(logger, reportEngine);
                default:
                    throw new Exception("Invalid affiliate level.");
            }
        }
    }
}
