using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorKata2
{
    public class StringCalculator
    {
        private string _sequence;
        private readonly List<string> _separators = new() {",", "\n"};

        public StringCalculator(string sequence)
        {
            _sequence = sequence;
        }

        public int Sum()
        {
            if (_sequence == "")
                return 0;
            
            if (_sequence.Contains("\n,") || _sequence.Contains(",\n"))
                throw new InvalidOperationException("Sequence not valid");
            
            if (_sequence.Contains("-"))
                throw new InvalidOperationException("Negatives not allowed");

            Regex containsSeparatorForwardSlash = new Regex(@"\/\/.\n\d");
            bool isForwardSlashSeparator = containsSeparatorForwardSlash.IsMatch(_sequence);
            
            if (isForwardSlashSeparator)
            {
                _separators.Add(_sequence[2].ToString());
                _sequence = _sequence[3..];

            }

            string[] numberSequence = _sequence.Split(_separators.ToArray(),StringSplitOptions.RemoveEmptyEntries);

            return numberSequence.Sum(Convert.ToInt32);

        }
    }
}