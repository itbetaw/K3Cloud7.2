using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行反审核操作。
    /// </summary>
    public class UnAudit : SingleActionOperation
    {
        #region 公共覆盖操作参数

        /// <summary>
        /// 操作的URL定义。
        /// </summary>
        public override string ServiceName
        {
            get
            {
                return "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.UnAudit";
            }
        }//end property

        #endregion

    }//end class
}//end namespace
