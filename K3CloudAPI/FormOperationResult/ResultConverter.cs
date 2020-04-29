using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.FormOperationResult
{
    [JsonObject]
    public class ResultConverter<T> where T : FormResult
    {
        [JsonProperty]
        public T Result { get; set; }//end property
    }//end class
}//end namespace
