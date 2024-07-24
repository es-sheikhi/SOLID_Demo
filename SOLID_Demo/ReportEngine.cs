using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class ReportEngine
    {
        public decimal TotalCommission { get; set; }
        private Logger _logger = new();
        private InfoReader _reader = new();
        public void EvaluateAffiliate()
        {
            _logger.Log("Starting evaluation process");
            var affiliateInfo = _reader.ReadInfo();
            _logger.Log("File read successfully");

            switch (affiliateInfo.Level)
            {
                case AffiliateLevel.Basic:
                    BasicAffiliateCalculus basicCalculator = 
                        new BasicAffiliateCalculus(_logger, this);
                    basicCalculator.Calculate(affiliateInfo);
                    break;
                case AffiliateLevel.Silver:
                    SilverAffiliateCalculus silverCalculator =
                        new SilverAffiliateCalculus(_logger, this);
                    silverCalculator.Calculate(affiliateInfo);
                    break;
                case AffiliateLevel.Gold:
                    GoldAffiliateCalculus goldCalculator =
                        new GoldAffiliateCalculus(_logger, this);
                    goldCalculator.Calculate(affiliateInfo);
                    break;
            }
        }
    }
}
