using Newtonsoft.Json;

namespace Discord.Rest;

public class MutualGuild
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("nick")]
    public string Nick { get; set; }
}
