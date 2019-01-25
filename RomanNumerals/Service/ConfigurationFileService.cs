using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using RomanNumerals.Interface;

namespace RomanNumerals.Service
{
    public class ConfigurationFileService : IConfigurationFile
    {

        public int GetInteger(string key)
        {
            int result;
            bool isValid = false;

            string val = ConfigurationManager.AppSettings[key];

            if (!string.IsNullOrEmpty(val))
            {
                isValid = int.TryParse(val, out result);

                if (isValid)
                {
                    return (result);
                }
                else
                {
                    throw new Exception("Configuration integer not valid");
                }
            }
            else
            {
                throw new Exception("Configuration integer not found");
            }

        }

        public string GetString(string key)
        {

            string val = ConfigurationManager.AppSettings[key];

            if (!string.IsNullOrEmpty(val))
            {
                return (val);
            }
            else
            {
                throw new Exception("Configuration string not found");
            }

        }

    }
}
