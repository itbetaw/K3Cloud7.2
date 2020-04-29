using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult
{
    [JsonObject]
    public class FormResult
    {
        [JsonProperty("ResponseStatus")]
        public FormStatus Status { get; internal set; }//end property
    }//end class
}//end namespace
