using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Interface;

namespace RomanNumerals.Service
{

    public class MockUnknownConfigurationSettingsService : ConfigurationSettingsBase, IConfigurationSettings
    {

        public MockUnknownConfigurationSettingsService()
        {

            // mock settings for unit tests, no config file dependency

            maxInt = 3999;

            romanNumeralI = "I";

            romanNumeralIV = "IV";

            romanNumeralV = "V";

            romanNumeralIX = "IX";

            romanNumeralX = "X";

            romanNumeralXL = "XL";

            romanNumeralL = "L";

            romanNumeralXC = "XC";

            romanNumeralC = "C";

            romanNumeralCD = "CD";

            romanNumeralD = "D";

            romanNumeralCM = "CM";

            romanNumeralM = "G"; // unknown roman numeral (may come in from config)

        }

    }
}
