using AbsentUtilities;
using RainfrostMod.StatusEffects;

namespace RainfrostMod.Cards.Companion;

internal class Eggbug() : AbstractCompanion(
    Name, "Eggbug",
    4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(WhenHitAddEggbugEggToHand.Name, 2)
        ];

        card.traits =
        [
            AbsentUtils.TStack("Fragile")
        ];
        
        card.greetMessages = ["*pitter patter*"];
    })
{
    public const string Name = "Eggbug";
}