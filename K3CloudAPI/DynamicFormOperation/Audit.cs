using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行审核操作。
    /// </summary>
    public class Audit : SingleActionOperation
    {
        #region 公共覆盖操作参数

        /// <summary>
        /// 操作的服务名称定义。
        /// </summary>
        public override string ServiceName

        {
            get
            {
                return "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit";
            }
        }//end property

        #endregion

    }//end class
}//end namespace
