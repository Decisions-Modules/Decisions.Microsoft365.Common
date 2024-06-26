using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Email;

[Writable]
public class Microsoft365EmailComment
{
    [WritableValue]
    [JsonProperty("comment")]
    public string? Comment { get; set; }
}