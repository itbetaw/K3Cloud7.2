using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 采购入库单保存信息实体
    /// </summary>
    public class STK_InStockSave
    {
        public string FID { get; set; }
        public Fbilltypeid FBillTypeID { get; set; }
        public string FBillNo { get; set; }
        public string FDate { get; set; }
        /// <summary>
        /// 收料组织
        /// </summary>
        public Fstockorgid FStockOrgId { get; set; }
        public Fstockerid FStockerId { get; set; }
        /// <summary>
        /// 采购组织
        /// </summary>
        public Fpurchaseorgid FPurchaseOrgId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public Fsupplierid FSupplierId { get; set; }
        /// <summary>
        /// 货主类型
        /// </summary>
        public string FOwnerTypeIdHead { get; set; }
        /// <summary>
        /// 货主
        /// </summary>
        public Fowneridhead FOwnerIdHead { get; set; }
        public Finstockfin FInStockFin { get; set; }
        public Finstockentry[] FInStockEntry { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }

        public class Fstockerid
        {
            public string FNumber { get; set; }
        }

        public class Fpurchaseorgid
        {
            public string FNumber { get; set; }
        }

        public class Fsupplierid
        {
            public string FNumber { get; set; }
        }

        public class Fowneridhead
        {
            public string FNumber { get; set; }
        }

        public class Finstockfin
        {
            public string FEntryId { get; set; }
            /// <summary>
            /// 结算组织
            /// </summary>
            public Fsettleorgid FSettleOrgId { get; set; }
            /// <summary>
            /// 结算币别
            /// </summary>
            public Fsettlecurrid FSettleCurrId { get; set; }
            /// <summary>
            /// 定价时点
            /// </summary>
            public string FPriceTimePoint { get; set; }
        }

        public class Fsettleorgid
        {
            public string FNumber { get; set; }
        }

        public class Fsettlecurrid
        {
            public string FNumber { get; set; }
        }

        public class Finstockentry
        {
            public string FEntryID { get; set; }
            /// <summary>
            /// 物料编码
            /// </summary>
            public Fmaterialid FMaterialId { get; set; }
            /// <summary>
            /// 库存单位
            /// </summary>
            public Funitid FUnitID { get; set; }
            /// <summary>
            /// 实收数量
            /// </summary>
            public string FRealQty { get; set; }
            /// <summary>
            /// 计价单位
            /// </summary>
            public Fpriceunitid FPriceUnitID { get; set; }
            /// <summary>
            /// 仓库
            /// </summary>
            public Fstockid FStockId { get; set; }
            public string FTaxPrice { get; set; }
            public Fremaininstockunitid FRemainInStockUnitId { get; set; }
            /// <summary>
            /// 采购数量
            /// </summary>
            public string FRemainInStockQty { get; set; }
        }

        public class Fmaterialid
        {
            public string FNumber { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
        }

        public class Fpriceunitid
        {
            public string FNumber { get; set; }
        }


        public class Fstockid
        {
            public string FNumber { get; set; }
        }

        public class Fremaininstockunitid
        {
            public string FNumber { get; set; }
        }

    }

}
