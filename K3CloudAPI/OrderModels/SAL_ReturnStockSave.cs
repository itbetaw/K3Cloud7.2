using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 销售退货单保存信息实体
    /// </summary>
    public class SAL_ReturnStockSave
    {
        public string FID { get; set; }
        /// <summary>
        /// 单据类型:FBillTypeID  (必填项)
        /// </summary>
        public Fbilltypeid FBillTypeID { get; set; }
        public string FBillNo { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string FDate { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        public Fsaleorgid FSaleOrgId { get; set; }
        /// <summary>
        /// 退货客户
        /// </summary>
        public Fretcustid FRetcustId { get; set; }
        /// <summary>
        /// 库存组织
        /// </summary>
        public Fstockorgid FStockOrgId { get; set; }
        public Subheadentity SubHeadEntity { get; set; }
        public Fentity[] FEntity { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }
        public class Fretcustid
        {
            public string FNumber { get; set; }

        }
        public class Fsaleorgid
        {
            public string FNumber { get; set; }
        }
        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }

        public class Subheadentity
        {
            public string FEntryId { get; set; }
            /// <summary>
            /// 结算币别
            /// </summary>
            public Fsettlecurrid FSettleCurrId { get; set; }
            /// <summary>
            /// 结算组织
            /// </summary>
            public Fsettleorgid FSettleOrgId { get; set; }
            public string FExchangeRate { get; set; }
        }

        public class Fsettlecurrid
        {
            public string FNumber { get; set; }
        }

        public class Fsettleorgid
        {
            public string FNumber { get; set; }
        }

        public class Fentity
        {
            /// <summary>
            /// 物料编码
            /// </summary>
            public Fmaterialid FMaterialId { get; set; }
            /// <summary>
            /// 库存单位
            /// </summary>
            public Funitid FUnitID { get; set; }
            /// <summary>
            /// 实退数量
            /// </summary>
            public string FRealQty { get; set; }
      
            /// <summary>
            /// 退货类型
            /// </summary>
            public Freturntype FReturnType { get; set; }
         
            /// <summary>
            /// 货主
            /// </summary>
            public Fownerid FOwnerId { get; set; }
    
            /// <summary>
            /// 仓库
            /// </summary>
            public Fstockid FStockId { get; set; }       
            /// <summary>
            /// 退货日期
            /// </summary>
            public string FDeliveryDate { get; set; }
        }

        public class Freturntype
        {
            public string FNumber { get; set; }
        }
        public class Fmaterialid
        {
            public string FNumber { get; set; }
        }


        public class Funitid
        {
            public string FNumber { get; set; }
        }

        public class Fownerid
        {
            public string FNumber { get; set; }
        }

        public class Fstockid
        {
            public string FNumber { get; set; }
        }


    }
}
