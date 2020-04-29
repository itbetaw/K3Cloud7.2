using System;
using System.Collections;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000007 RID: 7
	public class ExceptionWrapper
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000029BF File Offset: 0x00000BBF
		public static ExceptionWrapper WrapEx(Exception ex)
		{
			return ExceptionWrapper.Wrap(ex);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029C8 File Offset: 0x00000BC8
		private static ExceptionWrapper Wrap(Exception ex)
		{
			ExceptionWrapper exceptionWrapper = new ExceptionWrapper();
			exceptionWrapper.Data = ex.Data;
			exceptionWrapper.Message = ex.Message;
			exceptionWrapper.StackTrace = ex.StackTrace;
			exceptionWrapper.ExceptionType = ex.GetType().AssemblyQualifiedName;
			if (ex.InnerException != null)
			{
				exceptionWrapper.InnerException = ExceptionWrapper.Wrap(ex.InnerException);
			}
			return exceptionWrapper;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002A2C File Offset: 0x00000C2C
		public bool IsEmpty
		{
			get
			{
				return string.IsNullOrEmpty(this.HelpLink) && string.IsNullOrEmpty(this.Message) && string.IsNullOrEmpty(this.Message) && string.IsNullOrEmpty(this.Source) && string.IsNullOrEmpty(this.StackTrace) && string.IsNullOrEmpty(this.ExceptionType) && (this.InnerException == null || this.InnerException.IsEmpty);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A9E File Offset: 0x00000C9E
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002AA6 File Offset: 0x00000CA6
		public IDictionary Data { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002AAF File Offset: 0x00000CAF
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public string HelpLink { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public string Message { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002AD1 File Offset: 0x00000CD1
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public string Source { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002AE2 File Offset: 0x00000CE2
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002AEA File Offset: 0x00000CEA
		public string StackTrace { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002AF3 File Offset: 0x00000CF3
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002AFB File Offset: 0x00000CFB
		public string TargetSite { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002B04 File Offset: 0x00000D04
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002B0C File Offset: 0x00000D0C
		public string ExceptionType { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002B15 File Offset: 0x00000D15
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002B1D File Offset: 0x00000D1D
		public ExceptionWrapper InnerException { get; set; }
	}
}
