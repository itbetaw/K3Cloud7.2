using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI.AuthOperationResult
{
    [JsonObject]
    public class RedirectFormParam
    {
        [JsonProperty]
        public string FormId { get; internal set; }//end property

        [JsonProperty]
        public string PageId { get; internal set; }//end property

        [JsonProperty]
        public string FormType { get; internal set; }//end property

    }//end class
}//end namespace
