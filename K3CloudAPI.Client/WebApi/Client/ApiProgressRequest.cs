using System;
using System.Net;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x0200000C RID: 12
	internal class ApiProgressRequest : ApiRequest
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003336 File Offset: 0x00001536
		internal ApiProgressRequest(string serverUrl, bool async, Encoding encoder, CookieContainer cookies, string reqId) : base(serverUrl, async, encoder, cookies)
		{
			this.reqId = reqId;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000334C File Offset: 0x0000154C
		public override Uri ServiceUri
		{
			get
			{
				if (base.IsAsync)
				{
					return new Uri(new Uri(base.ServerUrl), "_prs_.kdsvc?rid=" + this.reqId);
				}
				return new Uri(new Uri(base.ServerUrl), "_pr_.kdsvc?rid=" + this.reqId);
			}
		}

		// Token: 0x04000029 RID: 41
		private string reqId;
	}
}
