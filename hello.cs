using System;
using System.Net;
using System.IO;
 
public class HelloWorld
{
	static public void Main ()
	{
		//String urlAddres = "http://www.google.com/";
		//String response = callWebsite(urlAddres);
		//Console.WriteLine(response);
		try
		{
			String[] files = Directory.GetFiles("/sys/bus/w1/devices/");
			foreach(String file in files)
			{
				Console.WriteLine(file);
			}
		}
		catch(Exception exception)
		{
			Console.WriteLine(exception.Message);
		}
	}

}
