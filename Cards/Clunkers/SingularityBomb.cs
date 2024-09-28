using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Clunkers
{
    internal class SingularityBomb() : AbstractClunker(
        Name, "Singularity Bomb",
        1,
        pools: Pools.None,
        subscribe: card =>
        {
            card.startWithEffects = [
                .. card.startWithEffects,
                Rainfrost.SStack(WhenScrapLostDamageAlliesInRowAndEnemiesInRow.Name, 50),
            ];
        })
    {
        public const string Name = "SingularityBomb";
    }
}