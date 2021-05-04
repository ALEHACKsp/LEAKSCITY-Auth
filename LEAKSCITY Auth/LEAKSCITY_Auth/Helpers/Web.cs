using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LEAKSCITY_Auth.Helpers
{
	public static class Web
	{
		public static string CreateRequest(string data, string url, bool get = false)
		{
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(data);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Proxy = null;
				httpWebRequest.Method = ((!get) ? "POST" : "GET");
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				if (!get)
				{
					httpWebRequest.ContentType = "application/x-www-form-urlencoded";
					httpWebRequest.ContentLength = bytes.Length;
					httpWebRequest.Proxy = null;
				}
				httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3835.0 Safari/537.36";
				httpWebRequest.Headers["Accept-Encoding"] = "gzip,deflate,sdch";
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				if (!get)
				{
					using (Stream stream = httpWebRequest.GetRequestStream())
					{
						stream.Write(bytes, 0, bytes.Length);
					}
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string result = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
				return result;
			}
			catch (Exception)
			{
				return "";
			}
		}
	}
}
