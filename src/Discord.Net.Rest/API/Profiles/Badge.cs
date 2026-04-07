using Newtonsoft.Json;

namespace Discord.Rest;

public class Badge
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }
}
