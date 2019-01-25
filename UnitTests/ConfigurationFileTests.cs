using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.Interface;
using RomanNumerals.Service;

namespace UnitTests
{

    [TestClass]
    public class ConfigurationFileTests
    {

        private readonly IConfigurationFile service;

        public ConfigurationFileTests()
        {

            //setup our dependency injection so we can find the implementation of IConfigurationFile
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfigurationFile, ConfigurationFileService>()
                .BuildServiceProvider();

            service = serviceProvider.GetService<IConfigurationFile>();

        }

        [TestMethod]
        public void I_can_generate_an_error_for_an_invalid_integer_setting()
        {

            ConfigurationManager.AppSettings.Set("MAX_INT", "x");

            try
            {
                int result = service.GetInteger("MAX_INT");

                Assert.Fail("Not an integer - An exception should have been thrown.");

            }
            catch (Exception e)
            {
                Assert.AreEqual("Configuration integer not valid", e.Message);
            }

        }

        [TestMethod]
        public void I_can_generate_an_error_for_a_none_existant_integer_setting()
        {

            try
            {
                int result = service.GetInteger("NOT_PRESENT");

                Assert.Fail("Setting not found - An exception should have been thrown.");

            }
            catch (Exception e)
            {
                Assert.AreEqual("Configuration integer not found", e.Message);
            }

        }

        [TestMethod]
        public void I_can_generate_an_error_for_a_none_existant_string_setting()
        {

            try
            {
                string result = service.GetString("NOT_PRESENT");

                Assert.Fail("Setting not found - An exception should have been thrown.");

            }
            catch (Exception e)
            {
                Assert.AreEqual("Configuration string not found", e.Message);
            }

        }

    }
}
