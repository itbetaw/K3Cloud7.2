using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.FormOperationResult
{
    [JsonObject]
    public class SuccessEntity
    {
        [JsonProperty]
        public string Id { get; internal set; }//end property

        [JsonProperty]
        public string Number { get; internal set; }//end property

        [JsonProperty]
        public string DIndex { get; internal set; }//end property
    }//end class
}//end namespace
