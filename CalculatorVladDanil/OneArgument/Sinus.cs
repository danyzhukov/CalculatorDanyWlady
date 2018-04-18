using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Sinus : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
