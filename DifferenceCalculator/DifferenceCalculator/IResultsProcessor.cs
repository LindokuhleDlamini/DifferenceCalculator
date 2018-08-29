namespace DifferenceCalculator
{
    public interface IResultsProcessor
    {       
        int Calculator(int initialValue);
        string Display(int input);
        int GetInputValue(string input);
        bool InputValidation(int initialValue);
    }
}
