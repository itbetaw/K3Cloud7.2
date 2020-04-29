using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.Models
{
    public class CustomerSave
    {
        public FNumberModel FCreateOrgId { get; set; }
        public string FNumber { get; set; }
        public FNumberModel FUseOrgId { get; set; }
        public string FName { get; set; }
        public string FShortName { get; set; }
        public string FADDRESS { get; set; }
        public FNumberModel FCustTypeId { get; set; }
        public FNumberModel FGroup { get; set; }
        public string FDescription { get; set; }
        public FT_BD_CUSTLOCATION[] ft_bd_custlocation { get; set; }
    }
    public class FT_BD_CUSTLOCATION
    {
        public FNumberModel FContactId { get; set; }
        public string FContact { get; set; }
        public string FMobilephone { get; set; }
        public string FBizAddress { get; set; }
    }
}
