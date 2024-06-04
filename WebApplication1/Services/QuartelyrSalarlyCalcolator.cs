namespace WebApplication1.Services
{
    public class QuartelyrSalarlyCalcolator: ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 4;
        }
    }
}
