using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.AuthOperationResult
{
    [JsonObject]
    public class OrganizationInfo
    {
        [JsonProperty]
        public long ID { get; internal set; }//end property

        [JsonProperty]
        public string AcctOrgType { get; internal set; }//end property

        [JsonProperty]
        public string Name { get; internal set; }//end property

        [JsonProperty]
        public List<long> FunctionIds { get; internal set; }//end property

    }//end class
}//end namespace
