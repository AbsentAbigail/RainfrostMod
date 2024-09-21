using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class RedCentipedeScale() : AbstractItem(
        Name, "Red Centipede Scale",
        0, true,
        Pools.Snowdweller,
        subscribe: card =>
        {
            card.attackEffects = [
                Rainfrost.SStack(Zap.Name, 1),
                Rainfrost.SStack("Shell", 6),
            ];
        })
    {
        public const string Name = "RedCentipedeScale";
    }
}