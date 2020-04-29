using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult
{
    [JsonObject]
    public class ValidationError
    {
        [JsonProperty]
        public string FieldName { get; internal set; }//end property

        [JsonProperty]
        public string Message { get; internal set; }//end property

        [JsonProperty]
        public string DIndex { get; internal set; }//end property
    }//end class
}//end namespace
