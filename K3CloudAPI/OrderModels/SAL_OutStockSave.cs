using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 销售出库单 保存实体
    /// </summary>
    public class Sal_OutStockSaveEntity
    {
        public string FID { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        public Fbilltypeid FBillTypeID { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
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
        /// 客户
        /// </summary>
        public Fcustomerid FCustomerID { get; set; }
        /// <summary>
        /// 销售部门
        /// </summary>
        public Fsaledeptid FSaleDeptID { get; set; }
        /// <summary>
        /// 交货地点
        /// </summary>
        public Fheadlocationid FHeadLocationId { get; set; }
        /// <summary>
        /// 对应组织
        /// </summary>
        public Fcorrespondorgid FCorrespondOrgId { get; set; }
        /// <summary>
        /// 承运商
        /// </summary>
        public Fcarrierid FCarrierID { get; set; }
        /// <summary>
        /// 运输单号
        /// </summary>
        public string FCarriageNO { get; set; }
        /// <summary>
        /// 销售组
        /// </summary>
        public Fsalesgroupid FSalesGroupID { get; set; }
        /// <summary>
        /// 销售员
        /// </summary>
        public Fsalesmanid FSalesManID { get; set; }
        /// <summary>
        /// 发货组织
        /// </summary>
        public Fstockorgid FStockOrgId { get; set; }
        /// <summary>
        /// 发货部门
        /// </summary>
        public Fdeliverydeptid FDeliveryDeptID { get; set; }
        /// <summary>
        /// 库存组
        /// </summary>
        public Fstockergroupid FStockerGroupID { get; set; }
        /// <summary>
        /// 仓管员
        /// </summary>
        public Fstockerid FStockerID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string FNote { get; set; }
        /// <summary>
        /// 收货方
        /// </summary>
        public Freceiverid FReceiverID { get; set; }
        /// <summary>
        /// 收货方地址
        /// </summary>
        public string FReceiveAddress { get; set; }
        /// <summary>
        /// 收货方联系人
        /// </summary>
        public Freceivercontactid FReceiverContactID { get; set; }
        /// <summary>
        /// 结算方
        /// </summary>
        public Fsettleid FSettleID { get; set; }
        /// <summary>
        /// 付款方
        /// </summary>
        public Fpayerid FPayerID { get; set; }
        /// <summary>
        /// 货主类型
        /// </summary>
        public string FOwnerTypeIdHead { get; set; }
        /// <summary>
        /// 货主
        /// </summary>
        public Fowneridhead FOwnerIdHead { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        public Subheadentity SubHeadEntity { get; set; }
        public Fentity[] FEntity { get; set; }
        public Foutstocktrace[] FOutStockTrace { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }
        /// <summary>
        /// 销售组织
        /// </summary>
        public class Fsaleorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 客户
        /// </summary>
        public class Fcustomerid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        ///销售部门
        /// </summary>
        public class Fsaledeptid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 交货地点
        /// </summary>
        public class Fheadlocationid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 对应组织
        /// </summary>
        public class Fcorrespondorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 承运商
        /// </summary>
        public class Fcarrierid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 销售组
        /// </summary>
        public class Fsalesgroupid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 销售员
        /// </summary>

        public class Fsalesmanid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 发货组织
        /// </summary>
        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 发货部门
        /// </summary>
        public class Fdeliverydeptid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 库存组
        /// </summary>
        public class Fstockergroupid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 仓管员
        /// </summary>
        public class Fstockerid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 收货方
        /// </summary>
        public class Freceiverid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 结算方式
        /// </summary>
        public class Fsettleid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 收货方联系方式
        /// </summary>
        public class Freceivercontactid
        {
            public string FNAME { get; set; }
        }
        /// <summary>
        /// 付款方
        /// </summary>
        public class Fpayerid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 货主
        /// </summary>
        public class Fowneridhead
        {
            public string FNumber { get; set; }
        }

        /// <summary>
        ///财务信息
        /// </summary>
        public class Subheadentity
        {
            public string FEntryId { get; set; }
            /// <summary>
            /// 结算币别
            /// </summary>
            public Fsettlecurrid FSettleCurrID { get; set; }
            /// <summary>
            /// 结算组织
            /// </summary>
            public Fsettleorgid FSettleOrgID { get; set; }
            /// <summary>
            /// 结算方法
            /// </summary>
            public Fsettletypeid FSettleTypeID { get; set; }
            /// <summary>
            /// 收款条件
            /// </summary>
            public Freceiptconditionid FReceiptConditionID { get; set; }
            /// <summary>
            /// 是否含税
            /// </summary>
            public string FIsIncludedTax { get; set; }
            /// <summary>
            /// 本位币
            /// </summary>
            public Flocalcurrid FLocalCurrID { get; set; }
            /// <summary>
            /// 汇率
            /// </summary>
            public string FExchangeRate { get; set; }
        }
        /// <summary>
        /// 结算币别
        /// </summary>
        public class Fsettlecurrid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 结算组织
        /// </summary>
        public class Fsettleorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 结算类别
        /// </summary>
        public class Fsettletypeid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 收款条件
        /// </summary>
        public class Freceiptconditionid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 本位币
        /// </summary>
        public class Flocalcurrid
        {
            public string FNumber { get; set; }
        }
        public class Fentity
        {
            public string FENTRYID { get; set; }
            /// <summary>
            /// 物料编码
            /// </summary>
            public Fmaterialid FMaterialID { get; set; }
            /// <summary>
            /// 单位
            /// </summary>
            public Funitid FUnitID { get; set; }
            /// <summary>
            /// 当前库存
            /// </summary>
            public string FInventoryQty { get; set; }
            /// <summary>
            /// 实发数量
            /// </summary>
            public string FRealQty { get; set; }
            /// <summary>
            /// 价格
            /// </summary>
            public string FPrice { get; set; }
            /// <summary>
            /// 含税单价
            /// </summary>
            public string FTaxPrice { get; set; }
            /// <summary>
            /// 免费
            /// </summary>
            public string FIsFree { get; set; }
            /// <summary>
            /// 生产日期
            /// </summary>
            public string FProduceDate { get; set; }
            /// <summary>
            /// 货主类型
            /// </summary>
            public string FOwnerTypeID { get; set; }
            /// <summary>
            /// 货主
            /// </summary>
            public Fownerid FOwnerID { get; set; }
            /// <summary>
            /// 批号
            /// </summary>
            public Flot FLot { get; set; }
            /// <summary>
            /// 有效期至
            /// </summary>
            public string FExpiryDate { get; set; }
            /// <summary>
            /// 税率
            /// </summary>
            public string FEntryTaxRate { get; set; }
            /// <summary>
            /// 数量 辅单位
            /// </summary>
            public string FExtAuxUnitQty { get; set; }
            /// <summary>
            /// 仓库
            /// </summary>
            public Fstockid FStockID { get; set; }
            /// <summary>
            /// 仓位
            /// </summary>
            public Fstocklocid FStockLocID { get; set; }
            /// <summary>
            /// 库存状态
            /// </summary>
            public Fstockstatusid FStockStatusID { get; set; }
            /// <summary>
            /// 质量类型
            /// </summary>
            public string FQualifyType { get; set; }
            /// <summary>
            /// 计划跟踪号
            /// </summary>
            public string FMtoNo { get; set; }
            /// <summary>
            /// 备注
            /// </summary>
            public string FEntrynote { get; set; }
            /// <summary>
            /// 折扣率
            /// </summary>
            public string FDiscountRate { get; set; }
            /// <summary>
            /// 实收数量
            /// </summary>
            public string FActQty { get; set; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public class Fmaterialid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public class Funitid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 货主
        /// </summary>
        public class Fownerid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public class Flot
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 仓库
        /// </summary>
        public class Fstockid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 仓位
        /// </summary>
        public class Fstocklocid
        {
            public FSTOCKLOCID__FF100002 FSTOCKLOCID__FF100002 { get; set; }
            public FSTOCKLOCID__FF100003 FSTOCKLOCID__FF100003 { get; set; }
            public FSTOCKLOCID__FF100004 FSTOCKLOCID__FF100004 { get; set; }
            public FSTOCKLOCID__FF100005 FSTOCKLOCID__FF100005 { get; set; }
        }

        public class FSTOCKLOCID__FF100002
        {
            public string FNumber { get; set; }
        }

        public class FSTOCKLOCID__FF100003
        {
            public string FNumber { get; set; }
        }

        public class FSTOCKLOCID__FF100004
        {
            public string FNumber { get; set; }
        }

        public class FSTOCKLOCID__FF100005
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 库存状态
        /// </summary>
        public class Fstockstatusid
        {
            public string FNumber { get; set; }
        }

        public class Foutstocktrace
        {
            /// <summary>
            /// 物流单号
            /// </summary>
            public string FCarryBillNo { get; set; }
        }
    }
}

