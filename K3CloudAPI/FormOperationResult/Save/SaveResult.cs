using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.FormOperationResult.Save
{
    [JsonObject]
    public class SaveResult<TReturn> : ResultConverter<SaveFormResult<TReturn>>
    {

    }//end class

    [JsonObject]
    public class SaveResult : ResultConverter<SaveFormResult<object>>
    {

    }//end class
}
