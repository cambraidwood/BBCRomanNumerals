using RomanNumerals.Interface;

namespace RomanNumerals.Service
{
    public class MockConfigurationSettingsService : ConfigurationSettingsBase, IConfigurationSettings
    {

        public MockConfigurationSettingsService()
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

            romanNumeralM = "M";

        }

    }
}
