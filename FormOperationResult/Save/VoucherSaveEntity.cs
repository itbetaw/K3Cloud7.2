using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult.Save
{
    public class VoucherSaveEntity
    {
        public int FVoucherID { get; set; }
        public FVoucherGroup FVoucherGroupID { get; set; }
        public String FVoucherGroupName { get; set; }
        public string FVoucherGroupNo { get; set; }
    }

    public class FVoucherGroup
    {
        public string FNumber { get; set; }
    }

}
