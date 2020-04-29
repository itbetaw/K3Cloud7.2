using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000015 RID: 21
	internal class ProgressReporter
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00004424 File Offset: 0x00002624
		internal static ProgressReporter Create(ApiClient client, ApiRequest request, ProgressChangedHandler progressCallback, int interval)
		{
			string key = request.RequestId;
			ProgressReporter.reporters[key] = new ProgressReporter(client, request, progressCallback, interval);
			return ProgressReporter.reporters[key];
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004458 File Offset: 0x00002658
		private ProgressReporter(ApiClient client, ApiRequest request, ProgressChangedHandler progressCallback, int interval)
		{
			string text = request.RequestId;
			if (interval < 0 || interval > 30)
			{
				interval = 5;
			}
			int num = 1000 * interval;
			this.timer = new Timer(new TimerCallback(this.TimerCallback), null, num, num);
			this.requestId = text;
			this.progressCallback = progressCallback;
			this.client = client;
			this.getLastAuto = request.AutoGetLastProgress;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000044D8 File Offset: 0x000026D8
		internal static void Finish(string rid)
		{
			if (ProgressReporter.reporters.ContainsKey(rid))
			{
				ProgressReporter.reporters[rid].DoLast();
				ProgressReporter progressReporter;
				ProgressReporter.reporters.TryRemove(rid, out progressReporter);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004510 File Offset: 0x00002710
		private void DoLast()
		{
			if (this.getLastAuto)
			{
				this.timer.Change(0, 0);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004551 File Offset: 0x00002751
		internal void TimerCallback(object state)
		{
			this.locker.Run(delegate
			{
				ProgressInfo[] progress = this.GetProgress();
				if (progress != null && progress.Length > 0)
				{
					this.progressCallback(progress);
				}
			});
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000456C File Offset: 0x0000276C
		internal ProgressInfo[] GetProgress()
		{
			try
			{
				ApiRequest request = this.client.CreateProgressQuery(this.requestId);
				string text = this.client.Call(request, null);
				if (!string.IsNullOrEmpty(text))
				{
					return JsonArray.Parse(text).ConvertTo<ProgressInfo>().ToArray<ProgressInfo>();
				}
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
			}
			return null;
		}

		// Token: 0x0400003E RID: 62
		private static ConcurrentDictionary<string, ProgressReporter> reporters = new ConcurrentDictionary<string, ProgressReporter>();

		// Token: 0x0400003F RID: 63
		private ProgressChangedHandler progressCallback;

		// Token: 0x04000040 RID: 64
		private ApiClient client;

		// Token: 0x04000041 RID: 65
		private Timer timer;

		// Token: 0x04000042 RID: 66
		private string requestId;

		// Token: 0x04000043 RID: 67
		private LockOneTime locker = new LockOneTime();

		// Token: 0x04000044 RID: 68
		private bool getLastAuto = true;
	}
}
