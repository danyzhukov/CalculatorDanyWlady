using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Sqrt : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(firstArgument, 0.5);
        }
    }
}
