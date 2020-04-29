using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.Models
{
    public class DepartmentEntitySave
    {
        /// <summary>
        /// 创建组织
        /// </summary>
        public FNumberModel FCreateOrgId { get; set; }
        /// <summary>
        /// 部门编码
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 使用组织
        /// </summary>
        public FNumberModel FUseOrgId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 助记码
        /// </summary>
        public string FHelpCode { get; set; }
        public string FFullName { get; set; }
        /// <summary>
        /// 部门属性
        /// </summary>
        public FNumberModel FDeptProperty { get; set; }
        /// <summary>
        /// 部门分组
        /// </summary>
        public FNumberModel FGroup { get; set; }
    }
}
