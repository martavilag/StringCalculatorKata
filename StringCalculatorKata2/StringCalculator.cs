using System;

namespace StringCalculatorKata2
{
    public class StringCalculator
    {
        private readonly string _sequence;

        public StringCalculator(string sequence)
        {
            _sequence = sequence;
        }

        public int Sum()
        {
            if (_sequence == "")
                return 0;
            
            if (!_sequence.Contains(",")) 
                return Convert.ToInt32(_sequence);
            
            int firstNumber = Convert.ToInt32(_sequence.Substring(0, 1));
            int secondNumber = Convert.ToInt32(_sequence.Substring(2));
            
            return firstNumber + secondNumber;

        }
    }
}