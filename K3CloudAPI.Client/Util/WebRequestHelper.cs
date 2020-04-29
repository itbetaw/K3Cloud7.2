using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.K3CloudAPI.Clent.Util
{
    // Token: 0x02000019 RID: 25
    public class WebRequestHelper
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00004790 File Offset: 0x00002990
		private static void SetSecurityProtocol(Uri uri)
		{
			if (!WebRequestHelper.HasSetSecurityProtocol)
			{
				try
				{
					if (uri.Scheme.Equals("https", StringComparison.CurrentCultureIgnoreCase))
					{
						ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls );
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					WebRequestHelper.HasSetSecurityProtocol = true;
				}
			}
			ServicePointManager.ServerCertificateValidationCallback = (ServicePointManager.ServerCertificateValidationCallback = ((object param0, X509Certificate param1, X509Chain param2, SslPolicyErrors param3) => true));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004814 File Offset: 0x00002A14
		public static HttpWebRequest Create(string uri)
		{
			Uri uri2 = new Uri(uri);
			return WebRequestHelper.Create(uri2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004830 File Offset: 0x00002A30
		public static HttpWebRequest Create(Uri uri)
		{
			if (!WebRequestHelper.HasSetSecurityProtocol)
			{
				WebRequestHelper.SetSecurityProtocol(uri);
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
			httpWebRequest.UserAgent = string.Format("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.123; WOW64; Trident/5.0; .NET4.0E; Kingdee/{0} MANM)", typeof(WebRequestHelper).Assembly.FullName);
			string text = ConfigurationManager.AppSettings.Get("ProxyHost");
			Uri address = null;
			if (text != null && Uri.TryCreate(text, UriKind.RelativeOrAbsolute, out address))
			{
				httpWebRequest.Proxy = new WebProxy(address);
			}
			if (uri.Scheme.Equals("https", StringComparison.CurrentCultureIgnoreCase))
			{
				string cerFile = WebRequestHelper.GetCerFile();
				if (File.Exists(cerFile))
				{
					X509Certificate value = new X509Certificate(cerFile);
					httpWebRequest.ClientCertificates.Add(value);
				}
				else
				{
					X509Store x509Store = new X509Store(StoreName.My);
					if (x509Store.Certificates.Count == 1)
					{
						httpWebRequest.ClientCertificates.Add(x509Store.Certificates[0]);
					}
					else if (x509Store.Certificates.Count > 0)
					{
						X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(X509FindType.FindBySubjectName, Environment.MachineName, true);
						if (x509Certificate2Collection.Count > 0)
						{
							httpWebRequest.ClientCertificates.Add(x509Certificate2Collection[0]);
						}
						httpWebRequest.ClientCertificates.Add(x509Store.Certificates[0]);
					}
				}
			}
			return httpWebRequest;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004974 File Offset: 0x00002B74
		private static string GetCerFile()
		{
			string text;
			if (Environment.UserInteractive)
			{
				text = WebRequestHelper.TryToGetCerFile(AppDomain.CurrentDomain.BaseDirectory);
				if (!File.Exists(text))
				{
					text = WebRequestHelper.TryToGetCerFile(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName);
				}
			}
			else
			{
				text = WebRequestHelper.TryToGetCerFile(AppDomain.CurrentDomain.BaseDirectory);
				if (!File.Exists(text))
				{
					text = WebRequestHelper.TryToGetCerFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));
				}
			}
			return text;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000049FC File Offset: 0x00002BFC
		private static string TryToGetCerFile(string dirName)
		{
			string text = Path.Combine(dirName, Environment.MachineName + ".cer");
			if (File.Exists(text))
			{
				return text;
			}
			return Path.Combine(dirName, "K3CloudCert.cer");
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004A38 File Offset: 0x00002C38
		public static bool PortIsOpen(string hostName, int port)
		{
			bool result;
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.SendTimeout = 2000;
				tcpClient.ReceiveTimeout = 2000;
				tcpClient.Connect(hostName, port);
				if (tcpClient.Connected)
				{
					tcpClient.Close();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000048 RID: 72
		private static bool HasSetSecurityProtocol;

		// Token: 0x0200001A RID: 26
		[Flags]
		public enum SecurityProtocolTypeEnum
		{
			// Token: 0x0400004B RID: 75
			Ssl3 = 48,
			// Token: 0x0400004C RID: 76
			Tls = 192,
			// Token: 0x0400004D RID: 77
			Tls11 = 768,
			// Token: 0x0400004E RID: 78
			Tls12 = 3072
		}
	}
}
