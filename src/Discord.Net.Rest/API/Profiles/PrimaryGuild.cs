using Newtonsoft.Json;

namespace Discord.Rest;

public class ProfilePrimaryGuild
{
    [JsonProperty("identity_guild_id")]
    public object IdentityGuildId { get; set; }

    [JsonProperty("identity_enabled")]
    public bool IdentityEnabled { get; set; }

    [JsonProperty("tag")]
    public object Tag { get; set; }

    [JsonProperty("badge")]
    public object Badge { get; set; }
}
