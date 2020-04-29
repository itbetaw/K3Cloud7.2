using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 其他入库单保存信息实体
    /// </summary>
    public class STK_MiscellaneousSave
    {
        public string FID { get; set; }
        public string FBillNo { get; set; }
        public Fbilltypeid FBillTypeID { get; set; }
        public Fstockorgid FStockOrgId { get; set; }
        public string FDate { get; set; }
        public FSUPPLIERID FSupplyerID { get; set; }
        public FDEPTID FDeptID { get; set; }
        public string FOwnerTypeIdHead { get; set; }
        public Fowneridhead FOwnerIdHead { get; set; }
        public Fentity[] FEntity { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }

        public class FSUPPLIERID
        {
            public string FNumber { get; set; }
        }

        public class FDEPTID
        {
            public string FNumber { get; set; }
        }
        public class Fowneridhead
        {
            public string FNumber { get; set; }
        }

        public class Fentity
        {
            public string FEntryID { get; set; }
            public FMATERIALID FMATERIALID { get; set; }
            public Funitid FUnitID { get; set; }
            /// <summary>
            /// 库存状态
            /// </summary>
            public FSTOCKSTATUSID FSTOCKSTATUSID { get; set; }
            public string FQty { get; set; }
            /// <summary>
            /// 收货仓库
            /// </summary>
            public FSTOCKID FSTOCKID { get; set; }
            /// <summary>
            /// 货主类型
            /// </summary>
            public string FOWNERTYPEID { get; set; }
            /// <summary>
            /// 货主
            /// </summary>
            public FOWNERID FOWNERID { get; set; }
            /// <summary>
            /// 保管者类型
            /// </summary>
            public string FKEEPERTYPEID { get; set; }
            /// <summary>
            /// 保管者
            /// </summary>
            public FKEEPERID FKEEPERID { get; set; }
        }

        public class FMATERIALID
        {
            public string FNumber { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
        }

        public class FSTOCKSTATUSID
        {
            public string FNumber { get; set; }
        }

        public class FSTOCKID
        {
            public string FNumber { get; set; }
        }
        public class FOWNERID
        {
            public string FNumber { get; set; }
        }

        public class FKEEPERID
        {
            public string FNumber { get; set; }
        }
    }


}
