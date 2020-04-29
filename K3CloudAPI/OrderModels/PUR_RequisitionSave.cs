using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 采购申请单保存操作信息实体
    /// </summary>
    public class PUR_RequisitionSave
    {
        public string FID { get; set; }
        //单据类型
        public Fbilltypeid FBillTypeID { get; set; }
        public string FBillNo { get; set; }
        //申请日期
        public string FApplicationDate { get; set; }
        //申请类型
        public string FRequestType { get; set; }
        //申请组织
        public Fapplicationorgid FApplicationOrgId { get; set; }
        public Fentity[] FEntity { get; set; }
        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class Fapplicationorgid
        {
            public string FNumber { get; set; }
        }

        public class Fentity
        {
            public string FEntryID { get; set; }
            //需求组织
            public Frequireorgid FRequireOrgId { get; set; }
            //物料编码
            public Fmaterialid FMaterialId { get; set; }
            //申请单位
            public Funitid FUnitId { get; set; }
            public string FReqQty { get; set; }
            //采购组织
            public Fpurchaseorgid FPurchaseOrgId { get; set; }
            //计价单位 
            public Fpriceunitid FPriceUnitId { get; set; }
            //库存单位
            public FREQSTOCKUNITID FREQSTOCKUNITID { get; set; }
            public Frequiredeptid FRequireDeptId { get; set; }
        }

        public class Frequireorgid
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

        public class Fpurchaseorgid
        {
            public string FNumber { get; set; }
        }



        public class Fpriceunitid
        {
            public string FNumber { get; set; }
        }

        public class FREQSTOCKUNITID
        {
            public string FNumber { get; set; }
        }
        public class Frequiredeptid
        {
            public string FNUMBER { get; set; }
        }
    }
}
