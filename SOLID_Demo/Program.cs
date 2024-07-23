using SOLID_Demo;

Console.WriteLine("Starting the affiliate evaluation process");

var reportEngine = new ReportEngine();
reportEngine.EvaluateAffiliate();

Console.WriteLine($"Affiliate comission is {reportEngine.TotalCommission:C}");