using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Ten_pow_x: IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
