using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals.Interface
{
    public interface IConfigurationSettings
    {

        int MAX_INT { get; set; }

        string ROMAN_NUMERAL_I { get; set; }

        string ROMAN_NUMERAL_IV { get; set; }

        string ROMAN_NUMERAL_V { get; set; }

        string ROMAN_NUMERAL_IX { get; set; }

        string ROMAN_NUMERAL_X { get; set; }

        string ROMAN_NUMERAL_XL { get; set; }

        string ROMAN_NUMERAL_L { get; set; }

        string ROMAN_NUMERAL_XC { get; set; }

        string ROMAN_NUMERAL_C { get; set; }

        string ROMAN_NUMERAL_CD { get; set; }

        string ROMAN_NUMERAL_D { get; set; }

        string ROMAN_NUMERAL_CM { get; set; }

        string ROMAN_NUMERAL_M { get; set; }

    }
}
