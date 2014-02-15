using System.Net;
using System.IO;
using System;

namespace PiMonitor
{
	public class WebUtility
	{
		public WebUtility ()
		{
		}


		public static String CallWebsite(String webAddres)
		{
			WebRequest request = WebRequest.Create(webAddres);
			using(WebResponse response = request.GetResponse())
			{
				using (StreamReader reader = new StreamReader (response.GetResponseStream ())) {
					String responseString = reader.ReadToEnd ();
					return responseString;
				}
			}
		}
	}
}

