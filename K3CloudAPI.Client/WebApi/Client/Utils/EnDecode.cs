using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client.Utils
{
	// Token: 0x02000017 RID: 23
	public static class EnDecode
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00004640 File Offset: 0x00002840
		public static string Encode(object data)
		{
			string s = "KingdeeK";
			string s2 = "KingdeeK";
			string result;
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
				byte[] inArray = null;
				int length = 0;
				using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
				{
					int keySize = descryptoServiceProvider.KeySize;
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(bytes, bytes2), CryptoStreamMode.Write))
						{
							using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
							{
								streamWriter.Write(data);
								streamWriter.Flush();
								cryptoStream.FlushFinalBlock();
								streamWriter.Flush();
								inArray = memoryStream.GetBuffer();
								length = (int)memoryStream.Length;
							}
						}
					}
				}
				result = Convert.ToBase64String(inArray, 0, length);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
	}
}
