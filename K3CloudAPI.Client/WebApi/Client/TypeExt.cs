using System;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
	// Token: 0x02000018 RID: 24
	internal static class TypeExt
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00004770 File Offset: 0x00002970
		public static bool IsSimpleType(this Type type)
		{
			return type.IsValueType || type == typeof(string);
		}
	}
}
