using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public abstract class Calculator
    {
        protected readonly ILogger _logger;
        protected readonly IReportEngine _reportEngine;
        protected Calculator(ILogger logger, IReportEngine reportEngine)
        {
            _logger = logger;
            _reportEngine = reportEngine;
        }

        public abstract void Calculate(Affiliate affiliate);
    }
}
