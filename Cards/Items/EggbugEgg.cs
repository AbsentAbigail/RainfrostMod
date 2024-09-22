using RainfrostMod.Helpers;

namespace RainfrostMod.Cards.Items
{
    internal class EggbugEgg() : AbstractItem(
        Name, "Eggbug Egg",
        needsTarget: true,
        pools: Pools.None,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack("Increase Max Health", 2)];
            card.traits = [
                Rainfrost.TStack("Zoomlin"),
                Rainfrost.TStack("Consume"),
            ];
        })
    {
        public const string Name = "EggbugEgg";
    }
}