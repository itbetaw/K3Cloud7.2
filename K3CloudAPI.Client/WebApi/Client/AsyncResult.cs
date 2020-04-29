using System;
using System.Collections.Generic;
using System.Linq;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000005 RID: 5
	public class AsyncResult<T>
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002780 File Offset: 0x00000980
		internal AsyncResult()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002788 File Offset: 0x00000988
		internal static AsyncResult<T> CreateUnsuccess(ServiceException ex)
		{
			return new AsyncResult<T>
			{
				Successful = false,
				ReturnValue = default(T),
				Exception = ex
			};
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027BC File Offset: 0x000009BC
		internal static AsyncResult<T> CreateSuccess(T result)
		{
			return new AsyncResult<T>
			{
				Successful = true,
				ReturnValue = result,
				Exception = null
			};
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000027E5 File Offset: 0x000009E5
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000027ED File Offset: 0x000009ED
		public bool Successful { get; internal set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000027F6 File Offset: 0x000009F6
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000027FE File Offset: 0x000009FE
		public T ReturnValue { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002807 File Offset: 0x00000A07
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000280F File Offset: 0x00000A0F
		public ServiceException Exception { get; internal set; }

		// Token: 0x0600002E RID: 46 RVA: 0x00002818 File Offset: 0x00000A18
		internal void ThrowEx()
		{
			if (this.Exception != null && !this.Exception.Handled)
			{
				throw this.Exception;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002838 File Offset: 0x00000A38
		internal AsyncResult<List<To>> ToList<To>()
		{
			AsyncResult<List<To>> asyncResult = new AsyncResult<List<To>>
			{
				Successful = this.Successful,
				Exception = this.Exception
			};
			if (typeof(T) == typeof(string))
			{
				AsyncResult<List<To>> asyncResult2 = asyncResult;
				T returnValue = this.ReturnValue;
				asyncResult2.ReturnValue = JsonArray.Parse(returnValue.ToString()).ConvertTo<To>().ToList<To>();
			}
			else
			{
				asyncResult.ReturnValue = (List<To>)((object)this.ReturnValue);
			}
			return asyncResult;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000028C4 File Offset: 0x00000AC4
		internal AsyncResult<To> Cast<To>()
		{
			AsyncResult<To> asyncResult = new AsyncResult<To>
			{
				Successful = this.Successful,
				Exception = this.Exception
			};
			if (typeof(T) == typeof(string))
			{
				string text;
				if (this.ReturnValue != null)
				{
					T returnValue = this.ReturnValue;
					text = returnValue.ToString();
				}
				else
				{
					text = "";
				}
				string text2 = text;
				if (string.IsNullOrEmpty(text2))
				{
					asyncResult.ReturnValue = default(To);
				}
				else
				{
					asyncResult.ReturnValue = JsonObject.Deserialize<To>(text2);
				}
			}
			else
			{
				asyncResult.ReturnValue = (To)((object)this.ReturnValue);
			}
			return asyncResult;
		}
	}
}
