using System;
using System.Net;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x0200000D RID: 13
	internal class StreamRequest : ApiRequest
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000033A2 File Offset: 0x000015A2
		public StreamRequest(string serverUrl, Encoding encoder, CookieContainer cookies) : base(serverUrl, true, encoder, cookies)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000033AE File Offset: 0x000015AE
		public override Uri ServiceUri
		{
			get
			{
				return new Uri(new Uri(base.ServerUrl), "stream.kdsvc");
			}
		}
	}
}
