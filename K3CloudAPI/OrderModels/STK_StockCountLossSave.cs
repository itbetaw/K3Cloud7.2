using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.OrderModels
{
    /// <summary>
    /// 盘亏单保存实体
    /// </summary>
    public class STK_StockCountLossSave
    {
        public string FID { get; set; }
        public string FBillNo { get; set; }
        public Fbilltypeid FBillTypeID { get; set; }
        public string FDate { get; set; }
        public string FStockCountInputNo { get; set; }
        public string FStkCountSchemeId { get; set; }
        public Fstockorgid FStockOrgId { get; set; }
        public string FOwnerTypeIdHead { get; set; }
        public Fowneridhead FOwnerIdHead { get; set; }
        public Fdeptid FDeptId { get; set; }
        public Fstockerid FStockerId { get; set; }
        public Fbillentry[] FBillEntry { get; set; }

        public class Fbilltypeid
        {
            public string FNUMBER { get; set; }
        }

        public class Fstockorgid
        {
            public string FNumber { get; set; }
        }

        public class Fowneridhead
        {
            public string FNumber { get; set; }
        }

        public class Fdeptid
        {
            public string FNumber { get; set; }
        }

        public class Fstockerid
        {
            public string FNumber { get; set; }
        }

        public class Fbillentry
        {
            public string FEntryID { get; set; }
            public Fmaterialid FMaterialId { get; set; }
            public Funitid FUnitID { get; set; }
            public string FCountQty { get; set; }
            public Fstockid FStockId { get; set; }
            public string FPrice { get; set; }
            public Fstockstatusid FStockStatusId { get; set; }
            public string FOwnerTypeId { get; set; }
            public Fownerid FOwnerid { get; set; }
            public string FKeeperTypeId { get; set; }
            public Fkeeperid FKeeperId { get; set; }
            public string FExpiryDate { get; set; }
        }

        public class Fmaterialid
        {
            public string FNumber { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
        }

        public class Fstockid
        {
            public string FNumber { get; set; }
        }

        public class Fstockstatusid
        {
            public string FNumber { get; set; }
        }

        public class Fownerid
        {
            public string FNumber { get; set; }
        }

        public class Fkeeperid
        {
            public string FNumber { get; set; }
        }
    }

}
