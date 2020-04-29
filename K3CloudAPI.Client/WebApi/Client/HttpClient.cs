using System;
using System.IO;
using System.Net;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x0200000E RID: 14
	internal class HttpClient
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000033C8 File Offset: 0x000015C8
		public string Send(ApiRequest request)
		{
			using (Stream requestStream = request.HttpRequest.GetRequestStream())
			{
				byte[] bytes = request.Encoder.GetBytes(request.ToJsonString());
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Flush();
			}
			string result;
			using (Stream responseStream = request.HttpRequest.GetResponse().GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					result = HttpClient.ValidateResult(streamReader.ReadToEnd());
				}
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003478 File Offset: 0x00001678
		public void SendAysnc(ApiRequest request, Action<AsyncResult<string>> callback, Action aftersent = null)
		{
			lock (this)
			{
				HttpClient.RequestState state = new HttpClient.RequestState(request, callback, aftersent);
				HttpWebRequest httpRequest = request.HttpRequest;
				httpRequest.BeginGetRequestStream(new AsyncCallback(this.BeginGetRequestCallback), state);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000354C File Offset: 0x0000174C
		private void BeginGetRequestCallback(IAsyncResult ar)
		{
			HttpClient.RequestState reqs = (HttpClient.RequestState)ar.AsyncState;
			this.SafeDo(reqs, delegate
			{
				reqs.EndSendRequest(ar);
				if (reqs.SentCallback != null)
				{
					reqs.SentCallback();
				}
				reqs.Request.HttpRequest.BeginGetResponse(new AsyncCallback(this.GetResponseCallback), ar.AsyncState);
			});
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000036A4 File Offset: 0x000018A4
		private void GetResponseCallback(IAsyncResult ar)
		{
			HttpClient.RequestState reqs = (HttpClient.RequestState)ar.AsyncState;
			this.SafeDo(reqs, delegate
			{
				Action<AsyncResult<string>> callback = reqs.Callback;
				ApiRequest request = ((HttpClient.RequestState)ar.AsyncState).Request;
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)request.HttpRequest.EndGetResponse(ar))
				{
					if (httpWebResponse.StatusCode == HttpStatusCode.OK)
					{
						using (Stream responseStream = httpWebResponse.GetResponseStream())
						{
							using (StreamReader streamReader = new StreamReader(responseStream, reqs.Request.Encoder))
							{
								string responseText = streamReader.ReadToEnd();
								string result = HttpClient.ValidateResult(responseText);
								callback(AsyncResult<string>.CreateSuccess(result));
							}
							goto IL_BE;
						}
					}
					ServiceException ex = new ServiceException((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
					callback(AsyncResult<string>.CreateUnsuccess(ex));
					IL_BE:;
				}
			});
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000036EC File Offset: 0x000018EC
		private static string ValidateResult(string responseText)
		{
			if (!responseText.StartsWith("response_error:"))
			{
				return responseText;
			}
			string text = responseText.TrimStart("response_error:".ToCharArray());
			if (text == null || text == "")
			{
				throw new ServiceException("返回的异常信息为空");
			}
			text = text.Replace("\"", "");
			throw new ServiceException(text);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000374C File Offset: 0x0000194C
		private void SafeDo(HttpClient.RequestState reqs, Action action)
		{
			try
			{
				action();
			}
			catch (ServiceException ex)
			{
				reqs.Callback(AsyncResult<string>.CreateUnsuccess(ex));
			}
			catch (Exception ex2)
			{
				reqs.Callback(AsyncResult<string>.CreateUnsuccess(new ServiceException(ex2)));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000037AC File Offset: 0x000019AC
		private void RequestTimeout(object state, bool timedOut)
		{
			if (timedOut)
			{
				WebRequest webRequest = (WebRequest)state;
				webRequest.Abort();
			}
		}

		// Token: 0x0200000F RID: 15
		private class RequestState
		{
			// Token: 0x06000089 RID: 137 RVA: 0x000037D1 File Offset: 0x000019D1
			public RequestState(ApiRequest request, Action<AsyncResult<string>> callback, Action aftersent)
			{
				this.Request = request;
				this.Callback = callback;
				this.SentCallback = aftersent;
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000037EE File Offset: 0x000019EE
			// (set) Token: 0x0600008B RID: 139 RVA: 0x000037F6 File Offset: 0x000019F6
			public Action SentCallback { get; private set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600008C RID: 140 RVA: 0x000037FF File Offset: 0x000019FF
			// (set) Token: 0x0600008D RID: 141 RVA: 0x00003807 File Offset: 0x00001A07
			public ApiRequest Request { get; private set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00003810 File Offset: 0x00001A10
			// (set) Token: 0x0600008F RID: 143 RVA: 0x00003818 File Offset: 0x00001A18
			public Action<AsyncResult<string>> Callback { get; private set; }

			// Token: 0x06000090 RID: 144 RVA: 0x00003824 File Offset: 0x00001A24
			internal void EndSendRequest(IAsyncResult ar)
			{
				using (Stream stream = this.Request.HttpRequest.EndGetRequestStream(ar))
				{
					byte[] bytes = this.Request.Encoder.GetBytes(this.Request.ToJsonString());
					stream.Write(bytes, 0, bytes.Length);
					stream.Flush();
				}
			}
		}
	}
}
