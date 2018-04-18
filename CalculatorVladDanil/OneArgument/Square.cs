namespace CalculatorVladDanil.OneArgument
{
    public class Square : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return firstArgument*firstArgument;
        }
    }
}
