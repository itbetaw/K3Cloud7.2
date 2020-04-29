using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000008 RID: 8
	public class JsonObject : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002B26 File Offset: 0x00000D26
		private JsonObject(string json)
		{
			this.jobject = JObject.Parse(json);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002B3A File Offset: 0x00000D3A
		protected JsonObject()
		{
			this.jobject = new JObject();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002B4D File Offset: 0x00000D4D
		public static JsonObject Parse(string json)
		{
			return new JsonObject(json);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002B55 File Offset: 0x00000D55
		public static T Deserialize<T>(string json)
		{
			return (T)((object)JsonObject.Deserialize(json, typeof(T)));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002B6C File Offset: 0x00000D6C
		private static object Deserialize(string json, Type type)
		{
			if (string.IsNullOrEmpty(json))
			{
				if (type.IsValueType)
				{
					return Activator.CreateInstance(type);
				}
				if (type.Equals(typeof(string)))
				{
					return json;
				}
				return null;
			}
			else
			{
				if (type == typeof(string))
				{
					return json;
				}
				if (type.IsEnum)
				{
					return Enum.Parse(type, json, true);
				}
				if (type == typeof(int))
				{
					return int.Parse(json);
				}
				if (type == typeof(byte))
				{
					return byte.Parse(json);
				}
				if (type == typeof(long))
				{
					return long.Parse(json);
				}
				if (type == typeof(DateTime))
				{
					return DateTime.Parse(json);
				}
				if (type == typeof(decimal))
				{
					return decimal.Parse(json);
				}
				if (type == typeof(bool))
				{
					return bool.Parse(json);
				}
				return JsonConvert.DeserializeObject(json, type);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C86 File Offset: 0x00000E86
		public void SetValue(string prop, object v)
		{
			if (v != null && v.GetType().IsSimpleType())
			{
				this.AddOrUpdate(prop, new JValue(v));
				return;
			}
			this.AddOrUpdate(prop, JObject.FromObject(v));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002CB3 File Offset: 0x00000EB3
		private void AddOrUpdate(string prop, JToken v)
		{
			if (this.jobject.Property(prop) == null)
			{
				this.jobject.Add(prop, v);
				return;
			}
			this.jobject[prop] = v;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public T GetValue<T>(string prop)
		{
			JToken value;
			if (this.jobject.TryGetValue(prop, out value))
			{
				return value.Value<T>();
			}
			throw new ServiceException("对象不包括属性" + prop);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002E6C File Offset: 0x0000106C
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			foreach (KeyValuePair<string, JToken> kv in this.jobject)
			{
				KeyValuePair<string, JToken> keyValuePair = kv;
				string key = keyValuePair.Key;
				KeyValuePair<string, JToken> keyValuePair2 = kv;
				yield return new KeyValuePair<string, string>(key, keyValuePair2.Value.ToString());
			}
			yield break;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002E88 File Offset: 0x00001088
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002E8F File Offset: 0x0000108F
		public override string ToString()
		{
			return this.jobject.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002E9C File Offset: 0x0000109C
		internal T Deserialize<T>()
		{
			return (T)((object)JsonConvert.DeserializeObject(this.ToString(), typeof(T)));
		}

		// Token: 0x04000015 RID: 21
		private JObject jobject;
	}
}
