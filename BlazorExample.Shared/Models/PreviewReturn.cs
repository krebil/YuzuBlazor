using Newtonsoft.Json;

namespace BlazorExample.Shared.Models;

public class PreviewReturn
{
    [JsonProperty("preview")] public string Preview { get; set; }

    [JsonProperty("error")] public string Error { get; set; }
}