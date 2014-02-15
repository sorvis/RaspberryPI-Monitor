using NUnit.Framework;
using System;
using PiMonitor;

namespace PiMonitorTest
{
	[TestFixture ()]
	public class WebUtilityTest
	{
		[Test ()]
		public void Test_CallWebsite_that_when_calling_google_it_returns_string_containing_google ()
		{
			Assert.IsTrue (WebUtility.CallWebsite ("http://www.google.com").Contains ("google"));
		}
	}
}

