namespace DifferenceCalculator
{
    public interface IInputProcessor
    {
        int GetInputValue(string input);
        bool InputValidation(int initialValue);
    }
}
