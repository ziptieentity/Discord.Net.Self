using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Discord.Rest;

public class ProfileModel
{
    [JsonProperty("user")]
    public UserModelProfile User { get; set; }

    [JsonProperty("connected_accounts")]
    public List<ConnectedAccount> ConnectedAccounts { get; set; }

    [JsonProperty("premium_type")]
    public PremiumType PremiumType { get; set; }

    [JsonProperty("premium_since")]
    public DateTime? PremiumSince { get; set; }

    [JsonProperty("premium_guild_since")]
    public DateTime? PremiumGuildSince { get; set; }

    [JsonProperty("user_profile")]
    public UserProfileModel UserProfile { get; set; }

    [JsonProperty("badges")]
    public List<Badge> Badges { get; set; }

    [JsonProperty("mutual_guilds")]
    public List<MutualGuild> MutualGuilds { get; set; }
}
