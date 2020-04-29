using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult.View
{
    public class SaleOutStockViewResultSimple
    {
        public int Id { get; set; }
        public string FFormId { get; set; }
        public string SrcEntityDisa { get; set; }
        public string BillNo { get; set; }
        public string DocumentStatus { get; set; }
        public int SaleOrgId_Id { get; set; }
        public DateTime Date { get; set; }
        public int StockOrgId_Id { get; set; }
        public int CustomerID_Id { get; set; }
        public int DeliveryDeptID_Id { get; set; }
        public object DeliveryDeptID { get; set; }
        public int SaleDeptID_Id { get; set; }
        public object SaleDeptID { get; set; }
        public int StockerGroupID_Id { get; set; }
        public object StockerGroupID { get; set; }
        public int StockerID_Id { get; set; }
        public object StockerID { get; set; }
        public int SalesGroupID_Id { get; set; }
        public object SalesGroupID { get; set; }
        public int SalesManID_Id { get; set; }
        public object SalesManID { get; set; }
        public int CarrierID_Id { get; set; }
        public object CarrierID { get; set; }
        public string CarriageNO { get; set; }
        public int ReceiverID_Id { get; set; }
        public int SettleID_Id { get; set; }
        public int PayerID_Id { get; set; }
        public DateTime FCreateDate { get; set; }
        public int FModifierId_Id { get; set; }
        public DateTime FModifyDate { get; set; }
        public int FCreatorId_Id { get; set; }
        public int ApproverID_Id { get; set; }
        public object ApproverID { get; set; }
        public object ApproveDate { get; set; }
        public string CancelStatus { get; set; }
        public int CancellerID_Id { get; set; }
        public object CancellerID { get; set; }
        public object CancelDate { get; set; }
        public string BillTypeID_Id { get; set; }
        public string OwnerTypeIdHead { get; set; }
        public int OwnerIdHead_Id { get; set; }
        public object OwnerIdHead { get; set; }
        public string BussinessType { get; set; }
        public string ReceiveAddress { get; set; }
        public int HeadLocationId_Id { get; set; }
        public object HeadLocationId { get; set; }
        public string CreditCheckResult { get; set; }
        public int TransferBizType_Id { get; set; }
    }
    public class SaleOutStockViewResult
    {
        public int Id { get; set; }
        public string FFormId { get; set; }
        public string SrcEntityDisa { get; set; }
        public string BillNo { get; set; }
        public string DocumentStatus { get; set; }
        public int SaleOrgId_Id { get; set; }
        public Saleorgid SaleOrgId { get; set; }
        public DateTime Date { get; set; }
        public int StockOrgId_Id { get; set; }
        public Stockorgid StockOrgId { get; set; }
        public int CustomerID_Id { get; set; }
        public Customerid CustomerID { get; set; }
        public int DeliveryDeptID_Id { get; set; }
        public object DeliveryDeptID { get; set; }
        public int SaleDeptID_Id { get; set; }
        public object SaleDeptID { get; set; }
        public int StockerGroupID_Id { get; set; }
        public object StockerGroupID { get; set; }
        public int StockerID_Id { get; set; }
        public object StockerID { get; set; }
        public int SalesGroupID_Id { get; set; }
        public object SalesGroupID { get; set; }
        public int SalesManID_Id { get; set; }
        public object SalesManID { get; set; }
        public int CarrierID_Id { get; set; }
        public object CarrierID { get; set; }
        public string CarriageNO { get; set; }
        public int ReceiverID_Id { get; set; }
        public Receiverid ReceiverID { get; set; }
        public int SettleID_Id { get; set; }
        public Settleid SettleID { get; set; }
        public int PayerID_Id { get; set; }
        public Payerid PayerID { get; set; }
        public DateTime FCreateDate { get; set; }
        public int FModifierId_Id { get; set; }
        public Fmodifierid FModifierId { get; set; }
        public DateTime FModifyDate { get; set; }
        public int FCreatorId_Id { get; set; }
        public Fcreatorid FCreatorId { get; set; }
        public int ApproverID_Id { get; set; }
        public object ApproverID { get; set; }
        public object ApproveDate { get; set; }
        public string CancelStatus { get; set; }
        public int CancellerID_Id { get; set; }
        public object CancellerID { get; set; }
        public object CancelDate { get; set; }
        public string BillTypeID_Id { get; set; }
        public Billtypeid BillTypeID { get; set; }
        public string OwnerTypeIdHead { get; set; }
        public int OwnerIdHead_Id { get; set; }
        public object OwnerIdHead { get; set; }
        public string BussinessType { get; set; }
        public string ReceiveAddress { get; set; }
        public int HeadLocationId_Id { get; set; }
        public object HeadLocationId { get; set; }
        public string CreditCheckResult { get; set; }
        public int TransferBizType_Id { get; set; }
        public Transferbiztype TransferBizType { get; set; }
        public int CorrespondOrgId_Id { get; set; }
        public object CorrespondOrgId { get; set; }
        public int ReceiverContactID_Id { get; set; }
        public object ReceiverContactID { get; set; }
        public bool IsInterLegalPerson { get; set; }
        public object ScanBox { get; set; }
        public object CDateOffsetUnit { get; set; }
        public int CDateOffsetValue { get; set; }
        public string PlanRecAddress { get; set; }
        public bool IsTotalServiceOrCost { get; set; }
        public string Note { get; set; }
        public bool DisassemblyFlag { get; set; }
        public SAL_OUTSTOCKFIN[] sal_outstockfin { get; set; }
        public SAL_OUTSTOCKENTRY[] sal_outstockentry { get; set; }
        public object[] OutStockTrace { get; set; }

        public class Saleorgid
        {
            public int Id { get; set; }
            public Multilanguagetext1[] MultiLanguageText { get; set; }
            public Name1[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg ParentOrg { get; set; }
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

        public class Stockorgid
        {
            public int Id { get; set; }
            public Multilanguagetext3[] MultiLanguageText { get; set; }
            public Name3[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg1 ParentOrg { get; set; }
        }

        public class Parentorg1
        {
            public int Id { get; set; }
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

        public class Multilanguagetext3
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name3
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Customerid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext7[] MultiLanguageText { get; set; }
            public Name7[] Name { get; set; }
            public string Number { get; set; }
            public string TEL { get; set; }
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
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext4[] MultiLanguageText { get; set; }
            public Name4[] Name { get; set; }
        }

        public class Multilanguagetext4
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name4
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Taxtype
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext5[] MultiLanguageText { get; set; }
            public Name5[] Name { get; set; }
        }

        public class Multilanguagetext5
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name5
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext6[] MultiLanguageText { get; set; }
            public Name6[] Name { get; set; }
        }

        public class Multilanguagetext6
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name6
        {
            public int Key { get; set; }
            public string Value { get; set; }
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

        public class BD_CUSTOMEREXT
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Receiverid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext11[] MultiLanguageText { get; set; }
            public Name11[] Name { get; set; }
            public string Number { get; set; }
            public string TEL { get; set; }
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
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT1[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID1
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext8[] MultiLanguageText { get; set; }
            public Name8[] Name { get; set; }
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

        public class Taxtype1
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext9[] MultiLanguageText { get; set; }
            public Name9[] Name { get; set; }
        }

        public class Multilanguagetext9
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name9
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid1
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

        public class Multilanguagetext11
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name11
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT1
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Settleid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext15[] MultiLanguageText { get; set; }
            public Name15[] Name { get; set; }
            public string Number { get; set; }
            public string TEL { get; set; }
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
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT2[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID2
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext12[] MultiLanguageText { get; set; }
            public Name12[] Name { get; set; }
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

        public class Taxtype2
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext13[] MultiLanguageText { get; set; }
            public Name13[] Name { get; set; }
        }

        public class Multilanguagetext13
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name13
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid2
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

        public class Multilanguagetext15
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name15
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT2
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Payerid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext19[] MultiLanguageText { get; set; }
            public Name19[] Name { get; set; }
            public string Number { get; set; }
            public string TEL { get; set; }
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
            public object[] BD_CUSTCONTACT { get; set; }
            public BD_CUSTOMEREXT3[] BD_CUSTOMEREXT { get; set; }
        }

        public class TRADINGCURRID3
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext16[] MultiLanguageText { get; set; }
            public Name16[] Name { get; set; }
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

        public class Taxtype3
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext17[] MultiLanguageText { get; set; }
            public Name17[] Name { get; set; }
        }

        public class Multilanguagetext17
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name17
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Custtypeid3
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

        public class Multilanguagetext19
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name19
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class BD_CUSTOMEREXT3
        {
            public int Id { get; set; }
            public int DefaultContact_Id { get; set; }
            public object DefaultContact { get; set; }
            public int SettleId_Id { get; set; }
            public object SettleId { get; set; }
            public int ChargeId_Id { get; set; }
            public object ChargeId { get; set; }
        }

        public class Fmodifierid
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string UserAccount { get; set; }
        }

        public class Fcreatorid
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string UserAccount { get; set; }
        }

        public class Billtypeid
        {
            public string Id { get; set; }
            public Multilanguagetext20[] MultiLanguageText { get; set; }
            public Name20[] Name { get; set; }
            public string Number { get; set; }
        }

        public class Multilanguagetext20
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name20
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Transferbiztype
        {
            public int Id { get; set; }
            public Multilanguagetext21[] MultiLanguageText { get; set; }
            public Name21[] Name { get; set; }
            public string Number { get; set; }
        }

        public class Multilanguagetext21
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name21
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class SAL_OUTSTOCKFIN
        {
            public int Id { get; set; }
            public int SettleOrgID_Id { get; set; }
            public Settleorgid SettleOrgID { get; set; }
            public int LocalCurrID_Id { get; set; }
            public Localcurrid LocalCurrID { get; set; }
            public int ExchangeTypeID_Id { get; set; }
            public Exchangetypeid ExchangeTypeID { get; set; }
            public float ExchangeRate { get; set; }
            public int SettleCurrID_Id { get; set; }
            public Settlecurrid SettleCurrID { get; set; }
            public int SettleTypeID_Id { get; set; }
            public object SettleTypeID { get; set; }
            public float BilCostlAmount { get; set; }
            public float BillCostAmount_LC { get; set; }
            public int ReceiptConditionID_Id { get; set; }
            public object ReceiptConditionID { get; set; }
            public float BillAmount_LC { get; set; }
            public float BillAllAmount_LC { get; set; }
            public float BillTaxAmount_LC { get; set; }
            public int PriceListId_Id { get; set; }
            public object PriceListId { get; set; }
            public float BillTaxAmount { get; set; }
            public float BillAllAmount { get; set; }
            public float BillAmount { get; set; }
            public bool IsIncludedTax { get; set; }
            public bool ISGENFORIOS { get; set; }
            public int SETTLECustomerID_Id { get; set; }
            public object SETTLECustomerID { get; set; }
            public int OwnerSupplierID_Id { get; set; }
            public object OwnerSupplierID { get; set; }
            public int DiscountListId_Id { get; set; }
            public object DiscountListId { get; set; }
            public int CreChkDays { get; set; }
            public string CreChkStatus { get; set; }
            public float CreChkAmount { get; set; }
            public string CrePreBatAndMonStatus { get; set; }
            public string CrePreBatchOver { get; set; }
            public string CreMonControlOver { get; set; }
            public bool IsPriceExcludeTax { get; set; }
            public string FThirdBillNo { get; set; }
            public string FThirdBillId { get; set; }
            public string FThirdSrcType { get; set; }
            public float CreChkOverAmount { get; set; }
        }

        public class Settleorgid
        {
            public int Id { get; set; }
            public Multilanguagetext23[] MultiLanguageText { get; set; }
            public Name23[] Name { get; set; }
            public string Number { get; set; }
            public object FRadio { get; set; }
            public int ParentOrg_Id { get; set; }
            public Parentorg2 ParentOrg { get; set; }
        }

        public class Parentorg2
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
        }

        public class Name23
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Localcurrid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext24[] MultiLanguageText { get; set; }
            public Name24[] Name { get; set; }
            public string Number { get; set; }
            public string Sysmbol { get; set; }
            public int PriceDigits { get; set; }
            public int AmountDigits { get; set; }
            public bool IsShowCSymbol { get; set; }
            public string FormatOrder { get; set; }
            public string RoundType { get; set; }
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

        public class Exchangetypeid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext25[] MultiLanguageText { get; set; }
            public Name25[] Name { get; set; }
            public string Number { get; set; }
            public int Digits { get; set; }
            public int ReverseDigits { get; set; }
        }

        public class Multilanguagetext25
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name25
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Settlecurrid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext26[] MultiLanguageText { get; set; }
            public Name26[] Name { get; set; }
            public string Number { get; set; }
            public string Sysmbol { get; set; }
            public int PriceDigits { get; set; }
            public int AmountDigits { get; set; }
            public bool IsShowCSymbol { get; set; }
            public string FormatOrder { get; set; }
            public string RoundType { get; set; }
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

        public class SAL_OUTSTOCKENTRY
        {
            public int Id { get; set; }
            public int Seq { get; set; }
            public string SrcEntityDisa { get; set; }
            public string CustMatID_Id { get; set; }
            public object CustMatID { get; set; }
            public int MaterialID_Id { get; set; }
            public Materialid MaterialID { get; set; }
            public int UnitID_Id { get; set; }
            public Unitid UnitID { get; set; }
            public float MustQty { get; set; }
            public float RealQty { get; set; }
            public int StockID_Id { get; set; }
            public Stockid StockID { get; set; }
            public int StockStatusID_Id { get; set; }
            public Stockstatusid StockStatusID { get; set; }
            public string OwnerTypeID { get; set; }
            public int OwnerID_Id { get; set; }
            public Ownerid OwnerID { get; set; }
            public string KeeperTypeID { get; set; }
            public int KeeperID_Id { get; set; }
            public Keeperid KeeperID { get; set; }
            public string Note { get; set; }
            public int BomID_Id { get; set; }
            public object BomID { get; set; }
            public float BaseUnitQty { get; set; }
            public int AuxUnitID_Id { get; set; }
            public object AuxUnitID { get; set; }
            public float AuxUnitQty { get; set; }
            public float CostPrice { get; set; }
            public float CostAmount { get; set; }
            public float CostAmount_LC { get; set; }
            public float ReturnQty { get; set; }
            public float SumRetNoticeQty { get; set; }
            public float SumRetStockQty { get; set; }
            public float InvoicedQty { get; set; }
            public float SumInvoicedQty { get; set; }
            public float SumInvoicedAMT { get; set; }
            public float SumReceivedAMT { get; set; }
            public float BaseReturnQty { get; set; }
            public float BaseInvoicedQty { get; set; }
            public bool StockFlag { get; set; }
            public string SoorDerno { get; set; }
            public int AuxPropId_Id { get; set; }
            public object AuxPropId { get; set; }
            public float BaseSumRetNoticeQty { get; set; }
            public string SrcType { get; set; }
            public float BaseSumRetstockQty { get; set; }
            public int StockLocID_Id { get; set; }
            public object StockLocID { get; set; }
            public object ProduceDate { get; set; }
            public object ExpiryDate { get; set; }
            public int JoinedQty { get; set; }
            public int UnJoinQty { get; set; }
            public float JoinedAmount { get; set; }
            public float UnJoinAmount { get; set; }
            public bool FullyJoined { get; set; }
            public string JoinStatus { get; set; }
            public int Lot_Id { get; set; }
            public object Lot { get; set; }
            public string Lot_Text { get; set; }
            public bool IsFree { get; set; }
            public float BaseSumInvoicedQty { get; set; }
            public float BaseMustQty { get; set; }
            public int BaseUnitID_Id { get; set; }
            public Baseunitid1 BaseUnitID { get; set; }
            public string ArrivalStatus { get; set; }
            public int ArrivalConfirmor_Id { get; set; }
            public object ArrivalConfirmor { get; set; }
            public object ValidateDate { get; set; }
            public string ValidateStatus { get; set; }
            public int ValidateConfirmor_Id { get; set; }
            public object ValidateConfirmor { get; set; }
            public int PriceUnitId_Id { get; set; }
            public Priceunitid PriceUnitId { get; set; }
            public float PriceUnitQty { get; set; }
            public float Price { get; set; }
            public float TaxPrice { get; set; }
            public int TaxCombination_Id { get; set; }
            public object TaxCombination { get; set; }
            public float TaxRate { get; set; }
            public float PriceCoefficient { get; set; }
            public float SysPrice { get; set; }
            public float LimitDownPrice { get; set; }
            public float BefDisAmt { get; set; }
            public float BefDisAllAmt { get; set; }
            public float DiscountRate { get; set; }
            public float Discount { get; set; }
            public object[] Discount_Detail { get; set; }
            public float Amount { get; set; }
            public float Amount_LC { get; set; }
            public float TaxAmount { get; set; }
            public float TaxAmount_LC { get; set; }
            public float AllAmount { get; set; }
            public float AllAmount_LC { get; set; }
            public float TaxNetPrice { get; set; }
            public float FBaseARJoinQty { get; set; }
            public object ArrivalDate { get; set; }
            public string FBFLowId_Id { get; set; }
            public object FBFLowId { get; set; }
            public float BASEARQTY { get; set; }
            public float ARJOINAMOUNT { get; set; }
            public float ARAMOUNT { get; set; }
            public object ServiceContext { get; set; }
            public float SalCostPrice { get; set; }
            public string SrcBillNo { get; set; }
            public float ActQty { get; set; }
            public float BaseJoinInStockQty { get; set; }
            public float JoinInStockQty { get; set; }
            public int SNUnitID_Id { get; set; }
            public object SNUnitID { get; set; }
            public float SNQty { get; set; }
            public string MTONO { get; set; }
            public string ProjectNo { get; set; }
            public float RefuseQty { get; set; }
            public float RepairQty { get; set; }
            public bool IsRepair { get; set; }
            public int PickDeptId_Id { get; set; }
            public object PickDeptId { get; set; }
            public float SECJOININSTOCKQTY { get; set; }
            public float SECRETURNQTY { get; set; }
            public string IsConsumeSum { get; set; }
            public float ARJoinQty { get; set; }
            public bool OUTCONTROL { get; set; }
            public int ExtAuxUnitId_Id { get; set; }
            public object ExtAuxUnitId { get; set; }
            public float ExtAuxUnitQty { get; set; }
            public float InventoryQty { get; set; }
            public int SalUnitId_Id { get; set; }
            public Salunitid SalUnitId { get; set; }
            public float SALUNITQTY { get; set; }
            public float SALBASEQTY { get; set; }
            public float PRICEBASEQTY { get; set; }
            public string QualifyType { get; set; }
            public float SalBaseNum { get; set; }
            public float StockBaseDen { get; set; }
            public float StockBaseReturnQty { get; set; }
            public float StockBaseSumRetStockQty { get; set; }
            public float StockBaseARJoinQty { get; set; }
            public int SRCBIZUNITID_Id { get; set; }
            public object SRCBIZUNITID { get; set; }
            public string IsCreateProDoc { get; set; }
            public int EOwnerSupplierId_Id { get; set; }
            public object EOwnerSupplierId { get; set; }
            public bool IsOverLegalOrg { get; set; }
            public int ESettleCustomerId_Id { get; set; }
            public object ESettleCustomerId { get; set; }
            public float SalBaseARJoinQty { get; set; }
            public float PURBASEJOININSTOCKQTY { get; set; }
            public int PriceListEntry_Id { get; set; }
            public object PriceListEntry { get; set; }
            public float ARNOTJOINQTY { get; set; }
            public int QmEntryID { get; set; }
            public int ConvertEntryID { get; set; }
            public int B2CORDERDETAILID { get; set; }
            public int SOEntryId { get; set; }
            public int ReserveEntryId { get; set; }
            public float DisPriceQty { get; set; }
            public float BeforeDisPriceQty { get; set; }
            public string RowType { get; set; }
            public int ParentMatId_Id { get; set; }
            public object ParentMatId { get; set; }
            public string RowId { get; set; }
            public string ParentRowId { get; set; }
            public float SignQty { get; set; }
            public string ThirdEntryId { get; set; }
            public float PriceDiscount { get; set; }
            public object[] SAL_OUTSTOCKENTRYTAX { get; set; }
            public object[] SAL_OutStockSerial { get; set; }
            public object[] FEntity_Link { get; set; }
        }

        public class Materialid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext28[] MultiLanguageText { get; set; }
            public Name28[] Name { get; set; }
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
            public object[] MaterialAuxPty { get; set; }
            public Materialinvpty[] MaterialInvPty { get; set; }
            public Materialqm[] MaterialQM { get; set; }
        }

        public class Useorgid
        {
            public int Id { get; set; }
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

        public class Multilanguagetext28
        {
            public int PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
            public string Specification { get; set; }
        }

        public class Name28
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

        public class Taxtype4
        {
            public string Id { get; set; }
            public string Number { get; set; }
            public Multilanguagetext30[] MultiLanguageText { get; set; }
            public Name30[] Name { get; set; }
        }

        public class Multilanguagetext30
        {
            public string PkId { get; set; }
            public int LocaleId { get; set; }
            public string Name { get; set; }
        }

        public class Name30
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        public class Categoryid
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
            public int StockPlaceId_Id { get; set; }
            public object StockPlaceId { get; set; }
            public int ExpPeriod { get; set; }
            public bool IsBatchManage { get; set; }
            public bool IsKFPeriod { get; set; }
            public bool IsExpParToFlot { get; set; }
            public bool IsSNManage { get; set; }
            public int SNCodeRule_Id { get; set; }
            public object SNCodeRule { get; set; }
            public int SNUnit_Id { get; set; }
            public object SNUnit { get; set; }
            public string UnitConvertDir { get; set; }
            public string SNGenerateTime { get; set; }
            public string SNManageType { get; set; }
        }

        public class Storeunitid
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

        public class Materialsale
        {
            public int Id { get; set; }
            public int SalePriceUnitId_Id { get; set; }
            public Salepriceunitid SalePriceUnitId { get; set; }
            public int SaleUnitId_Id { get; set; }
            public Saleunitid SaleUnitId { get; set; }
            public bool IsReturn { get; set; }
        }

        public class Salepriceunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext33[] MultiLanguageText { get; set; }
            public Name33[] Name { get; set; }
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

        public class Saleunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public string Number { get; set; }
            public Multilanguagetext34[] MultiLanguageText { get; set; }
            public Name34[] Name { get; set; }
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

        public class Materialpurchase
        {
            public int Id { get; set; }
            public bool IsVmiBusiness { get; set; }
        }

        public class Materialplan
        {
            public int Id { get; set; }
            public string PlanMode { get; set; }
        }

        public class Materialinvpty
        {
            public int Id { get; set; }
            public bool IsEnable { get; set; }
            public int InvPtyId_Id { get; set; }
            public Invptyid InvPtyId { get; set; }
        }

        public class Invptyid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
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

        public class Materialqm
        {
            public int Id { get; set; }
            public bool CheckDelivery { get; set; }
        }

        public class Unitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext36[] MultiLanguageText { get; set; }
            public Name36[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE[] UNITCONVERTRATE { get; set; }
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

        public class UNITCONVERTRATE
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Stockid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext38[] MultiLanguageText { get; set; }
            public Name38[] Name { get; set; }
            public string Number { get; set; }
            public bool IsOpenLocation { get; set; }
            public bool AllowMinusQty { get; set; }
            public string StockProperty { get; set; }
            public int SupplierId_Id { get; set; }
            public object SupplierId { get; set; }
            public int CustomerId_Id { get; set; }
            public object CustomerId { get; set; }
            public string StockStatusType { get; set; }
            public int DefStockStatusId_Id { get; set; }
            public Defstockstatusid DefStockStatusId { get; set; }
            public object[] StockFlexItem { get; set; }
        }

        public class Defstockstatusid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
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

        public class Stockstatusid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext39[] MultiLanguageText { get; set; }
            public Name39[] Name { get; set; }
            public string Number { get; set; }
            public string Type { get; set; }
            public bool NotSale { get; set; }
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

        public class Ownerid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext40[] MultiLanguageText { get; set; }
            public Name40[] Name { get; set; }
            public string Number { get; set; }
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

        public class Keeperid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext41[] MultiLanguageText { get; set; }
            public Name41[] Name { get; set; }
            public string Number { get; set; }
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

        public class Baseunitid1
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext42[] MultiLanguageText { get; set; }
            public Name42[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE1[] UNITCONVERTRATE { get; set; }
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

        public class UNITCONVERTRATE1
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Priceunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext43[] MultiLanguageText { get; set; }
            public Name43[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE2[] UNITCONVERTRATE { get; set; }
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

        public class UNITCONVERTRATE2
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }

        public class Salunitid
        {
            public int Id { get; set; }
            public int msterID { get; set; }
            public Multilanguagetext44[] MultiLanguageText { get; set; }
            public Name44[] Name { get; set; }
            public string Number { get; set; }
            public int Precision { get; set; }
            public string RoundType { get; set; }
            public UNITCONVERTRATE3[] UNITCONVERTRATE { get; set; }
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

        public class UNITCONVERTRATE3
        {
            public int Id { get; set; }
            public string ConvertType { get; set; }
        }
    }

}
