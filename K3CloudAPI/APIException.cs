using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Client.WebApi.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI
{
    /// <summary>
    /// 来源于API调用引发的异常信息类，
    /// 为保证.NET统一性，该类继承Kingdee.BOS.WebApi.Client.ServiceException。
    /// </summary>
    //public class APIException : ServiceException
    public class APIException : ServiceException
    {

        public APIException() { }
        public APIException(Exception ex) { }/* : base(ex) { }*/
        public APIException(string message) { } /*: base(message) { }*/
        public APIException(int code, string message) { }/*: base(code, message) { }*/
        public APIException(int code, string message, Exception ex) { }/* : base(code, message, ex) { }*/
    }
}
