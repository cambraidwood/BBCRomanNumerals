using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Interface;
using RomanNumerals.Models;

namespace RomanNumerals.Service
{
    public class RomanNumeralGeneratorService : IRomanNumeralGenerator
    {

        StringBuilder _result;

        readonly List<RomanNumeralValuePair> RomanNumeralValuePairList = new List<RomanNumeralValuePair>();

        private IConfigurationSettings _settingsService;

        public RomanNumeralGeneratorService(IConfigurationSettings settingsService)
        {

            // inject a service that implements the configuration settings interface

            _settingsService = settingsService;

            if (_settingsService != null)
            {
                // populate the roman numeral / roman numeral combinations along with their values into a list

                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(1000, _settingsService.ROMAN_NUMERAL_M));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(900, _settingsService.ROMAN_NUMERAL_CM));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(500, _settingsService.ROMAN_NUMERAL_D));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(400, _settingsService.ROMAN_NUMERAL_CD));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(100, _settingsService.ROMAN_NUMERAL_C));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(90, _settingsService.ROMAN_NUMERAL_XC));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(50, _settingsService.ROMAN_NUMERAL_L));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(40, _settingsService.ROMAN_NUMERAL_XL));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(10, _settingsService.ROMAN_NUMERAL_X));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(9, _settingsService.ROMAN_NUMERAL_IX));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(5, _settingsService.ROMAN_NUMERAL_V));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(4, _settingsService.ROMAN_NUMERAL_IV));
                RomanNumeralValuePairList.Add(new RomanNumeralValuePair(1, _settingsService.ROMAN_NUMERAL_I));
            }

        }

        public string Generate(int number)
        {

            _result = new StringBuilder();

            // check for beging outside the allowed range

            if (number > _settingsService.MAX_INT)
            {
                throw new Exception("Value too large");
            }

            // loop until we have no number left to find ...

            while (number > 0)
            {

                foreach (RomanNumeralValuePair candidate in RomanNumeralValuePairList)
                {

                    // check to see if we can deduct a roman numeral / roman numeral combination from the current number ...

                    if (number / candidate.DecimalValue >= 1)
                    {

                        // reduce the total and add note the numeral ...

                        number -= candidate.DecimalValue;
                        _result.Append(candidate.RomanNumeral);

                        break;
                    }

                }

            }

            return (_result.ToString());
        }
    }
}
