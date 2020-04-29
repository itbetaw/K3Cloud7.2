using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 调拨申请单保存信息实体
    /// </summary>
    public class STK_TransferApplySave
    {
        public string FID { get; set; }
        public Fbilltypeid FBillTypeID { get; set; }
        public string FBillNo { get; set; }
        public string FDate { get; set; }
        /// <summary>
        /// 申请组织
        /// </summary>
        public FAPPORGID FAppOrgID { get; set; }
        /// <summary>
        /// 调拨类型
        /// </summary>
        public string FTRANSTYPE { get; set; }
        /// <summary>
        /// 调入货主类型
        /// </summary>
        public string FOwnerTypeIdHead { get; set; }
        /// <summary>
        /// 调出货主类型
        /// </summary>
        public string FOwnerTypeInIdHead { get; set; }
        public Fentity[] FEntity { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class FAPPORGID
        {
            public string FNumber { get; set; }
        }

        public class Fentity
        {
            public string FEntryID { get; set; }
            public FMATERIALID FMATERIALID { get; set; }
            public FUNITID FUNITID { get; set; }
            public string FQty { get; set; }
            /// <summary>
            /// 调出组织
            /// </summary>
            public Fstockorgid FStockOrgId { get; set; }
            /// <summary>
            /// 调入组织
            /// </summary>
            public Fstockorginid FStockOrgInId { get; set; }
            /// <summary>
            /// 调出货主类型
            /// </summary>
            public string FOwnerTypeId { get; set; }
            /// <summary>
            /// 调入货主类型
            /// </summary>
            public string FOwnerTypeInId { get; set; }
            /// <summary>
            /// 基本单位
            /// </summary>
            public Fbaseunitid FBaseUnitID { get; set; }

        }

        public class FMATERIALID
        {
            public string FNumber { get; set; }
        }
        public class FUNITID
        {
            public string FNumber { get; set; }
        }

        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }
        public class Fstockorginid
        {
            public string FNumber { get; set; }
        }

        public class Fbaseunitid
        {
            public string FNumber { get; set; }
        }
    }

}
