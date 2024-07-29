using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class Factory
    {
        public static Calculator CreateCalculator(Affiliate affiliateInfo, ILogger logger, IReportEngine reportEngine)
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
        public static ILogger CreateLogger() => new Logger();
        public static IReader CreateReader() => new InfoReader();
        public static IReportEngine CreateReportEngine() => new SimpleReportEngine(CreateLogger(), CreateReader());

    }
}
