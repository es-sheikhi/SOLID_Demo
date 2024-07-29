using SOLID_Demo;

Console.WriteLine("Starting the affiliate evaluation process");

IReportEngine reportEngine = Factory.CreateReportEngine();
reportEngine.EvaluateAffiliate();

Console.WriteLine($"Affiliate comission is {reportEngine.TotalCommission:C}");