using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class FivePebbles() : AbstractCompanion(
    "FivePebbles", "Five Pebbles",
    attack: 0, counter: 5,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack("Scrap", 3),
            AbsentUtils.SStack(SummonBrotherLongLegs.Name),
            AbsentUtils.SStack("On Card Played Lose Scrap To Self")
        ];
        card.traits =
        [
            AbsentUtils.TStack(Iterator.Name),
            AbsentUtils.TStack("Spark")
        ];
        card.greetMessages = ["Fine, since you rescued me I suppose I'll help you."];
    },
    altSprite: true
)
{
}