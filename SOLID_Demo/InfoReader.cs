using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    public class InfoReader
    {
        public Affiliate ReadInfo()
        {
            var affiliateInfoFile = File.ReadAllText("report.json");
            var affiliateInfo =
                JsonSerializer.Deserialize<Affiliate>(affiliateInfoFile);
            return affiliateInfo;
        }
    }
}
