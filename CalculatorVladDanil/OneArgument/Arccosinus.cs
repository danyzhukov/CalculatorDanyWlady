using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Arccosinus : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
