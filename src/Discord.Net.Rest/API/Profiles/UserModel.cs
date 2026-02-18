using Newtonsoft.Json;

namespace Discord.Rest;

public class UserModelProfile
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("global_name")]
    public string GlobalName { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("public_flags")]
    public ulong PublicFlags { get; set; }

    [JsonProperty("primary_guild")]
    public PrimaryGuild? PrimaryGuild { get; set; }

    [JsonProperty("flags")]
    public int Flags { get; set; }

    [JsonProperty("banner")]
    public string Banner { get; set; }

    [JsonProperty("banner_color")]
    public string BannerColor { get; set; }

    [JsonProperty("accent_color")]
    public string AccentColor { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }
}
