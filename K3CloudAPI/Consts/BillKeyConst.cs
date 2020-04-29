using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Consts
{
    public class BillKeyConst
    {
        #region 财务会计 总账 

        public const string 科目 = "BD_Account";

        public const string 帐薄 = "BD_AccountBook";

        public const string 会计日历 = "BD_ACCOUNTCALENDAR";

        public const string 会计要素 = "BD_AccountGroup";

        public const string 币别 = "BD_Currency";

        public const string 费用项目 = "BD_Expense";

        public const string 汇率 = "BD_Rate";

        public const string 结算方式 = "BD_SETTLETYPE";

        public const string 凭证字 = "BD_VOUCHERGROUP";

        public const string 调整期间管理 = "GL_ADJUSTPERIOD";

        public const string 自动转账 = "GL_AutoTransfer";

        public const string 现金流量项目 = "GL_CashFlow";

        public const string 附表项目指定 = "GL_CashIndirectItem";

        public const string 智能转存 = "GL_DepositScheme";

        public const string 期末调汇 = "GL_ExchangeScheme";

        public const string 摘要库 = "GL_Explanation";

        public const string 附表项目调整 = "GL_INDIRECTITEMADJUST";

        public const string 帐薄隶属关系 = "GL_MultiBookMergeScheme";

        public const string 结转损益 = "GL_PLScheme";

        public const string T型账 = "GL_TACCOUNT";

        public const string 凭证 = "GL_VOUCHER";

        public const string 凭证摊销 = "GL_VoucherAmortize";

        public const string 模式凭证 = "GL_VoucherModel";

        public const string 凭证预提 = "GL_VoucherProvision";

        public const string 会计核算体系 = "Org_AccountSystem";

        #endregion

        #region 财务会计 智能会计平台

        public const string 业务凭证 = "BAS_BusinessVoucher";

        public const string 凭证生成 = "Bas_MakeBizVchWizard";

        public const string 分录类型 = "BAS_VchEntryType";

        public const string 凭证模板 = "BAS_VchTemplate";

        public const string 增值税发票单据 = "GL_AddedTaxBill";

        public const string 增值税发票识别 = "GL_AddedTaxOcrResult";

        public const string 凭证自动生成方案 = "GL_AutoBuildVoucherScheme";

        public const string 扫描识别模板管理 = "GL_BillOcrTemplate";

        public const string 对账方案 = "GL_CHECKSCHEME";

        public const string 自定义单据识别 = "GL_OcrResultBase";

        public const string 扫描仪注册登记 = "GL_ScannerSign";

        public const string 银行回单_付款 = "GL_YHHDFK";

        public const string 银行回单_收款 = "GL_YHHDSK";

        #endregion

        #region 供应链 采购单据

        public const string SCM_警示灯方案 = "SCM_WarnScheme";

        public const string BD_采购条款 = "BD_PURCLAUSE";

        public const string BD_采购折扣表 = "BD_PurDiscount";

        public const string PUR_评估等级 = "PUR_Assessment";

        public const string PUR_采购评估指标 = "PUR_AssessmentIndex";

        public const string PUR_采购评估方案 = "PUR_AssessmentPlans";

        public const string PUR_货源清单 = "PUR_CATALOG";

        public const string PUR_采购合同 = "PUR_Contract";

        public const string PUR_采购合同变更单 = "PUR_ContractChange";

        public const string PUR_期初采购退料单 = "PUR_InitMRS";

        public const string PUR_退料申请单 = "PUR_MRAPP";

        public const string PUR_采购退料单 = "PUR_MRB";

        public const string PUR_采购调价表 = "PUR_PAT";

        public const string PUR_采购定价变更单 = "PUR_POChange";

        public const string PUR_采购定价新变更单 = "PUR_POXChange";

        public const string PUR_采购价目表 = "PUR_PriceCategory";

        public const string PUR_物权转移单 = "PUR_PropertyConvert";

        public const string PUR_采购订单 = "PUR_PurchaseOrder";

        public const string PUR_收料通知单 = "PUR_ReceiveBill";

        public const string PUR_采购申请单 = "PUR_Requisition";

        public const string PUR_供应商评分表 = "PUR_SupplierAsseementTb";

        public const string PUR_消耗汇总表 = "PUR_VMIConsumeSum";

        public const string STK_期初采购入库单 = "STK_InitInStock";

        public const string STK_采购入库单 = "STK_InStock";

        #endregion

        #region 供应链 销售管理

        public const string BD_云之家考勤设置 = "BD_AttendanceSetting";

        public const string BD_轻应用自定义字段设置 = "BD_MobExtendFieldConfig";

        public const string BD_销售折扣表 = "BD_SAL_DiscountList";

        public const string BD_销售价目表 = "BD_SAL_PriceList";

        public const string BD_销售条款 = "BD_SALCLAUSE";

        public const string SAL_销售调价方案 = "SAL_ADJUSTPRICE";

        public const string SAL_可发量查询 = "SAL_AvailableQuery";

        public const string SAL_批量调价单 = "SAL_BATCHADJUSTPRICE";

        public const string SAL_寄售结算单 = "SAL_ConsignmentSettle";

        public const string SAL_客户物料对应表 = "SAL_CustMatMapping";

        public const string SAL_发货通知单 = "SAL_DELIVERYNOTICE";

        public const string SAL_期初销售出库单 = "SAL_INITOUTSTOCK";

        public const string SAL_电子面单 = "SAL_KuaidiBill";

        public const string SAL_销售物流信息 = "SAL_LogisticsInfo";

        public const string SAL_销售出库单 = "SAL_OUTSTOCK";

        public const string SAL_销售报价单 = "SAL_QUOTATION";

        public const string SAL_退货通知单 = "SAL_RETURNNOTICE";

        public const string SAL_销售退货单 = "SAL_RETURNSTOCK";

        public const string SAL_销售订单 = "SAL_SaleOrder";

        public const string SAL_销售订单变更单 = "SAL_SaleOrderChange";

        public const string SAL_模拟报价单 = "Sal_SimulateQuotation";

        public const string SAL_标准费率维护 = "Sal_StdExchangeRate";

        public const string SAL_销售订单新变更单 = "SAL_XORDER";

        public const string SAL_销售报价变更单 = "SAL_XQUOTATION";

        #endregion

        #region 供应链 信用管理

        public const string CRE_信用检查规则 = "CRE_CheckRule";

        public const string CRE_信用表更 = "CRE_CreditChange";

        public const string CRE_信用总额特批 = "CRE_CreditSumPermit";

        public const string CRE_信用档案 = "CRE_CustArchives";

        public const string CRE_客户物料信用档案 = "CRE_CustMaterialArchive";

        public const string CRE_信用评估模型 = "CRE_EvalModel";

        public const string CRE_信用评估指标 = "CRE_EvaluateIndex";

        public const string CRE_信用等级方案 = "CRE_Gade";

        public const string CRE_信用评分表 = "CRE_ScoringTable";

        public const string CRE_信用特批权限 = "CRE_SpecPermission";

        public const string CRE_临时信用档案 = "CRE_TmpCustArchives";


        #endregion

        #region 供应链 库存管理

        public const string BD_归档序列号 = "BD_ArchivedSerial";

        public const string BD_批号主档 = "BD_BatchMainFile";

        public const string BD_批号_序列号属性 = "BD_LotCodeItem";

        public const string BD_批号_序列号编码规则 = "BD_LotCodeRule";

        public const string BD_生产追溯序列号主档 = "BD_MTSerialMainFile";

        public const string BD_序列号主档 = "BD_SerialMainFile";

        public const string BD_仓库 = "BD_STOCK";

        public const string BD_仓库最大最小安全库存 = "BD_StockAlert";

        public const string BD_库存状态 = "BD_StockStatus";

        public const string SP_简单生成入库单 = "SP_InStock";

        public const string SP_简单生成退库单 = "SP_OUTSTOCK";

        public const string SP_简单生成领料单 = "SP_PickMtrl";

        public const string SP_简单生成退料单 = "SP_ReturnMtrl";

        public const string STK_组装拆卸单 = "STK_AssembledApp";

        public const string STK_周期盘点计划 = "STK_CycleCountPlan";

        public const string BD_物料周期盘点表 = "STK_CycleCountTable";

        public const string STK_即时库存 = "STK_Inventory";

        public const string STK_初始库存 = "STK_InvInit";

        public const string STK_库存锁库 = "STK_LockStock";

        public const string STK_锁库日志 = "STK_LOCKSTOCKLOG";

        public const string STK_批号调整单 = "STK_LOTADJUST";

        public const string STK_ABC分配组 = "STK_MaterialABCGroup";

        public const string STK_其他入库单 = "STK_MISCELLANEOUS";

        public const string STK_其他出库单 = "STK_MisDelivery";

        public const string STK_委托加工材料入库单 = "STK_OEMInStock";

        public const string STK_委托加工材料退料单 = "STK_OEMInStockRETURN";

        public const string STK_委托加工材料收料单 = "STK_OEMReceive";

        public const string STK_出库申请单 = "STK_OutStockApply";

        public const string STK_形态转换单 = "STK_StatusConvert";

        public const string STK_库存状态转换 = "STK_StockConvert";

        public const string STK_盘盈单 = "STK_StockCountGain";

        public const string STK_物料盘点作业 = "STK_StockCountInput";

        public const string STK_盘亏单 = "STK_StockCountLoss";

        public const string STK_盘点方案 = "STK_StockCountScheme";

        public const string STK_调拨申请单 = "STK_TRANSFERAPPLY";

        public const string STK_直接调拨单 = "STK_TransferDirect";

        public const string STK_分布式调入单 = "STK_TRANSFERIN";

        public const string STK_分布式调出单 = "STK_TRANSFEROUT";

        #endregion

        #region 供应链  组织间结算

        public const string IOS_应付结算清单_物料 = "IOS_APSettlement";

        public const string IOS_应付结算清单_费用 = "IOS_APSettlementExp";

        public const string IOS_应付结算清单_资产 = "IOS_APSettlementFA";

        public const string IOS_应收结算清单_物料 = "IOS_ARSettlement";

        public const string IOS_应收结算清单_费员 = "IOS_ARSettlementExp";

        public const string IOS_应收结算清单_资产 = "IOS_ARSettlementFA";

        public const string IOS_组织间结算价目表 = "IOS_PriceList";

        public const string IOS_定时结算 = "IOS_ScheduleSettle";

        public const string IOS_组织间结算关系 = "IOS_SettleRelation";

        public const string IOS_跨组织业务类型 = "IOS_TransferBizType";

        #endregion

        #region 供应链 条码管理

        public const string BD_异步生成数据 = "BD_AsyncBillScanData";

        public const string BD_条码盘点清单 = "BD_BarcodeInventoryData";

        public const string BD_条码属性 = "BD_BarCodeItem";

        public const string BD_条码主档 = "BD_BarCodeMainFile";

        public const string BD_条码打印 = "BD_BarCodePrint";

        public const string BD_条码规则 = "BD_BarCodeRule";

        public const string BD_条码扫描 = "BD_BarCodeScan";

        public const string BD_条码拆分 = "UN_BarCodeSplit";

        public const string BD_物料编码解析对应表 = "UN_MaterialMap";

        public const string BD_条码拆箱表 = "UN_Packaging";

        public const string BD_扫描配置 = "UN_SCAN";

        public const string BD_扫描记录 = "UN_SCANRecordSet";

        public const string BD_条码扫描任务 = "UN_SCANTASK";

        public const string BD_条码扫描任务生成日志 = "UN_SCANTASKCREATELOG";

        public const string BD_条码扫描任务方案 = "UN_SCANTASKSCHEME";

        #endregion

        #region 供应链 供应商管理

        public const string SVM_企业公告 = "SVM_BusinessBulletin";

        public const string SVM_比价单 = "SVM_ComparePrice";

        public const string SVM_询价单 = "SVM_InquiryBill";

        public const string SVM_报价单 = "SVM_QuoteBill";

        public const string SVM_供应商角色 = "SVM_Role";

        public const string SVM_供应商用户 = "SVM_SUPPLIERUSER";

        #endregion

        #region 供应链 供应商协同

        public const string SCP_供应商协同条码打印 = "SCP_BarCodePrint";

        public const string SCP_供应商协同条码扫描 = "SCP_BarCodeScan";

        public const string SCP_企业公告 = "SCP_BusinessBulletin";

        public const string SCP_询价单 = "SCP_InquiryBill";

        public const string SCP_采购入库单 = "SCP_InStock";

        public const string SCP_退料通知单 = "SCP_MRAPP";

        public const string SCP_采购退料单 = "SCP_MRB";

        public const string SCP_应付单 = "SCP_Payable";

        public const string SCP_采购订单变更单 = "SCP_POChange";

        public const string SCP_采购订单 = "SCP_PurchaseOrder";

        public const string SCP_报价单 = "SCP_QuoteBill";

        public const string SCP_送货通知单 = "SCP_ReceiveBill";

        public const string SCP_供应商协同即时库存查询 = "SCP_STKInventory";

        public const string SCP_供应商评估报告 = "SCP_SupplierAssResport";

        public const string SCP_供应商注册资料 = "SCP_SupReg";

        public const string SCP_供应商协同VMI消耗汇总表 = "SCP_VMIConsumeSum";

        #endregion

        #region 基础管理--基础资料

        public const string 关键字_智能机器人 = "BAS_ROBOTKEYWORDS";

        public const string 消息任务_智能机器人 = "BAS_ROBOTMSGTASK";

        public const string 关键字服务_智能机器人 = "BAS_ROBOTSERVICE";

        public const string 会计政策 = "BD_ACCTPOLICY";

        public const string 辅助属性值组合 = "BD_AuxPtyValCom";

        public const string 辅助属性值 = "BD_AuxPtyValue";

        public const string 银行 = "BD_BANK";

        public const string 联系对象 = "BD_ContactObject";

        public const string 客户 = "BD_Customer";

        public const string 客户_包含非交易客户 = "BD_Customer_All";

        public const string 部门 = "BD_Department";

        public const string 员工 = "BD_Empinfo";

        public const string 快递100物流公司 = "BD_KD100LogisticsCom";

        public const string 物料 = "BD_MATERIAL";

        public const string 存货类别 = "BD_MATERIALCATEGORY";

        public const string 存货模板 = "BD_MATERIALTEMPLATE";

        public const string 物料单位换算 = "BD_MATERIALUNITCONVERT";

        public const string 员工任岗信息 = "BD_NEWSTAFF";

        public const string 业务员 = "BD_OPERATOR";

        public const string 业务组 = "BD_OPERATORGROUPBILL";

        public const string 付款条件 = "BD_PaymentCondition";

        public const string 岗位汇报 = "BD_PostReport";

        public const string 收款条件 = "BD_RecCondition";

        public const string 供应商 = "BD_Supplier";

        public const string 税组合 = "BD_TAXMIX";

        public const string 税率 = "BD_TaxRate";

        public const string 税务规则 = "BD_TAXRULE";

        public const string 税收制度 = "BD_TAXSYSTEM";

        public const string 税种 = "BD_TAXTYPE";

        public const string 计量单位 = "BD_UNIT";

        public const string 银行账号 = "CN_BANKACNT";

        public const string 现金账号 = "CN_CASHACCOUNT";

        public const string 内部账户 = "CN_INNERACCOUNT";

        public const string 其他往来单位 = "FIN_OTHERS";

        public const string 岗位信息 = "HR_ORG_HRPOST";

        #endregion

        #region 基础管理--组织管理

        public const string 组织隶属关系 = "ORG_Affiliation";

        public const string 分配执行情况 = "ORG_AutoAllocateLogInfo";

        public const string 基础资料自动分配计划 = "ORG_AUTOALLOCATEPLAN";

        public const string 基础资料控制策略 = "ORG_BaseDataControlPolicy";

        public const string 组织业务关系 = "ORG_BizRelation";

        public const string 组织变更检查规则 = "ORG_ChangeChkRule";

        public const string 组织变更方案 = "ORG_ChangeSolution";

        public const string 组织机构 = "ORG_Organizations";

        public const string 组织形态 = "ORG_OrgBodyForm";

        public const string 组织用户维护 = "Org_OrgUserRoleMap";

        #endregion
    }
}
