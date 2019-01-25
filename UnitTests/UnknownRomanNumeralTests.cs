using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RomanNumerals.Interface;
using RomanNumerals.Service;

namespace UnitTests
{

    [TestClass]
    public class UnknownRomanNumeralTests
    {

        private ServiceProvider serviceProvider;

        public UnknownRomanNumeralTests()
        {

            //setup our dependency injection so we can find the implementation of IRomanNumeralGenerator
            serviceProvider = new ServiceCollection()
                .AddSingleton<IRomanNumeralGenerator, RomanNumeralGeneratorService>()
                .AddSingleton<IConfigurationSettings, MockUnknownConfigurationSettingsService>()
                .BuildServiceProvider();

        }

        [TestMethod]
        public void I_can_generate_an_error_for_an_invalid_roman_numeral()
        {

            try
            {

                var service = serviceProvider.GetService<IRomanNumeralGenerator>();

                string result = service.Generate(1234);

                Assert.Fail("Invalid Roman Numeral - An exception should have been thrown.");

            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid Roman Numeral", e.Message);
            }

        }

    }
}
