using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion;

internal class ScavengerMerchant() : AbstractCompanion(
    Name, "Scavenger Merchant",
    6, 3, 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnPearlCardPlayedDraw.Name, 2)
        ];
    })
{
    public const string Name = "ScavengerMerchant";
}