using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI
{
    /// <summary>
    /// API操作抽象类扩展。
    /// </summary>
    public static class KdAPIOperationExtension
    {
        /// <summary>
        /// 转向KdAPI请求。
        /// </summary>
        /// <param name="operation">API操作实例。</param>
        /// <returns>返回KdAPI请求对象。</returns>
        public static KdAPIRequest ToKdAPIRequest(this APIOperation operation)
        {
            return operation.ToAPIRequest<KdAPIRequest>();
        }//end method

    }//end class
}
