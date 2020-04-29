using System;
using System.Net;
using System.Text;
using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client.Utils;
using Newtonsoft.Json.Linq;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000002 RID: 2
	public class ApiClient
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public ApiClient(string serverUrl)
		{
			this.Encoder = new UTF8Encoding();
			this.serverUrl = serverUrl;
			this.CookiesContainer = new CookieContainer();
			this.httpClient = new HttpClient();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000208B File Offset: 0x0000028B
		public ApiClient(string serverUrl, int timeout) : this(serverUrl)
		{
			this._defaultTimeout = timeout;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209B File Offset: 0x0000029B
		public ApiClient(string serverUrl, FailCallbackHandler defaultfailcallback) : this(serverUrl)
		{
			this.defaultFailCallback = defaultfailcallback;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AB File Offset: 0x000002AB
		public ApiClient(string serverUrl, FailCallbackHandler defaultfailcallback, int timeout) : this(serverUrl, defaultfailcallback)
		{
			this._defaultTimeout = timeout;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020BC File Offset: 0x000002BC
		public ApiRequest CreateAsyncRequest(string servicename, object[] parameters = null)
		{
			return new ApiServiceRequest(this.serverUrl, true, this.Encoder, this.CookiesContainer, servicename, parameters);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020D8 File Offset: 0x000002D8
		public ApiRequest CreateRequest(string servicename, object[] parameters = null)
		{
			return new ApiServiceRequest(this.serverUrl, false, this.Encoder, this.CookiesContainer, servicename, parameters);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020F4 File Offset: 0x000002F4
		public ApiRequest CreateProgressQuery(string reqId)
		{
			return new ApiProgressRequest(this.serverUrl, false, this.Encoder, this.CookiesContainer, reqId);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000210F File Offset: 0x0000030F
		public bool Logout()
		{
			return this.Execute<bool>("Kingdee.BOS.WebApi.ServicesStub.AuthService.Logout", null);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002120 File Offset: 0x00000320
		public bool Login(string dbId, string userName, string password, int lcid)
		{
			object[] parameters = new object[]
			{
				dbId,
				EnDecode.Encode(userName),
				EnDecode.Encode(password),
				lcid
			};
			string json = this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUserEnDeCode", parameters);
			int num = JObject.Parse(json)["LoginResultType"].Value<int>();
			return num == 1;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002180 File Offset: 0x00000380
		public string ValidateLogin(string dbId, string userName, string password, int lcid)
		{
			object[] parameters = new object[]
			{
				dbId,
				EnDecode.Encode(userName),
				EnDecode.Encode(password),
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUserEnDeCode", parameters);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021C4 File Offset: 0x000003C4
		public string LoginByAppSecret(string dbId, string userName, string appId, string appSecret, int lcid)
		{
			object[] parameters = new object[]
			{
				dbId,
				userName,
				appId,
				appSecret,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginByAppSecret", parameters);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002204 File Offset: 0x00000404
		public string LoginBySign(string dbId, string userName, string appId, long timestamp, string sign, int lcid)
		{
			object[] parameters = new object[]
			{
				dbId,
				userName,
				appId,
				timestamp,
				sign,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginBySign", parameters);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000224C File Offset: 0x0000044C
		public string LoginBySimplePassport(string passportForBase64, int lcid = 2052)
		{
			object[] parameters = new object[]
			{
				passportForBase64,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginBySimplePassport", parameters);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000227C File Offset: 0x0000047C
		public string LoginByMobileCard(string passportForBase64, string customizationParameter, int lcid = 2052)
		{
			object[] parameters = new object[]
			{
				passportForBase64,
				customizationParameter,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginByMobileCard", parameters);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022B0 File Offset: 0x000004B0
		public string LoginByRSAAuth(string json)
		{
			object[] parameters = new object[]
			{
				json
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginByRSAAuth", parameters);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022D6 File Offset: 0x000004D6
		public T Execute<T>(string servicename, object[] parameters = null)
		{
			return this.Execute<T>(servicename, parameters, null, this._defaultTimeout);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022E8 File Offset: 0x000004E8
		public T Execute<T>(string servicename, object[] parameters = null, FailCallbackHandler failcallback = null, int timeout = 100)
		{
			ApiRequest apiRequest = this.CreateRequest(servicename, parameters);
			apiRequest.HttpRequest.Timeout = timeout * 1000;
			return this.Call<T>(apiRequest, failcallback);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002374 File Offset: 0x00000574
		public ApiRequest ExecuteAsync<T>(string servicename, Action<T> successCallback, object[] parameters = null, ProgressChangedHandler progressCallback = null, FailCallbackHandler failcallback = null, int timeout = 0, int reportInterval = 5)
		{
			return this.ExecuteAsyncInternal<T>(servicename, delegate(AsyncResult<T> ret)
			{
				if (ret.Successful)
				{
					successCallback(ret.ReturnValue);
					return;
				}
				FailCallbackHandler reallyFailCallback = this.GetReallyFailCallback(failcallback);
				if (reallyFailCallback != null)
				{
					reallyFailCallback(ret.Exception);
					return;
				}
				ret.ThrowEx();
			}, parameters, progressCallback, timeout, reportInterval);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023B8 File Offset: 0x000005B8
		private ApiRequest ExecuteAsyncInternal<T>(string servicename, Action<AsyncResult<T>> callback, object[] parameters = null, ProgressChangedHandler progressCallback = null, int timeout = 0, int reportInterval = 5)
		{
			ApiRequest apiRequest = this.CreateAsyncRequest(servicename, parameters);
			apiRequest.HttpRequest.Timeout = timeout * 1000;
			this.CallAsync<T>(apiRequest, callback, progressCallback, timeout, reportInterval);
			return apiRequest;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002420 File Offset: 0x00000620
		public string Call(ApiRequest request, FailCallbackHandler failcallback = null)
		{
			return this.SafeDo<string>(() => this.httpClient.Send(request), this.GetReallyFailCallback(failcallback));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024A0 File Offset: 0x000006A0
		public T Call<T>(ApiRequest request, FailCallbackHandler failcallback = null)
		{
			return this.SafeDo<T>(delegate
			{
				string text = this.httpClient.Send(request);
				if (string.IsNullOrEmpty(text))
				{
					return default(T);
				}
				return JsonObject.Deserialize<T>(text);
			}, this.GetReallyFailCallback(failcallback));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002568 File Offset: 0x00000768
		public void CallAsync<T>(ApiRequest request, Action<AsyncResult<T>> callback, ProgressChangedHandler progressCallback = null, int timeout = 0, int reportInterval = 5)
		{
			this.httpClient.SendAysnc(request, delegate(AsyncResult<string> ret)
			{
				ProgressReporter.Finish(request.RequestId);
				callback(ret.Cast<T>());
			}, null);
			if (progressCallback != null)
			{
				ProgressReporter reporter = ProgressReporter.Create(this, request, progressCallback, reportInterval);
				if (reportInterval > 0)
				{
					new DelayInvoker<ApiRequest>(delegate(ApiRequest r)
					{
						try
						{
							reporter.TimerCallback(null);
						}
						catch (WebException ex)
						{
							if (ex.Status == WebExceptionStatus.RequestCanceled)
							{
								throw new TimeoutException(string.Format("请求超时{0}秒，请求被终止", timeout));
							}
						}
					}, request, timeout).Invoke();
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002602 File Offset: 0x00000802
		private FailCallbackHandler GetReallyFailCallback(FailCallbackHandler failcallback)
		{
			if (failcallback != null)
			{
				return failcallback;
			}
			if (this.defaultFailCallback != null)
			{
				return this.defaultFailCallback;
			}
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000261C File Offset: 0x0000081C
		private T SafeDo<T>(Func<T> action, FailCallbackHandler failcallback)
		{
			try
			{
				return action();
			}
			catch (ServiceException ex)
			{
				bool flag = false;
				if (failcallback != null)
				{
					failcallback(ex);
					flag = ex.Handled;
				}
				if (!flag)
				{
					throw;
				}
			}
			return default(T);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002668 File Offset: 0x00000868
		public string ValidateLogin2(string dbId, string username, string password, bool isKickOff, int lcid)
		{
			object[] parameters = new object[]
			{
				dbId,
				username,
				password,
				isKickOff,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser2", parameters);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026AC File Offset: 0x000008AC
		public string LoginByAppSecret2(string dbId, string userName, string appId, string appSecret, bool isKickOff, int lcid = 2052)
		{
			object[] parameters = new object[]
			{
				dbId,
				userName,
				appId,
				appSecret,
				isKickOff,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginByAppSecret2", parameters);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026F4 File Offset: 0x000008F4
		public string LoginBySign2(string dbId, string userName, string appId, long timestamp, string sign, bool isKickOff, int lcid = 2052)
		{
			object[] parameters = new object[]
			{
				dbId,
				userName,
				appId,
				timestamp,
				sign,
				isKickOff,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginBySign2", parameters);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002748 File Offset: 0x00000948
		public string LoginBySimplePassport2(string passportForBase64, bool isKickOff, int lcid = 2052)
		{
			object[] parameters = new object[]
			{
				passportForBase64,
				isKickOff,
				lcid
			};
			return this.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.AuthService.LoginBySimplePassport2", parameters);
		}

		// Token: 0x04000001 RID: 1
		private HttpClient httpClient;

		// Token: 0x04000002 RID: 2
		private string serverUrl;

		// Token: 0x04000003 RID: 3
		private FailCallbackHandler defaultFailCallback;

		// Token: 0x04000004 RID: 4
		private CookieContainer CookiesContainer;

		// Token: 0x04000005 RID: 5
		private Encoding Encoder;

		// Token: 0x04000006 RID: 6
		private int _defaultTimeout = 300;
	}
}
