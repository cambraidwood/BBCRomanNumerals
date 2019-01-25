using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.Interface;

namespace RomanNumerals.Service
{

    public class MockUnknownConfigurationSettingsService : IConfigurationSettings
    {

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

        public MockUnknownConfigurationSettingsService()
        {

            // mock settings for unit tests, no config file dependency

            this.MAX_INT = 3999;

            this.ROMAN_NUMERAL_I = "I";

            this.ROMAN_NUMERAL_IV = "IV";

            this.ROMAN_NUMERAL_V = "V";

            this.ROMAN_NUMERAL_IX = "IX";

            this.ROMAN_NUMERAL_X = "X";

            this.ROMAN_NUMERAL_XL = "XL";

            this.ROMAN_NUMERAL_L = "L";

            this.ROMAN_NUMERAL_XC = "XC";

            this.ROMAN_NUMERAL_C = "C";

            this.ROMAN_NUMERAL_CD = "CD";

            this.ROMAN_NUMERAL_D = "D";

            this.ROMAN_NUMERAL_CM = "CM";

            this.ROMAN_NUMERAL_M = "G"; // unknown roman numeral (may come in from config)

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
