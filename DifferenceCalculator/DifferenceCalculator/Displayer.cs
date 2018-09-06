using System;

namespace DifferenceCalculator
{
    public class Displayer
    {
        private InputProcessor _inputProcessor;
        private ResultsProcessor _resultsProcessor;
        private int _targetValue;
        private string _condition;
        private int _input;

        public Displayer(int targetValue)
        {
            _targetValue = targetValue;
            _condition = "(0<= x <=" + _targetValue + ")";
            Console.WriteLine("Enter Initial Value " + _condition);
            _inputProcessor = new InputProcessor(_targetValue);
            _resultsProcessor = new ResultsProcessor(_targetValue);
            
        }

        public void Display(string input)
        {
            _input = _inputProcessor.GetInputValue(input);
            if (_inputProcessor.InputValidation(_input))
            {
                Console.WriteLine(_resultsProcessor.ResultsCalculator(_input) + " is required to get to " + _targetValue);
            }
            else
            {
                Console.WriteLine("Value provided doesn't meet the condition " + _condition);
            }
        }
    }
}
