using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Arcsinus : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
