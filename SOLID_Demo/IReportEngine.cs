namespace SOLID_Demo
{
    public interface IReportEngine
    {
        decimal TotalCommission { get; set; }

        void EvaluateAffiliate();
    }
}