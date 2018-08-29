using System;

namespace DifferenceCalculator
{
    public class DifferenceCalculatorRunner
    {
        public static void Main(string[] args)
        {
            var results = new ResultsProcessor(50);
            Console.WriteLine(results.Display(results.GetInputValue(Console.ReadLine())));
            Console.Read();
        }
    }
}
