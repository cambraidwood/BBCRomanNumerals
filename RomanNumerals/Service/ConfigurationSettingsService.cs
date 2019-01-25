using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Interface;

namespace RomanNumerals.Service
{
    public class ConfigurationSettingsService : IConfigurationSettings
    {
        private IConfigurationFile _configFileService;
        private int _max_int;
        private string _roman_numeral_I;
        private string _roman_numeral_IV;
        private string _roman_numeral_V;
        private string _roman_numeral_IX;
        private string _roman_numeral_X;
        private string _roman_numeral_XL;
        private string _roman_numeral_L;
        private string _roman_numeral_XC;
        private string _roman_numeral_C;
        private string _roman_numeral_CD;
        private string _roman_numeral_D;
        private string _roman_numeral_CM;
        private string _roman_numeral_M;

        public ConfigurationSettingsService(IConfigurationFile configFileService)
        {

            // inject a service that implements the configuration file interface

            _configFileService = configFileService;

            if (_configFileService != null)
            {

                // go to the configutation file (app.config) to determine our running values ...

                this.MAX_INT = _configFileService.GetInteger("MAX_INT");

                this.ROMAN_NUMERAL_I = _configFileService.GetString("I");

                this.ROMAN_NUMERAL_IV = _configFileService.GetString("IV");

                this.ROMAN_NUMERAL_V = _configFileService.GetString("V");

                this.ROMAN_NUMERAL_IX = _configFileService.GetString("IX");

                this.ROMAN_NUMERAL_X = _configFileService.GetString("X");

                this.ROMAN_NUMERAL_XL = _configFileService.GetString("XL");

                this.ROMAN_NUMERAL_L = _configFileService.GetString("L"); 

                this.ROMAN_NUMERAL_XC = _configFileService.GetString("XC");

                this.ROMAN_NUMERAL_C = _configFileService.GetString("C");

                this.ROMAN_NUMERAL_CD = _configFileService.GetString("CD");

                this.ROMAN_NUMERAL_D = _configFileService.GetString("D");

                this.ROMAN_NUMERAL_CM = _configFileService.GetString("CM");

                this.ROMAN_NUMERAL_M = _configFileService.GetString("M");
            }

        }

        public int MAX_INT
        {
            get { return _max_int; }

            set { _max_int = value; }
        }

        public string ROMAN_NUMERAL_I
        {
            get { return _roman_numeral_I; }

            set { _roman_numeral_I = value; }
        }

        public string ROMAN_NUMERAL_IV
        {
            get { return _roman_numeral_IV; }

            set { _roman_numeral_IV = value; }
        }

        public string ROMAN_NUMERAL_V
        {
            get { return _roman_numeral_V; }

            set { _roman_numeral_V = value; }
        }

        public string ROMAN_NUMERAL_IX
        {
            get { return _roman_numeral_IX; }

            set { _roman_numeral_IX = value; }
        }

        public string ROMAN_NUMERAL_X
        {
            get { return _roman_numeral_X; }

            set { _roman_numeral_X = value; }
        }

        public string ROMAN_NUMERAL_XL
        {
            get { return _roman_numeral_XL; }

            set { _roman_numeral_XL = value; }
        }

        public string ROMAN_NUMERAL_L
        {
            get { return _roman_numeral_L; }

            set { _roman_numeral_L = value; }
        }

        public string ROMAN_NUMERAL_XC
        {
            get { return _roman_numeral_XC; }

            set { _roman_numeral_XC = value; }
        }

        public string ROMAN_NUMERAL_C
        {
            get { return _roman_numeral_C; }

            set { _roman_numeral_C = value; }
        }

        public string ROMAN_NUMERAL_CD
        {
            get { return _roman_numeral_CD; }

            set { _roman_numeral_CD = value; }
        }

        public string ROMAN_NUMERAL_D
        {
            get { return _roman_numeral_D; }

            set { _roman_numeral_D = value; }
        }

        public string ROMAN_NUMERAL_CM
        {
            get { return _roman_numeral_CM; }

            set { _roman_numeral_CM = value; }
        }

        public string ROMAN_NUMERAL_M
        {
            get { return _roman_numeral_M; }

            set { _roman_numeral_M = value; }
        }
    }
}
