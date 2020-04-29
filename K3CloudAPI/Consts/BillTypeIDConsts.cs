using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Consts
{
    /// <summary>
    /// 单据类型编码
    /// </summary>
    public class BillTypeIDConsts
    {
        #region 采购管理

        /// <summary>
        /// 标准采购申请单
        /// </summary>
        public const string 采购申请单 = "CGSQD01_SYS";
        /// <summary>
        /// 标准采购入库
        /// </summary>
        public const string 采购入库单 = "RKD01_SYS";
        /// <summary>
        /// 标准采购合同
        /// </summary>
        public const string 采购合同 = "CGHT01_SYS";
        /// <summary>
        /// 期初采购退料单
        /// </summary>
        public const string 期初采购退料单 = "QCTLD01_SYS";
        /// <summary>
        /// 期初委外退料单
        /// </summary>
        public const string 期初委外退料单 = "QCTLD02_SYS";
        /// <summary>
        /// 标准退料申请
        /// </summary>
        public const string 退料申请单 = "TLSQDD01_SYS";
        /// <summary>
        /// 标准退料单
        /// </summary>
        public const string 采购退料单 = "TLD01_SYS";
        /// <summary>
        /// 标准采购订单变更单
        /// </summary>
        public const string 采购订单变更单 = "CGDDBGD01_SYS";
        /// <summary>
        /// VMI物权转移
        /// </summary>
        public const string 物权转移单 = "WQZY001_SYS";

        #endregion

        #region 销售管理
        
        /// <summary>
        /// 标准发货通知单
        /// </summary>
        public const string 发货通知单 = "FHTZD01_SYS";
        /// <summary>
        /// 寄售结算单
        /// </summary>
        public const string 寄售结算单 = "JSJSD01_SYS";
        /// <summary>
        ///标准模拟报价单
        /// </summary>
        public const string 模拟报价单 = "MNBJD01_SYS";
        /// <summary>
        /// 期初销售出库单
        /// </summary>
        public const string 期初销售出库单 = "QCXSCKD_SYS";
        /// <summary>
        /// 期初销售退货单
        /// </summary>
        public const string 期初销售退货单 = "QCXSTHD_SYS";
        /// <summary>
        /// 标准退货通知单
        /// </summary>
        public const string 退货通知单 = "THTZD01_SYS";
        /// <summary>
        /// 标准销售报价单
        /// </summary>
        public const string 销售报价单 = "XSBJD01_SYS";
        /// <summary>
        /// 标准销售出库单
        /// </summary>
        public const string 标准销售出库单 = "XSCKD01_SYS";
        /// <summary>
        /// 标准销售订单
        /// </summary>
        public const string 标准销售订单 = "XSDD01_SYS";
        /// <summary>
        /// 标准销售订单变更单
        /// </summary>
        public const string 标准销售订单变更单 = "XSDDBGD01_SYS";
        /// <summary>
        /// 标准销售退货单
        /// </summary>
        public const string 标准销售退货单 = "XSTHD01_SYS";
        #endregion

        #region 库存管理

        public const string 标准出库申请 = "CKSQ01_SYS";
        public const string VMI出库申请 = "CKSQ02_SYS";
        public const string 资产出库申请 = "CKSQ03_SYS";
        public const string 费用物料出库申请 = "CKSQ04_SYS ";
        public const string 标准初始库存单 = "CSKC01_SYS ";
        public const string 标准调拨申请单 = "DBSQD01_SYS";
        public const string VMI调拨申请单 = "DBSQD02_SYS";
        public const string 标准分步式调出单 = "FBDC01_SYS ";
        public const string VMI分步式调出单 = "FBDC02_SYS ";
        public const string 标准分步式调入单 = "FBDR01_SYS ";
        public const string VMI分步式调入单 = "FBDR02_SYS ";
        public const string 简单生产领料 = "JDSCLL01_SYS";
        public const string VMI简单生产领料 = " JDSCLL02_SYS";
        public const string 简单生产入库 = " JDSCRK01_SYS";
        public const string 简单生产退库 = "JDSCTK01_SYS";
        public const string 简单生产退料 = " JDSCTL01_SYS";
        public const string VMI简单生产退料 = "JDSCTL02_SYS";
        public const string 标准库存状态转换 = " KCZTZH01_SYS";
        public const string 标准盘点方案 = " PDFA01_SYS ";
        public const string 标准批号调整单 = " PHTZ01_SYS";
        public const string 标准盘亏单 = " PK01_SYS";
        public const string VMI盘亏单 = "PK02_SYS ";
        public const string 标准盘盈单 = " PY01_SYS ";
        public const string 标准其他出库单 = "QTCKD01_SYS ";
        public const string 资产出库 = " QTCKD02_SYS ";
        public const string VMI出库 = "QTCKD03_SYS ";
        public const string 费用物料出库 = " QTCKD04_SYS ";
        public const string 库存调整 = "QTCKD05_SYS ";
        public const string 标准其他入库单 = " QTRKD01_SYS ";
        public const string 受托加工材料入库单 = " STCLRK01_SYS";
        public const string 标准受托加工材料收料单 = " STCLSL01_SYS";
        public const string 标准受托加工材料退料单 = " STCLTL01_SYS";
        public const string 标准物料盘点作业 = "WLPDZY01_SYS ";
        public const string 标准周期盘点表 = " WLZQPD01_SYS ";
        public const string 标准形态转换 = " XTZH01_SYS ";
        public const string 标准直接调拨单 = "ZJDB01_SYS ";
        public const string 寄售直接调拨单 = "ZJDB02_SYS ";
        public const string 委外直接调拨单 = "ZJDB03_SYS ";
        public const string 分销直接调拨单 = " ZJDB04_SYS ";
        public const string VMI直接调拨单 = " ZJDB05_SYS ";
        public const string 标准周期盘点计划单 = "ZQPDJH01_SYS ";
        public const string 标准组装拆卸 = "ZZCX01_SYS";

        #endregion


    }
}
