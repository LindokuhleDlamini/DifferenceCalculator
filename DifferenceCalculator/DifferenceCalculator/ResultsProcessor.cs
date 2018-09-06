using System;

namespace DifferenceCalculator
{
    public class ResultsProcessor : IResultsProcessor
    {
        private int _targetValue;


        public ResultsProcessor(int targetValue)
        {
            _targetValue = targetValue;
            
        }

        public int ResultsCalculator(int initialValue)
        {
            return _targetValue - initialValue;
        }
    }
}
