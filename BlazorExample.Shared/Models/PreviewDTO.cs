using Newtonsoft.Json;

namespace BlazorExample.Shared.Models;

public class PreviewDTO
{
    [JsonProperty("content")] public string Content { get; set; }

    [JsonProperty("contentTypeKey")] public string ContentTypeKey { get; set; }
}