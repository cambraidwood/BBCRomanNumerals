using System;
using Microsoft.Extensions.DependencyInjection;
using RomanNumerals.Interface;
using RomanNumerals.Service;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            // setup our dependency injection so we can find the implementations
            // of the service classes

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRomanNumeralGenerator, RomanNumeralGeneratorService>()
                .AddSingleton<IConfigurationFile, ConfigurationFileService>()
                .AddSingleton<IConfigurationSettings, ConfigurationSettingsService>()
                .BuildServiceProvider();

            // locate a service that implements the roman numeral generator interface ...

            var rngSvc = serviceProvider.GetService<IRomanNumeralGenerator>();

            // run some examples through the generator ...

            Console.WriteLine($"0 => {rngSvc.Generate(0)}");
            Console.WriteLine($"1 => {rngSvc.Generate(1)}");
            Console.WriteLine($"4 => {rngSvc.Generate(4)}");
            Console.WriteLine($"5 => {rngSvc.Generate(5)}");
            Console.WriteLine($"9 => {rngSvc.Generate(9)}");
            Console.WriteLine($"10 => {rngSvc.Generate(10)}");
            Console.WriteLine($"13 => {rngSvc.Generate(13)}");
            Console.WriteLine($"15 => {rngSvc.Generate(15)}");
            Console.WriteLine($"19 => {rngSvc.Generate(19)}");
            Console.WriteLine($"20 => {rngSvc.Generate(20)}");
            Console.WriteLine($"27 => {rngSvc.Generate(27)}");
            Console.WriteLine($"1027 => {rngSvc.Generate(1027)}");
            Console.WriteLine($"2056 => {rngSvc.Generate(2056)}");
            Console.WriteLine($"3999 => {rngSvc.Generate(3999)}");

            Console.WriteLine("Press any key to exit ...");

            Console.ReadKey();

        }
    }
}
