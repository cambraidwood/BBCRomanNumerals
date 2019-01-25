using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Interface;

namespace RomanNumerals.Service
{
    public class ConfigurationSettingsService : ConfigurationSettingsBase, IConfigurationSettings
    {

        private readonly IConfigurationFile configFileService;

        public ConfigurationSettingsService(IConfigurationFile configFileService)
        {

            // inject a service that implements the configuration file interface

            this.configFileService = configFileService;

            if (this.configFileService != null)
            {

                // go to the configuration file (app.config) to determine our running values ...

                maxInt = this.configFileService.GetInteger("MAX_INT");

                romanNumeralI = this.configFileService.GetString("I");

                romanNumeralIV = this.configFileService.GetString("IV");

                romanNumeralV = this.configFileService.GetString("V");

                romanNumeralIX = this.configFileService.GetString("IX");

                romanNumeralX = this.configFileService.GetString("X");

                romanNumeralXL = this.configFileService.GetString("XL");

                romanNumeralL = this.configFileService.GetString("L"); 

                romanNumeralXC = this.configFileService.GetString("XC");

                romanNumeralC = this.configFileService.GetString("C");

                romanNumeralCD = this.configFileService.GetString("CD");

                romanNumeralD = this.configFileService.GetString("D");

                romanNumeralCM = this.configFileService.GetString("CM");

                romanNumeralM = this.configFileService.GetString("M");
            }

        }

    }
}
