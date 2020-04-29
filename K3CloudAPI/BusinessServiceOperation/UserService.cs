using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.BusinessServiceOperation
{
    /// <summary>
    /// 用户服务。
    /// </summary>
    public class UserService : ExecuteServiceOperation
    {
        /// <summary>
        /// 会话服务的参数构造方法。
        /// </summary>
        public UserService()
        {
            this.SetAssemblyName("Middleware.BOS.WebAPI.ServiceStub");
            this.SetClassNameWithoutNamespace("User.UserService");
        }//end constructor

    }//end class
}//end namespace
