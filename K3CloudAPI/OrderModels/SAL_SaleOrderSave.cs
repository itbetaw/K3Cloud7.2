using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{

    /// <summary>
    /// 销售订单保存信息实体
    /// </summary>
    public class Sal_SaveOrderSaveEntity
    {
        /// <summary>
        /// 单据主键
        /// </summary>
        public string FID { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        public Fbilltypeid FBillTypeID { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        ///日期
        /// </summary>
        public string FDate { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        public Fsaleorgid FSaleOrgId { get; set; }
        /// <summary>
        /// 客户
        /// </summary>
        public Fcustid FCustId { get; set; }
        /// <summary>
        /// 交货方式
        /// </summary>
        public Fheaddeliveryway FHeadDeliveryWay { get; set; }
        /// <summary>
        /// 收货方
        /// </summary>
        public Freceiveid FReceiveId { get; set; }
        /// <summary>
        /// 交货地点
        /// </summary>
        public FHEADLOCID fheadlocid { get; set; }
        /// <summary>
        /// 对应组织
        /// </summary>
        public Fcorrespondorgid FCorrespondOrgId { get; set; }
        /// <summary>
        /// 销售部门
        /// </summary>
        public Fsaledeptid FSaleDeptId { get; set; }
        /// <summary>
        /// 销售组
        /// </summary>
        public Fsalegroupid FSaleGroupId { get; set; }
        /// <summary>
        /// 销售员
        /// </summary>
        public Fsalerid FSalerId { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string FReceiveAddress { get; set; }
        /// <summary>
        /// 结算方式
        /// </summary>
        public Fsettleid FSettleId { get; set; }
        /// <summary>
        /// 收货方联系人
        /// </summary>
        public Freceivecontact FReceiveContact { get; set; }
        /// <summary>
        /// 付款方
        /// </summary>
        public Fchargeid FChargeId { get; set; }
        /// <summary>
        /// 商联网上订单编号
        /// </summary>
        public string FNetOrderBillNo { get; set; }
        /// <summary>
        /// 商联订单 ID
        /// </summary>
        public string FNetOrderBillId { get; set; }
        public string FOppID { get; set; }
        /// <summary>
        /// 是否期初订单
        /// </summary>
        public string FISINIT { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string FNote { get; set; }
        public string FIsMobile { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        public Fsaleorderfinance FSaleOrderFinance { get; set; }
        /// <summary>
        /// 订单明细
        /// </summary>
        public Fsaleorderentry[] FSaleOrderEntry { get; set; }
        /// <summary>
        /// 收款计划
        /// </summary
        public Fsalordertrace[] FSalOrderTrace { get; set; }
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
        public class Fcustid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 交货方式
        /// </summary>

        public class Fheaddeliveryway
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 交货地点
        /// </summary>
        public class FHEADLOCID
        {
            public string FNumber { get; set; }
        }

        /// <summary>
        /// 收货方
        /// </summary>
        public class Freceiveid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 收货方联系人
        /// </summary>
        public class Freceivecontact
        {
            public string FNAME { get; set; }
        }
        /// <summary>
        /// 对应组织
        /// </summary>
        public class Fcorrespondorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 销售部门
        /// </summary>
        public class Fsaledeptid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 销售组
        /// </summary>
        public class Fsalegroupid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 销售员
        /// </summary>
        public class Fsalerid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 结算方
        /// </summary>
        public class Fsettleid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 付款方
        /// </summary>
        public class Fchargeid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 财务信息
        /// </summary>
        public class Fsaleorderfinance
        {
            public string FEntryId { get; set; }
            public Fsettlecurrid FSettleCurrId { get; set; }
            public string FIsIncludedTax { get; set; }
            public string FMarginLevel { get; set; }
            public string FMargin { get; set; }
            public string FExchangeRate { get; set; }
        }
        /// <summary>
        /// 结算币别
        /// </summary>
        public class Fsettlecurrid
        {
            public string FNumber { get; set; }
        }

        public class Fsaleorderentry
        {
            public string FEntryID { get; set; }
            public string FReturnType { get; set; }
            public string FRowType { get; set; }
            public Fmaterialid FMaterialId { get; set; }
            public Funitid FUnitID { get; set; }
            public string FInventoryQty { get; set; }
            public string FCurrentInventory { get; set; }
            public string FAwaitQty { get; set; }
            public string FAvailableQty { get; set; }
            public string FQty { get; set; }
            public string FOldQty { get; set; }
            public string FPrice { get; set; }
            public string FTaxPrice { get; set; }
            public string FIsFree { get; set; }
            public string FEntryTaxRate { get; set; }
            public string FProduceDate { get; set; }
            public string FExpPeriod { get; set; }
            public string FExpUnit { get; set; }
            public string FExpiryDate { get; set; }
            public Flot FLot { get; set; }
            public string FPriceDiscount { get; set; }
            public string FInStockPrice { get; set; }
            public string FDiscountRate { get; set; }
            public string FDeliveryDate { get; set; }
            public Fstockorgid FStockOrgId { get; set; }
            public Fsettleorgids FSettleOrgIds { get; set; }
            public Fsupplyorgid FSupplyOrgId { get; set; }
            public string FOwnerTypeId { get; set; }
            public Fownerid FOwnerId { get; set; }
            public string FEntryNote { get; set; }
            public string FReserveType { get; set; }
            public Fstockunitid FStockUnitID { get; set; }
            public string FStockQty { get; set; }
            public string FStockBaseQty { get; set; }
            /// <summary>
            /// 超发控制单位
            /// </summary>
            public string FOutLmtUnitID { get; set; }
        }

        /// <summary>
        /// 物料编号
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
        /// 批号
        /// </summary>
        public class Flot
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 库存组织
        /// </summary>
        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 结算组织
        /// </summary>
        public class Fsettleorgids
        {
            public string FNumber { get; set; }
        }
        /// <summary>
        /// 供应组织
        /// </summary>
        public class Fsupplyorgid
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



        public class Fstockunitid
        {
            public string FNumber { get; set; }
        }




        public class Fsalordertrace
        {
            public string FCarryBillNo { get; set; }
            public string FDelTime { get; set; }

        }
    }
}
