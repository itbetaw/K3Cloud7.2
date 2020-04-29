using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000010 RID: 16
	public class JsonArray : IEnumerable<JsonObject>, IEnumerable
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000388C File Offset: 0x00001A8C
		private JsonArray(string json)
		{
			this.jarray = JArray.Parse(json);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000038A0 File Offset: 0x00001AA0
		protected JsonArray()
		{
			this.jarray = new JArray();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000038B3 File Offset: 0x00001AB3
		public static JsonArray Parse(string json)
		{
			return new JsonArray(json);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003A50 File Offset: 0x00001C50
		public IEnumerable<T> ConvertTo<T>()
		{
			foreach (JsonObject jo in this)
			{
				yield return jo.Deserialize<T>();
			}
			yield break;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003BAC File Offset: 0x00001DAC
		public IEnumerator<JsonObject> GetEnumerator()
		{
			foreach (JToken item in ((IEnumerable<JToken>)this.jarray))
			{
				yield return JsonObject.Parse(item.ToString());
			}
			yield break;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003BC8 File Offset: 0x00001DC8
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003BCF File Offset: 0x00001DCF
		public override string ToString()
		{
			return this.jarray.ToString();
		}

		// Token: 0x0400002D RID: 45
		private JArray jarray;
	}
}
