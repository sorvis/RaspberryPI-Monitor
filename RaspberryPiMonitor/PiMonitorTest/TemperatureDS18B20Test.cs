using NUnit.Framework;
using System;
using PiMonitor;

namespace PiMonitorTest
{
	[TestFixture ()]
	public class TemperatureDS18B20Test
	{
		[Test ()]
		public void Test_GetTemperatureInCelsius_extracts_celsius_from_raw_output ()
		{
			Assert.AreEqual (_temperatureInCelsius, TemperatureDS18B20.GetTemperatureInCelsius (RAW_TEMPERATURE_OUTPUT));
		}

		private const string RAW_TEMPERATURE_OUTPUT = @"4a 01 4b 46 7f ff 06 10 f7 : crc=f7 YES
4a 01 4b 46 7f ff 06 10 f7 t=20625
";
		private double _temperatureInCelsius = 20.625;
	}
}

