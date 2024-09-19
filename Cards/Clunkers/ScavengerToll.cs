using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Clunkers
{
    internal class ScavengerToll() : AbstractClunker(
        Name, "Scavenger Toll",
        1,
        subscribe: card =>
        {
            card.startWithEffects = [
                .. card.startWithEffects,
                Rainfrost.SStack(WhileActiveAddMultiHitToAllPearls.Name, 2),
            ];
        })
    {
        public const string Name = "ScavengerToll";
    }
}