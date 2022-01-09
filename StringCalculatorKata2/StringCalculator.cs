using System;
using System.Linq;

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
            
            if (_sequence.Contains("\n,") || _sequence.Contains(",\n"))
                throw new InvalidOperationException("Sequence not valid");

            char[] separators = new char[] {',', '\n'};
            string[] numberSequence = _sequence.Split(separators);

            return numberSequence.Sum(Convert.ToInt32);

        }
    }
}