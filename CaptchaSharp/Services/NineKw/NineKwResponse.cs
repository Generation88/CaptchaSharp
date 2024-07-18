using Newtonsoft.Json;

namespace CaptchaSharp.Services.NineKw;

internal class NineKwResponse
{
    [JsonProperty("status")]
    public required NineKwStatus Status { get; set; }
    
    [JsonProperty("error")]
    public string? Error { get; set; }
}
