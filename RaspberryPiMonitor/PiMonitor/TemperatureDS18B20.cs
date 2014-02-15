using System;
using System.Linq;

namespace PiMonitor
{
	/// <summary>
	/// Class for handling interation with a DS18B20 temperature sensor
	/// </summary>
	public class TemperatureDS18B20
	{
		public TemperatureDS18B20 ()
		{
		}

		public static double GetTemperatureInFahrenheit(String rawTemperatureOutput)
		{
			return ConvertCelsiusToFahrenheit (GetTemperatureInCelsius (rawTemperatureOutput));
		}

		/// <summary>
		/// Converts the celsius to fahrenheit.
		/// Multiply by 9, then divide by 5, then add 32
		/// </summary>
		/// <returns>The celsius to fahrenheit.</returns>
		/// <param name="celsius">Celsius.</param>
		public static double ConvertCelsiusToFahrenheit(double celsius)
		{
			return celsius * 9 / 5 + 32;
		}

		public static double GetTemperatureInCelsius(String rawTemperatureOutput)
		{
			if (!rawTemperatureOutput.Contains ("t=")) {
				throw new FormatException ("Expected to see \"t=\" in raw temperature output");
			}
			String temperatureElement = rawTemperatureOutput.Split (' ').FirstOrDefault (item => item.Contains ("t=")).Trim();
			int numberTemperatureValue = int.Parse (temperatureElement.Split ('=').FirstOrDefault (item => !item.Contains ("t")));
			return (double)numberTemperatureValue / 1000;
		}
	}
}

