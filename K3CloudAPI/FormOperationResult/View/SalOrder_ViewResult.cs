using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.FormOperationResult.View
{
    public class SaleOrder_ViewResultSimple
    {
        public int Id { get; set; }
        public string FFormId { get; set; }
        public string BillNo { get; set; }
        public string DocumentStatus { get; set; }
        public int SaleOrgId_Id { get; set; }
        public DateTime Date { get; set; }
        public int CustId_Id { get; set; }
        public int SaleDeptId_Id { get; set; }
        public int SaleGroupId_Id { get; set; }
        public object SaleGroupId { get; set; }
        public int SalerId_Id { get; set; }
        public int ReceiveId_Id { get; set; }
        public int SettleId_Id { get; set; }
        public int CreatorId_Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime MOdifyDate { get; set; }
        public string VersionNo { get; set; }
        public int ChangerId_Id { get; set; }
        public object ChangerId { get; set; }
        public object ChangeDate { get; set; }
        public string ChangeReason { get; set; }
        public string BillTypeId_Id { get; set; }
        public string BusinessType { get; set; }
        public string HeadDeliveryWay_Id { get; set; }
        public object HeadDeliveryWay { get; set; }
        public string ReceiveAddress { get; set; }
        public int HeadLocId_Id { get; set; }
        public object HeadLocId { get; set; }
        public string CreditCheckResult { get; set; }
        public int CorrespondOrgId_Id { get; set; }
        public object CorrespondOrgId { get; set; }
        public int ReceiveContact_Id { get; set; }
        public object ReceiveContact { get; set; }
        public string NetOrderBillNo { get; set; }
        public int NetOrderBillId { get; set; }
        public int OppID { get; set; }
        public int SalePhaseID_Id { get; set; }
        public object SalePhaseID { get; set; }
        public bool ISINIT { get; set; }
        public string Note { get; set; }
        public bool IsMobile { get; set; }
        public object[] SalOrderTrace { get; set; }
    }
    public class SalOrder_ViewResult
    {
        public int Id { get; set; }
        public string FFormId { get; set; }
        public string BillNo { get; set; }
        public string DocumentStatus { get; set; }
        public int SaleOrgId_Id { get; set; }
        public Saleorgid SaleOrgId { get; set; }
        public DateTime Date { get; set; }
        public int CustId_Id { get; set; }
        public Custid CustId { get; set; }
        public int SaleDeptId_Id { get; set; }
        public Saledeptid SaleDeptId { get; set; }
        public int SaleGroupId_Id { get; set; }
        public object SaleGroupId { get; set; }
        public int SalerId_Id { get; set; }
        public Salerid SalerId { get; set; }
        public int ReceiveId_Id { get; set; }
        public Receiveid ReceiveId { get; set; }
        public int SettleId_Id { get; set; }
        public Settleid SettleId { get; set; }
        public int ChargeId_Id { get; set; }
        public Chargeid ChargeId { get; set; }
        public int CreatorId_Id { get; set; }
        public Creatorid CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifierId_Id { get; set; }
        public Modifierid ModifierId { get; set; }
        public DateTime MOdifyDate { get; set; }
        public int ApproverId_Id { get; set; }
        public object ApproverId { get; set; }
        public object ApproveDate { get; set; }
        public string CloseStatus { get; set; }
        public int CloserId_Id { get; set; }
        public object CloserId { get; set; }
        public object CloseDate { get; set; }
        public string CancelStatus { get; set; }
        public int CancellerId_Id { get; set; }
        public object CancellerId { get; set; }
        public object CancelDate { get; set; }
        public string VersionNo { get; set; }
        public int ChangerId_Id { get; set; }
        public object ChangerId { get; set; }
        public object ChangeDate { get; set; }
        public string ChangeReason { get; set; }
        public string BillTypeId_Id { get; set; }
        public Billtypeid BillTypeId { get; set; }
        public string BusinessType { get; set; }
        public string HeadDeliveryWay_Id { get; set; }
        public object HeadDeliveryWay { get; set; }
        public string ReceiveAddress { get; set; }
        public int HeadLocId_Id { get; set; }
        public object HeadLocId { get; set; }
        public string CreditCheckResult { get; set; }
        public int CorrespondOrgId_Id { get; set; }
        public object CorrespondOrgId { get; set; }
        public int ReceiveContact_Id { get; set; }
        public object ReceiveContact { get; set; }
        public string NetOrderBillNo { get; set; }
        public int NetOrderBillId { get; set; }
        public int OppID { get; set; }
        public int SalePhaseID_Id { get; set; }
        public object SalePhaseID { get; set; }
        public bool ISINIT { get; set; }
        public string Note { get; set; }
        public bool IsMobile { get; set; }
        public string SignStatus { get; set; }
        public bool IsDirectChange { get; set; }
        public bool ManualClose { get; set; }
        public Saleorderclause[] SaleOrderClause { get; set; }
        public Saleorderentry[] SaleOrderEntry { get; set; }
        public Saleorderfinance[] SaleOrderFinance { get; set; }
        public Saleorderplan[] SaleOrderPlan { get; set; }
        public object[] SalOrderTrace { get; set; }

        public class Saleorgid
        {
            public int Id { get; set; }
            public Multilanguagetext1[] MultiLanguageText { get; set; }
            public Name1[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg ParentOrg { get; set; }
            public string OrgFunctions { get; set; }
        }

        public class Parentorg
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext[] MultiLanguageText { get; set; }
            public Name[] Name { get; set; }
        }

        public class Multilanguagetext
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext1
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name1
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext5[] MultiLanguageText { get; set; }
            public Name5[] Name { get; set; }
            public string Number { get; set; }
            public int FGROUPCUSTID_Id { get; set; }
            public object FGROUPCUSTID { get; set; }
            public int TRADINGCURRID_Id { get; set; }
            public TRADINGCURRID TRADINGCURRID { get; set; }
            public int SALDEPTID_Id { get; set; }
            public object SALDEPTID { get; set; }
            public int SALGROUPID_Id { get; set; }
            public object SALGROUPID { get; set; }
            public int SELLER_Id { get; set; }
            public object SELLER { get; set; }
            public int TRANSLEADTIME { get; set; }
            public int PRICELISTID_Id { get; set; }
            public object PRICELISTID { get; set; }
            public int DISCOUNTLISTID_Id { get; set; }
            public object DISCOUNTLISTID { get; set; }
            public int SETTLETYPEID_Id { get; set; }
            public object SETTLETYPEID { get; set; }
            public int RECCONDITIONID_Id { get; set; }
            public object RECCONDITIONID { get; set; }
            public bool FISCREDITCHECK { get; set; }
            public string TaxType_Id { get; set; }
            public Taxtype TaxType { get; set; }
            public string CustTypeId_Id { get; set; }
            public Custtypeid CustTypeId { get; set; }
            public string ADDRESS { get; set; }
            public int CorrespondOrgId_Id { get; set; }
            public object CorrespondOrgId { get; set; }
            public bool IsDefPayer { get; set; }
            public bool IsGroup { get; set; }
            public bool IsTrade { get; set; }
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext2[] MultiLanguageText { get; set; }
            public Name2[] Name { get; set; }
        }

        public class Multilanguagetext2
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name2
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext3[] MultiLanguageText { get; set; }
            public Name3[] Name { get; set; }
        }

        public class Multilanguagetext3
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name3
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext4[] MultiLanguageText { get; set; }
            public Name4[] Name { get; set; }
        }

        public class Multilanguagetext4
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name4
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext5
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name5
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public float MarginLevel { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Saledeptid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext6[] MultiLanguageText { get; set; }
            public Name6[] Name { get; set; }
            public string Number { get; set; }
        }

        public class Multilanguagetext6
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name6
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Salerid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext8[] MultiLanguageText { get; set; }
            public Name8[] Name { get; set; }
            public string Number { get; set; }
            public int DeptId_Id { get; set; }
            public Deptid DeptId { get; set; }
            public object[] BD_SALESMANENTRY { get; set; }
        }

        public class Deptid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext7[] MultiLanguageText { get; set; }
            public Name7[] Name { get; set; }
        }

        public class Multilanguagetext7
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name7
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext8
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name8
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Receiveid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext12[] MultiLanguageText { get; set; }
            public Name12[] Name { get; set; }
            public string Number { get; set; }
            public int FGROUPCUSTID_Id { get; set; }
            public object FGROUPCUSTID { get; set; }
            public int TRADINGCURRID_Id { get; set; }
            public TRADINGCURRID1 TRADINGCURRID { get; set; }
            public int SALDEPTID_Id { get; set; }
            public object SALDEPTID { get; set; }
            public int SALGROUPID_Id { get; set; }
            public object SALGROUPID { get; set; }
            public int SELLER_Id { get; set; }
            public object SELLER { get; set; }
            public int TRANSLEADTIME { get; set; }
            public int PRICELISTID_Id { get; set; }
            public object PRICELISTID { get; set; }
            public int DISCOUNTLISTID_Id { get; set; }
            public object DISCOUNTLISTID { get; set; }
            public int SETTLETYPEID_Id { get; set; }
            public object SETTLETYPEID { get; set; }
            public int RECCONDITIONID_Id { get; set; }
            public object RECCONDITIONID { get; set; }
            public bool FISCREDITCHECK { get; set; }
            public string TaxType_Id { get; set; }
            public Taxtype1 TaxType { get; set; }
            public string CustTypeId_Id { get; set; }
            public Custtypeid1 CustTypeId { get; set; }
            public string ADDRESS { get; set; }
            public int CorrespondOrgId_Id { get; set; }
            public object CorrespondOrgId { get; set; }
            public bool IsDefPayer { get; set; }
            public bool IsGroup { get; set; }
            public bool IsTrade { get; set; }
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT1[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID1
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext9[] MultiLanguageText { get; set; }
            public Name9[] Name { get; set; }
        }

        public class Multilanguagetext9
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name9
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype1
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext10[] MultiLanguageText { get; set; }
            public Name10[] Name { get; set; }
        }

        public class Multilanguagetext10
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name10
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid1
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext11[] MultiLanguageText { get; set; }
            public Name11[] Name { get; set; }
        }

        public class Multilanguagetext11
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name11
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext12
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name12
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT1
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public float MarginLevel { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Settleid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext16[] MultiLanguageText { get; set; }
            public Name16[] Name { get; set; }
            public string Number { get; set; }
            public int FGROUPCUSTID_Id { get; set; }
            public object FGROUPCUSTID { get; set; }
            public int TRADINGCURRID_Id { get; set; }
            public TRADINGCURRID2 TRADINGCURRID { get; set; }
            public int SALDEPTID_Id { get; set; }
            public object SALDEPTID { get; set; }
            public int SALGROUPID_Id { get; set; }
            public object SALGROUPID { get; set; }
            public int SELLER_Id { get; set; }
            public object SELLER { get; set; }
            public int TRANSLEADTIME { get; set; }
            public int PRICELISTID_Id { get; set; }
            public object PRICELISTID { get; set; }
            public int DISCOUNTLISTID_Id { get; set; }
            public object DISCOUNTLISTID { get; set; }
            public int SETTLETYPEID_Id { get; set; }
            public object SETTLETYPEID { get; set; }
            public int RECCONDITIONID_Id { get; set; }
            public object RECCONDITIONID { get; set; }
            public bool FISCREDITCHECK { get; set; }
            public string TaxType_Id { get; set; }
            public Taxtype2 TaxType { get; set; }
            public string CustTypeId_Id { get; set; }
            public Custtypeid2 CustTypeId { get; set; }
            public string ADDRESS { get; set; }
            public int CorrespondOrgId_Id { get; set; }
            public object CorrespondOrgId { get; set; }
            public bool IsDefPayer { get; set; }
            public bool IsGroup { get; set; }
            public bool IsTrade { get; set; }
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT2[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID2
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext13[] MultiLanguageText { get; set; }
            public Name13[] Name { get; set; }
        }

        public class Multilanguagetext13
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name13
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype2
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext14[] MultiLanguageText { get; set; }
            public Name14[] Name { get; set; }
        }

        public class Multilanguagetext14
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name14
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid2
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext15[] MultiLanguageText { get; set; }
            public Name15[] Name { get; set; }
        }

        public class Multilanguagetext15
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name15
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext16
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name16
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT2
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public float MarginLevel { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Chargeid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext20[] MultiLanguageText { get; set; }
            public Name20[] Name { get; set; }
            public string Number { get; set; }
            public int FGROUPCUSTID_Id { get; set; }
            public object FGROUPCUSTID { get; set; }
            public int TRADINGCURRID_Id { get; set; }
            public TRADINGCURRID3 TRADINGCURRID { get; set; }
            public int SALDEPTID_Id { get; set; }
            public object SALDEPTID { get; set; }
            public int SALGROUPID_Id { get; set; }
            public object SALGROUPID { get; set; }
            public int SELLER_Id { get; set; }
            public object SELLER { get; set; }
            public int TRANSLEADTIME { get; set; }
            public int PRICELISTID_Id { get; set; }
            public object PRICELISTID { get; set; }
            public int DISCOUNTLISTID_Id { get; set; }
            public object DISCOUNTLISTID { get; set; }
            public int SETTLETYPEID_Id { get; set; }
            public object SETTLETYPEID { get; set; }
            public int RECCONDITIONID_Id { get; set; }
            public object RECCONDITIONID { get; set; }
            public bool FISCREDITCHECK { get; set; }
            public string TaxType_Id { get; set; }
            public Taxtype3 TaxType { get; set; }
            public string CustTypeId_Id { get; set; }
            public Custtypeid3 CustTypeId { get; set; }
            public string ADDRESS { get; set; }
            public int CorrespondOrgId_Id { get; set; }
            public object CorrespondOrgId { get; set; }
            public bool IsDefPayer { get; set; }
            public bool IsGroup { get; set; }
            public bool IsTrade { get; set; }
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT3[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID3
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext17[] MultiLanguageText { get; set; }
            public Name17[] Name { get; set; }
        }

        public class Multilanguagetext17
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name17
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype3
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext18[] MultiLanguageText { get; set; }
            public Name18[] Name { get; set; }
        }

        public class Multilanguagetext18
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name18
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid3
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext19[] MultiLanguageText { get; set; }
            public Name19[] Name { get; set; }
        }

        public class Multilanguagetext19
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name19
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext20
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name20
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT3
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public float MarginLevel { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Creatorid
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string UserAccount { get; set; }
        }

        public class Modifierid
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string UserAccount { get; set; }
        }

        public class Billtypeid
        {
            public string Id { get; set; }
            public Multilanguagetext21[] MultiLanguageText { get; set; }
            public Name21[] Name { get; set; }
            public string Number { get; set; }
        }

        public class Multilanguagetext21
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name21
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Saleorderclause
        {
            public int Id { get; set; }
            public int Seq { get; set; }
            public int ClauseId_Id { get; set; }
            public object ClauseId { get; set; }
            public object ClauseDesc { get; set; }
        }

        public class Saleorderentry
        {
            public int Id { get; set; }
            public int Seq { get; set; }
            public int MaterialId_Id { get; set; }
            public Materialid MaterialId { get; set; }
            public int UnitId_Id { get; set; }
            public Unitid UnitId { get; set; }
            public float Price { get; set; }
            public float TaxPrice { get; set; }
            public int BomId_Id { get; set; }
            public object BomId { get; set; }
            public int PriceUnitId_Id { get; set; }
            public Priceunitid PriceUnitId { get; set; }
            public float PriceUnitQty { get; set; }
            public float PriceCoefficient { get; set; }
            public float DiscountRate { get; set; }
            public float Discount { get; set; }
            public object[] Discount_Detail { get; set; }
            public float TaxRate { get; set; }
            public float TaxAmount { get; set; }
            public float AllAmount { get; set; }
            public float TaxNetPrice { get; set; }
            public float BaseUnitQty { get; set; }
            public bool DeliveryControl { get; set; }
            public float DeliveryMaxQty { get; set; }
            public float DeliveryMinQty { get; set; }
            public int TransportLeadTime1 { get; set; }
            public float BefDisAllAmt { get; set; }
            public float BefDisAmt { get; set; }
            public float TaxAmount_LC { get; set; }
            public float Amount_LC { get; set; }
            public float AllAmount_LC { get; set; }
            public string MrpCloseStatus { get; set; }
            public string MrpFreezeStatus { get; set; }
            public int FreezerId_Id { get; set; }
            public object FreezerId { get; set; }
            public object FreezeDate { get; set; }
            public string MrpTerminateStatus { get; set; }
            public int TerminaterId_Id { get; set; }
            public object TerminaterId { get; set; }
            public object TerminateDate { get; set; }
            public float BaseDeliJoinQty { get; set; }
            public float DeliQty { get; set; }
            public float StockOutQty { get; set; }
            public float RetNoticeQty { get; set; }
            public float ReturnQty { get; set; }
            public float RemainOutQty { get; set; }
            public float BaseInvoiceJoinQty { get; set; }
            public float InvoiceJoinQty { get; set; }
            public float InvoiceQty { get; set; }
            public float InvoiceAmount { get; set; }
            public float ReceiveAmount { get; set; }
            public float BasePurJoinQty { get; set; }
            public float PurJoinQty { get; set; }
            public float PurReqQty { get; set; }
            public float PurOrderQty { get; set; }
            public int ReceiptOrgId_Id { get; set; }
            public Receiptorgid ReceiptOrgId { get; set; }
            public int SettleOrgId_Id { get; set; }
            public Settleorgid SettleOrgId { get; set; }
            public float Amount { get; set; }
            public string Note { get; set; }
            public float Qty { get; set; }
            public float LimitDownPrice { get; set; }
            public float SysPrice { get; set; }
            public int StockOrgId_Id { get; set; }
            public Stockorgid StockOrgId { get; set; }
            public float BaseStockOutQty { get; set; }
            public float BaseDeliQty { get; set; }
            public float BaseRetNoticeQty { get; set; }
            public float BaseReturnQty { get; set; }
            public float BasePurReqQty { get; set; }
            public float BasePurOrderQty { get; set; }
            public int BaseUnitId_Id { get; set; }
            public Baseunitid1 BaseUnitId { get; set; }
            public string ChangeFlag { get; set; }
            public string MapId_Id { get; set; }
            public object MapId { get; set; }
            public string OwnerTypeId { get; set; }
            public int OwnerId_Id { get; set; }
            public Ownerid OwnerId { get; set; }
            public bool IsFree { get; set; }
            public float LOCKQTY { get; set; }
            public bool FLOCKFLAG { get; set; }
            public object ProduceDate { get; set; }
            public object ExpiryDate { get; set; }
            public string ExpUnit { get; set; }
            public int ExpPeriod { get; set; }
            public int TaxCombination_Id { get; set; }
            public object TaxCombination { get; set; }
            public int Lot_Id { get; set; }
            public object Lot { get; set; }
            public string Lot_Text { get; set; }
            public int AuxPropId_Id { get; set; }
            public object AuxPropId { get; set; }
            public string ReturnType { get; set; }
            public DateTime DeliveryDate { get; set; }
            public float TransJoinQty { get; set; }
            public float BaseTransJoinQty { get; set; }
            public string SrcType { get; set; }
            public string SrcBillNo { get; set; }
            public float BaseDeliveryMaxQty { get; set; }
            public float BaseDeliveryMinQty { get; set; }
            public float OEMInStockJoinQty { get; set; }
            public float BaseOEMInStockJoinQty { get; set; }
            public float BaseARJoinQty { get; set; }
            public float InventoryQty { get; set; }
            public string FBFLowId_Id { get; set; }
            public object FBFLowId { get; set; }
            public float BASEARQTY { get; set; }
            public float ARJOINAMOUNT { get; set; }
            public float ARAMOUNT { get; set; }
            public float BaseRemainOutQty { get; set; }
            public float ReBackQty { get; set; }
            public float BaseReBackQty { get; set; }
            public float ARQTY { get; set; }
            public float CanOutQty { get; set; }
            public float BaseCanOutQty { get; set; }
            public float CanReturnQty { get; set; }
            public float BaseCanReturnQty { get; set; }
            public float BASEAPQTY { get; set; }
            public float FAPAMOUNT { get; set; }
            public string MtoNo { get; set; }
            public int Priority { get; set; }
            public string ReserveType { get; set; }
            public DateTime MinPlanDeliveryDate { get; set; }
            public string DeliveryStatus { get; set; }
            public float OldQty { get; set; }
            public string PromotionMatchType { get; set; }
            public int PriceListEntry_Id { get; set; }
            public object PriceListEntry { get; set; }
            public float AwaitQty { get; set; }
            public float AvailableQty { get; set; }
            public int SupplyOrgId_Id { get; set; }
            public Supplyorgid SupplyOrgId { get; set; }
            public int NetOrderEntryId { get; set; }
            public float PriceBaseQty { get; set; }
            public int SetPriceUnitID_Id { get; set; }
            public object SetPriceUnitID { get; set; }
            public int StockUnitID_Id { get; set; }
            public Stockunitid StockUnitID { get; set; }
            public float StockQty { get; set; }
            public float StockBaseQty { get; set; }
            public float StockBaseCanOutQty { get; set; }
            public float StockBaseCanReturnQty { get; set; }
            public float StockBaseARJoinQty { get; set; }
            public float StockBaseTransJoinQty { get; set; }
            public object ServiceContext { get; set; }
            public float StockBasePurJoinQty { get; set; }
            public float SalBaseNum { get; set; }
            public float StockBaseDen { get; set; }
            public int SRCBIZUNITID_Id { get; set; }
            public object SRCBIZUNITID { get; set; }
            public float PurBaseQty { get; set; }
            public int PurUnitID_Id { get; set; }
            public object PurUnitID { get; set; }
            public float PurQty { get; set; }
            public float SalBaseARJoinQty { get; set; }
            public float STOCKBASESTOCKOUTQTY { get; set; }
            public float STOCKBASEREBACKQTY { get; set; }
            public string OUTLMTUNIT { get; set; }
            public int OutLmtUnitID_Id { get; set; }
            public Outlmtunitid OutLmtUnitID { get; set; }
            public float TRANSRETURNQTY { get; set; }
            public float TRANSRETURNBASEQTY { get; set; }
            public float CONSIGNSETTQTY { get; set; }
            public float CONSIGNSETTBASEQTY { get; set; }
            public float LeftQty { get; set; }
            public float CurrentInventory { get; set; }
            public string RowType { get; set; }
            public int ParentMatId_Id { get; set; }
            public object ParentMatId { get; set; }
            public string RowId { get; set; }
            public string ParentRowId { get; set; }
            public float InStockPrice { get; set; }
            public float PriceDiscount { get; set; }
            public int SOStockId_Id { get; set; }
            public object SOStockId { get; set; }
            public int SOStockLocalId_Id { get; set; }
            public object SOStockLocalId { get; set; }
            public int PurPriceUnitId_Id { get; set; }
            public object PurPriceUnitId { get; set; }
            public Orderentryplan[] OrderEntryPlan { get; set; }
            public object[] SAL_ORDERENTRYTAX { get; set; }
            public object[] FSaleOrderEntry_Link { get; set; }
        }

        public class Materialid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext23[] MultiLanguageText { get; set; }
            public Name23[] Name { get; set; }
            public string Number { get; set; }
            public int UseOrgId_Id { get; set; }
            public Useorgid UseOrgId { get; set; }
            public Specification[] Specification { get; set; }
            public int MaterialGroup_Id { get; set; }
            public object MaterialGroup { get; set; }
            public Materialbase[] MaterialBase { get; set; }
            public Materialstock[] MaterialStock { get; set; }
            public Materialsale[] MaterialSale { get; set; }
            public Materialpurchase[] MaterialPurchase { get; set; }
            public Materialplan[] MaterialPlan { get; set; }
            public Materialproduce[] MaterialProduce { get; set; }
            public object[] MaterialAuxPty { get; set; }
            public Materialinvpty[] MaterialInvPty { get; set; }
        }

        public class Useorgid
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext22[] MultiLanguageText { get; set; }
            public Name22[] Name { get; set; }
        }

        public class Multilanguagetext22
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name22
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext23
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
            public string Specification { get; set; }
        }

        public class Name23
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Specification
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Materialbase
        {
            public int Id { get; set; }
            public string ErpClsID { get; set; }
            public bool IsInventory { get; set; }
            public bool IsSale { get; set; }
            public bool IsAsset { get; set; }
            public bool IsSubContract { get; set; }
            public bool IsProduce { get; set; }
            public bool IsPurchase { get; set; }
            public int BaseUnitId_Id { get; set; }
            public Baseunitid BaseUnitId { get; set; }
            public string TaxType_Id { get; set; }
            public Taxtype4 TaxType { get; set; }
            public int CategoryID_Id { get; set; }
            public Categoryid CategoryID { get; set; }
            public string Suite { get; set; }
        }

        public class Baseunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext24[] MultiLanguageText { get; set; }
            public Name24[] Name { get; set; }
        }

        public class Multilanguagetext24
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name24
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype4
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext25[] MultiLanguageText { get; set; }
            public Name25[] Name { get; set; }
        }

        public class Multilanguagetext25
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name25
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Categoryid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext26[] MultiLanguageText { get; set; }
            public Name26[] Name { get; set; }
        }

        public class Multilanguagetext26
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name26
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Materialstock
        {
            public int Id { get; set; }
            public int StoreUnitID_Id { get; set; }
            public Storeunitid StoreUnitID { get; set; }
            public int AuxUnitID_Id { get; set; }
            public object AuxUnitID { get; set; }
            public int StockId_Id { get; set; }
            public object StockId { get; set; }
            public string ExpUnit { get; set; }
            public int OnlineLife { get; set; }
            public int ExpPeriod { get; set; }
            public bool IsBatchManage { get; set; }
            public bool IsKFPeriod { get; set; }
            public bool IsExpParToFlot { get; set; }
        }

        public class Storeunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext27[] MultiLanguageText { get; set; }
            public Name27[] Name { get; set; }
        }

        public class Multilanguagetext27
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name27
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Materialsale
        {
            public int Id { get; set; }
            public int SalePriceUnitId_Id { get; set; }
            public Salepriceunitid SalePriceUnitId { get; set; }
            public int SaleUnitId_Id { get; set; }
            public Saleunitid SaleUnitId { get; set; }
            public bool IsReturn { get; set; }
            public float OutStockLmtH { get; set; }
            public float OutStockLmtL { get; set; }
            public string OutLmtUnit { get; set; }
        }

        public class Salepriceunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext28[] MultiLanguageText { get; set; }
            public Name28[] Name { get; set; }
        }

        public class Multilanguagetext28
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name28
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Saleunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext29[] MultiLanguageText { get; set; }
            public Name29[] Name { get; set; }
        }

        public class Multilanguagetext29
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name29
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Materialpurchase
        {
            public int Id { get; set; }
            public int PurchaseUnitID_Id { get; set; }
            public Purchaseunitid PurchaseUnitID { get; set; }
            public int PurchasePriceUnitId_Id { get; set; }
            public Purchasepriceunitid PurchasePriceUnitId { get; set; }
            public bool IsVmiBusiness { get; set; }
        }

        public class Purchaseunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext30[] MultiLanguageText { get; set; }
            public Name30[] Name { get; set; }
        }

        public class Multilanguagetext30
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name30
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Purchasepriceunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext31[] MultiLanguageText { get; set; }
            public Name31[] Name { get; set; }
        }

        public class Multilanguagetext31
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name31
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Materialplan
        {
            public int Id { get; set; }
            public string ReserveType { get; set; }
            public string PlanMode { get; set; }
        }

        public class Materialproduce
        {
            public int Id { get; set; }
            public bool IsMainPrd { get; set; }
        }

        public class Materialinvpty
        {
            public int Id { get; set; }
            public bool IsEnable { get; set; }
            public bool IsAffectPrice { get; set; }
            public int InvPtyId_Id { get; set; }
            public Invptyid InvPtyId { get; set; }
        }

        public class Invptyid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext32[] MultiLanguageText { get; set; }
            public Name32[] Name { get; set; }
        }

        public class Multilanguagetext32
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name32
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Unitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext33[] MultiLanguageText { get; set; }
            public Name33[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext33
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name33
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Priceunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext34[] MultiLanguageText { get; set; }
            public Name34[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE1[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext34
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name34
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE1
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Receiptorgid
        {
            public int Id { get; set; }
            public Multilanguagetext36[] MultiLanguageText { get; set; }
            public Name36[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg1 ParentOrg { get; set; }
            public string OrgFunctions { get; set; }
        }

        public class Parentorg1
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext35[] MultiLanguageText { get; set; }
            public Name35[] Name { get; set; }
        }

        public class Multilanguagetext35
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name35
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext36
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name36
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Settleorgid
        {
            public int Id { get; set; }
            public Multilanguagetext38[] MultiLanguageText { get; set; }
            public Name38[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg2 ParentOrg { get; set; }
            public string OrgFunctions { get; set; }
        }

        public class Parentorg2
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext37[] MultiLanguageText { get; set; }
            public Name37[] Name { get; set; }
        }

        public class Multilanguagetext37
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name37
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext38
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name38
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Stockorgid
        {
            public int Id { get; set; }
            public Multilanguagetext40[] MultiLanguageText { get; set; }
            public Name40[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg3 ParentOrg { get; set; }
            public string OrgFunctions { get; set; }
        }

        public class Parentorg3
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext39[] MultiLanguageText { get; set; }
            public Name39[] Name { get; set; }
        }

        public class Multilanguagetext39
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name39
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext40
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name40
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Baseunitid1
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext41[] MultiLanguageText { get; set; }
            public Name41[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE2[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext41
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name41
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE2
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Ownerid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext42[] MultiLanguageText { get; set; }
            public Name42[] Name { get; set; }
            public string Number { get; set; }
        }

        public class Multilanguagetext42
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name42
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Supplyorgid
        {
            public int Id { get; set; }
            public Multilanguagetext44[] MultiLanguageText { get; set; }
            public Name44[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg4 ParentOrg { get; set; }
            public string OrgFunctions { get; set; }
        }

        public class Parentorg4
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext43[] MultiLanguageText { get; set; }
            public Name43[] Name { get; set; }
        }

        public class Multilanguagetext43
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name43
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Multilanguagetext44
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name44
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Stockunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext45[] MultiLanguageText { get; set; }
            public Name45[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE3[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext45
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name45
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE3
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Outlmtunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext46[] MultiLanguageText { get; set; }
            public Name46[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE4[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext46
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name46
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE4
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Orderentryplan
        {
            public int Id { get; set; }
            public int Seq { get; set; }
            public int StockId_Id { get; set; }
            public object StockId { get; set; }
            public int PlanUnitId_Id { get; set; }
            public Planunitid PlanUnitId { get; set; }
            public float PlanQty { get; set; }
            public float DeliCommitQty { get; set; }
            public float DeliRemainQty { get; set; }
            public int DetailLocId_Id { get; set; }
            public object DetailLocId { get; set; }
            public string DetailLocAddress { get; set; }
            public DateTime PlanDate { get; set; }
            public DateTime PlanDeliveryDate { get; set; }
            public int TransportLeadTime { get; set; }
            public float BasePlanQty { get; set; }
            public float BaseDeliCommitQty { get; set; }
            public float BaseDeliRemainQty { get; set; }
            public int PlanBaseUnitId_Id { get; set; }
            public Planbaseunitid PlanBaseUnitId { get; set; }
            public float NOTICEQTY { get; set; }
            public float NOTICEREMAINQTY { get; set; }
            public float NOTICEBASEQTY { get; set; }
            public float NOTICEREMAINBASEQTY { get; set; }
        }

        public class Planunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext47[] MultiLanguageText { get; set; }
            public Name47[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE5[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext47
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name47
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE5
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Planbaseunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext48[] MultiLanguageText { get; set; }
            public Name48[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE6[] UNITCONVERTRATE { get; set; }
        }

        public class Multilanguagetext48
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name48
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class UNITCONVERTRATE6
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Saleorderfinance
        {
            public int Id { get; set; }
            public int LocalCurrId_Id { get; set; }
            public Localcurrid LocalCurrId { get; set; }
            public int ExchangeTypeId_Id { get; set; }
            public Exchangetypeid ExchangeTypeId { get; set; }
            public float ExchangeRate { get; set; }
            public float PayAdvanceRate { get; set; }
            public float PayAdvanceAmount { get; set; }
            public int DiscountListId_Id { get; set; }
            public object DiscountListId { get; set; }
            public int SettleCurrId_Id { get; set; }
            public Settlecurrid SettleCurrId { get; set; }
            public float BillTaxAmount_LC { get; set; }
            public float BillAmount_LC { get; set; }
            public float BillAllAmount { get; set; }
            public float BillAllAmount_LC { get; set; }
            public int PriceListId_Id { get; set; }
            public object PriceListId { get; set; }
            public float BillTaxAmount { get; set; }
            public float BillAmount { get; set; }
            public bool IsIncludedTax { get; set; }
            public bool NeedPayAdvance { get; set; }
            public int RecBillId_Id { get; set; }
            public object RecBillId { get; set; }
            public int RecConditionId_Id { get; set; }
            public object RecConditionId { get; set; }
            public int SettleModeId_Id { get; set; }
            public object SettleModeId { get; set; }
            public float JoinStockAmount { get; set; }
            public float JoinOrderAmount { get; set; }
            public string CreChkStatus { get; set; }
            public int CreChkDays { get; set; }
            public float CreChkAmount { get; set; }
            public string FCrePreBatAndMonStatus { get; set; }
            public string FCrePreBatchOver { get; set; }
            public string FCreMonControlOver { get; set; }
            public bool IsPriceExcludeTax { get; set; }
            public float FMarginLevel { get; set; }
            public float FAssociateMargin { get; set; }
            public float FMargin { get; set; }
            public float FAssRefundMargin { get; set; }
            public float CreChkOverAmount { get; set; }
        }

        public class Localcurrid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext49[] MultiLanguageText { get; set; }
            public Name49[] Name { get; set; }
            public string Number { get; set; }
            public string Sysmbol { get; set; }
            public int PriceDigits { get; set; }
            public int AmountDigits { get; set; }
            public bool IsShowCSymbol { get; set; }
            public string FormatOrder { get; set; }
            public string RoundType { get; set; }
        }

        public class Multilanguagetext49
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name49
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Exchangetypeid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext50[] MultiLanguageText { get; set; }
            public Name50[] Name { get; set; }
            public string Number { get; set; }
            public int Digits { get; set; }
            public int ReverseDigits { get; set; }
        }

        public class Multilanguagetext50
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name50
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Settlecurrid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext51[] MultiLanguageText { get; set; }
            public Name51[] Name { get; set; }
            public string Number { get; set; }
            public string Sysmbol { get; set; }
            public int PriceDigits { get; set; }
            public int AmountDigits { get; set; }
            public bool IsShowCSymbol { get; set; }
            public string FormatOrder { get; set; }
            public string RoundType { get; set; }
        }

        public class Multilanguagetext51
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name51
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Saleorderplan
        {
            public int Id { get; set; }
            public int Seq { get; set; }
            public bool NeedRecAdvance { get; set; }
            public float RecAdvanceRate { get; set; }
            public object MustDate { get; set; }
            public float RecAdvanceAmount { get; set; }
            public float RecAmount { get; set; }
            public string RelBillNo { get; set; }
            public string ReMark { get; set; }
            public string ReceiveType_Id { get; set; }
            public object ReceiveType { get; set; }
            public string ControlSend { get; set; }
            public int PlanMaterialId_Id { get; set; }
            public object PlanMaterialId { get; set; }
            public int MaterialSeq { get; set; }
            public int OrderEntryId { get; set; }
            public object[] SAL_ORDERPLANENTRY { get; set; }
        }
    }

}
