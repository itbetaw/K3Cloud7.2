using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x0200000B RID: 11
	internal class ApiServiceRequest : ApiRequest
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00003256 File Offset: 0x00001456
		internal ApiServiceRequest(string serverUrl, bool async, Encoding encoder, CookieContainer cookies, string servicename, object[] parameters) : base(serverUrl, async, encoder, cookies)
		{
			this.ServiceName = servicename;
			if (parameters == null)
			{
				this.Parameters = new List<object>();
				return;
			}
			this.Parameters = new List<object>(parameters);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003288 File Offset: 0x00001488
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003290 File Offset: 0x00001490
		public string ServiceName { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003299 File Offset: 0x00001499
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000032A1 File Offset: 0x000014A1
		public List<object> Parameters { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000032AC File Offset: 0x000014AC
		public override Uri ServiceUri
		{
			get
			{
				if (base.IsAsync)
				{
					return new Uri(new Uri(base.ServerUrl), "a\\" + this.ServiceName + ".common.kdsvc");
				}
				return new Uri(new Uri(base.ServerUrl), this.ServiceName + ".common.kdsvc");
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003307 File Offset: 0x00001507
		public override string ToJsonString()
		{
			base.SetValue("rid", base.RequestId);
			base.SetValue("parameters", JsonConvert.SerializeObject(this.Parameters));
			return base.ToJsonString();
		}
	}
}
