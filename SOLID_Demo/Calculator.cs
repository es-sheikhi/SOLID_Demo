using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public abstract class Calculator
    {
        protected readonly Logger _logger;
        protected readonly ReportEngine _reportEngine;
        protected Calculator(Logger logger, ReportEngine reportEngine)
        {
            _logger = logger;
            _reportEngine = reportEngine;
        }

        public abstract void Calculate(Affiliate affiliate);
    }
}
