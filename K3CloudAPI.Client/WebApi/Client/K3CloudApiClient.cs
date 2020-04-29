using System;
using System.Collections.Generic;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000012 RID: 18
	public class K3CloudApiClient : ApiClient
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00003C48 File Offset: 0x00001E48
		public K3CloudApiClient(string serverUrl) : base(serverUrl)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003C51 File Offset: 0x00001E51
		public K3CloudApiClient(string serverUrl, int timeout) : base(serverUrl, timeout)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003C5B File Offset: 0x00001E5B
		public List<DataCenter> GetDataCenters()
		{
			return base.Execute<List<DataCenter>>("Kingdee.BOS.ServiceFacade.ServicesStub.Account.AccountService.GetDataCenterList", new object[0]);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003C70 File Offset: 0x00001E70
		public string ExcuteOperation(string formid, string opNumber, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExcuteOperation", new object[]
			{
				formid,
				opNumber,
				data
			});
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003C9C File Offset: 0x00001E9C
		public string Save(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public string BatchSave(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.BatchSave", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003CEC File Offset: 0x00001EEC
		public string Audit(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003D14 File Offset: 0x00001F14
		public string Delete(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Delete", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003D3C File Offset: 0x00001F3C
		public string UnAudit(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.UnAudit", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003D64 File Offset: 0x00001F64
		public string Submit(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Submit", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003D8C File Offset: 0x00001F8C
		public string View(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.View", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public List<List<object>> ExecuteBillQuery(string data)
		{
			return base.Execute<List<List<object>>>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExecuteBillQuery", new object[]
			{
				data
			});
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003DDC File Offset: 0x00001FDC
		public string Draft(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Draft", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003E04 File Offset: 0x00002004
		public string Allocate(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Allocate", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003E2C File Offset: 0x0000202C
		public string FlexSave(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.FlexSave", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003E54 File Offset: 0x00002054
		public string SendMsg(string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.SendMsg", new object[]
			{
				data
			});
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003E78 File Offset: 0x00002078
		public string Push(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Push", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003EA0 File Offset: 0x000020A0
		public string GroupSave(string formid, string data)
		{
			return base.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.GroupSave", new object[]
			{
				formid,
				data
			});
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003EC8 File Offset: 0x000020C8
		public void GetDataCentersSync(Action<List<DataCenter>> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<List<DataCenter>>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.GetDataCenterList", SuccResultHandler, new object[0], progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003EE4 File Offset: 0x000020E4
		public void ExcuteOperationSync(string formid, string opNumber, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExcuteOperation", SuccResultHandler, new object[]
			{
				formid,
				opNumber,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003F1C File Offset: 0x0000211C
		public void SaveSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003F50 File Offset: 0x00002150
		public void BatchSaveSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.BatchSave", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003F84 File Offset: 0x00002184
		public void AuditSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003FB8 File Offset: 0x000021B8
		public void DeleteSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Delete", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003FEC File Offset: 0x000021EC
		public void UnAuditSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.UnAudit", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004020 File Offset: 0x00002220
		public void SubmitSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Submit", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004054 File Offset: 0x00002254
		public void ViewSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.View", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004088 File Offset: 0x00002288
		public void ExecuteBillQuerySync(string data, Action<List<List<object>>> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<List<List<object>>>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExecuteBillQuery", SuccResultHandler, new object[]
			{
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000040B8 File Offset: 0x000022B8
		public void DraftSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Draft", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000040EC File Offset: 0x000022EC
		public void AllocateSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Allocate", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004120 File Offset: 0x00002320
		public void FlexSaveSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.FlexSave", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004154 File Offset: 0x00002354
		public void SendMsgSync(string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.SendMsg", SuccResultHandler, new object[]
			{
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004184 File Offset: 0x00002384
		public void PushSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Push", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000041B8 File Offset: 0x000023B8
		public void GroupSaveSync(string formId, string data, Action<string> SuccResultHandler, FailCallbackHandler failcallback = null, ProgressChangedHandler progressCallback = null, int reportInterval = 5)
		{
			base.ExecuteAsync<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.GroupSave", SuccResultHandler, new object[]
			{
				formId,
				data
			}, progressCallback, failcallback, 10, reportInterval);
		}
	}
}
