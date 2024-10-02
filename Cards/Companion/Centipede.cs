using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class Centipede() : AbstractUnit(
        Name, "Centipede",
        8, 0, 4,
        pools: Pools.None,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack(Zap.Name, 2)];
            card.startWithEffects = [Rainfrost.SStack("MultiHit", 1)];
            card.traits = [Rainfrost.TStack("Aimless")];
        })
    {
        public const string Name = "Centipede";
    }
}