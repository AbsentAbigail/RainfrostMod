using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion;

internal class Firebug() : AbstractCompanion(
    Name, "Firebug",
    2,
    pools: Pools.Shademancer,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Block"),
            AbsentUtils.SStack(WhenHitAddFirebugEggToHand.Name, 2)
        ];

        card.traits =
        [
            AbsentUtils.TStack("Fragile")
        ];
        
        card.greetMessages = ["*pitter patter*"];
    })
{
    public const string Name = "Firebug";
}