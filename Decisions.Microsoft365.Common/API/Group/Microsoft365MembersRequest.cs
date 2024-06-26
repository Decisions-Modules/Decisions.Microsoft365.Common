using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Group
{
    [Writable]
    public class Microsoft365MembersRequest
    {
        [WritableValue]
        [JsonProperty("members@odata.bind")]
        public string[]? Members;
    }
}