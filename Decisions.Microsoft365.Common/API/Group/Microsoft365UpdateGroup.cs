using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Group
{
    [Writable]
    public class Microsoft365UpdateGroup
    {
        [WritableValue]
        [JsonProperty("description")]
        public string? Description { get; set; }

        [WritableValue]
        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        [WritableValue]
        [JsonProperty("groupTypes")]
        public string[]? GroupTypes { get; set; }

        [WritableValue]
        [JsonProperty("mailEnabled")]
        public bool? MailEnabled { get; set; }

        [WritableValue]
        [JsonProperty("mailNickname")]
        public string? MailNickname { get; set; }

        [WritableValue]
        [JsonProperty("securityEnabled")]
        public bool? SecurityEnabled { get; set; }
        
        [WritableValue]
        [JsonProperty("visibility")]
        public string? Visibility { get; set; }
        
        [WritableValue]
        [JsonProperty("allowExternalSenders")]
        public bool? AllowExternalSenders { get; set; }
        
        [WritableValue]
        [JsonProperty("assignedLabels")]
        public Microsoft365AssignedLabel[]? AssignedLabels { get; set; }
        
        [WritableValue]
        [JsonProperty("autoSubscribeNewMembers")]
        public bool? AutoSubscribeNewMembers { get; set; }
        
        [WritableValue]
        [JsonProperty("preferredDataLocation")]
        public string? PreferredDataLocation { get; set; }
    }

    [Writable]
    public class Microsoft365AssignedLabel
    {
        [WritableValue]
        [JsonProperty("displayName")]
        public string? DisplayName;
        
        [WritableValue]
        [JsonProperty("labelId")]
        public string? LabelId;
    }
}