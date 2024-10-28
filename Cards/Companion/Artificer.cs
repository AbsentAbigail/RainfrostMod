using AbsentUtilities;
using RainfrostMod.StatusEffects;
using RainfrostMod.Traits;

namespace RainfrostMod.Cards.Companion;

internal class Artificer() : AbstractCompanion(
    Name, "Artificer",
    6, 4, 4,
    subscribe: card =>
    {
        card.startWithEffects =
        [
            AbsentUtils.SStack(OnCardPlayedApplySpiceToCardsInHand.Name, 3)
        ];

        card.traits =
        [
            AbsentUtils.TStack(Slugcat.Name)
        ];

        card.greetMessages = ["Wrr... Wawa? (They suppose they'll join.)"];
    })
{
    public const string Name = "Artificer";
}