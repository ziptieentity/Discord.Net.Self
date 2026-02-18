using Newtonsoft.Json; 
using System.Collections.Generic;

namespace Discord.Rest;

public class UserProfileModel
{
    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("accent_color")]
    public int? AccentColor { get; set; }

    [JsonProperty("pronouns")]
    public string Pronouns { get; set; }

    [JsonProperty("profile_effect")]
    public object ProfileEffect { get; set; }
}
