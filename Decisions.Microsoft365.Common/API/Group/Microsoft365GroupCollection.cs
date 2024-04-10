using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Group
{
    public class Microsoft365GroupCollection
    {
        [JsonProperty("@odata.context")]
        public string? OdataContext { get; set; }

        [JsonProperty("value")]
        public Microsoft365Group[]? Value { get; set; }
    }
}