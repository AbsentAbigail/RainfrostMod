using RainfrostMod.Helpers;

namespace RainfrostMod.Cards.Items
{
    internal class Mushroom() : AbstractItem(
        Name, "Mushroom",
        needsTarget: true,
        pools: Pools.Snowdweller,
        subscribe: card =>
        {
            card.attackEffects = [
                Rainfrost.SStack("Shroom", 2),
                Rainfrost.SStack("Reduce Counter", 1),
            ];
            card.traits = [
                Rainfrost.TStack("Consume"),
            ];
        })
    {
        public const string Name = "Mushroom";
    }
}