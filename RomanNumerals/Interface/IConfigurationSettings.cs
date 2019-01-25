using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals.Interface
{
    public interface IConfigurationSettings
    {

        int MaxInt { get; set; }

        string RomanNumeralI { get; set; }

        string RomanNumeralIV { get; set; }

        string RomanNumeralV { get; set; }

        string RomanNumeralIX { get; set; }

        string RomanNumeralX { get; set; }

        string RomanNumeralXL { get; set; }

        string RomanNumeralL { get; set; }

        string RomanNumeralXC { get; set; }

        string RomanNumeralC { get; set; }

        string RomanNumeralCD { get; set; }

        string RomanNumeralD { get; set; }

        string RomanNumeralCM { get; set; }

        string RomanNumeralM { get; set; }

    }
}
