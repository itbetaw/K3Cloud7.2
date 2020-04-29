using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.FormOperationResult.View
{
    [JsonObject]
    public class ViewResult<T> : ResultConverter<ViewFormResult<T>>
    {

    }//end class
}
