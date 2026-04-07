using Newtonsoft.Json;

namespace Discord.Rest;

public class ConnectedAccount
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("verified")]
    public bool Verified { get; set; }

    [JsonProperty("metadata")]
    public ConnectedAccountMetadata Metadata { get; set; }
}
