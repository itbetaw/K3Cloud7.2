using System;
using System.Threading;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000011 RID: 17
	internal class LockOneTime
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00003BDC File Offset: 0x00001DDC
		internal void Run(Action action)
		{
			if (this.sema.CurrentCount == 0)
			{
				return;
			}
			this.sema.Wait();
			try
			{
				action();
			}
			finally
			{
				this.sema.Release();
			}
		}

		// Token: 0x0400002E RID: 46
		private static int max = 1;

		// Token: 0x0400002F RID: 47
		private SemaphoreSlim sema = new SemaphoreSlim(LockOneTime.max);
	}
}
