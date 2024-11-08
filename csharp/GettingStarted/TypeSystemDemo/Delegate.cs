using System;

namespace TypeSystemDemo
{
    public delegate double TemperatureConversion(double temperature);

    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}