using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Clunkers;

internal class ScavengerToll() : AbstractClunker(
    Name, "Scavenger Toll",
    subscribe: card =>
    {
        card.startWithEffects =
        [
            .. card.startWithEffects,
            AbsentUtils.SStack(WhileActiveAddMultiHitToAllPearls.Name, 2)
        ];
    })
{
    public const string Name = "ScavengerToll";
}