using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items;

internal class RedCentipedeScale() : AbstractItem(
    Name, "Red Centipede Scale",
    0, true,
    Pools.Snowdweller,
    subscribe: card =>
    {
        card.attackEffects =
        [
            AbsentUtils.SStack(Zap.Name),
            AbsentUtils.SStack("Shell", 6)
        ];
    })
{
    public const string Name = "RedCentipedeScale";
}