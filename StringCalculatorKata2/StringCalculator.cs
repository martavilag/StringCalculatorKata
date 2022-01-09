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
            if (_sequence != "")
                return Convert.ToInt32(_sequence);
            return 0;
        }
    }
}