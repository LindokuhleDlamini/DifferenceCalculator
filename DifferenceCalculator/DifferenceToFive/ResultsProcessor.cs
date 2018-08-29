using System;

namespace DifferenceCalculator
{
    public class ResultsProcessor : IResultsProcessor
    {
        private int _targetValue;
        private string _condition;

        public ResultsProcessor(int targetValue)
        {
            _targetValue = targetValue;
            _condition = "(0<= x <=" + _targetValue + ")";
            Console.WriteLine("Enter Initial Value "+_condition);
        }

        public int Calculator(int initialValue)
        {
            return _targetValue - initialValue;
        }

        public string Display(int input)
        {
            if (InputValidation(input))
            {
                return Calculator(input) + " is required to get to " + _targetValue;
            }
            return "Value provided doesn't meet the condition " + _condition;
        }

        public int GetInputValue(string input)
        {
            int InputValue;
            return int.TryParse(input, out InputValue)? InputValue: -1;
        }

        public bool InputValidation(int initialValue)
        {
            if (initialValue > _targetValue || initialValue < 0)
            {
                return false;
            }
            return true;
        }
    }
}
