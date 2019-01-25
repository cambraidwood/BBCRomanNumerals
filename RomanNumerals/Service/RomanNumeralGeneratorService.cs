using System;
using System.Collections.Generic;
using System.Text;

using RomanNumerals.Interface;
using RomanNumerals.Models;

namespace RomanNumerals.Service
{
    public class RomanNumeralGeneratorService : IRomanNumeralGenerator
    {

        private readonly List<RomanNumeralValuePair> romanNumeralValuePairList = new List<RomanNumeralValuePair>();

        private readonly IConfigurationSettings settingsService;

        public RomanNumeralGeneratorService(IConfigurationSettings settingsService)
        {

            // inject a service that implements the configuration settings interface

            this.settingsService = settingsService;

            if (this.settingsService != null)
            {
                // populate the roman numeral / roman numeral combinations along with their values into a list

                romanNumeralValuePairList.Add(new RomanNumeralValuePair(1000, this.settingsService.RomanNumeralM));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(900, this.settingsService.RomanNumeralCM));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(500, this.settingsService.RomanNumeralD));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(400, this.settingsService.RomanNumeralCD));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(100, this.settingsService.RomanNumeralC));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(90, this.settingsService.RomanNumeralXC));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(50, this.settingsService.RomanNumeralL));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(40, this.settingsService.RomanNumeralXL));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(10, this.settingsService.RomanNumeralX));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(9, this.settingsService.RomanNumeralIX));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(5, this.settingsService.RomanNumeralV));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(4, this.settingsService.RomanNumeralIV));
                romanNumeralValuePairList.Add(new RomanNumeralValuePair(1, this.settingsService.RomanNumeralI));
            }

        }

        public string Generate(int number)
        {

            StringBuilder result = new StringBuilder();

            // check for beging outside the allowed range

            if (number > this.settingsService.MaxInt)
            {
                throw new Exception("Value too large");
            }

            // loop until we have no number left to find ...

            while (number > 0)
            {

                foreach (RomanNumeralValuePair candidate in romanNumeralValuePairList)
                {

                    // check to see if we can deduct a roman numeral / roman numeral combination from the current number ...

                    if (number / candidate.DecimalValue >= 1)
                    {

                        // reduce the total and note the numeral ...

                        number -= candidate.DecimalValue;
                        result.Append(candidate.RomanNumeral);

                        break;
                    }

                }

            }

            return (result.ToString());
        }
    }
}
