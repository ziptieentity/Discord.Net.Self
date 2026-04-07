using Newtonsoft.Json; 
using System.Collections.Generic;

namespace Discord.Rest;

public class GameModel
{
    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("comment")]
    public object Comment { get; set; }

    [JsonProperty("tags")]
    public List<object> Tags { get; set; }
}
