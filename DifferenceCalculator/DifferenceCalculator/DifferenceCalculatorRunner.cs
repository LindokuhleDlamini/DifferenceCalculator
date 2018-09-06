using System;

namespace DifferenceCalculator
{
    public class DifferenceCalculatorRunner
    {
        public static void Main(string[] args)
        {
            var result = new Displayer(50);
            result.Display(Console.ReadLine());
            Console.Read();
        }
    }
}
