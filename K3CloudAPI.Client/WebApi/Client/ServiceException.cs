using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Web;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client
{
    // Token: 0x02000014 RID: 20
    public class ServiceException : Exception, ISerializable
    {
        // Token: 0x060000C2 RID: 194 RVA: 0x00004214 File Offset: 0x00002414
        public ServiceException()
        {
        }

        // Token: 0x060000C3 RID: 195 RVA: 0x0000421C File Offset: 0x0000241C
        public ServiceException(int code, string message, Exception ex)
        {
            this.errorCode = code;
            this.message = message;
        }

        // Token: 0x060000C4 RID: 196 RVA: 0x00004235 File Offset: 0x00002435
        public ServiceException(string message) : this(ServiceException.apiClientErrorCode, message)
        {
        }

        // Token: 0x060000C5 RID: 197 RVA: 0x00004243 File Offset: 0x00002443
        public ServiceException(int code, string message) : this(code, message, null)
        {
        }

        // Token: 0x060000C6 RID: 198 RVA: 0x0000424E File Offset: 0x0000244E
        public ServiceException(Exception ex) : this(ServiceException.apiClientErrorCode, ex.Message, ex)
        {
        }

        // Token: 0x060000C7 RID: 199 RVA: 0x00004264 File Offset: 0x00002464
        private ServiceException(SerializationInfo info, StreamingContext context)
        {
            this.InnerExWrapper = (info.GetValue("InnerExWrapper", typeof(ExceptionWrapper)) as ExceptionWrapper);
            this._httpCode = info.GetInt32("_httpCode");
            this.errorCode = info.GetInt32("HResult");
            this.HelpLink = info.GetString("HelpURL");
            this.ClassName = info.GetString("ClassName");
            this.ExceptionMethod = info.GetString("ExceptionMethod");
            this.message = info.GetString("Message");
            this.Source = info.GetString("Source");
            this.stackTrace = info.GetString("StackTraceString");
            try
            {
                info.GetValue("Data", typeof(IDictionary));
            }
            catch
            {
            }
        }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x060000C8 RID: 200 RVA: 0x0000434C File Offset: 0x0000254C
        // (set) Token: 0x060000C9 RID: 201 RVA: 0x00004354 File Offset: 0x00002554
        public string ClassName { get; private set; }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x060000CA RID: 202 RVA: 0x0000435D File Offset: 0x0000255D
        // (set) Token: 0x060000CB RID: 203 RVA: 0x00004365 File Offset: 0x00002565
        public string ExceptionMethod { get; private set; }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x060000CC RID: 204 RVA: 0x0000436E File Offset: 0x0000256E
        //public override int ErrorCode
        //{
        //    get
        //    {
        //        return this.errorCode;
        //    }
        //}

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x060000CD RID: 205 RVA: 0x00004376 File Offset: 0x00002576
        // (set) Token: 0x060000CE RID: 206 RVA: 0x0000437E File Offset: 0x0000257E
        public override string HelpLink { get; set; }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x060000CF RID: 207 RVA: 0x00004387 File Offset: 0x00002587
        public override string Message
        {
            get
            {
                return this.message;
            }
        }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x060000D0 RID: 208 RVA: 0x0000438F File Offset: 0x0000258F
        // (set) Token: 0x060000D1 RID: 209 RVA: 0x00004397 File Offset: 0x00002597
        public override string Source { get; set; }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x060000D2 RID: 210 RVA: 0x000043A0 File Offset: 0x000025A0
        public override string StackTrace
        {
            get
            {
                return this.stackTrace;
            }
        }

        // Token: 0x060000D3 RID: 211 RVA: 0x000043A8 File Offset: 0x000025A8
        public int GetHttpCode()
        {
            return this._httpCode;
        }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x060000D4 RID: 212 RVA: 0x000043B0 File Offset: 0x000025B0
        public override IDictionary Data
        {
            get
            {
                return this.data;
            }
        }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x060000D5 RID: 213 RVA: 0x000043B8 File Offset: 0x000025B8
        // (set) Token: 0x060000D6 RID: 214 RVA: 0x000043C0 File Offset: 0x000025C0
        public bool Handled { get; set; }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x060000D7 RID: 215 RVA: 0x000043C9 File Offset: 0x000025C9
        // (set) Token: 0x060000D8 RID: 216 RVA: 0x000043D1 File Offset: 0x000025D1
        public ExceptionWrapper InnerExWrapper { get; set; }

        // Token: 0x060000D9 RID: 217 RVA: 0x000043DC File Offset: 0x000025DC
        public ExceptionWrapper GetLastInnerEx()
        {
            if (this.InnerExWrapper == null)
            {
                return null;
            }
            ExceptionWrapper exceptionWrapper = this.InnerExWrapper;
            while (exceptionWrapper.InnerException != null && !exceptionWrapper.InnerException.IsEmpty)
            {
                exceptionWrapper = exceptionWrapper.InnerException;
            }
            return exceptionWrapper;
        }

        // Token: 0x04000032 RID: 50
        private static int apiClientErrorCode = -1;

        // Token: 0x04000033 RID: 51
        private int errorCode;

        // Token: 0x04000034 RID: 52
        private string message;

        // Token: 0x04000035 RID: 53
        private string stackTrace;

        // Token: 0x04000036 RID: 54
        private IDictionary data;

        // Token: 0x04000037 RID: 55
        private int _httpCode;
    }
}
