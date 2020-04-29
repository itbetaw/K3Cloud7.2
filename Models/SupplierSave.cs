using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.Models
{
    public class SupplierSave
    {
        public FNumberModel FCreateOrgId { get; set; }
        public string FNumber { get; set; }
        public FNumberModel FUseOrgId { get; set; }
        public string FName { get; set; }
        public string FShortName { get; set; }
        public string FDescription { get; set; }
        public Ffinanceinfo FFinanceInfo { get; set; }
        public Flocationinfo[] FLocationInfo { get; set; }
    }

    public class FNumberModel
    {
        public string FNumber { get; set; }
    }
    public class Ffinanceinfo
    {
        public FNumberModel FPayCurrencyId { get; set; }
    }

    public class Flocationinfo
    {
        /// <summary>
        /// 地点名称
        /// </summary>
        public string FLocName { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public FNumberModel FLocNewContact { get; set; }
        /// <summary>
        /// 通讯地址
        /// </summary>
        public string FLocAddress { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string FLocMobile { get; set; }
    }
}
