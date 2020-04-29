using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Consts
{
    /// <summary>
    /// 库存状态
    /// </summary>
    public class StockStatusConsts
    {
        public const string 可用 = "KCZT01_SYS";
        public const string 待检 = "KCZT02_SYS";
        public const string 冻结 = "KCZT03_SYS";
        public const string 退回冻结 = "KCZT04_SYS";
        public const string 在途 = "KCZT05_SYS";
        public const string 收货冻结 = "KCZT06_SYS";
        public const string 废品 = "KCZT07_SYS";
        public const string 不良 = "KCZT08_SYS";

    }

    public class StockStatus
    {
        public string[] status { get; set; }
    }

}
