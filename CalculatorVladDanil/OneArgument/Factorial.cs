namespace CalculatorVladDanil.OneArgument
{
    public class Factorial : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            int res = 1;
            for (int i = (int)firstArgument; i > 1; i--)
                res *= i;
            return res;
        }
    }
}
