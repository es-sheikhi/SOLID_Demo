﻿using System;
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

        public void EvaluateAffiliate()
        {
            Console.WriteLine("Starting evaluation process");
            var affiliateInfoFile = File.ReadAllText("report.json");
            var affiliateInfo =
                JsonSerializer.Deserialize<Affiliate>(affiliateInfoFile);
            Console.WriteLine("File read successfully");
            switch (affiliateInfo.Level)
            {
                case AffiliateLevel.Basic:
                    Console.WriteLine("Calculating the basic affiliate's total commission");
                    TotalCommission = affiliateInfo.TotalSales * .15m;
                    break;
                case AffiliateLevel.Silver:
                    Console.WriteLine("Calculating the silver affiliate's total commission");
                    if (affiliateInfo.ItemsSold > 10)
                    {
                        TotalCommission = affiliateInfo.TotalSales * .25m;
                    }
                    else
                    {
                        TotalCommission = affiliateInfo.TotalSales * .20m;
                    }
                    break;
                case AffiliateLevel.Gold:
                    Console.WriteLine("Calculating the gold affiliate's total commission");
                    if (affiliateInfo.ItemsSold > 20)
                    {
                        TotalCommission = affiliateInfo.TotalSales * .50m;
                    }
                    else if (affiliateInfo.ItemsSold > 10)
                    {
                        TotalCommission = affiliateInfo.TotalSales * .40m;
                    }
                    else
                    {
                        TotalCommission = affiliateInfo.TotalSales * .30m;
                    }
                    break;
            }
        }
    }
}