using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using RomanNumerals.Interface;
using RomanNumerals.Service;

namespace UnitTests
{
    [TestClass]
    public class RomanNumeralTests
    {
        private readonly IRomanNumeralGenerator rngSvc;

        public RomanNumeralTests()
        {

            //setup our dependency injection so we can find the implementation of IRomanNumeralGenerator
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRomanNumeralGenerator, RomanNumeralGeneratorService>()
                .AddSingleton<IConfigurationSettings, MockConfigurationSettingsService>()
                .BuildServiceProvider();

            rngSvc = serviceProvider.GetService<IRomanNumeralGenerator>();

        }

        [TestMethod]
        public void I_can_generate_the_roman_numerals_for_1()
        {

            string result = rngSvc.Generate(1);

            Assert.AreEqual(result, "I");

        }

        [TestMethod]
        public void I_can_generate_the_roman_numerals_for_5()
        {

            string result = rngSvc.Generate(5);

            Assert.AreEqual(result, "V");

        }

        [TestMethod]
        public void I_can_generate_the_roman_numerals_for_10()
        {

            string result = rngSvc.Generate(10);

            Assert.AreEqual(result, "X");

        }

        [TestMethod]
        public void I_can_generate_the_roman_numerals_for_20()
        {

            string result = rngSvc.Generate(20);

            Assert.AreEqual(result, "XX");

        }

        [TestMethod]
        public void I_can_generate_the_roman_numerals_for_3999()
        {

            string result = rngSvc.Generate(3999);

            Assert.AreEqual(result, "MMMCMXCIX");

        }

        [TestMethod]
        public void I_can_generate_an_error_for_a_number_outside_the_valid_range()
        {

            try
            {
                string result = rngSvc.Generate(4000);

                Assert.Fail("Value out of range - An exception should have been thrown.");

            }
            catch (Exception e)
            {
                Assert.AreEqual("Value too large", e.Message);
            }

        }

        
    }
}
