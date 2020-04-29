using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2
{
    public class K3AccountModel
    {
        /// <summary>
        /// 科目名称
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 科目编码
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 使用组织编码
        /// </summary>
        public string FUserOrgNumber { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string FGroupName { get; set; }
        /// <summary>
        /// 助记码
        /// </summary>
        public string FHelperCode { get; set; }
        /// <summary>
        /// 辅助核算
        /// </summary>
        public string FItemDetailName { get; set; }
        /// <summary>
        /// 拼音助记码
        /// </summary>
        public string FPYHelperCode { get; set; }

        public string FFullName { get; set; }
        public bool FIsDetail { get; set; }
    }
}
