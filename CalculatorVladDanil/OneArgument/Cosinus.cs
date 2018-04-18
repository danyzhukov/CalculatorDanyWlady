using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Cosinus : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
