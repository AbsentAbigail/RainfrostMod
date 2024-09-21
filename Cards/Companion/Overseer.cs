using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class Overseer() : AbstractUnit(
        Name, "Overseer",
        1, 0, 2,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack(Zap.Name, 1)];
            card.startWithEffects = [Rainfrost.SStack(WhileActiveGainMultiHitForEachActiveIterators.Name, 1)];
            card.traits = [Rainfrost.TStack("Fragile")];
        })
    {
        public const string Name = "Overseer";
    }
}