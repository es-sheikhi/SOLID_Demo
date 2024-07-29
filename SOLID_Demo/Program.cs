using SOLID_Demo;

Console.WriteLine("Starting the affiliate evaluation process");

IReportEngine reportEngine = new SimpleReportEngine(new Logger(), new InfoReader());
reportEngine.EvaluateAffiliate();

Console.WriteLine($"Affiliate comission is {reportEngine.TotalCommission:C}");