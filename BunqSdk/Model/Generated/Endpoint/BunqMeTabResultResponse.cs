using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Used to view bunq.me TabResultResponse objects belonging to a tab. A TabResultResponse is an object that holds
    /// details on a tab which has been paid from the provided monetary account.
    /// </summary>
    public class BunqMeTabResultResponse : BunqModel
    {
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE = "BunqMeTabResultResponse";
    
        /// <summary>
        /// The payment made for the bunq.me tab.
        /// </summary>
        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; private set; }
    }
}
