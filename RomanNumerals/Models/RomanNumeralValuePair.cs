using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals.Models
{
    public class RomanNumeralValuePair
    {
        private int _decimalValue;

        private string[] valid = new[] {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};

        public int DecimalValue
        {
            get => _decimalValue;

            set => _decimalValue = value;
        }

        private string _romanNumeral;

        public string RomanNumeral
        {
            get => _romanNumeral;

            set
            {
                if (valid.Contains(value))
                {
                    _romanNumeral = value;
                }
                else
                {
                    throw new Exception("Invalid Roman Numeral");
                }

            }
        }

        public RomanNumeralValuePair(int decimalValue, string romanNumeral)
        {
            this.DecimalValue = decimalValue;
            this.RomanNumeral = romanNumeral;
        }

    }
}
