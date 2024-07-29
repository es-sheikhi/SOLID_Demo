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

            Calculator calculator = CalculatorFactory.Create(affiliateInfo, _logger, this);
            calculator.Calculate(affiliateInfo);
        }
    }
}
