using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Module_of_x : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Sign(firstArgument);
        }
    }
}
