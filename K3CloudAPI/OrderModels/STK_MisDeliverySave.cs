using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 其他出库单保存信息实体
    /// </summary>
    public class STK_MisDeliverySave
    {
        public string FID { get; set; }
        public string FBillNo { get; set; }
        public Fbilltypeid FBillTypeID { get; set; }
        public Fstockorgid FStockOrgId { get; set; }
        public string FDate { get; set; }
        public Fcustid FCustId { get; set; }
        public Fdeptid FDeptId { get; set; }
        public string FOwnerTypeIdHead { get; set; }
        public Fowneridhead FOwnerIdHead { get; set; }
        public Fentity[] FEntity { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }

        public class Fcustid
        {
            public string FNumber { get; set; }
        }

        public class Fdeptid
        {
            public string FNumber { get; set; }
        }
        public class Fowneridhead
        {
            public string FNumber { get; set; }
        }
        public class Fentity
        {
            public string FEntryID { get; set; }
            public Fmaterialid FMaterialId { get; set; }
            public Funitid FUnitID { get; set; }
            public string FQty { get; set; }
            public Fbaseunitid FBaseUnitId { get; set; }
            public Fstockid FStockId { get; set; }
            public string FOwnerTypeId { get; set; }
            public Fownerid FOwnerId { get; set; }
            public Fstockstatusid FStockStatusId { get; set; }
            public Fkeeperid FKeeperId { get; set; }
        }

        public class Fmaterialid
        {
            public string FNumber { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
        }

        public class Fbaseunitid
        {
            public string FNumber { get; set; }
        }

        public class Fstockid
        {
            public string FNumber { get; set; }
        }


        public class Fownerid
        {
            public string FNumber { get; set; }
        }

        public class Fstockstatusid
        {
            public string FNumber { get; set; }
        }

        public class Fkeeperid
        {
            public string FNumber { get; set; }
        }

    }

}
