using Discord.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API;

public class UserProfile
{
    public ulong Id { get; set; }
    public string Bio { get; set; }
    public string Pronouns { get; set; }
    public IReadOnlyCollection<ConnectedAccount> ConnectedAccounts { get; set; }
    public IReadOnlyCollection<Badge> Badges { get; set; }
    public PublicFlags PublicFlags { get; set; }
    public PremiumType PremiumType { get; set; }
    public DateTime? PremiumSince { get; set; }
    public string BannerHash { get; set; }

    public string GetBannerUrl(ImageFormat format = ImageFormat.Auto, ushort size = 128)
            => CDN.GetUserBannerUrl(Id, BannerHash, size, format);

    public UserProfile(ProfileModel model)
    {
        this.Id = ulong.TryParse(model.User.Id, out var id) ? id : 0;
        this.Bio = model.UserProfile.Bio;
        this.Pronouns = model.UserProfile.Pronouns;
        this.ConnectedAccounts = model.ConnectedAccounts;
        this.PublicFlags = (PublicFlags)model.User.PublicFlags;
        this.PremiumType = model.PremiumType;
        this.PremiumSince = model.PremiumSince;
        this.Badges = model.Badges;
        this.BannerHash = model.User.Banner;
    }
}
