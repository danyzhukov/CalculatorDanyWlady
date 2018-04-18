using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Two_pow_x: IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}

