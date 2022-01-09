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

            int resultSum = 0;
            string[] numberSequence = _sequence.Split(",");

            foreach (var number in numberSequence)
            {
                resultSum += Convert.ToInt32(number);
            }
            
            return resultSum;

        }
    }
}