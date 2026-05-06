using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common.API.Email;

[Writable]
public class Microsoft365AttachmentsResponse
{
    [WritableValue]
    [JsonProperty("value")]
    public Microsoft365AttachmentResponse[]? Value { get; set; } =  Array.Empty<Microsoft365AttachmentResponse>();
}

[Writable]
public class Microsoft365AttachmentResponse
{
    [WritableValue]
    [JsonProperty("@odata.type")]
    public string? ODataType { get; set; }

    [WritableValue]
    [JsonProperty("id")]
    public string? Id { get; set; }

    [WritableValue]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [WritableValue]
    [JsonProperty("contentType")]
    public string? ContentType { get; set; }

    [WritableValue]
    [JsonProperty("size")]
    public int? Size { get; set; }

    [WritableValue]
    [JsonProperty("contentBytes")]
    public byte[]? ContentBytes { get; set; }
}