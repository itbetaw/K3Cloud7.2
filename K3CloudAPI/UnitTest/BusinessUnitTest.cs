using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.DynamicFormOperation;
using Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.Consts;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.UnitTest
{
    public class BusinessUnitTest : BaseUnitTest<UnitTestParameter>
    {
        public string typeId = BillKeyConst.物料;
        public virtual void TestOrderView()
        {
            //var result = APIClient.CreateAPIOperation<View>(this.TestParameter.URL)
            //    .SetObjectTypeId(typeId)
            //    .SetCreateOrgId(0)
            //    .SetNumber("PRE001")
            //    .ToAPIRequest<KdAPIRequest>().Execute<string>();

            var result1 = APIClient.CreateAPIOperation<Allocate>(this.TestParameter.URL)
                .SetObjectTypeId(typeId)
                .AddPkid("")
                .AddPkid("")
                .AddTOrgId("")
                .AddTOrgId("")
                .ToAPIRequest<KdAPIRequest>().Execute<string>();
        }
    }
}
