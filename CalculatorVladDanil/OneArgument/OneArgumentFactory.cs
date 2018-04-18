using System;

namespace CalculatorVladDanil.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentcalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Module" :
                    return new Module_of_x();
                case "Arccosinus":
                    return new Arccosinus();
                case "Arcsinus":
                    return new Arcsinus();
                case "Two_in_power":
                    return new Two_pow_x();
                case "Cosinus":
                    return new Cosinus();
                case "Factorial":
                    return new Factorial();
                case "Sinus":
                    return new Sinus();
                case "Sqrt":
                    return new Sqrt();
                case "Square":
                    return new Square();
                case "Ten":
                    return new Ten_pow_x();
                default :
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
