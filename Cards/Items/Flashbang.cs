using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Items
{
    internal class Flashbang() : AbstractItem(
        Name, "Flashbang",
        0, true,
        pools: Pools.Clunkmaster,
        subscribe: card =>
        {
            card.attackEffects = [
                Rainfrost.SStack(Zap.Name, 3),
            ];

            card.traits = [
                Rainfrost.TStack("Barrage"),
            ];
        })
    {
        public const string Name = "Flashbang";
    }
}