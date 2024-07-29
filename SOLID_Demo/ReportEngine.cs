using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class SimpleReportEngine : IReportEngine
    {
        public decimal TotalCommission { get; set; }
        private ILogger _logger;
        private IReader _reader;

        public SimpleReportEngine(ILogger logger, IReader reader)
        {
            _logger = logger;
            _reader = reader;
        }
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
