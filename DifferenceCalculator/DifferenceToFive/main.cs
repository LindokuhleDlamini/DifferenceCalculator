using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceCalculator
{
    public class main
    {      
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Initial Value (0<= x <=5)");
            Console.WriteLine(Calculator(GetInputValue(Console.ReadLine())));
            Console.Read();
        }

        public static int GetInputValue(string input)
        {
            int InputValue;

            if (!int.TryParse(input, out InputValue))
            {
                InputValue= -1;
            }
            return InputValue; 
        }

        public static string Calculator(int initialValue)
        {
            if (initialValue > 5 || initialValue < 0)
            {
                return "Value provided doesn't meet the condition (0<= x <=5)";
            }
            else
            {
                return (5 - initialValue) + " is required to get to 5";
            }
        }
    }
}
