using System;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class DataCenter
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002974 File Offset: 0x00000B74
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000297C File Offset: 0x00000B7C
		public string Id { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002985 File Offset: 0x00000B85
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000298D File Offset: 0x00000B8D
		public string Number { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002996 File Offset: 0x00000B96
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000299E File Offset: 0x00000B9E
		public string Name { get; set; }

		// Token: 0x06000037 RID: 55 RVA: 0x000029A7 File Offset: 0x00000BA7
		public override string ToString()
		{
			return this.Name;
		}
	}
}
