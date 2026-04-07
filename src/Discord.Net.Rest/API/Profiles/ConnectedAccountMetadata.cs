using Newtonsoft.Json;

namespace Discord.Rest;

public class ConnectedAccountMetadata
{
    [JsonProperty("game_count")]
    public string GameCount { get; set; }

    [JsonProperty("item_count_dota2")]
    public string ItemCountDota2 { get; set; }

    [JsonProperty("item_count_tf2")]
    public string ItemCountTf2 { get; set; }
}
