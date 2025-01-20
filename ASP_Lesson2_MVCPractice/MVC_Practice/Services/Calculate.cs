namespace MVC_Practice.Services
{
    public class Calculate : ICalculate
    {
        public decimal Data { get; set; }

        decimal ICalculate.Calculator(decimal value)
        {
            return Data += 100;
        }
    }
}
