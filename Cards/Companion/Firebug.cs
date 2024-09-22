using RainfrostMod.Helpers;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion
{
    internal class Firebug() : AbstractUnit(
        Name, "Firebug",
        health: 2,
        pools: Pools.Shademancer,
        subscribe: card =>
        {
            card.startWithEffects = [
                Rainfrost.SStack("Block", 1),
                Rainfrost.SStack(WhenHitAddFirebugEggToHand.Name, 2),
            ];

            card.traits = [
                Rainfrost.TStack("Fragile"),
            ];
        })
    {
        public const string Name = "Firebug";
    }
}