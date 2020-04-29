using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.DynamicFormOperation
{
    public class Allocate : FormOperation
    {
        #region 公共覆盖操作参数
        /// <summary>
        /// 操作的服务名称定义。
        /// </summary>
        public override string ServiceName
        {
            get
            {
                return "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Allocate";
            }
        }

        /// <summary>
        /// 操作的请求参数。
        /// </summary>
        public override string RequestParameters
        {
            get
            {
                var parametersArray = new object[]
                    {
                        new
                        {

                        FormId = this.ObjectTypeId,
                        PkIds = string.Join(",", this.PkIds),
                        TOrgIds = string.Join(",", this.TOrgIds)
                        }
                    };

                return JsonConvert.SerializeObject(parametersArray);
            }
        }

        #endregion

        #region 公共操作参数属性

        /// <summary>
        ///被分配的基础资料内码集合
        /// </summary>
        public virtual List<string> PkIds { get; set; }//end property

        /// <summary>
        ///目标组织内码集合
        /// </summary>
        public virtual List<string> TOrgIds { get; set; }//end property


        #endregion

        #region 公共方法

        /// <summary>
        /// 设置读写动态表单类型标识。
        /// </summary>
        /// <param name="objectTypeId">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual Allocate SetObjectTypeId(string objectTypeId)
        {
            return this.SetObjectTypeId<Allocate>(objectTypeId);
        }//end method

        /// <summary>
        /// 添加基础资料内码
        /// </summary>
        /// <param name="pkId">字段索引键。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual Allocate AddPkid(string pkId)
        {
            if (this.PkIds == null)
            {
                this.PkIds = new List<string>();
            }//end if

            this.PkIds.Add(pkId);
            return this;
        }//end method

        /// <summary>
        /// 添加目标组织内码
        /// </summary>
        /// <param name="TOrgId">字段索引键。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual Allocate AddTOrgId(string TOrgId)
        {
            if (this.TOrgIds == null)
            {
                this.TOrgIds = new List<string>();
            }//end if

            this.TOrgIds.Add(TOrgId);
            return this;
        }//end method

        #endregion
    }
}
