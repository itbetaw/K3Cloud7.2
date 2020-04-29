using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.K3CloudAPI.Clent.Util;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000009 RID: 9
	public class ApiRequest : JsonObject
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002EBC File Offset: 0x000010BC
		private static void SetSecurityProtocol(Uri uri)
		{
			if (!ApiRequest.HasSetSecurityProtocol)
			{
				try
				{
					if (uri.Scheme.Equals("https", StringComparison.CurrentCultureIgnoreCase))
					{
						ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls );
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					ApiRequest.HasSetSecurityProtocol = true;
				}
			}
			ServicePointManager.ServerCertificateValidationCallback = (ServicePointManager.ServerCertificateValidationCallback = ((object param0, X509Certificate param1, X509Chain param2, SslPolicyErrors param3) => true));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F4C File Offset: 0x0000114C
		public ApiRequest(string serverUrl, bool async, Encoding encoder, CookieContainer cookies)
		{
			this.Format = 1;
			this.UserAgent = "ApiClient";
			this.ServerUrl = serverUrl;
			this.Encoder = encoder;
			this.CookiesContainer = cookies;
			this.RequestId = Guid.NewGuid().ToString().GetHashCode().ToString();
			this.AutoGetLastProgress = true;
			this.IsAsync = async;
			this.Version = "1.0";
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002FC6 File Offset: 0x000011C6
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002FCE File Offset: 0x000011CE
		public bool IsAsync { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002FD7 File Offset: 0x000011D7
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002FE4 File Offset: 0x000011E4
		private int Format
		{
			get
			{
				return base.GetValue<int>(ApiRequest.fmtProp);
			}
			set
			{
				base.SetValue(ApiRequest.fmtProp, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002FF7 File Offset: 0x000011F7
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002FFF File Offset: 0x000011FF
		public CookieContainer CookiesContainer { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003008 File Offset: 0x00001208
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003010 File Offset: 0x00001210
		public Encoding Encoder { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003019 File Offset: 0x00001219
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00003021 File Offset: 0x00001221
		public string ServerUrl { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000302A File Offset: 0x0000122A
		public virtual Uri ServiceUri
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003031 File Offset: 0x00001231
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003039 File Offset: 0x00001239
		public string RequestId { get; protected set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003042 File Offset: 0x00001242
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000304A File Offset: 0x0000124A
		public bool AutoGetLastProgress { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003053 File Offset: 0x00001253
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00003060 File Offset: 0x00001260
		private string UserAgent
		{
			get
			{
				return base.GetValue<string>(ApiRequest.uaProp);
			}
			set
			{
				base.SetValue(ApiRequest.uaProp, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000306E File Offset: 0x0000126E
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00003076 File Offset: 0x00001276
		public string Version { get; set; }

		// Token: 0x0600006E RID: 110 RVA: 0x0000307F File Offset: 0x0000127F
		public virtual string ToJsonString()
		{
			base.SetValue("timestamp", DateTime.Now);
			base.SetValue("v", this.Version);
			return base.ToString();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000030B0 File Offset: 0x000012B0
		internal HttpWebRequest HttpRequest
		{
			get
			{
				HttpWebRequest result;
				lock (this)
				{
					if (this.httpRequest == null)
					{
						this.httpRequest = this.CreateRequest();
					}
					result = this.httpRequest;
				}
				return result;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003104 File Offset: 0x00001304
		private HttpWebRequest CreateRequest()
		{
			HttpWebRequest httpWebRequest = WebRequestHelper.Create(this.ServiceUri);
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("Accept-Charset", this.Encoder.HeaderName);
			httpWebRequest.CookieContainer = this.CookiesContainer;
			httpWebRequest.Pipelined = true;
			return httpWebRequest;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003169 File Offset: 0x00001369
		public void Abort()
		{
			this.httpRequest.Abort();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003178 File Offset: 0x00001378
		private static string GetCerFile()
		{
			string text;
			if (Environment.UserInteractive)
			{
				text = ApiRequest.TryToGetCerFile(AppDomain.CurrentDomain.BaseDirectory);
				if (!File.Exists(text))
				{
					text = ApiRequest.TryToGetCerFile(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName);
				}
			}
			else
			{
				text = ApiRequest.TryToGetCerFile(AppDomain.CurrentDomain.BaseDirectory);
				if (!File.Exists(text))
				{
					text = ApiRequest.TryToGetCerFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));
				}
			}
			return text;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003200 File Offset: 0x00001400
		private static string TryToGetCerFile(string dirName)
		{
			string text = Path.Combine(dirName, Environment.MachineName + ".cer");
			if (File.Exists(text))
			{
				return text;
			}
			return Path.Combine(dirName, "K3CloudCert.cer");
		}

		// Token: 0x04000016 RID: 22
		private static bool HasSetSecurityProtocol = false;

		// Token: 0x04000017 RID: 23
		private static string fmtProp = "format";

		// Token: 0x04000018 RID: 24
		private static string uaProp = "useragent";

		// Token: 0x04000019 RID: 25
		private HttpWebRequest httpRequest;

		// Token: 0x0200000A RID: 10
		[Flags]
		internal enum SecurityProtocolTypeEnum
		{
			// Token: 0x04000023 RID: 35
			Ssl3 = 48,
			// Token: 0x04000024 RID: 36
			Tls = 192,
			// Token: 0x04000025 RID: 37
			Tls11 = 768,
			// Token: 0x04000026 RID: 38
			Tls12 = 3072
		}
	}
}
