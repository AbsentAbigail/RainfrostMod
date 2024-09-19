using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class ScavengerMerchant() : AbstractUnit(
        Name, "Scavenger Merchant",
        6, 3, 4,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack(OnPearlCardPlayedDraw.Name, 2),
            ];
        })
    {
        public const string Name = "ScavengerMerchant";
    }
}