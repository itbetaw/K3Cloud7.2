using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.AuthOperationResult;
using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.AuthServiceOperation;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.UnitTest
{
    public abstract class BaseUnitTest<T> where T : BaseTestParameter, new()
    {
        /// <summary>
        /// 测试参数属性。
        /// </summary>
        public virtual T TestParameter
        {
            get { return ParameterSingleton.GetInstance<T>(); }
        }

        /// <summary>
        /// 实现登录。
        /// </summary>
        /// <returns>返回API结果。</returns>
        public virtual APIResponse<LoginResult> Login()
        {
            var result = APIClient.CreateAPIOperation<LoginByUserPassword>(this.TestParameter.URL)
                                  .SetDBId(this.TestParameter.DBId)
                                  .SetUserName(this.TestParameter.UserName)
                                  .SetPassword(this.TestParameter.Password)
                                  .ToKdAPIRequest()
                                  .ToAPIResponse<LoginResult>();
            return result;
        }
    }
}
