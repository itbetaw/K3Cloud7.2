using System;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000013 RID: 19
	public class ProgressInfo
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000041EA File Offset: 0x000023EA
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000041F2 File Offset: 0x000023F2
		public byte Percentage { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000041FB File Offset: 0x000023FB
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00004203 File Offset: 0x00002403
		public string Message { get; set; }
	}
}
