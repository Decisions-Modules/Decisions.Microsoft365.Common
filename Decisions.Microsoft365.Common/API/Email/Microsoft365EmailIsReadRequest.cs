using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Email;

[Writable]
public class Microsoft365EmailIsReadRequest
{
    [WritableValue]
    [JsonProperty("isRead")]
    public bool? IsRead { get; set; }
}