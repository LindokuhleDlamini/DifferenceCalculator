namespace DifferenceCalculator
{
    public class InputProcessor
    {
        private int _targetValue;

        public InputProcessor(int targetValue)
        {
            _targetValue = targetValue;
        }

        public int GetInputValue(string input)
        {
            int InputValue;
            return int.TryParse(input, out InputValue) ? InputValue : -1;
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
