using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.People
{
    [Writable]
    public class Microsoft365PeopleList
    {
        [WritableValue]
        [JsonProperty("value")]
        public Microsoft365Person[] Value { get; set; }
    }
}