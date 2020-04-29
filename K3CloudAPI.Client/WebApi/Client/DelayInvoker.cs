using System;
using System.Threading;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000016 RID: 22
	internal class DelayInvoker<T>
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000045E4 File Offset: 0x000027E4
		public DelayInvoker(Action<T> action, T state, int timeout)
		{
			this.action = action;
			this.state = state;
			this.timeout = timeout * 1000;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000461A File Offset: 0x0000281A
		internal void Invoke()
		{
			new Timer(delegate(object s)
			{
				this.action((T)((object)s));
			}, this.state, this.timeout, -1);
		}

		// Token: 0x04000045 RID: 69
		private int timeout;

		// Token: 0x04000046 RID: 70
		private T state;

		// Token: 0x04000047 RID: 71
		private Action<T> action;
	}
}
