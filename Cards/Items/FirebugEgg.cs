using RainfrostMod.Helpers;

namespace RainfrostMod.Cards.Items
{
    internal class FirebugEgg() : AbstractItem(
        Name, "Firebug Egg",
        0, true,
        pools: Pools.None,
        subscribe: card =>
        {
            card.attackEffects = [Rainfrost.SStack("Overload", 3)];
            card.traits = [
                Rainfrost.TStack("Zoomlin"),
                Rainfrost.TStack("Consume"),
            ];
        })
    {
        public const string Name = "FirebugEgg";
    }
}